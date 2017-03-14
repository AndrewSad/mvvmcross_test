using System;
namespace MCTest.Core
{
	public class Constants
	{
		public static string SOBaseAddress = "http://api.stackexchange.com/2.2/";
		public static string SOQuestionsByTagRequest = "questions?order=desc&sort=activity&tagged={0}&site=stackoverflow&filter=!gB7hjL3lhJ*Cnfe63rh6pC_qBj).1ki33j5";
		public static string SOAnswersByQuestionIDRequest = "questions/{0}/answers?order=desc&sort=activity&page=20&site=stackoverflow&filter=!gB7hjL3lhJ*Cnfe63rh6pC_qBj).1ki33j5";
		public static string SOSmartFilter = "!gB7hjL3lhJ*Cnfe63rh6pC_qBj).1ki33j5";
	}
}
