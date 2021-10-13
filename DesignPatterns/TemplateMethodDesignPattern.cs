using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class TemplateMethodDesignPattern
    {
    }

    abstract class ScoringAlgoritm
    {
        public int GenerateScore(int hits, TimeSpan time)
        {
            int score = CalculateScore(hits);
            int reduction = CalculateReduction(time);
            return CalculateOverallScore(score, reduction);
        }

        public abstract int CalculateOverallScore(int score, int reduction);
        public abstract int CalculateReduction(TimeSpan time);
        public abstract int CalculateScore(int hits);
    }

    class MensScoringAlgoritm : ScoringAlgoritm
    {
        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 5;
        }

        public override int CalculateScore(int hits)
        {
            return hits * 100;
        }
    }

    class WomansScoringAlgoritm : ScoringAlgoritm
    {
        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 10;
        }

        public override int CalculateScore(int hits)
        {
            return hits * 50;
        }
    }

    class KidsScoringAlgoritm : ScoringAlgoritm
    {
        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 20;
        }

        public override int CalculateScore(int hits)
        {
            return hits * 200;
        }
    }
}
