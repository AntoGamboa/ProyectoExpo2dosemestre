/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 06/05/2023
 * Hora: 07:00 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoFinal.Formularios.Modulos.Gestion_DVD
{
	partial class FormDvD
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDvD));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnRefrescar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnDesactivarProducto = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.btnDetallesProducto = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.btnActualizarProducto = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAgregarProducto = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.BuscarCodigo = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.BuscarNombre = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.BuscarTipo = new System.Windows.Forms.ComboBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.flowLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.flowLayoutPanel2);
			this.panel1.Controls.Add(this.flowLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(710, 462);
			this.panel1.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(11)))), ((int)(((byte)(250)))));
			this.panel3.Controls.Add(this.btnRefrescar);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.btnDesactivarProducto);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.btnDetallesProducto);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.btnActualizarProducto);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.btnAgregarProducto);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 388);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(710, 74);
			this.panel3.TabIndex = 3;
			// 
			// btnRefrescar
			// 
			this.btnRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRefrescar.FlatAppearance.BorderSize = 0;
			this.btnRefrescar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
			this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
			this.btnRefrescar.Location = new System.Drawing.Point(642, 3);
			this.btnRefrescar.Name = "btnRefrescar";
			this.btnRefrescar.Size = new System.Drawing.Size(56, 37);
			this.btnRefrescar.TabIndex = 9;
			this.btnRefrescar.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.DarkTurquoise;
			this.label6.Location = new System.Drawing.Point(642, 43);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 16);
			this.label6.TabIndex = 8;
			this.label6.Text = "Recargar";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.DarkTurquoise;
			this.label5.Location = new System.Drawing.Point(357, 44);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(126, 16);
			this.label5.TabIndex = 7;
			this.label5.Text = "Desactivar Producto";
			// 
			// btnDesactivarProducto
			// 
			this.btnDesactivarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDesactivarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDesactivarProducto.FlatAppearance.BorderSize = 0;
			this.btnDesactivarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
			this.btnDesactivarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDesactivarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnDesactivarProducto.Image")));
			this.btnDesactivarProducto.Location = new System.Drawing.Point(385, 4);
			this.btnDesactivarProducto.Name = "btnDesactivarProducto";
			this.btnDesactivarProducto.Size = new System.Drawing.Size(56, 37);
			this.btnDesactivarProducto.TabIndex = 6;
			this.btnDesactivarProducto.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.DarkTurquoise;
			this.label4.Location = new System.Drawing.Point(262, 44);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Ver Detalles";
			// 
			// btnDetallesProducto
			// 
			this.btnDetallesProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDetallesProducto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDetallesProducto.FlatAppearance.BorderSize = 0;
			this.btnDetallesProducto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
			this.btnDetallesProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDetallesProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnDetallesProducto.Image")));
			this.btnDetallesProducto.Location = new System.Drawing.Point(262, 4);
			this.btnDetallesProducto.Name = "btnDetallesProducto";
			this.btnDetallesProducto.Size = new System.Drawing.Size(56, 37);
			this.btnDetallesProducto.TabIndex = 4;
			this.btnDetallesProducto.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DarkTurquoise;
			this.label3.Location = new System.Drawing.Point(123, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Actualizar Producto";
			// 
			// btnActualizarProducto
			// 
			this.btnActualizarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnActualizarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnActualizarProducto.FlatAppearance.BorderSize = 0;
			this.btnActualizarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
			this.btnActualizarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnActualizarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarProducto.Image")));
			this.btnActualizarProducto.Location = new System.Drawing.Point(153, 4);
			this.btnActualizarProducto.Name = "btnActualizarProducto";
			this.btnActualizarProducto.Size = new System.Drawing.Size(56, 37);
			this.btnActualizarProducto.TabIndex = 2;
			this.btnActualizarProducto.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkTurquoise;
			this.label2.Location = new System.Drawing.Point(4, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 16);
			this.label2.TabIndex = 1;
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
			this.btnAgregarProducto.Location = new System.Drawing.Point(28, 4);
			this.btnAgregarProducto.Name = "btnAgregarProducto";
			this.btnAgregarProducto.Size = new System.Drawing.Size(56, 37);
			this.btnAgregarProducto.TabIndex = 0;
			this.btnAgregarProducto.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(11)))), ((int)(((byte)(250)))));
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 85);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(710, 377);
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
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(11)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeight = 18;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column3,
									this.Column4,
									this.Column5,
									this.Column6,
									this.Column7,
									this.Column8,
									this.Column9});
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = System.Drawing.Color.Black;
			this.dataGridView1.Location = new System.Drawing.Point(12, 6);
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
			this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.dataGridView1.Size = new System.Drawing.Size(686, 284);
			this.dataGridView1.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Codigo";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 69;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Titulo";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 62;
			// 
			// Column3
			// 
			this.Column3.FillWeight = 120F;
			this.Column3.HeaderText = "Emision";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 73;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Tipo de Medio";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 111;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Existencia";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 88;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Precio";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 66;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Fecha de Ingreso";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Width = 129;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "Prestamo";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.Width = 82;
			// 
			// Column9
			// 
			this.Column9.HeaderText = "Estado";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			this.Column9.Width = 69;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(11)))), ((int)(((byte)(250)))));
			this.flowLayoutPanel2.Controls.Add(this.BuscarCodigo);
			this.flowLayoutPanel2.Controls.Add(this.BuscarNombre);
			this.flowLayoutPanel2.Controls.Add(this.BuscarTipo);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 39);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(710, 46);
			this.flowLayoutPanel2.TabIndex = 1;
			// 
			// BuscarCodigo
			// 
			this.BuscarCodigo.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BuscarCodigo.Barra = System.Windows.Forms.ScrollBars.None;
			this.BuscarCodigo.CaracterContraseña = false;
			this.BuscarCodigo.ColorBorde = System.Drawing.Color.MediumSlateBlue;
			this.BuscarCodigo.ColorEnfoque = System.Drawing.Color.HotPink;
			this.BuscarCodigo.ColorMarcadorPosicion = System.Drawing.Color.Gray;
			this.BuscarCodigo.EstiloLinea = false;
			this.BuscarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BuscarCodigo.ForeColor = System.Drawing.Color.DimGray;
			this.BuscarCodigo.Location = new System.Drawing.Point(4, 4);
			this.BuscarCodigo.Margin = new System.Windows.Forms.Padding(4);
			this.BuscarCodigo.ModoLectura = false;
			this.BuscarCodigo.Multilinea = false;
			this.BuscarCodigo.Name = "BuscarCodigo";
			this.BuscarCodigo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.BuscarCodigo.RadioArcos = 5;
			this.BuscarCodigo.Size = new System.Drawing.Size(205, 31);
			this.BuscarCodigo.TabIndex = 0;
			this.BuscarCodigo.TamaBorde = 2;
			this.BuscarCodigo.TextoMarcadorPosicion = "Buscar por codigo";
			this.BuscarCodigo.Textos = "";
			// 
			// BuscarNombre
			// 
			this.BuscarNombre.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BuscarNombre.Barra = System.Windows.Forms.ScrollBars.None;
			this.BuscarNombre.CaracterContraseña = false;
			this.BuscarNombre.ColorBorde = System.Drawing.Color.MediumSlateBlue;
			this.BuscarNombre.ColorEnfoque = System.Drawing.Color.HotPink;
			this.BuscarNombre.ColorMarcadorPosicion = System.Drawing.Color.Gray;
			this.BuscarNombre.EstiloLinea = false;
			this.BuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BuscarNombre.ForeColor = System.Drawing.Color.DimGray;
			this.BuscarNombre.Location = new System.Drawing.Point(217, 4);
			this.BuscarNombre.Margin = new System.Windows.Forms.Padding(4);
			this.BuscarNombre.ModoLectura = false;
			this.BuscarNombre.Multilinea = false;
			this.BuscarNombre.Name = "BuscarNombre";
			this.BuscarNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.BuscarNombre.RadioArcos = 5;
			this.BuscarNombre.Size = new System.Drawing.Size(207, 31);
			this.BuscarNombre.TabIndex = 1;
			this.BuscarNombre.TamaBorde = 2;
			this.BuscarNombre.TextoMarcadorPosicion = "Buscar Por Nombre";
			this.BuscarNombre.Textos = "";
			// 
			// BuscarTipo
			// 
			this.BuscarTipo.FormattingEnabled = true;
			this.BuscarTipo.Location = new System.Drawing.Point(431, 3);
			this.BuscarTipo.Name = "BuscarTipo";
			this.BuscarTipo.Size = new System.Drawing.Size(136, 21);
			this.BuscarTipo.TabIndex = 2;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(11)))), ((int)(((byte)(250)))));
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(710, 39);
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
			this.label1.Size = new System.Drawing.Size(285, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Modulo Gestion DvD";
			// 
			// FormDvD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(710, 462);
			this.Controls.Add(this.panel1);
			this.Name = "FormDvD";
			this.Text = "FormDvD";
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnRefrescar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.ComboBox BuscarTipo;
		private System.Windows.Forms.Button btnDesactivarProducto;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnDetallesProducto;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnActualizarProducto;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAgregarProducto;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel2;
		private ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada BuscarNombre;
		private ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada BuscarCodigo;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
	}
}
