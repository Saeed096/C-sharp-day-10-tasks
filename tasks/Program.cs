namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int x = 749;
            Console.WriteLine(x.reverse());

            Console.WriteLine(x.no_of_digit());

            string str = "saeed mohamed saeed";
            Console.WriteLine(str.trim());

            int[] arr = new int[5] { -11, -2, -3, -4, -5 };
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(40);
            list.Add(80);

            Console.WriteLine(list.get_max());
            Console.WriteLine(arr.get_max());


            List<char> list2 = new List<char>();
            list2.Add('a');
            list2.Add('b');
            list2.Add('c');
            list2.Add('d');
            list2.Add('e');

            Console.WriteLine(list2.generic_get_max<char>());




        }
    }
}
