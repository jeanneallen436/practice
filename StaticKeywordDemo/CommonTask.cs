using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaticKeyowrdDemo
{
    public static class CommonTask
    {
        public static bool IsEmpty(string value)
        {
            if (value.Length > 0)
            {
                return true;
            }

            return false;
        }

        public static string GetComputerName()
        {
            return System.Environment.MachineName;
        }
    }
}