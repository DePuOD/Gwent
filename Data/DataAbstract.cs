using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class DataAbstract
    {
    }

    public interface ICard { 
        int Value { get; set; }
        int Row { get; set; }
        String Type { get; set; }
    }
}
