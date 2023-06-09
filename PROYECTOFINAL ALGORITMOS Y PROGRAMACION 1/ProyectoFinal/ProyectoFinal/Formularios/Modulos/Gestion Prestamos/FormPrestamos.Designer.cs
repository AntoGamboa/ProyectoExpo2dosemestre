/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 20/05/2023
 * Hora: 04:15 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoFinal.Formularios.Modulos.Gestion_Prestamos
{
	partial class FormPrestamos
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrestamos));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.direccion = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.apellido = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.nombre = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.BuscarDClientes = new System.Windows.Forms.Button();
			this.Cedula = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.btnGenerarVenta = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAgregarProducto = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.flowLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(758, 518);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(11)))), ((int)(((byte)(250)))));
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 118);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(758, 326);
			this.panel2.TabIndex = 2;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(11)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeight = 20;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column3,
									this.Column4,
									this.Column5,
									this.Column6,
									this.Column7});
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(47)))), ((int)(((byte)(222)))));
			this.dataGridView1.Location = new System.Drawing.Point(12, 10);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(11)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(47)))), ((int)(((byte)(222)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.Size = new System.Drawing.Size(734, 306);
			this.dataGridView1.TabIndex = 2;
			// 
			// Column1
			// 
			this.Column1.FillWeight = 71.68831F;
			this.Column1.HeaderText = "Codigo";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.FillWeight = 67.53922F;
			this.Column2.HeaderText = "Titulo";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.FillWeight = 127.1738F;
			this.Column3.HeaderText = "Tipo de Medio";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.FillWeight = 73.65768F;
			this.Column4.HeaderText = "Precio";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.FillWeight = 146.6092F;
			this.Column5.HeaderText = "Fecha de entega";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.FillWeight = 147.076F;
			this.Column6.HeaderText = "Fecha Devolucion";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column7
			// 
			this.Column7.FillWeight = 86.25574F;
			this.Column7.HeaderText = "Cantidad";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(11)))), ((int)(((byte)(250)))));
			this.panel4.Controls.Add(this.direccion);
			this.panel4.Controls.Add(this.apellido);
			this.panel4.Controls.Add(this.nombre);
			this.panel4.Controls.Add(this.BuscarDClientes);
			this.panel4.Controls.Add(this.Cedula);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 39);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(758, 79);
			this.panel4.TabIndex = 4;
			// 
			// direccion
			// 
			this.direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(11)))), ((int)(((byte)(250)))));
			this.direccion.Barra = System.Windows.Forms.ScrollBars.None;
			this.direccion.CaracterContraseña = false;
			this.direccion.ColorBorde = System.Drawing.Color.GhostWhite;
			this.direccion.ColorEnfoque = System.Drawing.Color.HotPink;
			this.direccion.ColorMarcadorPosicion = System.Drawing.Color.Gray;
			this.direccion.EstiloLinea = true;
			this.direccion.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.direccion.ForeColor = System.Drawing.Color.White;
			this.direccion.Location = new System.Drawing.Point(270, 43);
			this.direccion.Margin = new System.Windows.Forms.Padding(4);
			this.direccion.ModoLectura = true;
			this.direccion.Multilinea = false;
			this.direccion.Name = "direccion";
			this.direccion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.direccion.RadioArcos = 0;
			this.direccion.Size = new System.Drawing.Size(129, 34);
			this.direccion.TabIndex = 15;
			this.direccion.TamaBorde = 3;
			this.direccion.TextoMarcadorPosicion = "";
			this.direccion.Textos = "";
			// 
			// apellido
			// 
			this.apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(11)))), ((int)(((byte)(250)))));
			this.apellido.Barra = System.Windows.Forms.ScrollBars.None;
			this.apellido.CaracterContraseña = false;
			this.apellido.ColorBorde = System.Drawing.Color.GhostWhite;
			this.apellido.ColorEnfoque = System.Drawing.Color.HotPink;
			this.apellido.ColorMarcadorPosicion = System.Drawing.Color.Gray;
			this.apellido.EstiloLinea = true;
			this.apellido.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.apellido.ForeColor = System.Drawing.Color.White;
			this.apellido.Location = new System.Drawing.Point(133, 43);
			this.apellido.Margin = new System.Windows.Forms.Padding(4);
			this.apellido.ModoLectura = true;
			this.apellido.Multilinea = false;
			this.apellido.Name = "apellido";
			this.apellido.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.apellido.RadioArcos = 0;
			this.apellido.Size = new System.Drawing.Size(129, 34);
			this.apellido.TabIndex = 14;
			this.apellido.TamaBorde = 3;
			this.apellido.TextoMarcadorPosicion = "";
			this.apellido.Textos = "";
			// 
			// nombre
			// 
			this.nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(11)))), ((int)(((byte)(250)))));
			this.nombre.Barra = System.Windows.Forms.ScrollBars.None;
			this.nombre.CaracterContraseña = false;
			this.nombre.ColorBorde = System.Drawing.Color.GhostWhite;
			this.nombre.ColorEnfoque = System.Drawing.Color.HotPink;
			this.nombre.ColorMarcadorPosicion = System.Drawing.Color.Gray;
			this.nombre.EstiloLinea = true;
			this.nombre.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nombre.ForeColor = System.Drawing.Color.White;
			this.nombre.Location = new System.Drawing.Point(12, 43);
			this.nombre.Margin = new System.Windows.Forms.Padding(4);
			this.nombre.ModoLectura = true;
			this.nombre.Multilinea = false;
			this.nombre.Name = "nombre";
			this.nombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.nombre.RadioArcos = 0;
			this.nombre.Size = new System.Drawing.Size(104, 34);
			this.nombre.TabIndex = 13;
			this.nombre.TamaBorde = 3;
			this.nombre.TextoMarcadorPosicion = "";
			this.nombre.Textos = "";
			// 
			// BuscarDClientes
			// 
			this.BuscarDClientes.BackColor = System.Drawing.Color.Teal;
			this.BuscarDClientes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BuscarDClientes.FlatAppearance.BorderSize = 0;
			this.BuscarDClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BuscarDClientes.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BuscarDClientes.ForeColor = System.Drawing.Color.White;
			this.BuscarDClientes.Location = new System.Drawing.Point(166, 13);
			this.BuscarDClientes.Name = "BuscarDClientes";
			this.BuscarDClientes.Size = new System.Drawing.Size(96, 33);
			this.BuscarDClientes.TabIndex = 12;
			this.BuscarDClientes.Text = "Buscar";
			this.BuscarDClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BuscarDClientes.UseVisualStyleBackColor = false;
			// 
			// Cedula
			// 
			this.Cedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(11)))), ((int)(((byte)(250)))));
			this.Cedula.Barra = System.Windows.Forms.ScrollBars.None;
			this.Cedula.CaracterContraseña = false;
			this.Cedula.ColorBorde = System.Drawing.Color.MediumSlateBlue;
			this.Cedula.ColorEnfoque = System.Drawing.Color.HotPink;
			this.Cedula.ColorMarcadorPosicion = System.Drawing.Color.Gray;
			this.Cedula.EstiloLinea = true;
			this.Cedula.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Cedula.ForeColor = System.Drawing.Color.White;
			this.Cedula.Location = new System.Drawing.Point(12, 4);
			this.Cedula.Margin = new System.Windows.Forms.Padding(4);
			this.Cedula.ModoLectura = false;
			this.Cedula.Multilinea = false;
			this.Cedula.Name = "Cedula";
			this.Cedula.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.Cedula.RadioArcos = 0;
			this.Cedula.Size = new System.Drawing.Size(129, 34);
			this.Cedula.TabIndex = 11;
			this.Cedula.TamaBorde = 2;
			this.Cedula.TextoMarcadorPosicion = "Cedula";
			this.Cedula.Textos = "";

			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(11)))), ((int)(((byte)(250)))));
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.btnEliminar);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.btnGenerarVenta);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.btnAgregarProducto);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 444);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(758, 74);
			this.panel3.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.DarkTurquoise;
			this.label6.Location = new System.Drawing.Point(247, 53);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(111, 16);
			this.label6.TabIndex = 17;
			this.label6.Text = "eliminar Prodcuto";
			// 
			// btnEliminar
			// 
			this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.Location = new System.Drawing.Point(260, 13);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(56, 37);
			this.btnEliminar.TabIndex = 16;
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DarkTurquoise;
			this.label3.Location = new System.Drawing.Point(135, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 16);
			this.label3.TabIndex = 15;
			this.label3.Text = "Generar Factura";
			// 
			// btnGenerarVenta
			// 
			this.btnGenerarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnGenerarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGenerarVenta.Enabled = false;
			this.btnGenerarVenta.FlatAppearance.BorderSize = 0;
			this.btnGenerarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
			this.btnGenerarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGenerarVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarVenta.Image")));
			this.btnGenerarVenta.Location = new System.Drawing.Point(148, 13);
			this.btnGenerarVenta.Name = "btnGenerarVenta";
			this.btnGenerarVenta.Size = new System.Drawing.Size(56, 37);
			this.btnGenerarVenta.TabIndex = 14;
			this.btnGenerarVenta.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkTurquoise;
			this.label2.Location = new System.Drawing.Point(16, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 16);
			this.label2.TabIndex = 13;
			this.label2.Text = "Agregar Prodcuto";
			// 
			// btnAgregarProducto
			// 
			this.btnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
			this.btnAgregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
			this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.Image")));
			this.btnAgregarProducto.Location = new System.Drawing.Point(40, 13);
			this.btnAgregarProducto.Name = "btnAgregarProducto";
			this.btnAgregarProducto.Size = new System.Drawing.Size(56, 37);
			this.btnAgregarProducto.TabIndex = 12;
			this.btnAgregarProducto.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Yellow;
			this.label7.Location = new System.Drawing.Point(728, 31);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(18, 18);
			this.label7.TabIndex = 11;
			this.label7.Text = "$";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Yellow;
			this.label5.Location = new System.Drawing.Point(706, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(16, 18);
			this.label5.TabIndex = 10;
			this.label5.Text = "0";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Yellow;
			this.label4.Location = new System.Drawing.Point(630, 29);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 21);
			this.label4.TabIndex = 9;
			this.label4.Text = "Monto:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(11)))), ((int)(((byte)(250)))));
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(758, 39);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(260, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Modulo Prestamos";
			// 
			// FormPrestamos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(758, 518);
			this.Controls.Add(this.panel1);
			this.Name = "FormPrestamos";
			this.Text = "FormPrestamos";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnAgregarProducto;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Label label6;
		private ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada Cedula;
		private System.Windows.Forms.Button BuscarDClientes;
		private ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada nombre;
		private ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada apellido;
		private ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada direccion;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.Button btnGenerarVenta;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
		
		
	}
}
