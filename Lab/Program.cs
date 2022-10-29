using System.Diagnostics.Contracts;

namespace lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(123);
            list.Add(321);

            foreach (int item in list.GetArray())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(MyClass<List<int>>.FactoryMethod());
        }
    }
}