using System;
using System.Collections.Generic;
using MvvmCross.Core.ViewModels;
using PropertyChanged;

namespace MCTest.Core
{
	[ImplementPropertyChanged]
	public class DetailedQuestionViewModel : MvxViewModel
	{
		public Question CurrentQuestion { get; set; }

		public DetailedQuestionViewModel(Question question)
		{
			CurrentQuestion = question;
			AnswersList = question.answers;
		}

		readonly IDataService _dataService;

		public DetailedQuestionViewModel(IDataService dataService)
		{
			_dataService = dataService;
		}

		public List<Answer> AnswersList { get; set; }

		public override async void Start()
		{
			base.Start();

			if (AnswersList != null) return;

			AnswersList = await _dataService.getAnswersByQuestionID(CurrentQuestion.question_id);

		}
	}
}
