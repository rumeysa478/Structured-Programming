using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace C_FINAL
{
    //W8
    /*
    public static (1) name(2)
    1: eğer return şeklinde çıktı istiyorsak çıktının türü yazılır
    eğer console.writeline ile çıktılıyorsak void kullanılır
    2:girdinin tütü ve girdi için kullanılacak değişken isimleri yazılır 

    static method: herkes için tek, nesne oluşturmaya gerek yok
    PrintOut.PrintInfo(); -> printout sınıfı printinfo methodunu çalıştır demek -> sınıf_adı.method_adı()
    instance method: nesneye(object) aittir, çağırmak için nesne oluşturman gerekir
    PrintOut prntout = new PrintOut(); -> sınıf nesne_adı = new sınıf() ->nesneyi tanımlar
    prntout.Display(); -> nesneyi çağırır -> nesne_adı.method_adı()
    */

    //W9
    /*
    in -> read-only methoddur valueyi okur ama değiştiremez, const gibi davranır
    out -> değer metodun içinde tanımlanmak zorunda, metod çağırılmadan önce değer atanmış olmak zorunda değil
    ref -> değer metot içinde okunabilir ve değiştirilebilir, method çağırılmadan önce başka bir değer almak zorunda
    eğer hiçbirşey kullanmazsak değeri anlık değiştirir, kalıcı olarak değişmez
    Özellik	                        in	ref	out
    Referans mı?	                ✅	✅	✅
    Önceden değer gerekli mi?	    ✅	✅	❌
    Metot içinde atama zorunlu mu?	❌	❌	✅
    Metot değiştirebilir mi?	    ❌	✅	✅
    params -> kaç tane değer girileceğini bilmiyorsak, değerleri dizi(array) şeklinde alır
    */

    //W10
    /*
    *arithmetic
    /Math.E -> Represents the natural logarithmic base, specified by the constant, e. (2.718281828459045)
    /Math.PI -> 3.141592653589793
    /Math.Tau -> Represents the number of radians in one turn, specified by the constant, τ. (6,283185307179586)
    /Math.Abs(x) -> Return the absolute value of a specified number, mutlak değer
    /Math.BigMul(x, y) -> int sayıları çarpıp long döndürür
    /Math.Cbrt(x) -> cube root of a specified number
    /Math.Ceiling(x.y) -> Return the smallest integral value that is greater than or equal to the float number
    /Math.Floor(x.y) -> Return the largest integral value that is less than or equal to the float number
    Math.Clamp(x(value), y(min), z(max)) -> sayı aralıktaysa sayıyı verir, küçükse min, büyükse max değerini verir
    Math.CopySign(x, y) -> xin mutlak değerini, ynin işaretini alır ve değer oluşturur
    /Math.DivRem(x, y) -> Return quotient and remainder resulting from dividing two numbers,(quotient, remainder)
    /Math.Exp(x) -> e raised to the value power, e^value
    Math.FusedMultiplyAdd(x, y, z) -> x * y + z
    Math.IEEERemainder(x, y) -> yuvarlanmış remainder resulting from the division of numbers
    /Math.Max(x, y) -> the larger of two numbers
    Math.MaxMagnitude(x, y) -> the number with the larger magnitude(mutlak değer)
    /Math.Min(x, y) -> the smaller of two numbers
    Math.MinMagnitude(x, y) -> the number with the smaller magnitude(mutlak değer)
    /Math.Pow(x, y) -> x üzeri y
    Math.ReciprocalEstimate(x) -> 1/x
    Math.ReciprocalSqrtEstimate(x) -> 1/ sqrt(x)
    /Math.Round(x.y) -> Return the integral or decimal value nearest to the specified float number
    Math.ScaleB(y, e) -> y x 2^e
    /Math.Sign(x) -> Return a value indicating the sign of a number (-1(-), 0, 1(+))
    /Math.Sqrt(x) -> Return the square root of a specified number
    /Math.Truncate(x.y) -> Return the integral part of a specified float number (x)
    *logaritmic
    Math.Log(x) -> ln(x)
    Math.Log(x(number), y(base)) -> 
    Math.Log10(x) -> Return the base 10 logarithm of a specified number
    Math.Log2(x) -> Return the base 2 logarithm of a specified number
    Math.ILogB(x) -> x sayısının 2 tabanındaki logaritmasının TAM KISMINI döndürür
    *trigonometric
    double angle = 60;
    double radians = angle * Math.PI / 180;
    /Math.Cos(radians) -> Return the cosine of the specified angle
    /Math.SinCos(radians) -> Return the sine and cosine of the specified angle
    Math.Acos(x) -> Return the angle whose cosine is the specified number
    Math.Atan2(x, y)  -> Return the angle whose tangent is the quotient of two specified numbers
    /Math.Cosh(radians) -> Return the hyperbolic cosine of the specified angle
    Math.Acosh(x) -> Return the angle whose hyperbolic cosine is the specified number
    */

    //W11
    /*
    // Create DateTime Object
    DateTime dateTime = new DateTime(); // 1/1/0001 12:00:00 AM
    // Set Current DateTime
    dateTime = DateTime.Now;
    // Create DateTime Object with Year, Month, Day
    dateTime = new DateTime(2024, 12, 18);
    // Create DateTime Object with Year, Month, Day, Hour, Minute, Second
    dateTime = new DateTime(2024, 12, 18, 15, 45, 00);
    // Create Today's DateTime
    DateTime date = DateTime.Today;
    // Create DateOnly Object
    DateOnly dateOnly = new DateOnly(2024, 12, 18);
    // Create TimeOnly Object
    TimeOnly timeOnly = new TimeOnly(15, 45, 00);
    // Storing  Days, Hours, Minutes, Seconds in TimeSpan
    TimeSpan timeSpan = new TimeSpan(5, 10, 15, 20);
    // Setting Turkish DateTime Format
    CultureInfo trCulture = new CultureInfo("tr-TR");
    Console.WriteLine("Turkish DateTime Format: {0}", dateTime.ToString("D", trCulture));
    *properties
    dateTime = DateTime.Today; -> ile değiştirilebilir
    dateTime.Year, dateTime.Month... day, hour, minute, second, millisecond, dayofweek, dayofyear, ticks, kind, date, timeofday
    dateTime.IsDaylightSavingTime(), DateTime.IsLeapYear(dateTime.Year)
    *custom format specifiers
    //turkish culture
    Console.WriteLine("d: {0}", dateTime.ToString("d")); -> 18.12.2024, //D -> 18 Aralik 2024 Çarsamba
    f -> 18 Aralik 2024 Çarsamba 00:00, //F -> 18 Aralik 2024 Çarsamba 00:00:00
    g -> 18.12.2024 00:00, //G -> 18.12.2024 00:00:00 
    m -> 18 Aralik, //M -> 18 Aralik, //o -> 2024-12-18T00:00:00.0000000+03:00
    R -> Wed, 18 Dec 2024 00:00:00 GMT, //s -> 2024-12-18T00:00:00, //t -> 00:00, //T -> 00:00:00
    u -> 2024-12-18 00:00:00Z, //U -> 17 Aralik 2024 Sali 21:00:00, //y -> Aralik 2024, //Y -> Aralik 2024
    dd -> 18, //ddd -> Çar, //dddd -> Çarsamba
    gg -> MS, //hh -> 12, //MMM -> Ara, //MMMM -> Aralik, //yy -> 24, //yyyy -> 2024, //zz -> +03
    Console.WriteLine(dateTime.ToString("gg dd MMMM yyyy dddd zzz")); -> MS 18 Aralik 2024 Çarsamba +03:00
    add method -> today.AddDays(x), days kısmı ne eklmek istiyorsak değişir 
    *subtract   
    today.Subtract(birthDate)
    //Subtracting 2 hour, 18 minutes, 15 seconds from today
    DateTime dateDiff = today.Subtract(new TimeSpan(2, 18, 15));
    // Subtracting 2 days from today
    dateDiff = today.Subtract(new TimeSpan(2, 0, 0, 0));
    // Subtracting 2 hours from today
    dateDiff = today.AddHours(-2);
    DateTime.Compare(date3, date4); -> compare two DateTime
    bool isEqualDate = date3.Equals(date4); -> DateTime Equals Method
    **strings**
    char[] letters = str.ToCharArray(); -> Convert string to char array 
    str.Length -> string length
    foreach (char c in str)   ]
      Console.Write(c + " "); ]-> iterating the string
    string str2 = new string('A', 5); // AAAAA -> string generation
    String.Format("{0, 30}", str); -> 30 karakterlik alanda sağa hizala
    String.Format("{0, -30}", str); -> 30 karakterlik alanda sola hizala
    Console.OutputEncoding = System.Text.Encoding.UTF8; -> konsolun karakter setini UTF-8 yapar (para birimleri, türkçe karakterler var)
    Console.WriteLine("\nDecimal: " + String.Format("{0, 0:d5}", 123)); // 00123 
    Console.WriteLine("Decimal Point: " + String.Format("{0, 0:0.00}", 123.456)); // 123.46
    Console.WriteLine("\nScientific: " + String.Format("{0, 0:e}", 123.456)); // 1.234560e+002
    Console.WriteLine("Fixed-point: " + String.Format("{0, 0:f2}", 123.456)); // 123.46
    Console.WriteLine("General: " + String.Format("{0, 0:g}", 123.456)); // 123.456
    Console.WriteLine("Number: " + String.Format("{0, 0:n}", 123456)); // 123,456.00
    Console.WriteLine("\nPercent: " + String.Format("{0, 0:p}", 0.123)); // %12.30
    Console.WriteLine("Percent: " + String.Format("{0, 0:0.00%}", 0.123)); // 12.30%
    Console.WriteLine("\nHexadecimal: " + String.Format("{0, 0:x}", 123)); // 7b
    Console.WriteLine("Zero: " + String.Format("{0, 0:00000}", 123)); // 00123
    Console.WriteLine("Digit: " + String.Format("{0, 0:###}", 123)); // 123
    Console.WriteLine("Thousand Separator: " + String.Format("{0, 0:#,###}", 123456)); // 123,456
    *string methods
    string str4 = (string)str3.Clone(); -> cloning string
    String.Compare(str3, str4) -> comparing if same prints 0,-1 if first is less than second, 1 first is greater than second
    str3.CompareTo(str4) -> ""
    String.CompareOrdinal(str7, str8); -> unicode değerine göre karşılaştırır
    String.Concat(str9, " ", str10); -> stringleri bitişik yazar
    String.Copy(str12); -> copy method
    str.CopyTo(stringdeki_başlangıç, char[], arraydeki_başlangıç, kaç karakter) -> stringi diziye kopyalar
    str12.EndsWith(str15); // True
    str12.StartsWith(str17); // True
    str19.Equals(str20); // True
    str19.GetType()
    str19.GetHashCode() -> hash kod verir bu kodlar değişkendir
    str22.IndexOf(str23) -> bir stringin içindeki substringdir, ilk bulduğunu döndürür, bulamazsa- 1 döner
    str25.LastIndexOf(str26) -> bulduğu son stringi döndürür
    str29.Insert(0, str28) -> bir string’in belirli bir konumuna başka bir string ekler
    String.IsNullOrEmpty(str31), String.IsNullOrWhiteSpace(str31)
    string[] str34 = { "Structured", "Programming", "II" }; ]
    string str35 = String.Join(" ", str34);                 ]-> dizideki elemanların arasına belirlenen eki ekler
    str36.PadLeft(20)); // "          Structured"
    str37.PadRight(20)); // "Structured          "
    str38.Remove(str38.Length - 2) -> belirtilen indexten itibaren siler
    str38.Remove(başlangıç_indexi, kaç_tane_silinecek)
    str39.Replace(oldStr, newStr)); // Structured Programming III
    string str40 = "Structured Programming II"; ]
    string[] words = str40.Split(' ');          ]-> stringdeki kelimeleri dizi elemanlarına ayırır
    str41.Substring(başlangıç_indexi, kaç_tane_index)
    str41.Substring(11) -> 11. indexten sonuna kadar olan stringi substring yapar
    char[] chars = str42.ToCharArray(); -> stringi charlara dönüştürür
    str43.ToLower()
    str43.ToUpper()
    str43.ToLowerInvariant() -> dil kurallarını önemsemeden lower yapar IŞIK -> ışık //not isik
    str44.Trim() -> baş ve sondaki gereksiz boşlukları siler
    str44.TrimEnd()
    str44.TrimStart()      
    */

    //W12
    /*
    Some exceptions:
    DivideByZero Exception
    NullReference Exception
    IndexOutOfRange Exception 
    Exception -> It is the basic exception type. It can handle all exceptions.
    DivideByZeroException -> It handles the exception caused by the divisor being zero.
    NullReferenceException -> It handles the exception caused by accessing a null reference.
    IndexOutOfRangeException -> It handles the exception caused by accessing an index outside the bounds of the array.
    ArgumentException -> It handles the exception caused by givin invalid/incompatible arguments to a method.
    OverflowException -> It handles the exception caused by assigning a value to a data type beyond its capacity.
    InvalidCastException -> It handles the exception caused by type conversion.
    IO.IOException -> It handles the input-output exceptions.
    FieldAccessException -> It handles the exception caused by accessing private or protected members.
    StackOverflowException -> It handles the exception caused by buffer overflow.
    OutOfMemoryException ->It handles the exception caused by insufficient memory.
    ArrayTypeMismatchException -> It handles the exception caused by assigning data of an inappropriate type to arrays.
    ArithmeticException -> It handles the exceptions caused by arithmetic calculation exceptions.
    FormatException -> It handles the exception caused by giving wrong or inappropriate parameters to methods.
    TimeoutException -> It handles the exceptions that occur when the time given to an operation expires.
    TypeInitializationException -> It covers the errors coming from a static constructor.
    */

    internal class PrintOut //W8
    {
        // Static Method
        public static void PrintInfo()
        {
            Console.WriteLine("Static Method");
        }

        // Instance Method
        public void Display()
        {
            Console.WriteLine("Instance Method");
        }
    }

    public class DivideByZeroCustomException : Exception //W12
    {
        public DivideByZeroCustomException(String message) : base(message)
        {
            //DivideByZeroCustomException IS A Exception dedik 
        }
    }

    internal class Program
    {
        public static void IncreaseValue(in int x) //W9
        {
            // x = 5; // This line will cause a compile-time error.
            // x += 5; // This line will cause a compile-time error.
            Console.WriteLine($"x (Not Increased) = {x}");
        }

        public static void ChangeValue(out int y) //W9
        {
            y = 10;
            Console.WriteLine($"y (Changed) = {y}");
        }

        public static void IncreasedValue(ref int a) //W9
        {
            a += 5;
            Console.WriteLine($"x (Increased) = {a}");
        }

        public static void IncreaseValue1(int b)//W9
        {
            b += 5;
            Console.WriteLine($"b (Increased) = {b}");
        }

        public static void ProcessValues(params int[] numbers) //W9
        {
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine($"{i}. argument: {numbers[i]}");
        }

        public static double Divide() //W12
        {
            Console.WriteLine("Enter the numerator:");
            int numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the denominator:");
            int denominator = Convert.ToInt32(Console.ReadLine());
            return (double)(numerator / denominator);
        }

        public static double Divided() //W12
        {
            Console.WriteLine("Enter the numerator:");
            int numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the denominator:");
            int denominator = Convert.ToInt32(Console.ReadLine());
            
            if (denominator == 0)
                throw new DivideByZeroCustomException("The denominator cannot be zero!");

            return (double)(numerator / denominator);
        }

        static void Main(string[] args)
        {
            //W8
            // Call the static method
            PrintOut.PrintInfo();
            // Create an object of the PrintOut class
            PrintOut prntout = new PrintOut();
            // Call the instance method
            prntout.Display();

            //W9
            int x = 5;
            Console.WriteLine($"x (Initially) = {x}");
            IncreaseValue(in x);
            Console.WriteLine($"x (Now)= {x}");

            int y;
            Console.WriteLine($"y (Initially) is unset.");
            ChangeValue(out y);
            Console.WriteLine($"y (Now)= {y}");

            int a = 5;
            Console.WriteLine($"a (Initially) = {a}");
            IncreasedValue(ref a);
            Console.WriteLine($"a (Now) = {a}");

            int b = 5;
            Console.WriteLine($"b (Initially) = {b}");
            IncreaseValue1(b);
            Console.WriteLine($"b (Now) = {b}");

            ProcessValues(4, 12, 2024);
            Console.ReadLine();

            //W11
            //DateTime Parse Methods:");
            string tarih = "18.12.2024 16:15:33";
            Console.WriteLine("String Date: {0}", tarih);
            try
            {
                DateTime parsedDate = DateTime.Parse(tarih);
                Console.WriteLine("Parsed Date: {0}", parsedDate);

                // ParseExact Method
                DateTime parsedDate2 = DateTime.ParseExact(tarih, "dd/MMMM/yyyy ", new CultureInfo("tr-TR"));
                Console.WriteLine("ParseExact Date: {0}", parsedDate2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }

            //DateTime TryParse Methods:");
            // Notice that the year is missing in the date string
            string tarih2 = "18.12. 16:15:33";
            Console.WriteLine("String Date: {0}", tarih2);
            DateTime parsedDate3;
            if (DateTime.TryParse(tarih2, out parsedDate3))
            {
                Console.WriteLine("TryParse Date: {0}", parsedDate3);
            }
            else
            {
                Console.WriteLine("Invalid Date Format");
            }

            //Formating String
            decimal price = 123.456m;

            // Define US culture
            CultureInfo dollarCulture = new CultureInfo("en-US");
            dollarCulture.NumberFormat.CurrencySymbol = "$"; // Dollar symbol
            Console.WriteLine("Currency (Dollar): " + String.Format(dollarCulture, "{0:c}", price));

            // Define European culture
            CultureInfo euroCulture = new CultureInfo("fr-FR");
            // Unicode for the Euro symbol
            euroCulture.NumberFormat.CurrencySymbol = "\u20AC";
            Console.WriteLine("Currency (Euro): " + String.Format(euroCulture, "{0:c}", price));

            // Using CultureInfo for Pound (£) symbol
            CultureInfo poundCulture = new CultureInfo("en-GB");
            Console.WriteLine("Currency (Pound): " + String.Format(poundCulture, "{0:c}", price)); // £123.46

            // Define Turkish culture
            CultureInfo liraCulture = new CultureInfo("tr-TR");
            liraCulture.NumberFormat.CurrencyPositivePattern = 3; // 3 places the symbol after the number
            // Unicode for the Turkish Lira (₺) symbol
            liraCulture.NumberFormat.CurrencySymbol = "\u20BA"; // Unicode for the Turkish Lira symbol
            Console.WriteLine("Currency (Turkish Lira): " + String.Format(liraCulture, "{0:c}", price));

            //W12
            
            //Geçersiz index girilirse özel hata mesajları göstermek
            string[] departments = {"Management Information Systems", "Computer Programming", "History", "Sociology", "Physics" };
            Console.WriteLine("Enter an index value between 0 and {0}:", departments.Length - 1);
            int index = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(departments[index]);
            }
            catch (IndexOutOfRangeException) when (index < 0)
            {
                Console.WriteLine("Index value cannot be negative!");
            }
            catch (IndexOutOfRangeException) when (index > departments.Length - 1)
            {
                Console.WriteLine("Index value can be at most {0}!", departments.Length - 1);
            }
            finally
            {
                Console.ReadLine();
            }

            //
            try
            {
                double result1 = Divide();
                Console.WriteLine(result1);
            }
            catch (DivideByZeroException ex_divide) //özel 0a bölme filtresi
            {
                Console.WriteLine("The denominator cannot be zero!");
            }
            //farklı when durumlarını tek bir catchde toplar
            catch (Exception ex) when (ex is OverflowException //sayı çok büyük
            || ex is FormatException //yanliş format girildi, int değil
            || ex is ArithmeticException) //matematiksel hata
            {
                Console.WriteLine("You did not enter a number or the number is out of range!");
                Console.WriteLine("---Exception Details---");
                Console.WriteLine("Exception Message: {0}", ex.Message); //Hatanın kısa, insan okuyabilir açıklaması
                Console.WriteLine("Exception Source: {0}", ex.Source); //Exception’ın hangi assembly / bileşenden geldiğini
                Console.WriteLine("Exception Stack Trace: {0}", ex.StackTrace); //Hata oluşana kadar çağrılan metotların TAM LİSTESİ
                Console.WriteLine("Exception Target Site: {0}", ex.TargetSite); //Exception’ın fırlatıldığı metodun adı
            }
            /*
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("The denominator cannot be zero!");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("You did not enter a number!");
            }
            */
            finally
            {
                Console.ReadLine();
            }

            //iç içe geçmiş hali, nested
            try
            {
                try
                {

                    double result3 = Divide();
                    Console.WriteLine(result3);
                }
                catch (FieldAccessException e)
                {
                    Console.WriteLine("You cannot access protected or private members. " + e.Message);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred that was not caught in the inner catch block!");
            }

            //
            try
            {
                double result2 = Divided();
                Console.WriteLine(result2);
            }
            catch (DivideByZeroCustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            //no exeption handling
            /* 
            Explain program as comment briefly
            Ask user to enter two numbers
            Read the numbers
            Divide the first number by the second number
            Display the result
            */
            Console.Write("Enter the first number: ");
            int numerator = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int denominator = int.Parse(Console.ReadLine());

            int result = numerator / denominator;
            Console.WriteLine("The result is: " + result);
            //parse string girilen değeri istenilen türe çevirir, int.Parse, DateTime.Parse


        }
    }
}
