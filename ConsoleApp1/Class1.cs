using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GenericsSample
    {
        public List<string> GetStringList()
        {
            var list = new List<string>();  //リストには絶対に型指定が必要。varは推論して入れるだけだから使えない。
            list.Add("文字列");             //object型を指定することでなんでも入れられるが、処理が重くなるため本当に「なんでも型」が必要か考える必要がある。
            //string item = list[0];
            return list;
        }
    }
}
