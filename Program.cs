using System;

namespace PersonElevAnställd
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Person person1 = new Person("Nisse", "19760203-2121");
            Elev elev1 = new Elev("Kajsa", "20010506-2600",2019,"Teknik");
          //  Console.WriteLine(person1);
            Console.WriteLine(elev1);
        }
    }
}
//Abstrakt klass, får ej skapa instanser av, kan däremot ärva från, person ska vara det, person är aldrig bara person antingen elev eller personal.