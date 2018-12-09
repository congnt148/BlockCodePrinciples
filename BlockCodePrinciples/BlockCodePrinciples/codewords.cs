using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCodePrinciples
{
    class codewords
    {
        string name;
        string valuescode;
        public string Valuescode
        {
            get
            {
                return valuescode;
            }

            set
            {
                valuescode = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public codewords()
        {
            Name = Valuescode =  "";
        }
        public codewords(codewords A)
        {
            this.Name = A.Name;
            this.Valuescode = A.Valuescode;
        }
        public codewords(string _name, string _values)
        {
            this.Name = _name;
            this.Valuescode = _values;
        }
    }
}
