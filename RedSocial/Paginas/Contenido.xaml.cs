using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace RedSocial
{
	public partial class Contenido : ContentPage
	{
		ListaNotificaciones list;
		Label resultsLabel;

		public Contenido ()
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



			StackLayout laynoticias = new StackLayout ();
			laynoticias.Padding = new Thickness(3, 0, 3, 0);


			LayoutNoticias slayNoticias1 = new LayoutNoticias ();
			LayoutNoticias slayNoticias2 = new LayoutNoticias ();
			LayoutNoticias slayNoticias3 = new LayoutNoticias ();

			laynoticias.Children.Add (slayNoticias1);
			laynoticias.Children.Add (slayNoticias2);
			laynoticias.Children.Add (slayNoticias3);

			RelativeLayout laytbarra = new RelativeLayout ();

			BoxView barra = new BoxView ();
			barra.BackgroundColor = Color.White;
			barra.AnchorY = 60;

			laytbarra.Children.Add (barra,
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 60;
				}));

			var imgedit = new Image () {
				Source = ImageSource.FromResource ("RedSocial.Resources.user117.png"),
				Aspect = Aspect.AspectFill
			};
			laytbarra.Children.Add (imgedit,
				Constraint.Constant (30),
				Constraint.Constant (10),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));

			var imgperson = new Image () {
				Source = ImageSource.FromResource ("RedSocial.Resources.user168.png"),
				Aspect = Aspect.AspectFill
			};
			laytbarra.Children.Add (imgperson,
				Constraint.Constant (120),
				Constraint.Constant (10),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));

			var imgletter = new Image () {
				Source = ImageSource.FromResource ("RedSocial.Resources.premium1.png"),
				Aspect = Aspect.AspectFill
			};
			laytbarra.Children.Add (imgletter,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-150;
				}),
				Constraint.Constant (10),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));

			var imgreward = new Image () {
				Source = ImageSource.FromResource ("RedSocial.Resources.social12.png"),
				Aspect = Aspect.AspectFill
			};
			laytbarra.Children.Add (imgreward,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-70;
				}),
				Constraint.Constant (10),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));
			

			// Accomodate iPhone status bar.
			this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

			// Build the page.
			this.Content = new StackLayout
			{
				Children =
				{
					
					searchBar,

					new ScrollView
					{
						Content = laynoticias,
						VerticalOptions = LayoutOptions.FillAndExpand
					},
					laytbarra

				}
				};


			




		}
	}
}

