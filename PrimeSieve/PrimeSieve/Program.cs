namespace PrimeSieve
{
    internal class Program
    {
        static int[] arrayofprimes(int numofprimes)
        {
            //works when numofprimes >= 5
            int[] primes = new int[numofprimes];
            primes[0] = 2; primes[1] = 3; primes[2] = 5; primes[3] = 7;
            primes[numofprimes - 1] = 0;
            int num = 8;
            int index = 4;
            while (primes[numofprimes - 1] == 0)
            {
                bool divisible = false;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        divisible = true;
                    }
                }
                if (divisible == false)
                {
                    primes[index] = num;
                    index++;
                }
                num++;
            }
            return primes;
        }
        static void Main(string[] args)
        {
            foreach (int num in arrayofprimes(5))
            {
                Console.Write($"{num}, ");
            }
        }
    }
}
