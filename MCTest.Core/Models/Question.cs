using System;
using System.Collections.Generic;
using PropertyChanged;

namespace MCTest.Core
{
	[ImplementPropertyChanged]
	public class Question
	{
		public List<string> tags { get; set; }
		public List<Answer> answers { get; set; }
		public Owner owner { get; set; }
		public bool is_answered { get; set; }
		public int view_count { get; set; }
		public int answer_count { get; set; }
		public int score { get; set; }
		public long last_activity_date { get; set; }
		public long last_edit_date { get; set; }
		public long creation_date { get; set; }
		public string question_id { get; set; }
		public string title { get; set; }
		public string body { get; set; }


	}
}
