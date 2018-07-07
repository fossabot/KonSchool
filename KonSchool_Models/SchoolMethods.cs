using System;
using System.Linq;
using static System.Convert;

namespace KonSchool_Models
{
    public partial class School
    {
        public bool IsEligible(Query q)
            => !((q.IsMale && type == "GIRLS") || (q.Class > 8 && level == "Junior Secondary"));

        public double[] ScoreValues(Query q)
        {
            int max = q.Criteria.Length;
            string temp;
            double[] scores = new double[max];

            for (int i = 0; i < max; i++)
            {
                temp = q.Criteria[i];
                switch (temp)
                {
                    case "TSR": scores[i] = tsRatio; break;
                    case "SES": scores[i] = seScore; break;
                    case "MFR": scores[i] = smfRatio; break;
                    case "AS": scores[i] = age; break;
                    case "DIST": scores[i] = distance; break;
                    case "ADS": scores[i] = averAge; break;
                    default: scores[i] = 0.0; break;
                }
            }
            return scores;
        }

        public void CalcValues(Query q)
        {
            tsRatio = ToDouble(q.fileReader[eiin, "TSR_SCORE"]);
            double mfr = ToDouble(q.fileReader[eiin, "FEM_STD_RATIO"]);
            smfRatio = q.IsMale ? 1 - mfr : mfr;
            double locaScore = ToDouble(q.fileReader[eiin, "AScore"]) / 10;
            switch (q.Social)
            {
                case 10.0:
                    seScore = ToDouble(q.fileReader[eiin, "SESscore_UP"]) * 2 + locaScore;
                    seScore /= 3;
                    break;
                case 7.5:
                    seScore = ToDouble(q.fileReader[eiin, "SESscore_UM"]) * 2 + locaScore;
                    seScore /= 3;
                    break;
                case 5.0:
                    seScore = ToDouble(q.fileReader[eiin, "SESscore_LM"]) * 2 + locaScore;
                    seScore /= 3;
                    break;
                case 2.5:
                    seScore = ToDouble(q.fileReader[eiin, "SESscore_LO"]) * 2 + locaScore;
                    seScore /= 3;
                    break;
                default:
                    seScore = locaScore;
                    break;
            }

            

            
        }
    }
}

