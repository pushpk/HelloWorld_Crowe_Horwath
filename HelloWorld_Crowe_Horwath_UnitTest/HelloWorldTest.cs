using HelloWorld_Crowe_Horwath;
using HelloWorld_Crowe_Horwath.AbstractTarget;
using HelloWorld_Crowe_Horwath.ConcreteTarget;
using HelloWorld_Crowe_Horwath.Factory;
using HelloWorld_Crowe_Horwath_API_Services.Controllers;
using HelloWorld_Crowe_Horwath_API_Services.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Threading.Tasks;
using static HelloWorld_Crowe_Horwath.Helper.TargetTypeEnum;

namespace HelloWorld_Crowe_Horwath_UnitTest
{
    [TestClass]
    public class HelloWorldTest
    {
        private IConfigurationRoot configuration;
        private ITarget target;

        [TestInitialize]
        public void Init()
        {
            configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
        }


        [TestMethod]
        public void Test_API()
        {
            HelloWorldController controller = new HelloWorldController(new HelloWorldGreeting());
            APIAssert.AreEqual("Hello World", controller.Get());
        }


        [TestMethod]
        public void Test_Factory_Object_Creation_Console()
        {
            var consoleObj = TargetFactory.Create(TargetTypes.Console);

            Assert.IsNotNull(consoleObj);
            Assert.IsInstanceOfType(consoleObj, typeof(ConsoleTarget));
        }

        [TestMethod]
        public void Test_Factory_Object_Creation_Database()
        {
            var dbObj = TargetFactory.Create(TargetTypes.Database);

            Assert.IsNotNull(dbObj);
            Assert.IsInstanceOfType(dbObj, typeof(DatabaseTarget));
        }

    }
}
