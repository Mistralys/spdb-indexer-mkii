using SPDB_MKII.Classes.DatabaseHandling;
using SPDB_MKII.Classes.TagInfos.TagEvents;

namespace SPDB_MKII.Classes.TagInfos
{
    internal static class TagCollection
    {
        public static Dictionary<long,TagCategoryRecord>? categories = null;

        public static List<TagCategoryRecord> Categories
        {
            get
            { 
                List<TagCategoryRecord> list = new();

                foreach(long categoryID in CategoryIDs)
                {
                    list.Add(GetCategoryByID(categoryID));
                }

                return list;
            }
        }

        public static TagCategoryRecord GetCategoryByID(long categoryID)
        {
            categories ??= new Dictionary<long, TagCategoryRecord>();

            if(categories.ContainsKey(categoryID))
            {
                return categories[categoryID];
            }

            TagCategoryRecord category = new(categoryID);
            category.Saved += Handle_CategorySaved;

            categories.Add(categoryID, category);

            return category;
        }

        private static void Handle_CategorySaved(object? sender, DatabaseHandling.RecordEvents.RecordSavedEventArgs e)
        {
            if (e.Record is TagCategoryRecord def)
            {
                CategorySaved?.Invoke(null, new CategorySavedEventArgs(def));
            }
        }

        public static TagCategoryRecord AddCategory(string name)
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

            TagCategoryRecord category = GetCategoryByID(id);

            CategoryAdded?.Invoke(null, new CategoryAddedEventArgs(category));

            return category;
        }

        private static TagCategoryRecord? deletingCategory = null;

        public static void DeleteCategory(TagCategoryRecord category)
        {
            DBHelper.RequireTransaction();

            if (categories == null)
            {
                return;
            }

            // Store the category being deleted so this information
            // can be passed on in the DeleteTag event.
            deletingCategory = category;

            // First off, delete all tags in the category,
            // so anyone watching those tag events can react
            // to the change. For example, the collection uses
            // this to remove the tag from the tags collection.
            //
            // We use a copy of the tags list to avoid issues
            // when modifying the tags collection.
            List<TagRecord> tags = new(category.Tags);

            foreach(TagRecord tag in tags)
            {
                DeleteTag(tag);
            }

            DBHelper.Instance.Delete(
                string.Format(
                    @"DELETE FROM
                        `{0}`
                    WHERE
                        `{1}`=@id",
                    TagCategoryRecord.TableName,
                    TagCategoryRecord.ColPrimary
                ),
                new Dictionary<string, string> {
                    { "id", category.ID.ToString() }
                }
            );

            categories.Remove(category.ID);
            deletingCategory = null;

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

        public static Dictionary<long,TagRecord>? tags = null;

        public static List<TagRecord> Tags
        {
            get
            {
                List<TagRecord> list = new();

                foreach (long tagID in TagIDs)
                {
                    list.Add(new TagRecord(tagID));
                }

                return list;
            }
        }

        public static TagRecord GetTagByID(long tagID)
        {
            tags ??= new Dictionary<long,TagRecord>();

            TagRecord tag = new(tagID);
            tag.CategorySwitched += Handle_Tag_CategoryChanged;

            tags[tagID] = tag;

            return tag;
        }

        private static void Handle_Tag_CategoryChanged(object? sender, TagCategorySwitchedEventArgs e)
        {
            TagCategorySwitched?.Invoke(null, e);
        }

        public static void DeleteTag(TagRecord tag)
        {
            DBHelper.RequireTransaction();

            DBHelper.Instance.Delete(
                string.Format(
                    @"DELETE FROM
                        `{0}`
                    WHERE
                        `{1}`=@id",
                    TagRecord.TableName,
                    TagRecord.ColPrimary
                ),
                new Dictionary<string, string> 
                {
                    { "id", tag.ID.ToString() }
                }
            );

            if (tagIDs != null)
            {
                tagIDs.Remove(tag.ID);
            }

            TagDeleted?.Invoke(null, new TagDeletedEventArgs(tag.ID, tag.Name, deletingCategory));
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
        /// Triggered whenever a category's columns have been modified, 
        /// and the changes have been committed to the database.
        /// </summary>
        public static event EventHandler<CategorySavedEventArgs>? CategorySaved;

        /// <summary>
        /// Triggered when a tag has been switched to another category.
        /// </summary>
        public static event EventHandler<TagCategorySwitchedEventArgs>? TagCategorySwitched;

        public static event EventHandler<TagDeletedEventArgs>? TagDeleted;
    }
}
