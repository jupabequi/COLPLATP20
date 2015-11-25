using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RedSocial
{
	public partial class Rewards : ContentPage
	{

		ListaNotificaciones list;
		Label resultsLabel;
		public Rewards ()
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

			RelativeLayout layout = new RelativeLayout ();

			var imgBackground = new Image () {
				Source = ImageSource.FromResource ("RedSocial.Resources.fondogrande.png"),
				Aspect = Aspect.AspectFill
			};

			layout.Children.Add (imgBackground,
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 180;
				}));





			resultsLabel = new Label();
			list = new ListaNotificaciones ();
			list.HeightRequest = 400;

			BoxView barra = new BoxView ();
			barra.BackgroundColor = Color.White;
			barra.AnchorY = 60;

			Entry comentario = new Entry ();
			comentario.AnchorY = 60;


			// Accomodate iPhone status bar.
			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			// Build the page.
			this.Content = new StackLayout
			{
				Children =
				{

					searchBar,
					layout,
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

