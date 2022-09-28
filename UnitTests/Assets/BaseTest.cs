using Microsoft.VisualStudio.TestPlatform.TestHost;
using SPDB_MKII.Classes.DatabaseHandling;
using SPDB_MKII.Classes.DatabaseInfos;

namespace UnitTests.Assets
{
    public abstract class BaseTest
    {
        private readonly string testDBServer = "localhost";
        private readonly string testDBUser = "root";
        private readonly string testDBPassword = "tomato";
        private readonly string testDBName = "spdb_tests";

        protected DBHelper db;

        public BaseTest()
        {
            var def = DatabaseCollection.AddDefinition(
                testDBServer,
                testDBUser,
                testDBPassword,
                testDBName,
                0
            );

            DatabaseCollection.ActiveDatabase = def;

            db = DBHelper.Instance;
        }

        [TestInitialize]
        public void SetUp()
        {
            SPDB_MKII.Program.Log.Debug("Setting up the base test.");

            db.StartTransaction();

            Assert.IsTrue(db.TransactionStarted);
        }

        [TestCleanup]
        public void TearDown()
        {
            SPDB_MKII.Program.Log.Debug("Tearing down the base test.");

            db.RollbackTransaction();
        }
    }
}
