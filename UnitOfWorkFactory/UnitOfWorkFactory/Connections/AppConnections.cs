namespace UnitOfWorkFactory.Connections
{
    public static class AppConnections
    {
        public static Connection Dev = new Connection("connection1", "servername", "database", "username", "password");
        public static Connection Staging = new Connection("connection2", "servername", "database", "username", "password");
        public static Connection Prod = new Connection("connection3", "servername", "database", "username", "password");
    }
}