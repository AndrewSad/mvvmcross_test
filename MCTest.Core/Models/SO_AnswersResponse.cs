using System;
using System.Collections.Generic;
using PropertyChanged;

namespace MCTest.Core
{
	[ImplementPropertyChanged]
	public class SO_AnswersResponse
	{
		public List<Answer> items { get; set; }
		public bool has_more { get; set; }
		public int quota_max { get; set; }
		public int quota_remaining { get; set; }
	}
}
