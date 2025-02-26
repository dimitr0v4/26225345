namespace _262254
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] test = ArrayCr.CreateArray(6, false);
            Console.WriteLine(Search(test, 4));
            Console.WriteLine(Search(test, 4));
        }
        public static int Search(int[] a, int t)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == t)
                {
                    (a[i], a[0]) = (a[0], a[i]);
                    return i;
                }
            }
            return -1;
        }
    }
}
