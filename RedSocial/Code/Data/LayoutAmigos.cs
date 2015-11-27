using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace RedSocial
{
	public class LayoutAmigos : RelativeLayout
	{
		public LayoutAmigos ()
		{
			this.BackgroundColor = Color.White;
			this.Padding = new Thickness (3, 3, 3, 3);

			string foto = new Fotos ().fotoaleatoria();




			var imgfoto = new Image () {
				Source = ImageSource.FromResource (foto),
				Aspect = Aspect.AspectFill
			};

			this.Children.Add (imgfoto,
				Constraint.Constant (0),
				Constraint.Constant (2),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
				}));


			StackLayout labeltit = new StackLayout ();

			Label label = new Label () {
				FontSize=12
			};
			label.HorizontalOptions = LayoutOptions.FillAndExpand;
			label.XAlign = TextAlignment.Start;

			var fs = new FormattedString ();


			Span sp1 = new Span () {
				Text = "Jonatahan Ivan Vargas Gómez",
				FontAttributes = FontAttributes.Bold,
				FontSize=12
			};
			fs.Spans.Add (sp1);
			label.FormattedText = fs;
			labeltit.Children.Add (label);

			this.Children.Add (labeltit,
				Constraint.Constant (55),
				Constraint.Constant (2),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width - 55;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
				}));
			
			ExtendedButton btnconfirmar = new ExtendedButton () {
				Text = "Confirmar",
				TextColor = Color.White,
				BackgroundColor = Color.FromRgb(96, 178, 54)
			};

		

			this.Children.Add (btnconfirmar,
				Constraint.Constant (55),
				Constraint.Constant (20),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width - 55)/2-10;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));

			ExtendedButton btneliminar = new ExtendedButton () {
				Text = "Eliminar",
				TextColor = Color.White,
				BackgroundColor = Color.FromRgb(96, 178, 54)
			};



			this.Children.Add (btneliminar,
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width - 55)/2+55;
				}),
				Constraint.Constant (20),
				Constraint.RelativeToParent ((Parent) => {
					return (Parent.Width - 55)/2-10;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));


		}
	}
}

