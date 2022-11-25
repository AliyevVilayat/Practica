using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.Utilities.Exceptions;

public class CapacityLimitException : Exception
{

    public CapacityLimitException(string message) : base(message)
    {

    }

}
