using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using PropertyChanged;

namespace MCTest.Core.ViewModels
{
	public class FirstViewModel
		: MvxViewModel
	{
		readonly IDataService _dataService;

		public ObservableCollection<Question> Questions { get; set; }

		string _questionsTag;

		public string QuestionsTag
		{
			get { return _questionsTag; }
			set
			{
				_questionsTag = value;
				RaisePropertyChanged(() => QuestionsTag);
			}
		}

		bool _isLoading;

		public bool IsLoading
		{
			get { return _isLoading; }
			set
			{
				_isLoading = value;
				RaisePropertyChanged(() => IsLoading);


			}
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

		public FirstViewModel(IDataService dataService)
		{
			_dataService = dataService;
			QuestionsTag = "xamarin";
			getTestList().ConfigureAwait(false);
		}

		async Task<ObservableCollection<Question>> getTestList()
		{
			IsLoading = true;
			var questionsArray = await _dataService.getQuestionsByTag("xamarin");
			Questions = questionsArray;
			IsLoading = false;
			return questionsArray;
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
