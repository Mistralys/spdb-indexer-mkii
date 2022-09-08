using SPDB_MKII.Classes.DatabaseHandling;
using SPDB_MKII.Classes.TagInfos.TagEvents;

namespace SPDB_MKII.Classes.TagInfos
{
    internal class TagRecord : BaseRecord
    {
        public const string TableName = "tags";
        public const string ColCategoryID = "category_id";
        public const string ColPrimary = "tag_id";
        public const string ColName = "name";
        public const string ColParentTagID = "parent_tag_id";

        public TagRecord(long id) : base(id)
        {

        }

        public string Name
        {
            get => GetColumn(ColName);
            set => SetColumn(ColName, value);
        }

        public long CategoryID
        {
            get => GetColumnInt(ColCategoryID);
        }

        public long ParentTagID
        {
            get => GetColumnInt(ColParentTagID);
            set => SetColumn(ColParentTagID, value);
        }

        public TagRecord? ParentTag
        {
            get
            {
                if (HasParent)
                {
                    return TagCollection.GetTagByID(ParentTagID);
                }

                return null;
            }
            set
            {
                if(value == null)
                {
                    if (ParentTag == null) 
                    { 
                        return;
                    }

                    TagRecord previous = ParentTag; 

                    SetColumn(ColParentTagID, null);

                    ParentTagSwitched?.Invoke(this, new TagParentSwitched(this, previous));
                    return;
                }

                // Switch the category before setting the parent
                // tag, because this resets the parent tag.
                if(value.CategoryID != CategoryID)
                {
                    Category = value.Category;
                }

                TagRecord? old = ParentTag;

                SetColumn(ColParentTagID, value.ID);

                ParentTagSwitched?.Invoke(this, new TagParentSwitched(this, old, value));
            }
        }

        public bool HasParent
        {
            get => ParentTagID > 0;
        }

        public List<TagRecord> ChildTags
        {
            get
            {
                List<TagRecord> list = new();

                foreach(TagRecord record in TagCollection.Tags)
                {
                    if(record.ParentTag == this)
                    {
                        list.Add(record);
                    }
                }

                return list;
            }
        }

        public TagCategoryRecord Category
        {
            get => TagCollection.GetCategoryByID(CategoryID);
            set
            {
                if(value.ID == CategoryID)
                {
                    return;
                }

                TagCategoryRecord old = Category;

                SetColumn(ColCategoryID, value.ID);
                
                // Remove any parent tag, as this will not be available
                // in the target category.
                SetColumn(ColParentTagID, null);

                CategorySwitched?.Invoke(this, new TagCategorySwitchedEventArgs(this, old, value));
            }
        }

        protected override string GetPrimaryName()
        {
            return ColPrimary;
        }

        protected override string GetTableName()
        {
            return TableName;
        }

        protected override void DisposeCollections()
        {
        }

        protected override void DisposeDisposables()
        {
        }

        public event EventHandler<TagCategorySwitchedEventArgs>? CategorySwitched;
        public event EventHandler<TagParentSwitched>? ParentTagSwitched;
    }
}
