using System;

namespace RedSocial
{
	public class Notificacion
	{
		public string Title { get; set; }

		public string Subtitle { get; set; }

		public double Latitude { get; set; }

		public double Longitude { get; set; }

		public Notificacion (string title, string subtitle)
		{
			this.Title = title;
			this.Subtitle = subtitle;
		}
	}
}

