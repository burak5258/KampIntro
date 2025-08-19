namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            Console.WriteLine(isimler.Length); // 1

            isimler.Add("Murat");
            Console.WriteLine(isimler.Length); // 2

        }
    }
}
