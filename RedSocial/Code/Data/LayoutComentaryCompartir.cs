using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RedSocial
{
	public class LayoutComentaryCompartir : RelativeLayout
	{
		public LayoutComentaryCompartir ()
		{

			BoxView linea = new BoxView () {
				Color = Color.Gray,
				HeightRequest=1
			};

			this.Children.Add (linea,
				Constraint.Constant (5),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-10;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 1;
				}));

			Label lblcomentar = new Label () {
				Text="Comentar",
				FontSize=9,
				FontAttributes = FontAttributes.Bold,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center,
				TextColor = Color.Gray
			};

			this.Children.Add (lblcomentar,
				Constraint.Constant (0),
				Constraint.Constant (1),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 15;
				}));



			Label lblcompartir = new Label () {
				Text="Compartir",
				FontSize=9,
				FontAttributes = FontAttributes.Bold,
				XAlign = TextAlignment.Center,
				TextColor = Color.Gray,
				YAlign = TextAlignment.Center,
			};

			this.Children.Add (lblcompartir,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2;
				}),
				Constraint.Constant (1),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width/2;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 15;
				}));
		}
	}
}

