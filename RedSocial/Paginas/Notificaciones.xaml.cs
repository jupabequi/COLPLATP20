using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RedSocial
{
	public partial class Notificaciones : ContentPage
	{
		public Notificaciones ()
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


			StackLayout laynoticias = new StackLayout ();
			laynoticias.Padding = new Thickness(3, 0, 3, 0);


			layoutnotificacion slayNoticias1 = new layoutnotificacion ();
			layoutnotificacion slayNoticias2 = new layoutnotificacion ();
			layoutnotificacion slayNoticias3 = new layoutnotificacion ();
			layoutnotificacion slayNoticias4 = new layoutnotificacion ();
			layoutnotificacion slayNoticias5 = new layoutnotificacion ();
			layoutnotificacion slayNoticias6 = new layoutnotificacion ();
			layoutnotificacion slayNoticias7 = new layoutnotificacion ();
			layoutnotificacion slayNoticias8 = new layoutnotificacion ();
			layoutnotificacion slayNoticias9 = new layoutnotificacion ();

			laynoticias.Children.Add (slayNoticias1);
			laynoticias.Children.Add (slayNoticias2);
			laynoticias.Children.Add (slayNoticias3);
			laynoticias.Children.Add (slayNoticias4);
			laynoticias.Children.Add (slayNoticias5);
			laynoticias.Children.Add (slayNoticias6);
			laynoticias.Children.Add (slayNoticias7);
			laynoticias.Children.Add (slayNoticias8);
			laynoticias.Children.Add (slayNoticias9);

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
				Constraint.RelativeToParent ((Parent) => {
					return 10;
				}),
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
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/5+10;
				}),
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
					return Parent.Width/5*2+10;
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
					return Parent.Width/5*3+10;
				}),
				Constraint.Constant (10),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));

			var otro = new Image () {
				Source = ImageSource.FromResource ("RedSocial.Resources.email126.png"),
				Aspect = Aspect.AspectFill
			};
			laytbarra.Children.Add (otro,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/5*4+10;
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

