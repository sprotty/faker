﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerNet
{
    internal static class RandomExtensions
    {
        public static int NextInt32(this Random random, int n)
        {
            return random.Next(n);
        }
        public static int NextInt32(this Random random, int min, int max)
        {
            return random.Next((max - min) + 1) + min;
        }

        public static long NextInt64(this Random random, long min, long max)
        {
            return (Math.Abs(random.NextInt64() % (max - min)) + min);
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
            return (random.NextDouble() * (max - min)) + min;
        }
        public static bool NextBoolean(this Random random)
        {
            return random.Next(2) == 0;
        }

        public static T NextItem<T>(this Random random, IList<T> lst)
        {
            return lst[random.Next(lst.Count)];
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