using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CodePlay_Piano
{
	internal class ClassPiano
	{

		public int AnchoTeclasNegras;
		public int AltoTeclasNegras;

		public int AnchoTeclasBlancas;
		public int AltoTeclasBlancas;

		public ClassPiano()
		{
			AnchoTeclasNegras = 40;
			AltoTeclasNegras = 200;
			AnchoTeclasBlancas = 50;
			AltoTeclasBlancas = 300;
		}

		public void CrearTeclasNegras(String[] NotasDeTeclasNegras, Panel panel)
		{
			for (int i = 0; i < NotasDeTeclasNegras.Length; i++)
			{
				if (NotasDeTeclasNegras[i] != "_")
				{
					Button TeclaNegra = new Button();
					TeclaNegra.BackColor = Color.Black;
					TeclaNegra.ForeColor = Color.White;

					TeclaNegra.Size = new Size(AnchoTeclasNegras, this.AltoTeclasNegras);
					TeclaNegra.Name = NotasDeTeclasNegras[i].ToString();
					TeclaNegra.Location = new Point(TeclaNegra.Location.X + (i * this.AnchoTeclasBlancas) + 30, TeclaNegra.Location.Y);
					TeclaNegra.Text = NotasDeTeclasNegras[i];
					TeclaNegra.Click += ReproducirSonido;
					panel.Controls.Add(TeclaNegra);
				}
			}
		}
		public void CrearTeclasBlancas(String[] NotasDeTeclasBlancas, Panel panel)
		{
			for (int i = 0; i < NotasDeTeclasBlancas.Length; i++)
			{
				Button TeclaBlanca = new Button();
				TeclaBlanca.Name = NotasDeTeclasBlancas[i].ToString();
				TeclaBlanca.TextAlign = ContentAlignment.BottomCenter;
				TeclaBlanca.Text = NotasDeTeclasBlancas[i];
				TeclaBlanca.Size = new Size(this.AnchoTeclasBlancas, this.AltoTeclasBlancas);
				TeclaBlanca.ForeColor = Color.Black;
				int TheX = TeclaBlanca.Location.X + (i * this.AnchoTeclasBlancas);
				TeclaBlanca.Location = new Point(TheX, TeclaBlanca.Location.Y);
				TeclaBlanca.Click += ReproducirSonido;
				panel.Controls.Add(TeclaBlanca);
			}

		}

		public void ReproducirSonido(object sender, EventArgs e)
		{
			var BtnSonido = (Button)sender;
			ReproducirSonido(BtnSonido.Name);
		}


		public void ReproducirSonido(string nombreNota)
		{
			bool pedalActivo = Control.IsKeyLocked(Keys.CapsLock);
			string recurso = pedalActivo ? nombreNota + "_SUS" : nombreNota;

			Stream str = (Stream)Properties.Resources.ResourceManager.GetObject(recurso);

			if (str != null)
			{
				SoundPlayer Sonido = new SoundPlayer(str);
				Sonido.Play();
			}
			else
			{
				Console.WriteLine($"Recurso no encontrado: {recurso}");
			}
		}
	}
}
