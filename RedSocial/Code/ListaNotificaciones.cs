using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Linq;

namespace RedSocial
{
	public class ListaNotificaciones : ListView
	{
		List<Notificacion> notificaciones;

		public ListaNotificaciones ()
		{
			//notificaciones = new Notificacion ("Red Social","BtoB");

			var cell = new DataTemplate (typeof(TextCell));

			cell.SetBinding (TextCell.TextProperty, "Title");
			cell.SetBinding (TextCell.DetailProperty, "Subtitle");

			ItemTemplate = cell;


			var loc = new List<Notificacion> () {
				new Notificacion ("Abercrombie & Fitch / abercrombie kids", "Level 2 | (480) 792-9275"),
				new Notificacion ("ALDO", "Level 2 | (480) 899-0803"),
				new Notificacion ("All Mobile Matters Mobile Phone Repair & More", "Level 2 | (480) 228-9690"),
				new Notificacion ("Alterations By L", "Level 1 | (480) 786-8092"),
				new Notificacion ("AMERICAN EAGLE OUTFITTERS", "Level 2 | (480) 812-0090"),
				new Notificacion ("Ann Taylor", "Level 1 | (480) 726-6944"),
				new Notificacion ("Apex by sunglass hut", "Level 2 | (480) 855-1709")
			};


			ItemsSource = loc;

			/*ItemSelected += (s, e) => {
				if (SelectedItem == null)
					return;
				var selected = (Notificacion)e.SelectedItem;
				SelectedItem = null;
				//Navigation.PushAsync (new CampusLocationPage (selected));
			};*/

		}
	}
}

