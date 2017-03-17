using System;

using Foundation;
using MCTest.Core;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using UIKit;

namespace MSTest.iOS
{
	public partial class QuestionTableViewCell : MvxTableViewCell
	{
		public static readonly NSString Key = new NSString("QuestionTableViewCell");
		public static readonly UINib Nib;

		static QuestionTableViewCell()
		{
			Nib = UINib.FromName("QuestionTableViewCell", NSBundle.MainBundle);
		}

		protected QuestionTableViewCell(IntPtr handle) : base(handle)
		{
			
			// Note: this .ctor should not contain any initialization logic.
			this.DelayBind(() => {
				var set = this.CreateBindingSet<QuestionTableViewCell, Question>();
				set.Bind(AuthorLabel).To(question => question.owner.display_name);
				set.Bind(ModDateLabel).To(question => question.creation_date).WithConversion("LongToDateString");
				set.Bind(AnswerCountLabel).To(question => question.answer_count);
				set.Bind(BodyLabel).For(label => label.AttributedText).To(question => question.body).WithConversion("HtmlToString", BodyLabel);
				set.Apply();
			});
		}
	}
}
