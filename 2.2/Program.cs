namespace w4
{
    public abstract class Shape1
    {
        public abstract double Area(); //no bbody
        //we cant create an instence of abstract class
    }

    //define abstract class with tittled car, drive and breaks methods, inherit this abstract class with named togg
    public abstract class Car //eğer başında public olmazsa başına otomatık private koyar
    {
        public abstract void Drive();
        public abstract void Breaks();
    }

    public class TOGG : Car //abstractların içini doldurmalıyız
    {
        public override void Breaks()
        {
            Console.WriteLine("Togg car is breaking...");
        }
        public override void Drive()
        {
            Console.WriteLine("Togg car is driving...");
        }
    }
    
    public class Ogrenci
    {
        public static void Study()
        {
            Console.WriteLine("sudent is studying");
        }

        public static void Exam()
        {
            Console.WriteLine("sudent is taking an exam");
        }
    }
    public class Lisans : Ogrenci
    {

    }
   
    public class Shape
    {
        public virtual double Area() => 0;
        public virtual double Perimeter(double a, double b) => 2 * (a +b);
    }
    //if method has same name with class = constructer method
    public class Circle : Shape
    {
        public double R;
        public override double Area() => Math.PI * R * R;
        public override double Perimeter() => Math.PI * 2 * R;
    }
    internal class Program
    {
        public static int topla(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(topla(10, 20));
            Console.WriteLine(topla(10.4, 20.6));
            Console.WriteLine(topla(10, 20, 30));

            Car car = new Car(); //abstract sınıfın instancesi oluşturulamaz
            TOGG tOGG = new TOGG();
            tOGG.Breaks();
            tOGG.Drive();

            Ogrenci.Study();
            Lisans.Exam();
        }

        public static double topla(double x, double y)//methodun parametresi değiştiği iin sorun olmaz
        {
            return x + y;
        }
        
        public static float topla(float x, float y)
        {
            return x + y;
        }

        public static long topla(long x, long y)
        {
            return x + y;
        }

        public static int topla(int x, int y, int z)
        {
            return x + y;
        }
        //method overloading
        //miras alınan sınıfın methodunun değiştirilmesi -> overriding

        
    }
}
