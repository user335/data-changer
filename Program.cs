using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataChanger mydatachanger = new DataChanger();
            Console.WriteLine("Doing more nothing with numbers. This time our victim will be int 12");
            mydatachanger.NumberChanger(12);
            Console.WriteLine("Here goes another. This time our victim will be decimal 4");
            mydatachanger.NumberChanger(4m);
            Console.WriteLine("Last one. Passing string \"50\"");
            mydatachanger.NumberChanger("50");
            Console.WriteLine("And there you have it. Any key to exit.");
            Console.ReadKey();
        }

    }
    class DataChanger
    {
        public int NumberChanger(int i)
        {
            Console.WriteLine("Operation 1 turns " + i + " into " + i * 2);
            return i * 2;
        }
        public int NumberChanger(decimal d)
        {
            int dtodub = 0;

            try
            {
                dtodub = Convert.ToInt32(d);
            }
            catch (Exception)
            {
                Console.WriteLine("uh, come again?");
            }

            Console.WriteLine("Operation 2 turns " + dtodub + " into " + (dtodub + 4));
            return dtodub + 4;
        }
        public int NumberChanger(string s)
        {
            int stoint = 0;
                try
                {
                    stoint = Convert.ToInt32(s);
                }
                catch (Exception)
                {
                    Console.WriteLine("uh, come again?");
                }
            Console.WriteLine("Operation 3 turns " + stoint + " into " + (stoint - 26633));
            return stoint - 26633;
        }
    }
}
