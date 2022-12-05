using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Language
    {
        public int Year { get; set; }
        public string Name { get; set; }

        public string ChiefDeveloper { get; set; }

        public string Predecessors { get; set; }

        public Language(int year, string name, string chiefDeveloper, string predecessors)
        {
            Year = year;
            Name = name;
            ChiefDeveloper = chiefDeveloper;
            Predecessors = predecessors;
        }

        public string Prettify()
        {
            return $"{Year}, {Name}, {ChiefDeveloper}, {Predecessors}";
        }

        public static void PrettyPrintAll(IEnumerable<Language> languages)
        {
            foreach(var lang in languages)
            {
                Console.WriteLine($"{lang.Year}, {lang.Name}, {lang.ChiefDeveloper}, {lang.Predecessors}");
            }
        }

        public static Language FromTsv(string tsvLine)
        {
            string[] values = tsvLine.Split('\t');
            Language language = new Language(
                    Convert.ToInt32(values[0]),
                    Convert.ToString(values[1]),
                    Convert.ToString(values[2]),
                    Convert.ToString(values[3])
                );
          return language;
        }
    }
}
