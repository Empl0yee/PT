using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data
{
    public interface IDataAPI
    {
        string GetMessage();
        void SaveMessage(string msg);
    }

    public class DataAPI : IDataAPI
    {
        private string _storedMessage = "Initial data";
        public string GetMessage()
        {
            return _storedMessage;
        }
        public void SaveMessage(string msg)
        {
            _storedMessage = msg;
        }
    }
}
