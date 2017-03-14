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

		//public Question()
		//{
		//	tags = new List<string> { };
		//	answers = new List<Answer> { };
		//	is_answered = false;
		//	score = 0;
		//	creation_date = int.Parse(DateTime.Now.ToString());
		//	last_activity_date = creation_date;
		//	last_edit_date = creation_date;
		//	question_id = "0";
		//	body = "Dummy question body";
		//	title = "Dummy question title";
		//	owner = new Owner { display_name = "Dummy owner's display name", profile_image = "", reputation = "0", link = "", user_id = "0" };

		//}
	}
}
