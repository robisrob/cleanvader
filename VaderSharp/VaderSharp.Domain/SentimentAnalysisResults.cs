using System;
using System.Collections.Generic;
using System.Text;

namespace VaderSharp.Domain
{
    public class SentimentAnalysisResults
    {
        public double Negative { get; set; }
        public double Neutral { get; set; }
        public double Positive { get; set; }
        public double Compound { get; set; }
    }
}
