using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class DisplayClass
    {
        public string display(string Answer)
        {
            string number = Answer;
            string newnumber = "";
            for(int i = number.Length -1; i >= 0; i--)
            {
                newnumber += number[i];
            }
            return newnumber;
        }
    }
}
