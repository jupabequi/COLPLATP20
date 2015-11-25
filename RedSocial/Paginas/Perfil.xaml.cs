using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace RedSocial
{
	public partial class Perfil : ContentPage
	{
		ListaNotificaciones list;
		Label resultsLabel;

		public Perfil ()
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

			var imgfoto = new Image () {
				Source = ImageSource.FromResource ("RedSocial.Resources.foto.png"),
				Aspect = Aspect.AspectFill
			};

			layout.Children.Add (imgfoto,
				Constraint.Constant (20),
				Constraint.Constant (70),
				Constraint.RelativeToParent ((Parent) => {
					return 100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 100;
				}));



			resultsLabel = new Label();
			list = new ListaNotificaciones ();
			list.HeightRequest = 400;


			RelativeLayout layoutbarra = new RelativeLayout ();

			BoxView barra = new BoxView ();
			barra.BackgroundColor = Color.White;
			barra.AnchorY = 60;

			layoutbarra.Children.Add (barra,
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 60;
				}));
			
			var imgedit = new Image () {
				Source = ImageSource.FromResource ("RedSocial.Resources.pencil432.png"),
				Aspect = Aspect.AspectFill
			};
			layoutbarra.Children.Add (imgedit,
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
			layoutbarra.Children.Add (imgperson,
				Constraint.Constant (120),
				Constraint.Constant (10),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));

			var imgletter = new Image () {
				Source = ImageSource.FromResource ("RedSocial.Resources.email126.png"),
				Aspect = Aspect.AspectFill
			};
			layoutbarra.Children.Add (imgletter,
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
				Source = ImageSource.FromResource ("RedSocial.Resources.premium1.png"),
				Aspect = Aspect.AspectFill
			};
			layoutbarra.Children.Add (imgreward,
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

			ExtendedEntry comentario = new ExtendedEntry (){
				Placeholder="Comentario"
			};
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
					layoutbarra,
					comentario,
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

