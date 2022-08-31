using SPDB_MKII.Classes.DatabaseHandling;

namespace SPDB_MKII.Classes.TagInfos
{
    internal class TagCategoryDefinition : BaseRecord
    {
        public TagCategoryDefinition(long id) : base(id)
        {
        }

        public string Name
        {
            get => GetColumn("name");
            set => SetColumn("name", value);
        }

        protected override string GetPrimaryName()
        {
            return "tag_category_id";
        }

        protected override string GetTableName()
        {
            return "tags_categories";
        }
    }
}
