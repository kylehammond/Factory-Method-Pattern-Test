namespace UnitOfWorkFactory.Connections
{
    public class Connection : IConnection
    {
        public Connection(string name, string server, string database, string userName, string password)
        {
            Name = name;
            Server = server;
            Database = database;
            UserName = userName;
            Password = password;
        }

        public string Name { get; set; }
        public string Server { get; set; }
        public string Database { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConnectionString => "data source=" + Server + "; initial catalog=" + Database + "; username=" + UserName + "; password=" + Password;
    }
}