using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace RedSocial
{
	public partial class Mensajes : ContentPage
	{
		public Mensajes ()
		{
			BackgroundColor = Color.FromRgb (96, 178, 54);

			var guardaritem = new ToolbarItem {
				Text = "Guardar",
				//Order = ToolbarItemOrder.Secondary
			};

			ToolbarItems.Add (guardaritem);



			RelativeLayout layoutsup = new RelativeLayout ();

			Label lblpara = new Label () {
				Text="Para:"
			};

			layoutsup.Children.Add (lblpara,
				Constraint.Constant (0),
				Constraint.Constant (6),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));

			SearchBar searchBar = new SearchBar
			{
				Placeholder = "Amigos",
				BackgroundColor= Color.FromRgb (96, 178, 54)
			};

			layoutsup.Children.Add (searchBar,
				Constraint.Constant (40),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-50;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));
			


			RelativeLayout aquien = new RelativeLayout ();

			string foto = new Fotos ().fotoaleatoria();




			var imgfoto = new Image () {
				Source = ImageSource.FromResource (foto),
				Aspect = Aspect.AspectFill
			};

			aquien.Children.Add (imgfoto,
				Constraint.Constant (0),
				Constraint.Constant (2),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
				}));


			StackLayout labeltit = new StackLayout ();

			ExtendedEntry label = new ExtendedEntry () {
				Placeholder = "Comparte esto..."
			};


			labeltit.Children.Add (label);



			aquien.Children.Add (labeltit,
				Constraint.Constant (55),
				Constraint.Constant (2),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width - 55;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
				}));
			layoutminicomentario mini = new layoutminicomentario ();


			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			RelativeLayout rl = new RelativeLayout ();

			rl.Children.Add (layoutsup,
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));
			rl.Children.Add (aquien,
				Constraint.Constant (0),
				Constraint.Constant (50),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
				}));
			rl.Children.Add (new LayoutBorde(mini),
				Constraint.Constant (50),
				Constraint.Constant (120),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
				}));

			this.Content = rl;

		}
	}
}

