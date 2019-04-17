using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class RegexNotFoundException : Exception
    {
        public RegexNotFoundException()
        {
        }

        public RegexNotFoundException(string message)
        : base(message)
        {
        }

        public RegexNotFoundException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
