using UnitOfWorkFactory.Connections;

namespace UnitOfWorkFactory.UnitOfWork
{
    public class UoWFactory
    {
        public UnitOfWork Get(EnvironmentType environmentType = EnvironmentType.None)
        {
            if (environmentType == EnvironmentType.Dev)
                return new UnitOfWork(AppConnections.Dev);

            if (environmentType == EnvironmentType.Staging)
                return new UnitOfWork(AppConnections.Staging);

            if (environmentType == EnvironmentType.Prod)
                return new UnitOfWork(AppConnections.Prod);

            return new UnitOfWork(AppConnections.Dev);
        }
    }
}