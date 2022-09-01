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

        public TagCategoryRecord Category
        {
            get => TagCollection.GetCategoryByID(CategoryID);
            set
            {
                TagCategoryRecord old = Category;

                SetColumn(ColCategoryID, value.ID);

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
    }
}
