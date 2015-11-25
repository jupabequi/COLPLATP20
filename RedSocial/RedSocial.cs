using System;

using Xamarin.Forms;

namespace RedSocial
{
	public class App : Application, ILoginManager
	{
		public App ()
		{
			//Current = this;

			var isLoggedIn = Properties.ContainsKey("IsLoggedIn")?(bool)Properties ["IsLoggedIn"]:false;

			var user = Properties.ContainsKey("usuario")?Properties ["usuario"]:null;

			// we remember if they're logged in, and only display the login page if they're not
			if (isLoggedIn && user!=null) {

				int usuario = (int)Properties ["usuario"];
				MainPage = new RedSocial.MainPage (null);
			}
			else
				//MainPage = new LoginModalPage (this,"");
				//MainPage = new Login (this);
				MainPage = new Contenido();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

		public void ShowMainPage ()
		{	
			MainPage = new RedSocial.MainPage (null);
		}
		public void ShowLogin(){
		}
		public void ShowRegistro(){
		}
	}
}

