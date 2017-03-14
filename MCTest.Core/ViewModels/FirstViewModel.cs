using System.Collections.Generic;
using MvvmCross.Core.ViewModels;
using PropertyChanged;

namespace MCTest.Core.ViewModels
{
	[ImplementPropertyChanged]
    public class FirstViewModel 
        : MvxViewModel
    {
		private readonly IDataService _dataService;

		public List<Question> Questions { get; set; }

		public string QuestionsTag { get; set; }

		public FirstViewModel(IDataService dataService)
		{
			_dataService = dataService;
		}

		private Question _selectedQuestion;

		public Question SelectedQuestion
		{
			get { return _selectedQuestion; }
			set
			{
				_selectedQuestion = value;
				RaisePropertyChanged(() => SelectedQuestion);

				ShowSelectedQuestionCommand.Execute(null);
			}
		}

		public IMvxCommand SearchQuestionsByTagCommand
		{ 
			get 
			{
				return new MvxCommand(async () =>
				{
					Questions = await _dataService.getQuestionsByTag(QuestionsTag);
				});
			}
		}

		public IMvxCommand ShowSelectedQuestionCommand
		{ 
			get 
			{
				return new MvxCommand(() => ShowViewModel<DetailedQuestionViewModel>(new { question = SelectedQuestion }),
				                      () => SelectedQuestion != null);
			}

		}
	}
}
