using System;
namespace MCTest.Core
{
	public class Answer
	{
		public Owner owner { get; set; }
		public bool is_accepted { get; set; }
		public int score { get; set; }
		public long last_activity_date { get; set; }
		public long last_edit_date { get; set; }
		public long creation_date { get; set; }
		public string answer_id { get; set; }
		public string question_id { get; set; }
		public string body { get; set; }
	}
}
