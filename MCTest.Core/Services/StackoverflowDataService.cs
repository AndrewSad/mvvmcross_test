using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ModernHttpClient;
using System.Net.Http;
using Newtonsoft.Json;
using MvvmCross.Platform;
using System.Linq;

namespace MCTest.Core
{
	public class StackoverflowDataService : IDataService
	{
		private HttpClient _baseClient;

		private HttpClient BaseClient
		{
			get
			{
				return _baseClient ?? (_baseClient = new HttpClient(new NativeMessageHandler())
				{
					BaseAddress = new Uri(Constants.SOBaseAddress)
				});
			}
		}

		public async Task<List<Question>> getQuestionsByTag(string tag)
		{
			//throw new NotImplementedException();
			var questions = new List<Question>();

			try
			{
				var res = await BaseClient.GetAsync(string.Format(Constants.SOQuestionsByTagRequest, tag));
				res.EnsureSuccessStatusCode();

				var json = await res.Content.ReadAsStringAsync();

				if (string.IsNullOrEmpty(json)) return null;

				var so_response = JsonConvert.DeserializeObject<SO_Response>(json);


				questions = so_response.items;


				return questions;
			}
			catch (Exception ex)
			{
				Mvx.TaggedTrace(typeof(StackoverflowDataService).Name,
					"Ooops! Something went wrong fetching information for tag: {0}. Exception: {1}", tag, ex);
				return null;
			}


		}

		public async Task<List<Answer>> getAnswersByQuestionID(string question_id)
		{
			var answers = new List<Answer>();
			try
			{
				var res = await BaseClient.GetAsync(string.Format(Constants.SOAnswersByQuestionIDRequest, question_id));
				res.EnsureSuccessStatusCode();

				var json = await res.Content.ReadAsStringAsync();

				if (string.IsNullOrEmpty(json)) return null;

				var so_response = JsonConvert.DeserializeObject<SO_AnswersResponse>(json);


				answers = so_response.items;


				return answers;
			}
			catch (Exception ex)
			{
				Mvx.TaggedTrace(typeof(StackoverflowDataService).Name,
				                "Ooops! Something went wrong fetching information for question_id: {0}. Exception: {1}", question_id, ex);
				return null;
			}
		}


	}
}
