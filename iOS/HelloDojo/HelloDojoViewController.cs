using System;
using System.Drawing;

using Foundation;
using UIKit;

using Assisticant.Binding;

namespace HelloDojo
{
	public partial class HelloDojoViewController : UIViewController
	{
        private BindingManager _bindings = new BindingManager();

		private AddressBookViewModel _viewModel = 
			new AddressBookViewModel(new AddressBook(), new PersonSelection());

		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public HelloDojoViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

            _bindings.Initialize(this);
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			_bindings.BindText(
				textName,
				() => _viewModel.NewName,
				x => _viewModel.NewName = x);

			_bindings.BindItems(
				tablePeople,
				() => _viewModel.People,
				(view, person, bindings) => 
				{
					bindings.BindText(view.TextLabel, () => person.Name);
				});

			_bindings.BindCommand(
				buttonAdd,
				() => _viewModel.AddPerson(),
				() => !string.IsNullOrWhiteSpace(_viewModel.NewName));
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

