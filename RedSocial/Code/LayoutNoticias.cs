using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RedSocial
{
	public class LayoutNoticias : StackLayout
	{
		public LayoutNoticias ()
		{

			this.BackgroundColor = Color.White;
			this.Padding = new Thickness (3, 3, 3, 3);
			//this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
			RelativeLayout layNoticia1 = new RelativeLayout ();

			var imgfoto = new Image () {
				Source = ImageSource.FromResource ("RedSocial.Resources.foto.png"),
				Aspect = Aspect.AspectFill
			};

			layNoticia1.Children.Add (imgfoto,
				Constraint.Constant (0),
				Constraint.Constant (2),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
				}));

			var Label = new Label () {
				Text = "Juan david Alvarino agregó 4 fotos nuevas - con Gabriel Alfonso",
				FontSize=12
			};

			layNoticia1.Children.Add (Label,
				Constraint.Constant (55),
				Constraint.Constant (2),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-55;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
				}));

			this.Children.Add (layNoticia1);

			var Labelmensaje = new Label () {
				Text = "#Meditadores Gracias Gustavo por recomendarme The Amplified. Meditación colectiva! hasta ahora va muy bien. Ahora tambien la uso para leer libros.",
				FontSize=12
			};

			this.Children.Add (Labelmensaje);


			var imgGrande = new Image () {
				Source = ImageSource.FromResource ("RedSocial.Resources.fondogrande.png"),
				Aspect = Aspect.AspectFill
			};

			this.Children.Add (imgGrande);


			RelativeLayout layoutbarra = new RelativeLayout ();

			Label lblcomentar = new Label () {
				Text="Comentar",
				FontSize=12
			};

			layoutbarra.Children.Add (lblcomentar,
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return 100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));



			Label lblcompartir = new Label () {
				Text="Compartir",
				FontSize=12
			};

			layoutbarra.Children.Add (lblcompartir,
				Constraint.Constant (200),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return 100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));

			this.Children.Add (layoutbarra);



		}
	}
}

