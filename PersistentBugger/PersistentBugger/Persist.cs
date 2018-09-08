using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistentBugger
{
    public class Persist
    {
        public static int Persistence(long n)
        {
            if (n < 10) return 0;
            var count = 0;
            return Temp(n,count);
        }

        private static int Temp(long n,int count)
        {
            var temp = 1;
            var i = n.ToString().ToCharArray();
            int[] j = Array.ConvertAll(i, new Converter<char, int>(CharToInt));
            foreach (var target in j)
            {
                temp *= target;
            }

            count++;

            if (temp < 10)
            {
                return count;
            }

            return Temp(temp, count);
        }

        public static int CharToInt(char pf)
        {
            return pf-48;
        }
    }
}
