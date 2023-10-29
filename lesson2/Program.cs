internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        int M = 100;
        int sum = 0;
        int say = 0;

        for (int i = 1; i <= M; i++)
        {
            if (i % 21 == 0)
            {
                sum += i;
                say++;
            }
        }

        double ededi_orta = (double)sum / say;

        Console.WriteLine($"1-den {M} edek ededler içerisinde 21-e bölünen ededlerin ededi ortasi   {ededi_orta}");




        int x = 3;
        int y = 13;
        int summ = 0;
        for (int i = x; i <= y; i++)
            sum += i;
        {
            {
            }
            Console.WriteLine(summ);


        }





        int m = 5;
        int n = 16;
        int summm = 0;
        for (int i = m; i < n; i++)
        {
            if (i % 2 == 0)
            {
                sum++;
            }
            Console.WriteLine(summm);
        }
    }
}