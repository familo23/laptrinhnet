using System;
class Program
{
    static void Bai1()
    {
        Console.Clear();

        Console.Write("nhap so thu nhat a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("nhap so thu hai b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("nhap phep toan (+, -, *, /, %): ");
        char op = char.Parse(Console.ReadLine());

        try
        {
            double result = op switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                '/' when b != 0 => a / b,
                '%' when b != 0 => a % b,
                '/' or '%' when b == 0 => throw new DivideByZeroException(),
                _ => throw new InvalidOperationException("phep toan khong hop le!")
            };

            Console.WriteLine($"ket qua: {result:F2}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("loi: khong the chia cho 0!");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"loi: {ex.Message}");
        }

        Console.WriteLine("\nnhan phim bat ky de quay lai menu...");
        Console.ReadKey();
    }

    static void Bai2()
    {
        Console.Clear();

        Console.Write("nhap a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("nhap b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("nhap c: ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                    Console.WriteLine("phuong trinh co vo so nghiem.");
                else
                    Console.WriteLine("phuong trinh vo nghiem.");
            }
            else
            {
                double x = -c / b;
                Console.WriteLine($"nghiem x = {x:F2}");
            }
        }
        else
        {
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"x1 = {x1:F2}");
                Console.WriteLine($"x2 = {x2:F2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"nghiem kep x = {x:F2}");
            }
            else
            {
                Console.WriteLine("vo nghiem.");
            }
        }

        Console.WriteLine("\nnhan phim bat ky de quay lai menu...");
        Console.ReadKey();
    }

    static bool IsPrime(int n)
    {
        if (n < 2)
            return false;

        int i = 2;

        while (i <= Math.Sqrt(n))
        {
            if (n % i == 0)
                return false;

            i++;
        }

        return true;
    }

    static bool IsPerfectNumber(int n)
    {
        if (n <= 1)
            return false;

        int sum = 0;

        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
                sum += i;
        }

        return sum == n;
    }

    static void Bai3()
    {
        Console.Clear();

        Console.Write("nhap so nguyen duong n: ");
        int N = int.Parse(Console.ReadLine());

        if (IsPrime(N))
            Console.WriteLine($"{N} la so nguyen to!");
        else
            Console.WriteLine($"{N} khong la so nguyen to.");

        if (IsPerfectNumber(N))
            Console.WriteLine($"{N} la so hoan hao!");
        else
            Console.WriteLine($"{N} khong la so hoan hao.");

        Console.Write($"day fibonacci {N} so: ");

        int f1 = 0;
        int f2 = 1;

        for (int i = 0; i < N; i++)
        {
            Console.Write(f1);

            if (i < N - 1)
                Console.Write(", ");

            int next = f1 + f2;
            f1 = f2;
            f2 = next;
        }

        Console.WriteLine();

        Console.WriteLine("\nnhan phim bat ky de quay lai menu...");
        Console.ReadKey();
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.Clear();

            Console.WriteLine("----- Menu-----");
            Console.WriteLine("1. chay bai tap 1 (calculator)");
            Console.WriteLine("2. chay bai tap 2 (phuong trinh bac 2)");
            Console.WriteLine("3. chay bai tap 3 (so nguyen to & fibonacci)");
            Console.WriteLine("0. thoat chuong trinh");
            Console.WriteLine("-----------------------------------");

            Console.Write("nhap lua chon: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Bai1();
                    break;

                case 2:
                    Bai2();
                    break;

                case 3:
                    Bai3();
                    break;

                case 0:
                    Console.Clear();
                    Console.WriteLine("da thoat chuong trinh!");
                    break;

                default:
                    Console.WriteLine("lua chon khong hop le!");
                    Console.WriteLine("nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                    break;
            }

        } while (choice != 0);
    }
}