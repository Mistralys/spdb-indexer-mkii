namespace SPDB_MKII.Classes.FolderInfos
{
    internal class FolderDefinition
    {
        public string Path;
        public string Label;

        public bool Exists { 
            get { 
                return File.Exists(Path); 
            }
        }

        public string ExistsPretty 
        {
            get 
            {
                if (Exists) {
                    return "✓";
                }

                return "x";
            }
        }

        public FolderDefinition(string path, string label)
        {
            Path = path;
            Label = label;
        }
    }
}
