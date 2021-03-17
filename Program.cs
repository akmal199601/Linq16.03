using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Link
{
    class Program
    {
        private static string aki;//для 3 задачи 

        static void Main(string[] args)
        {
            //Dictionary<int, char> li = new Dictionary<int, char>();
            //li.Add(1, 'a');
            //li.Add(2, 'e');
            //li.Add(3, 'i');
            //li.Add(4, 'o');
            //li.Add(5, 'u');
            //string text = "h3 th2r2";
            //foreach (char x in text)
            //{
            //    try
            //    {
            //        int z = int.Parse(x.ToString());
            //        text = text.Replace(char.Parse(z.ToString()), li[z]);
            //    }
            //    catch (Exception)
            //    {

            //    }
            //}

            //string aki = "hello";
            //string aki1 = string.Join(" ", aki.Select(x => (x == 'a') ? '1' : (x == 'e') ? '2' : (x == 'i') ? '3' : (x == 'o') ? '4' : (x == 'u') ? '5' : x));
            //foreach (var item in aki1)
            //{
            //    Console.Write(item);
            //}

            //string aki1 = "h3 th2r2";
            //string aki2 = string.Join("", aki1.Select(x => (x == '1') ? 'a' : (x == '2') ? 'e' : (x == '3') ? 'i' : (x == 4) ? 'o' : (x == 5) ? 'u' : x));
            //foreach (var item in aki2)
            //{
            //    Console.Write(item);
            //}


            //aki = string.Join(null, Regex.Split(aki, "[^0-9-*-/-+-]"));
            //aki.Split('*');
            //Console.Write(aki);


            //string[] aki = new string[] { "+", "-", "*", "/" };
            //var TextQuery = new string((from ch in Console.ReadLine()
            //                            where Char.IsDigit(ch) || ch == '+' || ch == '-' || ch == '*' || ch == '/'
            //                            select ch).ToArray());
            //string akmal = aki.FirstOrDefault(S => TextQuery.Contains(S));
            //int aki1 = int.Parse(new string(TextQuery.TakeWhile(ch => ch.ToString() != akmal).ToArray()));
            //int aki2 = int.Parse(new string(TextQuery.Reverse().TakeWhile(s => s.ToString() != akmal).Reverse().ToArray()));
            //int result = 0;
            //switch (akmal)
            //{
            //    case "+":
            //        {
            //            result = aki1 + aki2;
            //        }
            //        break;
            //    case "-":
            //        {
            //            result = aki1 - aki2;
            //        }
            //        break;
            //    case "*":
            //        {
            //            result = aki1 * aki2;
            //        }
            //        break;
            //    case "/":
            //        {
            //            result = aki1 / aki2;
            //        }
            //        break;
            //}
            //Console.WriteLine(result.ToString());

           
            string Mytext = "akmalAzizov";


            var chars = Mytext.ToString().SelectMany((x, i) => i > 0 && char.IsUpper(x) ? new char[] { ' ', x } : new char[] { x });

            Console.WriteLine(new string(chars.ToArray()));















        }

    }
}



