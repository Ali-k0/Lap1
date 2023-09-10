using System;

namespace Lap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {



                Console.WriteLine("Enter your text: ");
                string text = Console.ReadLine();
                string res = "";
                string start = "";
                long sum1 = 0;
                string end = "";

                for (int i = 0; i < text.Length; i++)
                {
                    // Console.WriteLine(text[i]);
                    for (int s = i + 1; s < text.Length; s++)
                    {


                        int Num = i + 1;
                        if (text[Num] == text[i])
                        { // check if the following number is the same                         {

                            break;
                        }
                        else if (Char.IsLetter(text[s]))
                        {
                            break;
                        }
                        else if (text[i] == text[s])
                        {
                            res = text.Substring(i, s + 1 - i);
                            start = text.Substring(0, i);
                            string endP = text.Substring(s + 1);
                            Console.Write(start);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(res);
                            Console.ResetColor();
                            Console.Write(endP + "\n");
                            sum1 += long.Parse(res);
                            //Console.WriteLine("for each sum : "+sum1);

                            break;


                        }
                    }


                }
                Console.WriteLine();
                Console.WriteLine("Total is : " + sum1);
            }
        }

    }
}
