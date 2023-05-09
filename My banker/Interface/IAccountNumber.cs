using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_banker.Interface
{
    interface IAccountNumber
    {
        public string RegNumber { get; set; }
        public int[] AccountNumber { get; set; }
    }
}
