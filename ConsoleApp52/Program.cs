namespace ConsoleApp52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededi daxil edin:");
            static string checkSameDigits(int n)
            {
                int digit = n % 10;

                while (n != 0)
                {
                    int current_digit = n % 10;
                    n = n / 10;

                    if (current_digit != digit)
                    {
                        return "Muxtelif reqemli";
                    }
                }

                return "Muxtelif reqemli deyil";
            }

            {
                int n = int.Parse(Console.ReadLine());
                Console.Write(checkSameDigits(n));
            }
        }
    }
}