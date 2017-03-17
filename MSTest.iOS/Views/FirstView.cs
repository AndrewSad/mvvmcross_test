using System.Drawing;
using MCTest.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using UIKit;

namespace MSTest.iOS.Views
{
	public partial class FirstView : MvxViewController<FirstViewModel>
    {
		//public FirstView() : base("FirstView", null)
		//{
		//}

		public override void ViewDidLoad()
		{
			this.View = new UIView { BackgroundColor = UIColor.White };

            base.ViewDidLoad();

			var tableView = new UITableView(new RectangleF(0, 0, 320, 640));
			tableView.RowHeight = 100;
			var source = new MvxSimpleTableViewSource(tableView, QuestionTableViewCell.Key, QuestionTableViewCell.Key);
			tableView.Source = source;
			Add(tableView);

			var loadingIndicator = new UIActivityIndicatorView(new RectangleF(130, 260, 60, 60));
			loadingIndicator.ActivityIndicatorViewStyle = UIActivityIndicatorViewStyle.WhiteLarge;
			loadingIndicator.Color = UIColor.Purple;
			loadingIndicator.HidesWhenStopped = true;
			loadingIndicator.StartAnimating();
			Add(loadingIndicator);

			var set = this.CreateBindingSet<FirstView, FirstViewModel>();
			set.Bind(source).To(vm => vm.Questions);
			set.Bind(Title).To(vm => vm.QuestionsTag);
			set.Bind(tableView).For("Visibility").To(vm => vm.IsLoading).WithConversion("InvertedVisibility");
			set.Bind(loadingIndicator).For("Visibility").To(vm => vm.IsLoading).WithConversion("Visibility");
			set.Apply();

			tableView.ReloadData();
        }
    }
}
