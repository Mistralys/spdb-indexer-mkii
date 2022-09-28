using SPDB_MKII.Classes.TagInfos;
using UnitTests.Assets;

namespace UnitTests.Tests.TagInfos
{
    [TestClass]
    public class TagsManagerTests : BaseTest
    {
        public TagsManagerTests() : base()
        {
        }

        [TestMethod]
        public void TestAddCategory()
        {
            SPDB_MKII.Program.Log.Debug("Test: Add category.");

            TagCategoryRecord category = TagCollection.AddCategory("Test category");

            Assert.IsNotNull(category);
            Assert.AreEqual("Test category", category.Name);
        }
    }
}