// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MSTest.iOS
{
	[Register ("QuestionTableViewCell")]
	partial class QuestionTableViewCell
	{
		[Outlet]
		UIKit.UILabel AnswerCountLabel { get; set; }

		[Outlet]
		UIKit.UILabel AuthorLabel { get; set; }

		[Outlet]
		UIKit.UILabel BodyLabel { get; set; }

		[Outlet]
		UIKit.UILabel ModDateLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (AuthorLabel != null) {
				AuthorLabel.Dispose ();
				AuthorLabel = null;
			}

			if (BodyLabel != null) {
				BodyLabel.Dispose ();
				BodyLabel = null;
			}

			if (ModDateLabel != null) {
				ModDateLabel.Dispose ();
				ModDateLabel = null;
			}

			if (AnswerCountLabel != null) {
				AnswerCountLabel.Dispose ();
				AnswerCountLabel = null;
			}
		}
	}
}
