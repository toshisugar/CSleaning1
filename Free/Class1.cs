using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Free
{
    class GenericsSample
    {
        public List<string> GetStringList()
        {
            var list = new List<string>();
            list.Add("文字列");

            //string item = list[10];
            return list;
        }
    }
}
