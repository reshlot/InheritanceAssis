using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class ClassTeaccher:Teacher
    {
        private CClass whichClass;

        public CClass WhichClass
        {
            get { return whichClass; }
            set { whichClass = value; }
        }
    }
}
