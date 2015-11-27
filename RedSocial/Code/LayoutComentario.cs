using System;
using System.Collections.Generic;

using Xamarin.Forms;
namespace RedSocial
{
	public class LayoutComentario: StackLayout
	{
		public LayoutComentario ()
		{
			this.BackgroundColor = Color.White;
			this.Padding = new Thickness (3, 3, 3, 3);

			this.Children.Add(new LayoutQuienyQue());

			Label comentario = new Label () {
				Text = "Comentario acerca de la noticia publicada, este puede ser tan largo como quiera. Incluso con link de pagina o algo asi.",
				FontSize=12
			};

			this.Children.Add (comentario);


			this.Children.Add(new LayoutComentaryCompartir());

		}
	}
}

