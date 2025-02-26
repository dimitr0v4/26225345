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
                {int at=i;
                    for(int j=i;j>0;j--)
                    { (a[j], a[j - 1]) = (a[j - 1], a[j]);}
                    
                    return i;
                }
            }
            return -1;
        }
    }
}
