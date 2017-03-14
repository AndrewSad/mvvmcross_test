using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MCTest.Core
{
	public interface IDataService
	{
		Task<List<Question>> getQuestionsByTag(string tag);
		Task<List<Answer>> getAnswersByQuestionID(string question_id);
	}
}
