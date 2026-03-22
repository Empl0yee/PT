using Project.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Logic
{
    public interface ILogicAPI
    {
        string GetData();
    }

    public class LogicAPI : ILogicAPI
    {
        private readonly IDataAPI _dataAPI;
        public LogicAPI(IDataAPI dataAPI)
        {
            _dataAPI = dataAPI;
        }
        public string GetData()
        {
            return _dataAPI.GetMessage();
        }
    }
}
