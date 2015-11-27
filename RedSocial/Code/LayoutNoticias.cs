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
			LayoutQuienyQue layNoticia1 = new LayoutQuienyQue ();



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


			Label cuantoscomentarios = new Label () {
				Text = "1 comentario",
				TextColor = Color.Gray,
				FontSize=8
			};

			this.Children.Add (cuantoscomentarios);

			LayoutComentaryCompartir layoutbarra = new LayoutComentaryCompartir ();



			this.Children.Add (layoutbarra);



		}
	}
}

