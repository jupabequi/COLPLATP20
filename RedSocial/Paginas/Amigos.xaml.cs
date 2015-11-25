using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RedSocial
{
	public partial class Amigos : ContentPage
	{

		ListaNotificaciones list;
		Label resultsLabel;


		public Amigos ()
		{
			BackgroundColor = Color.FromRgb (96, 178, 54);

			var guardaritem = new ToolbarItem {
				Text = "Guardar",
				//Order = ToolbarItemOrder.Secondary
			};

			ToolbarItems.Add (guardaritem);



			SearchBar searchBar = new SearchBar
			{
				Placeholder = "Buscar",
				BackgroundColor= Color.FromRgb (96, 178, 54)
			};
			//searchBar.SearchButtonPressed += OnSearchBarButtonPressed;

			resultsLabel = new Label();
			list = new ListaNotificaciones ();
			list.HeightRequest = 400;






			// Accomodate iPhone status bar.
			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			// Build the page.
			this.Content = new StackLayout
			{
				Children =
				{

					searchBar,
					new ScrollView
					{
						Content = list,
						VerticalOptions = LayoutOptions.FillAndExpand
					}
				}
			};
			
		}
	}
}

