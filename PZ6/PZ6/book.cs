using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ6
{
    internal class book
    {
        private string _name;
        public string Name
        {
            get => _name;
            private set => _name = value;
        }
        public book(string name)
        {
            _name = name;
        }
    }
}
