using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace курсовая
{
    internal class Exceptions : Exception
    {
        public Exceptions(string message) : base(message)
        {

        }
    }
}
