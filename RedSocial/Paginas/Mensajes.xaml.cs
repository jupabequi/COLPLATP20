using System;
using System.Collections.Generic;

using Xamarin.Forms;

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



			SearchBar searchBar = new SearchBar
			{
				Placeholder = "Buscar",
				BackgroundColor= Color.FromRgb (96, 178, 54)
			};

			var imgBackground = new Image () {
				Source = ImageSource.FromResource ("RedSocial.Resources.fondogrande.png"),
				Aspect = Aspect.AspectFit
			};


			RelativeLayout layout = new RelativeLayout ();

			Entry comentario = new Entry ();
			comentario.AnchorY = 40;

			layout.Children.Add (comentario,
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));

			Button publicar = new Button (){
				Text="Publicar"
			};
			publicar.AnchorY = 40;

			layout.Children.Add (publicar,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-100;
				}),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return 100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));


			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			this.Content = new StackLayout
			{
				Children =
				{

					searchBar,
					imgBackground,
					layout
				}
			};
		}
	}
}

