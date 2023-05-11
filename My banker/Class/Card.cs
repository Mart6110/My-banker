using My_banker.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_banker.Class
{
    public abstract class Card
    {
        public string Name { get; }

        protected Card(string name)
        {
            Name = name;
        }
    }
}
