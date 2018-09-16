using System.Collections.Generic;
using System.IO;
namespace App_Ergonomia.Clases
{
    static class Csv
    {
        public static List<string> question = new List<string>();
        public static List<string> hint = new List<string>();
        public static int ActualQuestion { get; set; }
        public static void GetQuestions()
        {
            using (var reader = new StreamReader("Questions/ergonomia.csv", System.Text.Encoding.Default))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    question.Add(values[0]);
                    hint.Add(values[1]);
                }
                ActualQuestion = 1;
            }
        }
    }
}
