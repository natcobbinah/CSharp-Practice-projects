using System.IO;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main()
        {
            List<Language> languages = File.ReadAllLines("./languages.tsv")
                                .Skip(1)
                                .Select(line => Language.FromTsv(line))
                                .ToList();

            //print all text in tsv(tab separated values file)
            /* foreach(var lang in languages)
             {
                 Console.WriteLine(lang.Prettify());
             }*/

            var selectAttributes = languages.Select(lang => $"{lang.Name} {lang.Year} {lang.ChiefDeveloper}");
            /*foreach(var lang in selectAttributes)
             {
                 Console.WriteLine(lang);
             }*/

            var findCSharp = languages.Where(lang => lang.Name == "C#");
            /*foreach(var lang in findCSharp)
            {
                Console.WriteLine(lang.Prettify());
            }*/

            var microsoftLangs = languages.Where(lang => lang.ChiefDeveloper
                    .Contains("Microsoft"));
            /* foreach(var lang in microsoftLangs)
             {
                 Console.WriteLine(lang.Prettify());
             }*/

            var langPredecessors = languages.Where(lang => lang.Predecessors
                    .Contains("Lisp"));
            /*foreach(var lang in langPredecessors)
            {
                Console.WriteLine(lang.Prettify());
            }*/

            var scriptLangs = languages.Where(lang => lang.Name.Contains("Script"))
                                       .Select(lang => lang.Name);
            /*foreach(var lang in scriptLangs)
            {
                Console.WriteLine(lang);
            }*/

            int langCount = languages.Count();
            //Console.WriteLine(langCount);

            int langCountBtwn1995and2000 = languages.Where(lang => lang.Year >= 1995 && lang.Year <= 2005)
                                                    .Count();
            // Console.WriteLine(langCountBtwn1995and2000);

            var nearMilleniumLangs = languages.Where(lang => lang.Year >= 1995 && lang.Year <= 2005)
                                              .Select(lang => $"{lang.Name} was invented in {lang.Year}");
            foreach(var lang in nearMilleniumLangs)
            {
                Console.WriteLine(lang);
            }
        }
    }
}