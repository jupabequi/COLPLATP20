using System;

namespace RedSocial
{
	public class Fotos
	{


		public string fotoaleatoria() {
			
			Random rand1 = new Random ();
			int numero = (int)(Math.Round(Math.Round(rand1.NextDouble ()*10)/2));

			string foto;

			switch (numero) {
			case 1:
				foto = "RedSocial.Resources.fotos.foto1.png";
				break;
			case 2:
				foto = "RedSocial.Resources.fotos.foto2.png";
				break;
			case 3:
				foto = "RedSocial.Resources.fotos.foto3.png";
				break;
			case 4:
				foto = "RedSocial.Resources.fotos.foto4.png";
				break;
			case 5:
				foto = "RedSocial.Resources.fotos.foto5.png";
				break;
			default:
				foto = "RedSocial.Resources.foto.png";
				break;

			}

			return foto;
		}
	}
}

