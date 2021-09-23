using System;
using System.Collections.Generic;
namespace PersonElevAnställd
{
    class Program
    {
        static void Main(string[] args)
        {
          List<Person> plist = new List<Person>();
            plist.Add(new Anställd("Nisse", "700101-5600",25000));
            plist.Add(new Elev("Kajsa", "20010506-2600",2019,"Teknik"));
            Console.Write("Ange namn: ");
            string namn=Console.ReadLine();
              Console.Write("Ange personnummer: ");
            string personnr=Console.ReadLine();
              Console.Write("Ange lön: ");
            int lön=int.Parse(Console.ReadLine());
           string allt = namn + personnr + lön;
           string elevinput = namn + personnr;
            Console.WriteLine(allt);
         
            foreach(var item in plist)
            {
                Console.WriteLine(item);
            }
    
        }
    }
}
//Abstrakt klass, får ej skapa instanser av, kan däremot ärva från, person ska vara det, person är aldrig bara person antingen elev eller personal.
//Koncept
//Referensvariabel
//case, när något specifikt händer som inte kan klassas som något annat.
/*
    if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
            }
            if (Console.CursorTop > 0)
            {
                Console.Write("");
            }
            
        }*/

//https://stackoverflow.com/questions/45063659/user-object-input-into-list-of-data/45063898