using Newtonsoft.Json;

namespace SPDB_MKII.Classes.FolderInfos
{
    internal static class FolderCollection
    {
        private const string RecordsSeparator = "__DELIM__";
        private static List<FolderDefinition>? folders = null;

        public static List<FolderDefinition> Folders
        {
            get 
            {
                if(folders == null)
                {
                    folders = new List<FolderDefinition>();

                    if(!string.IsNullOrWhiteSpace(Program.AppSettings.Folders))
                    {
                        LoadFolders(new DelimitedJSONParser(Program.AppSettings.Folders, RecordsSeparator), folders);
                    }
                }

                return folders;
            }
        }

        private static void LoadFolders(DelimitedJSONParser parsed, List<FolderDefinition> collection)
        {
            Program.Log.Debug("Folders | Found [{0}] stored folder configurations.", parsed.Count);

            foreach(string folderJSON in parsed.Items)
            {
                FolderDefinition? def = JsonConvert.DeserializeObject<FolderDefinition>(folderJSON);

                if (def != null)
                {
                    Program.Log.Debug("Folders | Detected folder configuration [{0}].", def.Path);

                    collection.Add(def);
                }
            }
        }

        public static FolderDefinition AddFolderDefinition(string path, string label)
        {
            Program.Log.Information("Folders | Adding new folder [{0}].", label);

            FolderDefinition def = new(path, label);
            Folders.Add(def);
            return def;
        }

        public static void Save()
        {
            Program.Log.Debug("Folders | Saving [{0}] folder configurations.", Folders.Count);

            List<string> values = new();

            foreach (FolderDefinition database in Folders)
            {
                values.Add(JsonConvert.SerializeObject(database));
            }

            Program.AppSettings.Folders = string.Join(RecordsSeparator, values.ToArray());
            Program.AppSettings.Save();
        }

        internal static void DeleteFolderDefinition(FolderDefinition def)
        {
            Program.Log.Information("Folders | Deleting the folder [{0}].", def.Label);

            List<FolderDefinition> keep = new();

            foreach(FolderDefinition folder in Folders)
            {
                if(folder != def)
                {
                    keep.Add(def);
                }
            }

            folders = keep;
        }
    }
}
