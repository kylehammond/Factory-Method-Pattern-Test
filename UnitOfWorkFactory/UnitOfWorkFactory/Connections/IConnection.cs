namespace UnitOfWorkFactory.Connections
{
    public interface IConnection
    {
        string Name { get; set; }
        string Server { get; set; }
        string Database { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string ConnectionString { get; }
    }
}