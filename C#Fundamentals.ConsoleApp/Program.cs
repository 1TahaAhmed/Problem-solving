
//using System.Threading.Channels;

//namespace C_Fundamentals.ConsoleApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(Kata.PigIt("Pig latin is cool"));
//        }
//        public class Kata
//        {
//            public static string PigIt(string str)
//            {
//                var words = str.Split(' ');
//                for (int i = 0; i < words.Length; i++) 
//                {
//                    if(char.IsLetter(words[i][0]))
//                    {
//                        words[i] = words[i].Substring(1) + words[i][0] + "ay";
//                    }
//                }
//                return string.Join(" ", words);
//            }
//        }
//    }
//}