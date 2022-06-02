using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballMatchReportsConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string returnString = PlayAnalyzer.AnalyzeOnField(6);
            Console.WriteLine($"return string is {returnString}");
            Console.ReadLine();
        }

        public static class PlayAnalyzer
        {
            public static string AnalyzeOnField(int shirtNum)
            {
               switch(shirtNum)
                {
                    case 1:
                        return "goalie";
                    case 2:
                        return "left back";
                    case 3: case 4:
                        return "center back";
                    case 5:
                        return "right back";
                    case 6: case 7: case 8:
                        return "midfielder";
                    case 9:
                        return "left wing";
                    case 10:
                        return "striker";
                    case 11:
                        return "right wing";
                    default:
                        throw new ArgumentOutOfRangeException($"{shirtNum} is not a valid number. 1-11");
                }
            }

            public static string AnalyzeOffField(object report)
            {

                switch (report)
                {
                    case Incident i when i.Foul():
                        return "The referee deemed a foul";
                    case Incident i when i.Injury(x):
                        return $"Oh no! Player {x} is injured. Medics are on the field.";
                    case Manager(name n, club c?):
                        return $"{n} {c}";
                    case string x:
                        return $"{x}";
                    case int x:
                        return $"There are {x} supporters at the match.";
                    default:
                        throw new ArgumentException($"");
                }
            }
        }
    }
}
