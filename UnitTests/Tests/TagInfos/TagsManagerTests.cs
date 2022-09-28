using SPDB_MKII.Classes.TagInfos;
using SPDB_MKII.Classes.TagInfos.TagEvents;
using UnitTests.Assets;

namespace UnitTests.Tests.TagInfos
{
    [TestClass]
    public class TagsManagerTests : BaseTest
    {
        #region _Tests

        [TestMethod]
        public void TestAddCategory()
        {
            TagCategoryRecord category = TagCollection.AddCategory("Test category");

            Assert.IsNotNull(category);
            Assert.AreEqual("Test category", category.Name);

            Assert.IsNotNull(_categoryAddedEventArgs);
            Assert.AreEqual(_categoryAddedEventArgs.Category, category);
        }

        [TestMethod]
        public void TestModifyCategory()
        {
            TagCategoryRecord category = TagCollection.AddCategory("Test category");

            category.Name = "New name";
            category.Save();

            Assert.IsNotNull(_categorySavedEventArgs);
            Assert.AreEqual(_categorySavedEventArgs.Category, category);

            // Reset the collection to fetch a fresh category instance
            TagCollection.ResetCollection();

            TagCategoryRecord freshCategory = TagCollection.GetCategoryByID(category.ID);
            Assert.AreNotSame(category, freshCategory);
            Assert.AreEqual("New name", freshCategory.Name);
        }

        #endregion

        #region Support methods

        private CategoryAddedEventArgs? _categoryAddedEventArgs = null;
        private CategorySavedEventArgs? _categorySavedEventArgs = null;

        public TagsManagerTests() : base()
        {
            TagCollection.CategoryAdded += Handle_CategoryAdded;
            TagCollection.CategorySaved += Handle_CategorySaved;
        }

        private void Handle_CategorySaved(object? sender, CategorySavedEventArgs e)
        {
            _categorySavedEventArgs = e;
        }

        private void Handle_CategoryAdded(object? sender, SPDB_MKII.Classes.TagInfos.TagEvents.CategoryAddedEventArgs e)
        {
            _categoryAddedEventArgs = e;
        }


        public new void TearDown()
        {
            base.TearDown();

            _categoryAddedEventArgs = null;
            _categorySavedEventArgs = null;
        }

        #endregion
    }
}