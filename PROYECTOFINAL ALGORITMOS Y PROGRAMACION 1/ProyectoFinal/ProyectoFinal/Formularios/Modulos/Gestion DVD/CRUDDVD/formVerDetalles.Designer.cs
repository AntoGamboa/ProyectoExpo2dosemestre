/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 16/05/2023
 * Hora: 06:52 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoFinal.Formularios.Modulos.Gestion_DVD.CRUDDVD
{
	partial class formVerDetalles
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txbDescripcion = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.pictureBox1 = new ControlesPersonalizados.ControlesBonitos.PintureBoxRedondeada();
			this.label4 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(583, 567);
			this.panel1.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel3.Controls.Add(this.txbDescripcion);
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Controls.Add(this.panel5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 63);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(583, 504);
			this.panel3.TabIndex = 7;
			// 
			// txbDescripcion
			// 
			this.txbDescripcion.BackColor = System.Drawing.Color.Gainsboro;
			this.txbDescripcion.Barra = System.Windows.Forms.ScrollBars.Horizontal;
			this.txbDescripcion.CaracterContraseña = false;
			this.txbDescripcion.ColorBorde = System.Drawing.SystemColors.Highlight;
			this.txbDescripcion.ColorEnfoque = System.Drawing.SystemColors.HotTrack;
			this.txbDescripcion.ColorMarcadorPosicion = System.Drawing.Color.Gray;
			this.txbDescripcion.EstiloLinea = false;
			this.txbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbDescripcion.ForeColor = System.Drawing.Color.DimGray;
			this.txbDescripcion.Location = new System.Drawing.Point(166, 260);
			this.txbDescripcion.Margin = new System.Windows.Forms.Padding(5);
			this.txbDescripcion.ModoLectura = true;
			this.txbDescripcion.Multilinea = true;
			this.txbDescripcion.Name = "txbDescripcion";
			this.txbDescripcion.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
			this.txbDescripcion.RadioArcos = 15;
			this.txbDescripcion.Size = new System.Drawing.Size(231, 234);
			this.txbDescripcion.TabIndex = 2;
			this.txbDescripcion.TamaBorde = 2;
			this.txbDescripcion.TextoMarcadorPosicion = "";
			this.txbDescripcion.Textos = "";
			// 
			// pictureBox1
			// 
			this.pictureBox1.AnguloDegradado = 50F;
			this.pictureBox1.BordeEstiloLinea = System.Drawing.Drawing2D.DashStyle.Solid;
			this.pictureBox1.ColorBorde = System.Drawing.Color.RoyalBlue;
			this.pictureBox1.ColorBorde2 = System.Drawing.Color.Red;
			this.pictureBox1.EstiloCapaBorde = System.Drawing.Drawing2D.DashCap.Flat;
			this.pictureBox1.Location = new System.Drawing.Point(216, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(136, 136);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.TamaBorde = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(226, 225);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 17);
			this.label4.TabIndex = 5;
			this.label4.Text = "Descripcion";
			// 
			// panel4
			// 
			this.panel4.AutoSize = true;
			this.panel4.BackColor = System.Drawing.Color.DimGray;
			this.panel4.Controls.Add(this.label2);
			this.panel4.Location = new System.Drawing.Point(12, 155);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(164, 37);
			this.panel4.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(26, 11);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "label2";
			// 
			// panel5
			// 
			this.panel5.AutoSize = true;
			this.panel5.BackColor = System.Drawing.Color.DimGray;
			this.panel5.Controls.Add(this.label3);
			this.panel5.Location = new System.Drawing.Point(249, 155);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(181, 37);
			this.panel5.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(17, 11);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "label3";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(583, 63);
			this.panel2.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(216, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// formVerDetalles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 567);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(601, 614);
			this.MinimumSize = new System.Drawing.Size(601, 614);
			this.Name = "formVerDetalles";
			this.Text = "formVerDetalles";
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.Label label1;
		public ControlesPersonalizados.ControlesBonitos.PintureBoxRedondeada pictureBox1;
		public ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada txbDescripcion;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
	}
}
