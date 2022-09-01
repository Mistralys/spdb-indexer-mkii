using SPDB_MKII.Classes.DatabaseHandling;
using SPDB_MKII.Classes.TagInfos.TagEvents;

namespace SPDB_MKII.Classes.TagInfos
{
    internal class TagCategoryRecord : BaseRecord
    {
        public const string ColPrimary = "tag_category_id";
        public const string TableName = "tags_categories";
        public const string ColName = "name";

        public TagCategoryRecord(long id) : base(id)
        {
            TagCollection.TagCategorySwitched += Handle_TagCollection_TagCategoryChanged;
        }

        private void Handle_TagCollection_TagCategoryChanged(object? sender, TagEvents.TagCategorySwitchedEventArgs e)
        {
            if(e.OldCategory == this)
            {
                TagDisconnected?.Invoke(this, new CategoryTagDisconnectedEventArgs(this, e.Tag));
            }

            if(e.NewCategory == this)
            {
                TagConnected?.Invoke(this, new CategoryTagConnectedEventArgs(this, e.Tag));
            }
        }

        public string Name
        {
            get => GetColumn(ColName);
            set => SetColumn(ColName, value);
        }

        public List<TagRecord> Tags
        {
            get
            {
                List<TagRecord> tags = new();

                foreach(TagRecord tag in TagCollection.Tags)
                {
                    if(tag.Category == this)
                    {
                        tags.Add(tag);
                    }
                }

                return tags;
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

        public event EventHandler<CategoryTagConnectedEventArgs>? TagConnected;
        public event EventHandler<CategoryTagDisconnectedEventArgs>? TagDisconnected;
    }
}
