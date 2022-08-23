using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    internal class Student : IStudent
    {
        public string[] TestsTaken { get { return testsList.ToArray(); } }
        private List<string> testsList = new List<string>();
        
        public void TakeTest(ITestpaper paper, string[] answers)
        {
            double rightAnswers = 0;

            for (int i = 0; i < paper.MarkScheme.Length; i++)
            {
                if (answers[i] == paper.MarkScheme[i])
                {
                    rightAnswers++;
                }
            }
            double percent = (rightAnswers / paper.MarkScheme.Length) * 100;

            if (percent > double.Parse(paper.PassMark.Replace("%", "")))
            {
                string result = $"{paper.Subject} Passed! ({Math.Round(percent, 2)}%)";
                testsList.Add(result);
            }
            else
            {
                string result = $"{paper.Subject} Did not pass! ({Math.Round(percent, 2)}%)";
                testsList.Add(result);
            }
        }

        
    }
}
