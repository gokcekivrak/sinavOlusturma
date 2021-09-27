using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
   public class Question
	{
        public int questionId { get; set; }
        public int testId { get; set; }
        public string question { get; set; }
        public string selectedFirst { get; set; }
        public string selectedSecond { get; set; }
        public string selectedThird { get; set; }
        public string selectedFourth { get; set; }
        public string Answer { get; set; }

        public Test Test { get; set; }
    }
}
