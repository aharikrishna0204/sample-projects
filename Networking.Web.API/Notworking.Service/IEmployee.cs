using System;
using System.Collections.Generic;

namespace Notworking.Service
{
    public interface IEmployee
    {
        IEnumerable<string> GetValues();
    }
}
