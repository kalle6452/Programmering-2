using System;
using System.Collections.Generic;
namespace PersonElevAnställd
{
    class Program
    {
        static void Main(string[] args)
        {
         
      
          
         /*   plist.Add(new Anställd("Nisse", "700101-5600",25000));
            plist.Add(new Elev("Kajsa", "20010506-2600",2019,"Teknik"));
            Console.Write("Ange namn: ");
            string namn=Console.ReadLine();
              Console.Write("Ange personnummer: ");
            string personnr=Console.ReadLine();
              Console.Write("Ange lön: ");
            int lön=int.Parse(Console.ReadLine());
           string allt = namn + personnr + lön;
           
            Console.WriteLine(allt);*/
         
          /*  foreach(var item in plist)
            {
                Console.WriteLine(item);
            }*/
    List<Person> plist = new List<Person>();
              int menyval = -1;
          while (menyval != 0)
          {
          
               Console.WriteLine("1 lägg till elev.");
               Console.WriteLine("2 lägg till anställd");
               Console.WriteLine("3 skriv upp alla elever.");
               Console.WriteLine("4 skriv upp alla anställda.");
                Console.WriteLine("5 Avsluta programmet");
               int meny = int.Parse(Console.ReadLine());
               if (meny==2)//Varför 2 ==
               {
                 
                  Console.Write("Ange namn: ");
            string namn=Console.ReadLine();
              Console.Write("Ange personnummer: ");
            string personnr=Console.ReadLine();
              Console.Write("Ange lön: ");
                  int lön=int.Parse(Console.ReadLine());
                  plist.Add(new Anställd(namn, personnr, lön));
               }
               if(meny==1)
               {
                     Console.Write("Ange namn: ");
            string namn=Console.ReadLine();
              Console.Write("Ange personnummer: ");
            string personnr=Console.ReadLine();
            Console.Write("Ange antagningsår ");
            int år=int.Parse(Console.ReadLine());
            Console.WriteLine("Ange Utbildningsprogram");
            string prog=Console.ReadLine();
            plist.Add(new Elev(namn, personnr, år, prog));
          
               }
               if(meny==3)
               {
                  foreach(Elev item in plist)
            {
                Console.WriteLine(item);
            }

               }
               if(meny==4)
               {
                   foreach (Anställd item in plist)
                   {
                       Console.WriteLine(item);
                   }
               }
               if(meny==6)
               {
                   break;
               }
          }
        }
    }
}