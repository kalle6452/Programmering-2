using System;

namespace projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
        }
    }
}



class Triangel : Shape
{
    public area {
        return width * height;
    }
    public Triangel(int width, int height): base(width, height)
    {

    }
}
/*{
   public int Area{get;}
   public int Circumferance {get;}
}*/


class Shape
{
    public int Height{get; set;}
    public int Width{get; set;}

public Shape(int width, int height)
{
    height = Height;
    width = Width;
}
}

