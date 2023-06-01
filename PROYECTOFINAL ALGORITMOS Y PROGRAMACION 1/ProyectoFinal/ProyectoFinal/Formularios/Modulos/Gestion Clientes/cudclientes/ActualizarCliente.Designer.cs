/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 17/05/2023
 * Hora: 05:27 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoFinal.Formularios.Modulos.Gestion_Clientes.cudclientes
{
	partial class ActualizarCliente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarCliente));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.nacimiento = new System.Windows.Forms.DateTimePicker();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.lblFechaingreso = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.correo = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.label12 = new System.Windows.Forms.Label();
			this.telefono = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.direccion = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.nroResidencia = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.panel6 = new System.Windows.Forms.Panel();
			this.apellido = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nombre = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.cedula = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel8);
			this.panel1.Controls.Add(this.panel7);
			this.panel1.Controls.Add(this.panel6);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(702, 485);
			this.panel1.TabIndex = 2;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel8.Controls.Add(this.label11);
			this.panel8.Controls.Add(this.nacimiento);
			this.panel8.Controls.Add(this.btnActualizar);
			this.panel8.Controls.Add(this.label10);
			this.panel8.Controls.Add(this.lblFechaingreso);
			this.panel8.Controls.Add(this.label8);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel8.Location = new System.Drawing.Point(228, 300);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(474, 450);
			this.panel8.TabIndex = 3;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(291, 59);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(152, 13);
			this.label11.TabIndex = 16;
			this.label11.Text = "Cliente Resgistrado el dia";
			// 
			// nacimiento
			// 
			this.nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.nacimiento.Location = new System.Drawing.Point(147, 52);
			this.nacimiento.Name = "nacimiento";
			this.nacimiento.Size = new System.Drawing.Size(97, 20);
			this.nacimiento.TabIndex = 17;
			// 
			// btnActualizar
			// 
			this.btnActualizar.BackColor = System.Drawing.Color.Teal;
			this.btnActualizar.FlatAppearance.BorderSize = 0;
			this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.ForeColor = System.Drawing.Color.White;
			this.btnActualizar.Location = new System.Drawing.Point(147, 130);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(195, 46);
			this.btnActualizar.TabIndex = 16;
			this.btnActualizar.Text = "Actualizar Datos";
			this.btnActualizar.UseVisualStyleBackColor = false;
			this.btnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(11, 52);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(109, 13);
			this.label10.TabIndex = 10;
			this.label10.Text = "Fecha Nacimiento";
			// 
			// lblFechaingreso
			// 
			this.lblFechaingreso.AutoSize = true;
			this.lblFechaingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaingreso.Location = new System.Drawing.Point(331, 89);
			this.lblFechaingreso.Name = "lblFechaingreso";
			this.lblFechaingreso.Size = new System.Drawing.Size(41, 13);
			this.lblFechaingreso.TabIndex = 14;
			this.lblFechaingreso.Text = "label9";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(189, 17);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(111, 19);
			this.label8.TabIndex = 13;
			this.label8.Text = "Otros Detalles";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel7.Controls.Add(this.correo);
			this.panel7.Controls.Add(this.label12);
			this.panel7.Controls.Add(this.telefono);
			this.panel7.Controls.Add(this.label4);
			this.panel7.Controls.Add(this.label6);
			this.panel7.Controls.Add(this.label9);
			this.panel7.Controls.Add(this.label7);
			this.panel7.Controls.Add(this.direccion);
			this.panel7.Controls.Add(this.nroResidencia);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(228, 150);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(474, 150);
			this.panel7.TabIndex = 2;
			// 
			// correo
			// 
			this.correo.BackColor = System.Drawing.Color.WhiteSmoke;
			this.correo.Barra = System.Windows.Forms.ScrollBars.None;
			this.correo.CaracterContraseña = false;
			this.correo.ColorBorde = System.Drawing.SystemColors.Highlight;
			this.correo.ColorEnfoque = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(47)))), ((int)(((byte)(222)))));
			this.correo.ColorMarcadorPosicion = System.Drawing.Color.Gray;
			this.correo.EstiloLinea = false;
			this.correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.correo.ForeColor = System.Drawing.Color.DimGray;
			this.correo.Location = new System.Drawing.Point(312, 41);
			this.correo.Margin = new System.Windows.Forms.Padding(4);
			this.correo.ModoLectura = false;
			this.correo.Multilinea = false;
			this.correo.Name = "correo";
			this.correo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.correo.RadioArcos = 15;
			this.correo.Size = new System.Drawing.Size(105, 31);
			this.correo.TabIndex = 15;
			this.correo.TamaBorde = 2;
			this.correo.TextoMarcadorPosicion = "";
			this.correo.Textos = "";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(241, 50);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(44, 13);
			this.label12.TabIndex = 14;
			this.label12.Text = "Correo";
			// 
			// telefono
			// 
			this.telefono.BackColor = System.Drawing.Color.WhiteSmoke;
			this.telefono.Barra = System.Windows.Forms.ScrollBars.None;
			this.telefono.CaracterContraseña = false;
			this.telefono.ColorBorde = System.Drawing.SystemColors.Highlight;
			this.telefono.ColorEnfoque = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(47)))), ((int)(((byte)(222)))));
			this.telefono.ColorMarcadorPosicion = System.Drawing.Color.Gray;
			this.telefono.EstiloLinea = false;
			this.telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.telefono.ForeColor = System.Drawing.Color.DimGray;
			this.telefono.Location = new System.Drawing.Point(312, 101);
			this.telefono.Margin = new System.Windows.Forms.Padding(4);
			this.telefono.ModoLectura = false;
			this.telefono.Multilinea = false;
			this.telefono.Name = "telefono";
			this.telefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.telefono.RadioArcos = 15;
			this.telefono.Size = new System.Drawing.Size(83, 31);
			this.telefono.TabIndex = 13;
			this.telefono.TamaBorde = 2;
			this.telefono.TextoMarcadorPosicion = "";
			this.telefono.Textos = "";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(164, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(149, 19);
			this.label4.TabIndex = 7;
			this.label4.Text = "Datos de contacto";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(243, 110);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Telefono";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(11, 50);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(61, 13);
			this.label9.TabIndex = 10;
			this.label9.Text = "Direccion";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(6, 110);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "Nro.Residencia";
			// 
			// direccion
			// 
			this.direccion.BackColor = System.Drawing.Color.WhiteSmoke;
			this.direccion.Barra = System.Windows.Forms.ScrollBars.None;
			this.direccion.CaracterContraseña = false;
			this.direccion.ColorBorde = System.Drawing.SystemColors.Highlight;
			this.direccion.ColorEnfoque = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(47)))), ((int)(((byte)(222)))));
			this.direccion.ColorMarcadorPosicion = System.Drawing.Color.Gray;
			this.direccion.EstiloLinea = false;
			this.direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.direccion.ForeColor = System.Drawing.Color.DimGray;
			this.direccion.Location = new System.Drawing.Point(109, 41);
			this.direccion.Margin = new System.Windows.Forms.Padding(4);
			this.direccion.ModoLectura = false;
			this.direccion.Multilinea = false;
			this.direccion.Name = "direccion";
			this.direccion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.direccion.RadioArcos = 15;
			this.direccion.Size = new System.Drawing.Size(107, 31);
			this.direccion.TabIndex = 8;
			this.direccion.TamaBorde = 2;
			this.direccion.TextoMarcadorPosicion = "";
			this.direccion.Textos = "";
			// 
			// nroResidencia
			// 
			this.nroResidencia.BackColor = System.Drawing.Color.WhiteSmoke;
			this.nroResidencia.Barra = System.Windows.Forms.ScrollBars.None;
			this.nroResidencia.CaracterContraseña = false;
			this.nroResidencia.ColorBorde = System.Drawing.SystemColors.Highlight;
			this.nroResidencia.ColorEnfoque = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(47)))), ((int)(((byte)(222)))));
			this.nroResidencia.ColorMarcadorPosicion = System.Drawing.Color.Gray;
			this.nroResidencia.EstiloLinea = false;
			this.nroResidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nroResidencia.ForeColor = System.Drawing.Color.DimGray;
			this.nroResidencia.Location = new System.Drawing.Point(109, 101);
			this.nroResidencia.Margin = new System.Windows.Forms.Padding(4);
			this.nroResidencia.ModoLectura = false;
			this.nroResidencia.Multilinea = false;
			this.nroResidencia.Name = "nroResidencia";
			this.nroResidencia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.nroResidencia.RadioArcos = 15;
			this.nroResidencia.Size = new System.Drawing.Size(73, 31);
			this.nroResidencia.TabIndex = 9;
			this.nroResidencia.TamaBorde = 2;
			this.nroResidencia.TextoMarcadorPosicion = "";
			this.nroResidencia.Textos = "";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel6.Controls.Add(this.apellido);
			this.panel6.Controls.Add(this.label5);
			this.panel6.Controls.Add(this.label3);
			this.panel6.Controls.Add(this.label2);
			this.panel6.Controls.Add(this.nombre);
			this.panel6.Controls.Add(this.cedula);
			this.panel6.Controls.Add(this.label1);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(228, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(474, 150);
			this.panel6.TabIndex = 1;
			// 
			// apellido
			// 
			this.apellido.BackColor = System.Drawing.Color.WhiteSmoke;
			this.apellido.Barra = System.Windows.Forms.ScrollBars.None;
			this.apellido.CaracterContraseña = false;
			this.apellido.ColorBorde = System.Drawing.SystemColors.Highlight;
			this.apellido.ColorEnfoque = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(47)))), ((int)(((byte)(222)))));
			this.apellido.ColorMarcadorPosicion = System.Drawing.Color.Gray;
			this.apellido.EstiloLinea = false;
			this.apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.apellido.ForeColor = System.Drawing.Color.DimGray;
			this.apellido.Location = new System.Drawing.Point(273, 103);
			this.apellido.Margin = new System.Windows.Forms.Padding(4);
			this.apellido.ModoLectura = false;
			this.apellido.Multilinea = false;
			this.apellido.Name = "apellido";
			this.apellido.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.apellido.RadioArcos = 15;
			this.apellido.Size = new System.Drawing.Size(83, 31);
			this.apellido.TabIndex = 7;
			this.apellido.TamaBorde = 2;
			this.apellido.TextoMarcadorPosicion = "";
			this.apellido.Textos = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(214, 112);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Apellido";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(18, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(22, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Cedula";
			// 
			// nombre
			// 
			this.nombre.BackColor = System.Drawing.Color.WhiteSmoke;
			this.nombre.Barra = System.Windows.Forms.ScrollBars.None;
			this.nombre.CaracterContraseña = false;
			this.nombre.ColorBorde = System.Drawing.SystemColors.Highlight;
			this.nombre.ColorEnfoque = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(47)))), ((int)(((byte)(222)))));
			this.nombre.ColorMarcadorPosicion = System.Drawing.Color.Gray;
			this.nombre.EstiloLinea = false;
			this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nombre.ForeColor = System.Drawing.Color.DimGray;
			this.nombre.Location = new System.Drawing.Point(75, 103);
			this.nombre.Margin = new System.Windows.Forms.Padding(4);
			this.nombre.ModoLectura = false;
			this.nombre.Multilinea = false;
			this.nombre.Name = "nombre";
			this.nombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.nombre.RadioArcos = 15;
			this.nombre.Size = new System.Drawing.Size(107, 31);
			this.nombre.TabIndex = 2;
			this.nombre.TamaBorde = 2;
			this.nombre.TextoMarcadorPosicion = "";
			this.nombre.Textos = "";
			// 
			// cedula
			// 
			this.cedula.BackColor = System.Drawing.Color.WhiteSmoke;
			this.cedula.Barra = System.Windows.Forms.ScrollBars.None;
			this.cedula.CaracterContraseña = false;
			this.cedula.ColorBorde = System.Drawing.SystemColors.Highlight;
			this.cedula.ColorEnfoque = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(47)))), ((int)(((byte)(222)))));
			this.cedula.ColorMarcadorPosicion = System.Drawing.Color.Gray;
			this.cedula.EstiloLinea = false;
			this.cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cedula.ForeColor = System.Drawing.Color.DimGray;
			this.cedula.Location = new System.Drawing.Point(79, 43);
			this.cedula.Margin = new System.Windows.Forms.Padding(4);
			this.cedula.ModoLectura = true;
			this.cedula.Multilinea = false;
			this.cedula.Name = "cedula";
			this.cedula.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.cedula.RadioArcos = 15;
			this.cedula.Size = new System.Drawing.Size(107, 31);
			this.cedula.TabIndex = 1;
			this.cedula.TamaBorde = 2;
			this.cedula.TextoMarcadorPosicion = "";
			this.cedula.Textos = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(164, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "DATOS FISCALES";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(228, 485);
			this.panel2.TabIndex = 0;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel5.Controls.Add(this.pictureBox3);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 300);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(228, 185);
			this.panel5.TabIndex = 2;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(12, 17);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(204, 159);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel4.Controls.Add(this.pictureBox2);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 150);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(228, 150);
			this.panel4.TabIndex = 1;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(12, 6);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(204, 138);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(228, 150);
			this.panel3.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(204, 134);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// ActualizarCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(702, 485);
			this.Controls.Add(this.panel1);
			this.MaximumSize = new System.Drawing.Size(718, 523);
			this.MinimumSize = new System.Drawing.Size(718, 523);
			this.Name = "ActualizarCliente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ActualizarCliente";
			this.panel1.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		public System.Windows.Forms.Label label11;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		public ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada cedula;
		public ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada nombre;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.Label label5;
		public ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada apellido;
		private System.Windows.Forms.Panel panel6;
		public ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada nroResidencia;
		public ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada direccion;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		public System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		public ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada telefono;
		public System.Windows.Forms.Label label12;
		public ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada correo;
		private System.Windows.Forms.Panel panel7;
		public System.Windows.Forms.Label label8;
		public System.Windows.Forms.Label lblFechaingreso;
		public System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnActualizar;
		public System.Windows.Forms.DateTimePicker nacimiento;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel1;
	}
}
