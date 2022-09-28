
namespace SPDB_MKII.Classes.DatabaseInfos
{
    public class DatabaseDefinition
    {
        private int port = 0;

        public DatabaseDefinition(string host, string userName, string password, string databaseName, int port)
        {
            Host = host;
            DatabaseName = databaseName;
            UserName = userName;
            Password = password;
            Port = port;
        }

        public string Host { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Port 
        {
            get 
            {
                if (port == 0) {
                    return 3306;
                }

                return port;
            } 
            set
            {
                port = value;
            }
        }

        public string ConnectionString {
            get
            {
                return string.Format(
                    "server={0};user={1};password={2};database={3};port={4}",
                    Host,
                    UserName,
                    Password,
                    DatabaseName,
                    Port
                );
            }
        }
    }
}
