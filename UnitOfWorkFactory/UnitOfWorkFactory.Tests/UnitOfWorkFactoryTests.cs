using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitOfWorkFactory.Connections;
using UnitOfWorkFactory.UnitOfWork;

namespace UnitOfWorkFactory.Tests
{
    [TestClass]
    public class UnitOfWorkFactoryTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var uow = new UoWFactory().Get(EnvironmentType.Dev))
            {
                uow.BananaRepository.GetAll(b => b.Color == "Yellow");
            }
        }
    }
}