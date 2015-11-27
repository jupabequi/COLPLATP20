using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RedSocial
{
	public class LayoutQuienyQue : RelativeLayout
	{
		public LayoutQuienyQue ()
		{




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
			Span sp2 = new Span () {
				Text = " compartió la ",
				FontSize=12
			};
			fs.Spans.Add (sp2);
			Span sp3 = new Span () {
				Text = "foto",
				FontAttributes = FontAttributes.Bold,
				FontSize=12
			};
			fs.Spans.Add (sp3);
			Span sp4 = new Span () {
				Text = " de ",
				FontSize=12
			};
			fs.Spans.Add (sp4);
			Span sp5 = new Span () {
				Text = "Gente Inteligente IQ",
				FontAttributes = FontAttributes.Bold,
				FontSize=12
			};
			fs.Spans.Add (sp5);
			label.FormattedText = fs;

			labeltit.Children.Add (label);

			Label tiempo = new Label () {
				Text = "El 2 de noviembre a las 8:33 p.m.",
				TextColor = Color.Gray,
				FontSize=8
			};
			labeltit.Children.Add (tiempo);

			this.Children.Add (labeltit,
				Constraint.Constant (55),
				Constraint.Constant (2),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width - 55;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
				}));
		}
	}
}

