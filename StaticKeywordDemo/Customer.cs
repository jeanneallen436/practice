using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StaticKeyowrdDemo;

namespace StaticKeywordDemo
{
    public class Customer
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        private string MachineName = "";

        public Customer()
        {
            // CommonTask commonTask = new CommonTask();
            MachineName = CommonTask.GetComputerName();
        }
        // public bool IsEmpty(string value)
        // {
        //     if(value.Length > 0)
        //     {
        //         return true;
        //     }
        //     return false;
        // }        
        public void Insert()
        {
            // CommonTask commonTask = new CommonTask();

            if (!CommonTask.IsEmpty(CustomerCode) && !CommonTask.IsEmpty(CustomerName))
            {
                //Insert the data
            }
        }
    }
}