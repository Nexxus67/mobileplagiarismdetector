using System;
using PlagiarismDetectorMobile.Interfaces;

namespace PlagiarismDetectorMobile.Pages
{
    public class PlagiarismDetectionService : IPlagiarismDetectionService
    {
        private List<string> GetNGrams(string code, int n)
        {
            code = code.ToLower(); // Convert to lowercase
            List<string> ngrams = new List<string>();
            for (int i = 0; i <= code.Length - n; i++)
            {
                string ngram = code.Substring(i, n);
                ngrams.Add(ngram);
            }
            return ngrams;
        }

        private double CalculateJaccardSimilarity(List<string> ngrams1, List<string> ngrams2)
        {
            var set1 = new HashSet<string>(ngrams1);
            var set2 = new HashSet<string>(ngrams2);

            int intersection = set1.Intersect(set2).Count();
            int union = set1.Union(set2).Count();

            double jaccardSimilarity = (double)intersection / union;
            return jaccardSimilarity;
        }

        public double CalculatePlagiarismScore(string code1, string code2, int n)
        {
            if (n <= 0 || n > code1.Length || n > code2.Length)
            {
                throw new ArgumentException("The value of n has to be between 1 and the smallest code size");
            }

            List<string> ngramsCode1 = GetNGrams(code1, n);
            List<string> ngramsCode2 = GetNGrams(code2, n);

            int totalNgrams = ngramsCode1.Count;
            int matches = 0;

            foreach (string ngram in ngramsCode1)
            {
                if (ngramsCode2.Contains(ngram))
                {
                    matches++;
                }
            }

            double plagiarismPercentage = (double)matches / totalNgrams * 100;
            return plagiarismPercentage;
        }
    }  
}
