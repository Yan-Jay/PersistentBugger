namespace PersistentBugger
{
    public class Persist
    {
        public static int Persistence(long n)
        {
            if (n < 10) return 0;
            var count = 0;
            return PersistentBuggerFunction(n, count);
        }

        private static int PersistentBuggerFunction(long n, int count)
        {
            var i = n.ToString().ToCharArray();
            var temp = 1;
            foreach (var target in i) temp *= (target - 48);
            count++;
            if (temp < 10) return count;
            return PersistentBuggerFunction(temp, count);
        }
    }
}