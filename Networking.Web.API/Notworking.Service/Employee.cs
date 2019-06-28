using System;
using System.Collections.Generic;
using System.Text;

namespace Notworking.Service
{
    public class Employee : IEmployee
    {
        public IEnumerable<string> GetValues()
        {
            return new List<string>() { "test1" };
        }
    }
}
