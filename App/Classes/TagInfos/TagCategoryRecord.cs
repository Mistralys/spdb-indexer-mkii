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
            TagCollection.TagCategorySwitched += Handle_TagCategoryChanged;
            TagCollection.TagDeleted += Handle_TagDeleted;
        }

        private void Handle_TagDeleted(object? sender, TagDeletedEventArgs e)
        {
            // Reset the tags collection to rebuild it if necessary.
            if (e.Category == this)
            {
                tags = null;
            }
        }

        private void Handle_TagCategoryChanged(object? sender, TagEvents.TagCategorySwitchedEventArgs e)
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
            get => GetColumn(ColName) ?? "";
            set => SetColumn(ColName, value);
        }

        private List<TagRecord>? tags = null;

        public List<TagRecord> Tags
        {
            get
            {
                if(tags != null)
                {
                    return tags;
                }

                tags = new();

                foreach(TagRecord tag in TagCollection.Tags)
                {
                    if(tag.Category == this && tag.ParentTagID == 0) 
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
