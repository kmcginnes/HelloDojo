// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace HelloDojo
{
	[Register ("HelloDojoViewController")]
	partial class HelloDojoViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonAdd { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView tablePeople { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField textName { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (buttonAdd != null) {
				buttonAdd.Dispose ();
				buttonAdd = null;
			}
			if (tablePeople != null) {
				tablePeople.Dispose ();
				tablePeople = null;
			}
			if (textName != null) {
				textName.Dispose ();
				textName = null;
			}
		}
	}
}
