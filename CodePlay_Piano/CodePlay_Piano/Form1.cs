using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CodePlay_Piano
{
	public partial class Form1 : Form
	{
		private ClassPiano Mipiano;
		private Dictionary<Keys, string> mapaTeclas;
		private HashSet<Keys> teclasPresionadas = new HashSet<Keys>();
		public Form1()
		{
			InitializeComponent();
			this.KeyPreview = true;
			InicializarMapaTeclas();

			this.WindowState = FormWindowState.Maximized;
			this.FormBorderStyle = FormBorderStyle.None;
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			String[] Negras = { "C#4", "D#4", "_", "F#4", "G#4", "A#4", "_", "C#5", "D#5", "_", "F#5", "G#5", "A#5" };
			String[] Blancas = { "C4", "D4", "E4", "F4", "G4", "A4", "B4", "C5", "D5", "E5", "F5", "G5", "A5", "B5", "C6" };
			Mipiano = new ClassPiano();
			Mipiano.CrearTeclasNegras(Negras, PanelPiano);
			Mipiano.CrearTeclasBlancas(Blancas, PanelPiano);
		}
		private void InicializarMapaTeclas()
		{
			mapaTeclas = new Dictionary<Keys, string>()
			{
				{ Keys.Z, "C4" },
				{ Keys.S, "C#4" },
				{ Keys.X, "D4" },
				{ Keys.D, "D#4" },
				{ Keys.C, "E4" },
				{ Keys.V, "F4" },
				{ Keys.G, "F#4" },
				{ Keys.B, "G4" },
				{ Keys.H, "G#4" },
				{ Keys.N, "A4" },
				{ Keys.J, "A#4" },
				{ Keys.M, "B4" },

				{ Keys.Q, "C5" },
				{ Keys.D2, "C#5" },
				{ Keys.W, "D5" },
				{ Keys.D3, "D#5" },
				{ Keys.E, "E5" },
				{ Keys.R, "F5" },
				{ Keys.D5, "F#5" },
				{ Keys.T, "G5" },
				{ Keys.D6, "G#5" },
				{ Keys.Y, "A5" },
				{ Keys.D7, "A#5" },
				{ Keys.U, "B5" },
				{ Keys.I, "C6" }
			};
		}

		protected override void OnKeyUp(KeyEventArgs e)
		{
			base.OnKeyUp(e);
			teclasPresionadas.Remove(e.KeyCode);
			if (mapaTeclas.ContainsKey(e.KeyCode))
			{
				string nota = mapaTeclas[e.KeyCode];
				Button btn = BuscarTeclaPorNombre(nota);
				if (btn != null && btn.BackColor == Color.Gray)
				{
					btn.BackColor = btn.ForeColor == Color.White ? Color.Black : Color.White;
				}
			}
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (!teclasPresionadas.Contains(e.KeyCode))
			{
				teclasPresionadas.Add(e.KeyCode);
				if (mapaTeclas.ContainsKey(e.KeyCode))
				{
					string nota = mapaTeclas[e.KeyCode];
					Button btn = BuscarTeclaPorNombre(nota);
					if (btn != null)
					{
						btn.BackColor = Color.Gray;
						Mipiano.ReproducirSonido(btn, EventArgs.Empty);
					}
				}
			}
		}
		private Button BuscarTeclaPorNombre(string nombre)
		{
			foreach (Control c in PanelPiano.Controls)
			{
				if (c is Button && c.Name == nombre)
					return (Button)c;
			}
			return null;
		}
		private void PanelSustain1_Paint(object sender, PaintEventArgs e)
		{
			bool capsLockOn = Control.IsKeyLocked(Keys.CapsLock);
			Color colorIndicador = capsLockOn ? Color.Red : Color.DimGray;

			using (SolidBrush brush = new SolidBrush(colorIndicador))
			{
				e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
				int diameter = Math.Min(PanelSustain1.Width, PanelSustain1.Height);
				e.Graphics.FillEllipse(brush,
					(PanelSustain1.Width - diameter) / 2,
					(PanelSustain1.Height - diameter) / 2,
					diameter,
					diameter);
			}
		}
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.CapsLock)
			{
				PanelSustain1.Invalidate(); // Redibuja el panel
				return true;
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}
		private void label1_Click(object sender, EventArgs e)
		{
		}
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void label1_Click_1(object sender, EventArgs e)
		{
		}
		private void Image1_Click(object sender, EventArgs e)
		{
		}
	}
}
