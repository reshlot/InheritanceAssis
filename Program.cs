using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance
{
     class Program
    {
        static void Main(string[] args)
        {
            runApp();
            Console.ReadKey();
        }

        public static void runApp()

        {
            Console.WriteLine("***INHERITANCE***\n");


            Console.WriteLine("***Subjects***");
            Subject algebra = new Subject();
            algebra.Name = "Algebra";

            Subject physics = new Subject();
            physics.Name = "Physics";

            Console.WriteLine($"{algebra.Name}\n {physics.Name}\n");



            Console.WriteLine("***Subject Teachers***\n");
            Console.WriteLine("Teacher-1");
            SubjectTeacher algebraTeacher = new SubjectTeacher();
            algebraTeacher.Name = "Mr.Alexa";
            Console.WriteLine("Name: "+algebraTeacher.Name);
            algebraTeacher.ContactAddress = "Some Address";
            Console.WriteLine("Addres:   " + algebraTeacher.ContactAddress);
            algebraTeacher.DateOfJoining = Convert.ToDateTime("2009-10-20 00:00:00");
            Console.WriteLine("Date Of Joining: " + algebraTeacher.DateOfJoining);
            algebraTeacher.WhichSubject = algebra;
            Console.WriteLine(" Subject Name: Algebra \n" );



            Console.WriteLine("Teacher-2");
            SubjectTeacher physicsTeacher = new SubjectTeacher();
            physicsTeacher.Name = "Mr.Physics";
            Console.WriteLine("Name: " + physicsTeacher.Name);
            physicsTeacher.ContactAddress = "Some Address";
            Console.WriteLine("Addres:   " + physicsTeacher.ContactAddress);
            physicsTeacher.DateOfJoining = Convert.ToDateTime("2009-10-20 00:00:00");
            Console.WriteLine("Date Of Joining: " + physicsTeacher.DateOfJoining);
            physicsTeacher.WhichSubject = physics;
            Console.WriteLine("Subject Name: Physics\n ");


            Console.WriteLine("***Class***\n");
            CClass class8 = new CClass();
            class8.Name = "8";
            Console.WriteLine("Class Number :\n"+class8.Name);




            Console.WriteLine("***CLass Teachers***\n");
            ClassTeaccher teacherOf8 = new ClassTeaccher();
            teacherOf8.Name = "Mrs.Femina";
            Console.WriteLine("Teacher Name of class 8:"+teacherOf8.Name);
            teacherOf8.ContactAddress = "Some Address";
            Console.WriteLine("Teacher Address of class 8:" + teacherOf8.ContactAddress);
            teacherOf8.DateOfJoining = Convert.ToDateTime("2009-10-20 00:00:00");
            Console.WriteLine("Teacher Date of Joining of class 8:" + teacherOf8.DateOfJoining);
            teacherOf8.WhichClass = class8;
            Console.WriteLine("Teacher's Class : Class 8 \n" );

            class8.WhichTeacher = teacherOf8;
            Console.WriteLine("Class 8 Which Teacher:\n"+ teacherOf8.Name);

            Console.WriteLine("*************************THANK YOU*********************************");

        }
    }
}
