using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RedSocial
{
	public partial class inicio : ContentPage
	{
		public inicio (ILoginManager ilm)
		{

			RelativeLayout layout = new RelativeLayout ();

			/*var imgBackground = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.FondoLogin.png"),
				Aspect = Aspect.AspectFill
			};


			layout.Children.Add (imgBackground,
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Height;
				}));*/
			//Fin Colocar background 

			/*var imginicio = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.inicio.png"),
				Aspect = Aspect.AspectFit
			};


			layout.Children.Add (imginicio,
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 590;
				}));*/

			var button = new Button { 
				Text = "Iniciar sesión",
				FontSize = 24,
				TextColor = Color.White,
				BackgroundColor = Color.FromRgb(240,90,40),
				FontFamily= "TwCenMT-Condensed"
			};
			button.Clicked += (sender, e) => {
				ilm.ShowLogin();

			};

			layout.Children.Add (button,
				Constraint.Constant (20),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Height-60-40-10;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-40;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));


			var button2 = new Button { 
				Text = "Crear cuenta",
				FontSize = 24,
				TextColor = Color.FromHex("#FFFFFF"),
				BackgroundColor = Color.Gray,
				FontFamily = "TwCenMT-Condensed"
			};
			button2.Clicked += (sender, e) => {
				ilm.ShowRegistro();

			};

			layout.Children.Add (button2,
				Constraint.Constant (20),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Height-60;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-40;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));

			Content = layout;

		}
	}
}


