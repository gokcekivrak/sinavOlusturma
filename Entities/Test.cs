using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
	public class Test
	{
        public int testId { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public int userId { get; set; }
        public string key { get; set; }

        public DateTime createdDate { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}
