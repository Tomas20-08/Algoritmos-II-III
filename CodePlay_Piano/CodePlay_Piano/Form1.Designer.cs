
namespace CodePlay_Piano
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			PanelPiano = new Panel();
			PanelSustain1 = new Panel();
			Title1 = new Label();
			Title2 = new Label();
			Image1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)Image1).BeginInit();
			SuspendLayout();
			// 
			// PanelPiano
			// 
			PanelPiano.BackColor = SystemColors.Control;
			PanelPiano.Location = new Point(585, 390);
			PanelPiano.Name = "PanelPiano";
			PanelPiano.Size = new Size(750, 300);
			PanelPiano.TabIndex = 0;
			// 
			// PanelSustain1
			// 
			PanelSustain1.BackColor = SystemColors.ActiveCaptionText;
			PanelSustain1.Location = new Point(1620, 780);
			PanelSustain1.Name = "PanelSustain1";
			PanelSustain1.Size = new Size(100, 100);
			PanelSustain1.TabIndex = 3;
			PanelSustain1.Paint += PanelSustain1_Paint;
			// 
			// Title1
			// 
			Title1.Font = new Font("Times New Roman", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Title1.ForeColor = SystemColors.AppWorkspace;
			Title1.Location = new Point(618, 133);
			Title1.Name = "Title1";
			Title1.Size = new Size(684, 108);
			Title1.TabIndex = 4;
			Title1.Text = "CodePlay Piano";
			// 
			// Title2
			// 
			Title2.AutoSize = true;
			Title2.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Title2.ForeColor = SystemColors.AppWorkspace;
			Title2.Location = new Point(1424, 776);
			Title2.Name = "Title2";
			Title2.Size = new Size(173, 108);
			Title2.TabIndex = 5;
			Title2.Text = "Sustain\r\nPedal\r\n";
			Title2.Click += label1_Click_1;
			// 
			// Image1
			// 
			Image1.Image = Properties.Resources.Logo_música_elegante_beige_negro;
			Image1.Location = new Point(152, 678);
			Image1.Name = "Image1";
			Image1.Size = new Size(302, 302);
			Image1.TabIndex = 6;
			Image1.TabStop = false;
			Image1.Click += Image1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaptionText;
			ClientSize = new Size(1904, 1041);
			Controls.Add(Image1);
			Controls.Add(Title2);
			Controls.Add(Title1);
			Controls.Add(PanelSustain1);
			Controls.Add(PanelPiano);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)Image1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}



		#endregion

		private Panel PanelPiano;
		private Label Title1;
		private Panel PanelSustain1;
		private Label Title2;
		private PictureBox Image1;
	}
}
