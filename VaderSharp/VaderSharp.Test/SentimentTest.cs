using System;
using Xunit;
using VaderSharp.Domain;
using FluentAssertions;

namespace VaderSharp.Test
{
    public class SentimentTest
    {
        [Fact]
        public void MatchPythonTest()
        {
            SentimentIntensityAnalyzer analyzer = new SentimentIntensityAnalyzer();

            var standardGoodTest = analyzer.PolarityScores("VADER is smart, handsome, and funny.");
            standardGoodTest.Negative.Should().Be(0);
            standardGoodTest.Neutral.Should().Be(0.254);
            standardGoodTest.Positive.Should().Be(0.746);
            standardGoodTest.Compound.Should().Be(0.8316);

            var kindOfTest = analyzer.PolarityScores("The book was kind of good.");
            kindOfTest.Negative.Should().Be(0);
            kindOfTest.Neutral.Should().Be(0.657);
            kindOfTest.Positive.Should().Be(0.343);
            kindOfTest.Compound.Should().Be(0.3832);

            var complexTest =
                analyzer.PolarityScores(
                    "The plot was good, but the characters are uncompelling and the dialog is not great.");
            complexTest.Negative.Should().Be(0.327);
            complexTest.Neutral.Should().Be(0.579);
            complexTest.Positive.Should().Be(0.094);
            complexTest.Compound.Should().Be(-0.7042);
        }
    }
}
