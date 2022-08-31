using SPDB_MKII.Classes.DatabaseHandling;
using SPDB_MKII.Classes.TagInfos.TagEvents;

namespace SPDB_MKII.Classes.TagInfos
{
    internal static class TagCollection
    {
        public static Dictionary<long,TagCategoryDefinition>? categories = null;

        public static List<TagCategoryDefinition> Categories
        {
            get
            { 
                List<TagCategoryDefinition> list = new();

                foreach(long categoryID in CategoryIDs)
                {
                    list.Add(GetCategoryByID(categoryID));
                }

                return list;
            }
        }

        public static TagCategoryDefinition GetCategoryByID(long categoryID)
        {
            categories ??= new Dictionary<long, TagCategoryDefinition>();

            if(categories.ContainsKey(categoryID))
            {
                return categories[categoryID];
            }

            TagCategoryDefinition category = new(categoryID);
            category.Saved += Handle_CategorySaved;

            categories.Add(categoryID, category);

            return category;
        }

        private static void Handle_CategorySaved(object? sender, DatabaseHandling.RecordEvents.RecordSavedEventArgs e)
        {
            if (e.Record is TagCategoryDefinition def)
            {
                CategoryModified?.Invoke(null, new CategoryModifiedEventArgs(def));
            }
        }

        public static TagCategoryDefinition AddCategory(string name)
        {
            long id = DBHelper.Instance.Insert(
                @"INSERT INTO
                    `tag_categories`
                SET
                    `name`=@name
                ",
                new Dictionary<string, string> {
                    { "name", name }
                }
            );

            TagCategoryDefinition category = GetCategoryByID(id);

            CategoryAdded?.Invoke(null, new CategoryAddedEventArgs(category));

            return category;
        }

        public static void DeleteCategory(TagCategoryDefinition category)
        {
            DBHelper.RequireTransaction();

            if (categories == null)
            {
                return;
            }

            categories.Remove(category.ID);

            CategoryDeleted?.Invoke(null, new CategoryDeletedEventArgs(category.ID, category.Name));
        }

        private static List<long>? categoryIDs = null;

        public static List<long> CategoryIDs
        {
            get 
            {
                categoryIDs ??= DBHelper.Instance.FetchAllKeyInt(
                        "tag_category_id",
                        @"SELECT
                        `tag_category_id`
                    FROM
                        `tags_categories`
                    ORDER BY
                        `name` ASC
                    "
                );

                return categoryIDs;
            }
        }

        private static List<long>? tagIDs = null;

        public static Dictionary<long,TagDefinition>? tags = null;

        public static List<TagDefinition> Tags
        {
            get
            {
                List<TagDefinition> list = new List<TagDefinition>();

                foreach (long tagID in TagIDs)
                {
                    list.Add(new TagDefinition(tagID));
                }

                return list;
            }
        }

        public static TagDefinition GetTagByID(long tagID)
        {
            tags ??= new Dictionary<long,TagDefinition>();

            TagDefinition tag = new(tagID);

            tags[tagID] = tag;

            return tag;
        }

        public static List<long> TagIDs
        {
            get
            {
                tagIDs ??= DBHelper.Instance.FetchAllKeyInt(
                    "tag_id",
                    @"SELECT
                        `tag_id`
                    FROM
                        `tags`
                    ORDER BY
                        `name` ASC
                    "
                );

                return tagIDs;
            }
        }

        public static event EventHandler<CategoryAddedEventArgs>? CategoryAdded;
        public static event EventHandler<CategoryDeletedEventArgs>? CategoryDeleted;


        /// <summary>
        /// Triggered whenever a category has been modified, and the changes
        /// have been committed to the database.
        /// </summary>
        public static event EventHandler<CategoryModifiedEventArgs>? CategoryModified;
    }
}
