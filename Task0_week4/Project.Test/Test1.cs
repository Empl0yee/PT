using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Data;
using Project.Logic;

namespace Project.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IDataAPI dataAPI = new DataAPI();
            dataAPI.SaveMessage("Hello, World!");

            ILogicAPI logicAPI = new LogicAPI(dataAPI);

            string result = logicAPI.GetData();

            Assert.AreEqual("Hello, World!", result);
        }
    }
}
