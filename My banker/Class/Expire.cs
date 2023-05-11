using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_banker.Class
{
    public class Expire : Card
    {
        protected DateTime ExpirationDate { get; }

        public Expire(string name) : base(name)
        {
            ExpirationDate = DateTime.Now.AddYears(5);
        }
    }
}
