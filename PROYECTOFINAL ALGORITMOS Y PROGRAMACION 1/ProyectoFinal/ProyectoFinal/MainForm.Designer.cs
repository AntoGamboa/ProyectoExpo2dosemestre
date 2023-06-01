/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 30/04/2023
 * Hora: 06:22 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoFinal
{
	partial class InicioSesion
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnSalir = new System.Windows.Forms.PictureBox();
			this.BtnRegistrarse = new ControlesPersonalizados.ControlesBonitos.BotonPerzonalizable();
			this.btnIniciarSesion = new ControlesPersonalizados.ControlesBonitos.BotonPerzonalizable();
			this.Contraseña = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.Usuario = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panelPic = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.HORA = new System.Windows.Forms.Label();
			this.horaactual = new System.Windows.Forms.Timer(this.components);
			this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelPic)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.btnSalir);
			this.panel2.Controls.Add(this.BtnRegistrarse);
			this.panel2.Controls.Add(this.btnIniciarSesion);
			this.panel2.Controls.Add(this.Contraseña);
			this.panel2.Controls.Add(this.Usuario);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(350, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(350, 300);
			this.panel2.TabIndex = 1;
			this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.panel4.Location = new System.Drawing.Point(0, 267);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(350, 3);
			this.panel4.TabIndex = 1;
			// 
			// btnSalir
			// 
			this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.Location = new System.Drawing.Point(318, 3);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(29, 29);
			this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnSalir.TabIndex = 6;
			this.btnSalir.TabStop = false;
			this.toolTipInfo.SetToolTip(this.btnSalir, "Haz Click Para Salir");
			// 
			// BtnRegistrarse
			// 
			this.BtnRegistrarse.BackColor = System.Drawing.Color.Transparent;
			this.BtnRegistrarse.colorborde = System.Drawing.Color.Black;
			this.BtnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnRegistrarse.FlatAppearance.BorderSize = 0;
			this.BtnRegistrarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
			this.BtnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnRegistrarse.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnRegistrarse.ForeColor = System.Drawing.Color.Black;
			this.BtnRegistrarse.Location = new System.Drawing.Point(196, 210);
			this.BtnRegistrarse.Name = "BtnRegistrarse";
			this.BtnRegistrarse.radioBorde = 40;
			this.BtnRegistrarse.Size = new System.Drawing.Size(126, 40);
			this.BtnRegistrarse.TabIndex = 5;
			this.BtnRegistrarse.TamaBorde = 2;
			this.BtnRegistrarse.Text = "Registrarse";
			this.BtnRegistrarse.UseVisualStyleBackColor = false;
			// 
			// btnIniciarSesion
			// 
			this.btnIniciarSesion.BackColor = System.Drawing.Color.Transparent;
			this.btnIniciarSesion.colorborde = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
			this.btnIniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIniciarSesion.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIniciarSesion.ForeColor = System.Drawing.Color.Black;
			this.btnIniciarSesion.Location = new System.Drawing.Point(43, 210);
			this.btnIniciarSesion.Name = "btnIniciarSesion";
			this.btnIniciarSesion.radioBorde = 40;
			this.btnIniciarSesion.Size = new System.Drawing.Size(126, 40);
			this.btnIniciarSesion.TabIndex = 4;
			this.btnIniciarSesion.TamaBorde = 2;
			this.btnIniciarSesion.Text = "Iniciar Sesion";
			this.btnIniciarSesion.UseVisualStyleBackColor = false;
			// 
			// Contraseña
			// 
			this.Contraseña.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Contraseña.CaracterContraseña = true;
			this.Contraseña.CausesValidation = false;
			this.Contraseña.ColorBorde = System.Drawing.Color.Black;
			this.Contraseña.ColorEnfoque = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.Contraseña.ColorMarcadorPosicion = System.Drawing.Color.Gray;
			this.Contraseña.EstiloLinea = true;
			this.Contraseña.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.Contraseña.Location = new System.Drawing.Point(54, 141);
			this.Contraseña.Margin = new System.Windows.Forms.Padding(4);
			this.Contraseña.Multilinea = false;
			this.Contraseña.Name = "Contraseña";
			this.Contraseña.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.Contraseña.RadioArcos = 0;
			this.Contraseña.Size = new System.Drawing.Size(250, 32);
			this.Contraseña.TabIndex = 3;
			this.Contraseña.TamaBorde = 2;
			this.Contraseña.TextoMarcadorPosicion = "Contraseña";
			this.Contraseña.Textos = "";
			this.toolTipInfo.SetToolTip(this.Contraseña, "Introduzca La contraseña");
			// 
			// Usuario
			// 
			this.Usuario.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Usuario.CaracterContraseña = false;
			this.Usuario.CausesValidation = false;
			this.Usuario.ColorBorde = System.Drawing.Color.Black;
			this.Usuario.ColorEnfoque = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.Usuario.ColorMarcadorPosicion = System.Drawing.Color.Gray;
			this.Usuario.EstiloLinea = true;
			this.Usuario.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.Usuario.Location = new System.Drawing.Point(54, 76);
			this.Usuario.Margin = new System.Windows.Forms.Padding(4);
			this.Usuario.Multilinea = false;
			this.Usuario.Name = "Usuario";
			this.Usuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.Usuario.RadioArcos = 0;
			this.Usuario.Size = new System.Drawing.Size(250, 32);
			this.Usuario.TabIndex = 2;
			this.Usuario.TamaBorde = 2;
			this.Usuario.TextoMarcadorPosicion = "Usuario/Correo";
			this.Usuario.Textos = "";
			this.toolTipInfo.SetToolTip(this.Usuario, "Introduzca el Usuario ");

			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.label1.Location = new System.Drawing.Point(0, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(250, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Inicia Sesion Para Comenzar";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.panel3.Location = new System.Drawing.Point(0, 33);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(350, 3);
			this.panel3.TabIndex = 0;
			// 
			// panelPic
			// 
			this.panelPic.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelPic.Image = ((System.Drawing.Image)(resources.GetObject("panelPic.Image")));
			this.panelPic.Location = new System.Drawing.Point(0, 0);
			this.panelPic.Name = "panelPic";
			this.panelPic.Size = new System.Drawing.Size(350, 300);
			this.panelPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.panelPic.TabIndex = 0;
			this.panelPic.TabStop = false;
			this.panelPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPic_MouseDown);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.panel1.Controls.Add(this.HORA);
			this.panel1.Controls.Add(this.panelPic);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(350, 300);
			this.panel1.TabIndex = 0;
			// 
			// HORA
			// 
			this.HORA.AutoSize = true;
			this.HORA.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HORA.ForeColor = System.Drawing.Color.White;
			this.HORA.Location = new System.Drawing.Point(3, 271);
			this.HORA.Name = "HORA";
			this.HORA.Size = new System.Drawing.Size(52, 21);
			this.HORA.TabIndex = 1;
			this.HORA.Text = "label2";
			// 
			// horaactual
			// 
			this.horaactual.Enabled = true;
			// 
			// InicioSesion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 300);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "InicioSesion";
			this.Opacity = 0.9D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Clout-Link";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelPic)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolTip toolTipInfo;
		private System.Windows.Forms.Timer horaactual;
		private System.Windows.Forms.Label HORA;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.PictureBox btnSalir;
		private ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada Usuario;
		private ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada Contraseña;
		private ControlesPersonalizados.ControlesBonitos.BotonPerzonalizable btnIniciarSesion;
		private ControlesPersonalizados.ControlesBonitos.BotonPerzonalizable BtnRegistrarse;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox panelPic;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
	}
}
