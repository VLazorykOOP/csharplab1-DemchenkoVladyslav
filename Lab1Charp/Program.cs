using System.Text;

class Program
{
    static void task1()
    {
        Console.WriteLine("Task1 !");
        float s1 = 0;
        float s2 = 0;
        while (true)
        {
            try
            {
                Console.Write("s1 = ");
                string str = Console.ReadLine();
                s1 = float.Parse(str);
                Console.Write("s2 = ");
                str = Console.ReadLine();
                s2 = float.Parse(str);
                break;
            }
            catch (Exception e)
            {
                Console.Clear();
                continue;
            }
        }
        double p = (s1 * s1 * s1 + s2 * s2 * s2) / 2;
        Console.WriteLine("p = " + p);

    }
    static void task2()
    {
        Console.WriteLine("Task1 !");
        int m, n;
        while (true)
        {
            try
            {
                Console.Write("M = ");
                m = int.Parse(Console.ReadLine());
                Console.Write("N = ");
                n = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception e)
            {
                Console.Clear();
                continue;
            }
        }
        if (m % n == 0)
            Console.WriteLine("M/N = " + m / n);
        else
            Console.WriteLine("M на N націло не ділиться");
    }
    static void task3()
    {
        int x, y;
        while (true)
        {
            try
            {
                Console.Write("x = ");
                x = int.Parse(Console.ReadLine());
                Console.Write("y = ");
                y = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception e)
            {
                Console.Clear();
                continue;
            }
        }
        if (x > 0 || x * x + y * y > 64 || x * x + y * y < 9)
        {
            Console.WriteLine("Ні");
        }
        if (x * x + y * y == 64 || x * x + y * y == 9 || (x == 0 && ((y <= 8 && y >= 3) || (y > -8 && y < -3))))
        {
            Console.WriteLine("На межі");
        }
        else
        {
            Console.WriteLine("Так");
        }
    }
    static void task4()
    {
        string[] cards = {"туз",
            "король",
            "дама",
            "валет",
            "десятка",
            "дев'ятка",
            "вісімка",
            "сімка",
            "шістка"};
        int k;
        while (true)
        {
            try
            {
                Console.Write("k = ");
                k = int.Parse(Console.ReadLine());
                if (k < 6 || k > 14)
                    throw new Exception();
                break;
            }
            catch (Exception e)
            {
                Console.Clear();
                continue;
            }
        }
        Console.WriteLine(cards[14 - k]);
    }
    public static double chastka(int n1, int n2)
    {
        if (n2 == 0)
            throw new DivideByZeroException();
        return n1 / n2;
    }
    static void task5()
    {
        int x, y;
        while (true)
        {
            try
            {
                Console.Write("x = ");
                x = int.Parse(Console.ReadLine());
                Console.Write("y = ");
                y = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception e)
            {
                Console.Clear();
                continue;
            }
        }
        try
        {
            Console.WriteLine(chastka(x, y));
        }
        catch (Exception e)
        { Console.WriteLine(e.Message); }
    }
    static void task6()
    {
        double a, b;
        while (true)
        {
            try
            {
                Console.Write("a = ");
                a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = double.Parse(Console.ReadLine());
                if (a == 0 && b == 0)
                    throw new DivideByZeroException();
                break;
            }
            catch (Exception e)
            {
                Console.Clear();
                continue;
            }
        }
        Console.WriteLine((a * b + (a - b) * (a + b) - 1) / (a * a + b * b) - 5);
    }
    public static void Main(String[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        Console.WriteLine("Lab 1 !");
        //task1();
        //task2();
        //task3();
        //task4();
        //task5();
        task6();
    }
}
