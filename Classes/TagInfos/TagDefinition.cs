using SPDB_MKII.Classes.DatabaseHandling;

namespace SPDB_MKII.Classes.TagInfos
{
    internal class TagDefinition : BaseRecord
    {
        public TagDefinition(long id) : base(id)
        {

        }

        protected override string GetPrimaryName()
        {
            return "tag_id";
        }

        protected override string GetTableName()
        {
            return "tags";
        }
    }
}
