﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Assisticant.Binding;

namespace Lister
{
	[Activity (Label = "Lister", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		private BindingManager _bindings = new BindingManager();

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			_bindings.Initialize (this);
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();

			_bindings.Unbind();
		}
	}
}


