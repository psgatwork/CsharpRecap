using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BasicsOne
{
    public class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(Point newLocation)
        {
            this.x = newLocation.x;
            this.y = newLocation.y;
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var point = new Point(10, 20);


        Console.WriteLine();
        Console.ReadLine();
    }

}
}
