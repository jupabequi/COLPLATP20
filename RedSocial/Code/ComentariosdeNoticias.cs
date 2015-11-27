using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RedSocial
{
	public class ComentariosdeNoticias : StackLayout
	{
		public ComentariosdeNoticias ()
		{

			this.BackgroundColor = Color.White;
			this.Padding = new Thickness (3, 3, 3, 3);


			LayoutQuienyQue quiencomenta = new LayoutQuienyQue ();

			this.Children.Add (quiencomenta);

			this.Children.Add (new LayoutBorde (new LayoutNoticias ()));


			this.Children.Add (new LayoutBorde (new LayoutComentario ()));
			this.Children.Add (new LayoutBorde (new LayoutComentario ()));
		}
	}
}

