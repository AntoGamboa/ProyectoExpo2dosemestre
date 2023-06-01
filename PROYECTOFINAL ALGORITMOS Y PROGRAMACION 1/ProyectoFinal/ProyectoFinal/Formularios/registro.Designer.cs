/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 30/04/2023
 * Hora: 10:00 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoFinal.Formularios
{
	partial class registro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registro));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.nombre = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.apellido = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.usuario = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.correo = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.contraseña = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.confirmarContraseña = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.btnRegistro = new System.Windows.Forms.Button();
			this.AceptarTerminos = new ControlesPersonalizados.ControlesBonitos.BotonActivacionBonito();
			this.label3 = new System.Windows.Forms.Label();
			this.btnsalir = new System.Windows.Forms.PictureBox();
			this.tootipAyuda = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnsalir)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SteelBlue;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(130, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(90, 108);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Registro";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(7, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Clout-link ";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-5, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Black;
			this.panel2.Location = new System.Drawing.Point(35, 541);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(286, 2);
			this.panel2.TabIndex = 1;
			// 
			// nombre
			// 
			this.nombre.BackColor = System.Drawing.Color.WhiteSmoke;
			this.nombre.CaracterContraseña = false;
			this.nombre.ColorBorde = System.Drawing.Color.Black;
			this.nombre.ColorEnfoque = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.nombre.ColorMarcadorPosicion = System.Drawing.Color.Gray;
			this.nombre.EstiloLinea = false;
			this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.nombre.Location = new System.Drawing.Point(46, 140);
			this.nombre.Margin = new System.Windows.Forms.Padding(4);
			this.nombre.Multilinea = false;
			this.nombre.Name = "nombre";
			this.nombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.nombre.RadioArcos = 10;
			this.nombre.Size = new System.Drawing.Size(117, 31);
			this.nombre.TabIndex = 2;
			this.nombre.TamaBorde = 2;
			this.nombre.TextoMarcadorPosicion = "Nombre";
			this.nombre.Textos = "";
			// 
			// apellido
			// 
			this.apellido.BackColor = System.Drawing.Color.WhiteSmoke;
			this.apellido.CaracterContraseña = false;
			this.apellido.ColorBorde = System.Drawing.Color.Black;
			this.apellido.ColorEnfoque = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.apellido.ColorMarcadorPosicion = System.Drawing.Color.Gray;
			this.apellido.EstiloLinea = false;
			this.apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.apellido.Location = new System.Drawing.Point(188, 140);
			this.apellido.Margin = new System.Windows.Forms.Padding(4);
			this.apellido.Multilinea = false;
			this.apellido.Name = "apellido";
			this.apellido.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.apellido.RadioArcos = 10;
			this.apellido.Size = new System.Drawing.Size(117, 31);
			this.apellido.TabIndex = 3;
			this.apellido.TamaBorde = 2;
			this.apellido.TextoMarcadorPosicion = "Apellido";
			this.apellido.Textos = "";
			// 
			// usuario
			// 
			this.usuario.BackColor = System.Drawing.Color.WhiteSmoke;
			this.usuario.CaracterContraseña = false;
			this.usuario.ColorBorde = System.Drawing.Color.Black;
			this.usuario.ColorEnfoque = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.usuario.ColorMarcadorPosicion = System.Drawing.Color.Gray;
			this.usuario.EstiloLinea = false;
			this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.usuario.Location = new System.Drawing.Point(46, 197);
			this.usuario.Margin = new System.Windows.Forms.Padding(4);
			this.usuario.Multilinea = false;
			this.usuario.Name = "usuario";
			this.usuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.usuario.RadioArcos = 10;
			this.usuario.Size = new System.Drawing.Size(259, 31);
			this.usuario.TabIndex = 4;
			this.usuario.TamaBorde = 2;
			this.usuario.TextoMarcadorPosicion = "Usuario";
			this.usuario.Textos = "";
			// 
			// correo
			// 
			this.correo.BackColor = System.Drawing.Color.WhiteSmoke;
			this.correo.CaracterContraseña = false;
			this.correo.ColorBorde = System.Drawing.Color.Black;
			this.correo.ColorEnfoque = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.correo.ColorMarcadorPosicion = System.Drawing.Color.Gray;
			this.correo.EstiloLinea = false;
			this.correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.correo.Location = new System.Drawing.Point(46, 249);
			this.correo.Margin = new System.Windows.Forms.Padding(4);
			this.correo.Multilinea = false;
			this.correo.Name = "correo";
			this.correo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.correo.RadioArcos = 10;
			this.correo.Size = new System.Drawing.Size(259, 31);
			this.correo.TabIndex = 5;
			this.correo.TamaBorde = 2;
			this.correo.TextoMarcadorPosicion = "CorreoElectronico";
			this.correo.Textos = "";
			// 
			// contraseña
			// 
			this.contraseña.BackColor = System.Drawing.Color.WhiteSmoke;
			this.contraseña.CaracterContraseña = true;
			this.contraseña.ColorBorde = System.Drawing.Color.Black;
			this.contraseña.ColorEnfoque = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.contraseña.ColorMarcadorPosicion = System.Drawing.Color.Gray;
			this.contraseña.EstiloLinea = false;
			this.contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.contraseña.Location = new System.Drawing.Point(46, 302);
			this.contraseña.Margin = new System.Windows.Forms.Padding(4);
			this.contraseña.Multilinea = false;
			this.contraseña.Name = "contraseña";
			this.contraseña.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.contraseña.RadioArcos = 10;
			this.contraseña.Size = new System.Drawing.Size(259, 31);
			this.contraseña.TabIndex = 6;
			this.contraseña.TamaBorde = 2;
			this.contraseña.TextoMarcadorPosicion = "Contraseña";
			this.contraseña.Textos = "";
			// 
			// confirmarContraseña
			// 
			this.confirmarContraseña.BackColor = System.Drawing.Color.WhiteSmoke;
			this.confirmarContraseña.CaracterContraseña = true;
			this.confirmarContraseña.ColorBorde = System.Drawing.Color.Black;
			this.confirmarContraseña.ColorEnfoque = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.confirmarContraseña.ColorMarcadorPosicion = System.Drawing.Color.Gray;
			this.confirmarContraseña.EstiloLinea = false;
			this.confirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.confirmarContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.confirmarContraseña.Location = new System.Drawing.Point(46, 354);
			this.confirmarContraseña.Margin = new System.Windows.Forms.Padding(4);
			this.confirmarContraseña.Multilinea = false;
			this.confirmarContraseña.Name = "confirmarContraseña";
			this.confirmarContraseña.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.confirmarContraseña.RadioArcos = 10;
			this.confirmarContraseña.Size = new System.Drawing.Size(259, 31);
			this.confirmarContraseña.TabIndex = 7;
			this.confirmarContraseña.TamaBorde = 2;
			this.confirmarContraseña.TextoMarcadorPosicion = "Confirmar Contraseña";
			this.confirmarContraseña.Textos = "";
			// 
			// btnRegistro
			// 
			this.btnRegistro.BackColor = System.Drawing.Color.Teal;
			this.btnRegistro.FlatAppearance.BorderSize = 0;
			this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegistro.Font = new System.Drawing.Font("Eurostile Extended", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistro.ForeColor = System.Drawing.Color.White;
			this.btnRegistro.Location = new System.Drawing.Point(46, 483);
			this.btnRegistro.Name = "btnRegistro";
			this.btnRegistro.Size = new System.Drawing.Size(259, 41);
			this.btnRegistro.TabIndex = 8;
			this.btnRegistro.Text = "Registrate";
			this.tootipAyuda.SetToolTip(this.btnRegistro, "Haz Click Para Registrarte");
			this.btnRegistro.UseVisualStyleBackColor = false;
			// 
			// AceptarTerminos
			// 
			this.AceptarTerminos.estilosolido = true;
			this.AceptarTerminos.fondoApagado = System.Drawing.Color.Gray;
			this.AceptarTerminos.fondoEncendido = System.Drawing.Color.DeepSkyBlue;
			this.AceptarTerminos.Location = new System.Drawing.Point(90, 412);
			this.AceptarTerminos.MinimumSize = new System.Drawing.Size(45, 22);
			this.AceptarTerminos.Name = "AceptarTerminos";
			this.AceptarTerminos.palancaApagada = System.Drawing.Color.Gainsboro;
			this.AceptarTerminos.PalancaEncendida = System.Drawing.Color.WhiteSmoke;
			this.AceptarTerminos.Size = new System.Drawing.Size(70, 25);
			this.AceptarTerminos.TabIndex = 9;
			this.AceptarTerminos.Text = "botonActivacionBonito1";
			this.tootipAyuda.SetToolTip(this.AceptarTerminos, "Haz Click Para Aceptar Los Terminos ");
			this.AceptarTerminos.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(166, 412);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 45);
			this.label3.TabIndex = 10;
			this.label3.Text = "Acepto los terminos y condiciones del servicio";
			// 
			// btnsalir
			// 
			this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
			this.btnsalir.Location = new System.Drawing.Point(319, 569);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(30, 30);
			this.btnsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnsalir.TabIndex = 11;
			this.btnsalir.TabStop = false;
			this.tootipAyuda.SetToolTip(this.btnsalir, "Haz click Para Salir ");
			// 
			// registro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(350, 600);
			this.Controls.Add(this.btnsalir);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.AceptarTerminos);
			this.Controls.Add(this.btnRegistro);
			this.Controls.Add(this.confirmarContraseña);
			this.Controls.Add(this.contraseña);
			this.Controls.Add(this.correo);
			this.Controls.Add(this.usuario);
			this.Controls.Add(this.apellido);
			this.Controls.Add(this.nombre);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "registro";
			this.Opacity = 0.9D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "registro";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnsalir)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox btnsalir;
		private System.Windows.Forms.ToolTip tootipAyuda;
		private System.Windows.Forms.Label label3;
		private ControlesPersonalizados.ControlesBonitos.BotonActivacionBonito AceptarTerminos;
		private System.Windows.Forms.Button btnRegistro;
		private ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada confirmarContraseña;
		private ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada contraseña;
		private ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada correo;
		private ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada usuario;
		private ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada apellido;
		private ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada nombre;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		
		
	}
}
