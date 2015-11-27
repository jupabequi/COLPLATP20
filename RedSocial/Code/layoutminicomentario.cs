using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RedSocial
{
	public class layoutminicomentario  : RelativeLayout
	{
		public layoutminicomentario ()
		{

			string foto = new Fotos ().fotoaleatoria();


			this.BackgroundColor = Color.FromRgb (190, 190, 190);

			this.Padding = new Thickness (3, 3, 3, 3);
			var imgfoto = new Image () {
				Source = ImageSource.FromResource (foto),
				Aspect = Aspect.AspectFill
			};

			this.Children.Add (imgfoto,
				Constraint.Constant (2),
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
				Text = "#ShielEnsony",
				FontAttributes = FontAttributes.Bold,
				FontSize=12
			};
			fs.Spans.Add (sp1);
			Span sp2 = new Span () {
				Text = "\n bit.ly ",
				FontSize=12
			};
			fs.Spans.Add (sp2);
			Span sp3 = new Span () {
				Text = "\nEl nuevo inhumano se enamor...",
				FontSize=12
			};
			fs.Spans.Add (sp3);
			label.FormattedText = fs;

			labeltit.Children.Add (label);

			Label tiempo = new Label () {
				Text = "El 2 de noviembre a las 8:33 p.m.",
				TextColor = Color.Gray,
				FontSize=8
			};
			labeltit.Children.Add (tiempo);

			this.Children.Add (labeltit,
				Constraint.Constant (57),
				Constraint.Constant (2),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width - 57;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 60;
				}));

		}
	}
}

