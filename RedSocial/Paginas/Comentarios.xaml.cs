using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace RedSocial
{
	public partial class Comentarios : ContentPage
	{
		ListaNotificaciones list;

		public Comentarios ()
		{
			BackgroundColor = Color.FromRgb (96, 178, 54);

			var guardaritem = new ToolbarItem {
				Text = "Guardar",
				//Order = ToolbarItemOrder.Secondary
			};

			ToolbarItems.Add (guardaritem);





			RelativeLayout layoutsup = new RelativeLayout ();

			Label lblpara = new Label () {
				Text="Para:"
			};

			layoutsup.Children.Add (lblpara,
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));
			
			SearchBar searchBar = new SearchBar
			{
				Placeholder = "Buscar",
				BackgroundColor= Color.FromRgb (96, 178, 54)
			};

			layoutsup.Children.Add (searchBar,
				Constraint.Constant (40),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-50;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));


			RelativeLayout layout = new RelativeLayout ();

			var imgBackground = new Image () {
				Source = ImageSource.FromResource ("RedSocial.Resources.foto.png")
			};

			layout.Children.Add (imgBackground,
				Constraint.Constant (20),
				Constraint.Constant (20),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 50;
			}));

			Entry comentario = new Entry ();
			comentario.AnchorY = 200;

			layout.Children.Add (comentario,
				Constraint.Constant (70),
				Constraint.Constant (20),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 200;
				}));


			BoxView barra = new BoxView ();
			barra.BackgroundColor = Color.White;
			barra.AnchorY = 40;


			BoxView blanco = new BoxView ();
			blanco.BackgroundColor = Color.Green;
			blanco.AnchorY = 400;


			RelativeLayout layoutcomentario = new RelativeLayout ();

			BoxView fondo = new BoxView (){
				BackgroundColor=Color.White,
				HeightRequest=30
			};

			layoutcomentario.Children.Add (fondo,
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 30;
				}));


			ExtendedEntry ecomentario = new ExtendedEntry (){
				Placeholder="Escriba un comentario",
				Font = Font.OfSize("arial",10)
			};
			comentario.AnchorY = 25;

			layoutcomentario.Children.Add (ecomentario,
				Constraint.Constant (2),
				Constraint.Constant (2),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-95;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 25;
				}));

			Button publicar = new Button (){
				Text="Publicar",
				FontSize=14,
				TextColor = Color.Gray

			};
			publicar.AnchorY = 25;

			layoutcomentario.Children.Add (publicar,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width-100;
				}),
				Constraint.Constant (2),
				Constraint.RelativeToParent ((Parent) => {
					return 100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 25;
				}));


		
			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);


			StackLayout slayout = new StackLayout
			{
				Children =
				{
					searchBar,
					new LayoutNoticiaconcomentarios(),

					layoutcomentario


				}
				};

			ScrollView scrollview = new ScrollView {

				Content = slayout

			};

			this.Content = scrollview;

			ecomentario.Focus ();
		}
	}
}

