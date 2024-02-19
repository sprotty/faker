using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerNet
{
    public class RandomService
    {
        private static Random SHARED_RANDOM = new Random();
        private Random random;

        /// <summary>
        /// Uses a default shared random.
        /// </summary>
        public RandomService()
            : this(SHARED_RANDOM)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="random">If null is passed in, a default Random is assigned</param>
        public RandomService(Random random)
        {
            this.random = random != null ? random : SHARED_RANDOM;
        }

        public int nextInt(int n)
        {
            return random.Next(n);
        }

        public long nextLong()
        {
            return random.NextInt64();
        }

        // lifted from http://stackoverflow.com/questions/2546078/java-random-long-number-in-0-x-n-range
        public long nextLong(long n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("bound must be positive");
            }

            long bits, val;
            do
            {
                long randomLong = random.NextInt64();
                bits = (randomLong << 1) >>> 1;
                val = bits % n;
            } while (bits - val + (n - 1) < 0L);
            return val;
        }

        public double nextDouble(double min , double max )
        {
            return (random.NextDouble() * (max-min)) + min;
        }

        public bool nextBoolean()
        {
            return random.Next(2) == 0;
        }

        public int nextInt(int min, int max)
        {
            return random.Next((max - min) + 1) + min;
        }

        public string hex()
        {
            return hex(8);
        }

        public T Item<T>(IList<T> lst)
        {
            return lst[random.Next(lst.Count)];
        }

        public Random Random => this.random;

        public string hex(int length)
        {
            if (length <= 0)
            {
                return ""; // Keep the existing behavior instead of throwing an error.
            }
            char[] hexChars = new char[length];
            for (int i = 0; i < length; i++)
            {
                int nextHex = nextInt(16);
                if (nextHex < 10)
                {
                    hexChars[i] = (char)('0' + nextHex);
                }
                else
                {
                    hexChars[i] = (char)('A' + nextHex - 10);
                }
            }
            return new string(hexChars);
        }
    }
}
