using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormWarden.Helpers.Resources
{
    public static class Resource
    {
        private static readonly string adjectivesFile = @"F:\FormWarden\FormWarden\FormWarden\Helpers\Resources\Adjetives.txt";
        private static readonly string adverbsFile = @"F:\FormWarden\FormWarden\FormWarden\Helpers\Resources\Adverbs.txt";
        private static readonly string nounsFile = @"F:\FormWarden\FormWarden\FormWarden\Helpers\Resources\Nouns.txt";
        private static readonly string verbsFile = @"F:\FormWarden\FormWarden\FormWarden\Helpers\Resources\Verbs.txt";


        public static string[] Adjectives = File.ReadAllLines(adjectivesFile);
        public static string[] Adverbs = File.ReadAllLines(adverbsFile);
        public static string[] Nouns = File.ReadAllLines(nounsFile);
        public static string[] Verbs = File.ReadAllLines(verbsFile);
    }
}
