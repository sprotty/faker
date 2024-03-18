using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerNet
{
    internal static class RandomExtensions
    {
        /// <summary>Returns a non-negative random integer that is less than the specified maximum.</summary>
        public static int NextInt32(this Random random, int n)
        {
            return random.Next(n);
        }
        /// <summary>Returns a random integer greater than or equal to <paramref name="min"/> and less than <paramref name="max"/>.</summary>
        public static int NextInt32(this Random random, int min, int max)
        {
            return random.Next(max - min + 1) + min;
        }
        //public static int NextInt32(this Random random, IntegerRange rng)
        //{
        //    return random.NextInt32((int)rng.Min, (int)rng.Max);
        //}

        public static long NextInt64(this Random random, long min, long max)
        {
            return Math.Abs(random.NextInt64() % (max - min)) + min;
        }
        // lifted from http://stackoverflow.com/questions/2546078/java-random-long-number-in-0-x-n-range
        public static long NextInt64(this Random random, long n)    
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

        public static double NextDouble(this Random random, double min, double max)
        {
            return random.NextDouble() * (max - min) + min;
        }
        public static DateTime NextDateTime(this Random random, DateTime min, DateTime max)
        {
            long ticks = random.NextInt64(min.Ticks, max.Ticks);
            return new DateTime(ticks); 
        }
        public static bool NextBoolean(this Random random)
        {
            return random.Next(2) == 0;
        }

        public static byte[] NextBytes(this Random random, int length)
        {
            byte[] data = new byte[length];
            random.NextBytes(data);
            return data;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="random"></param>
        /// <param name="trueRatio">1 for all true, 0 for all false</param>
        /// <returns></returns>
        public static bool NextBoolean(this Random random, double trueRatio)
        {
            return random.NextDouble() < trueRatio;
        }

        public static T NextEnum<T>(this Random random) where T : struct, Enum
        {
            return random.NextItem(Enum.GetValues<T>());
        }

        public static T NextItem<T>(this Random random, IEnumerable<T> lst)
        {
            return lst.ElementAt(random.Next(lst.Count()));
        }
        public static T NextItem<T>(this Random random, IList<T> lst)
        {
            return lst[random.Next(lst.Count)];
        }
        public static T NextItem<T>(this Random random, ICollection<T> lst)
        {
            return lst.ElementAt(random.Next(lst.Count));
        }
        public static TValue NextItem<TKey, TValue>(this Random random, IDictionary<TKey, TValue> map)
        {
            return map[random.NextItem(map.Keys)];
        }
        public static string NextHex(this Random random, int length)
        {
            if (length <= 0)
            {
                return ""; // Keep the existing behavior instead of throwing an error.
            }
            char[] hexChars = new char[length];
            for (int i = 0; i < length; i++)
            {
                int nextHex = random.NextInt32(16);
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
