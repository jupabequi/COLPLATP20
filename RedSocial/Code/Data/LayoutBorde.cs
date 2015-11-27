using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RedSocial
{
	public class LayoutBorde : StackLayout
	{
		public LayoutBorde (View layout)
		{
			this.BackgroundColor = Color.Gray;
			this.Padding = new Thickness (1, 1, 1, 1);
			this.Children.Add (layout);
		}
	}
}

