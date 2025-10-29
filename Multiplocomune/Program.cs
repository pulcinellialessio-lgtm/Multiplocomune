namespace MultipliComuni
{
    internal class Program
    {

        static bool multiplo(int n, int a, int b)
        {


            if (n % a == 0 && n % b == 0)
            {

                return true;

            }
            else
            {

                return false;

            }


        }


        static int somma(int x, int y, int a, int b)
        {

            int s = 0;

            for (int i = x; i <= y; i++)
            {

                if (multiplo(i, a, b) == true)
                {

                    s = s + i;

                }

            }

            return s;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Dimmi il primo numero dell intervallo");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dimmi il secondo numero dell intervallo");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dimmi il primo numero");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dimmi il secondo numero");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("La somma è " + somma(x, y, a, b));
        }
    }
}
