using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public  class CClass
    {

        private string name;
        private ClassTeaccher whichTeacher;
        private List<SubjectTeacher> subjectTeachers;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public ClassTeaccher WhichTeacher
        {
            get { return whichTeacher; }
            set { whichTeacher = value; }
        }

        public List<SubjectTeacher> SubjectTeachers
        {
            get { return subjectTeachers; }
            set { subjectTeachers = value; }
        }


    }

}

