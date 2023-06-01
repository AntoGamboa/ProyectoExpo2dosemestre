/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 13/05/2023
 * Hora: 01:56 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoFinal.Formularios.Modulos.Gestion_Clientes
{
	partial class FormClientes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.BtnRefrescar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnDesactivarProducto = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.btnActualizarCliente = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnRegistrarCliente = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.BuscarCedula = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.BuscarNombre = new ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.panel1.Size = new System.Drawing.Size(724, 494);
			this.panel1.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(11)))), ((int)(((byte)(250)))));
			this.panel3.Controls.Add(this.BtnRefrescar);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.btnDesactivarProducto);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.btnActualizarCliente);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.btnRegistrarCliente);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 413);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(724, 81);
			this.panel3.TabIndex = 3;
			// 
			// BtnRefrescar
			// 
			this.BtnRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnRefrescar.FlatAppearance.BorderSize = 0;
			this.BtnRefrescar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
			this.BtnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefrescar.Image")));
			this.BtnRefrescar.Location = new System.Drawing.Point(656, 11);
			this.BtnRefrescar.Name = "BtnRefrescar";
			this.BtnRefrescar.Size = new System.Drawing.Size(56, 37);
			this.BtnRefrescar.TabIndex = 9;
			this.BtnRefrescar.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.DarkTurquoise;
			this.label4.Location = new System.Drawing.Point(656, 51);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "Recargar";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.DarkTurquoise;
			this.label5.Location = new System.Drawing.Point(261, 51);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(114, 16);
			this.label5.TabIndex = 7;
			this.label5.Text = "Desactivar Cliente";
			// 
			// btnDesactivarProducto
			// 
			this.btnDesactivarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDesactivarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDesactivarProducto.FlatAppearance.BorderSize = 0;
			this.btnDesactivarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
			this.btnDesactivarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDesactivarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnDesactivarProducto.Image")));
			this.btnDesactivarProducto.Location = new System.Drawing.Point(279, 11);
			this.btnDesactivarProducto.Name = "btnDesactivarProducto";
			this.btnDesactivarProducto.Size = new System.Drawing.Size(56, 37);
			this.btnDesactivarProducto.TabIndex = 6;
			this.btnDesactivarProducto.UseVisualStyleBackColor = true;
			this.btnDesactivarProducto.Click += new System.EventHandler(this.BtnDesactivarProductoClick);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DarkTurquoise;
			this.label3.Location = new System.Drawing.Point(135, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Actualizar Cliente";
			// 
			// btnActualizarCliente
			// 
			this.btnActualizarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnActualizarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnActualizarCliente.FlatAppearance.BorderSize = 0;
			this.btnActualizarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
			this.btnActualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnActualizarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarCliente.Image")));
			this.btnActualizarCliente.Location = new System.Drawing.Point(153, 11);
			this.btnActualizarCliente.Name = "btnActualizarCliente";
			this.btnActualizarCliente.Size = new System.Drawing.Size(56, 37);
			this.btnActualizarCliente.TabIndex = 2;
			this.btnActualizarCliente.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkTurquoise;
			this.label2.Location = new System.Drawing.Point(4, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Agregar Cliente";
			// 
			// btnRegistrarCliente
			// 
			this.btnRegistrarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnRegistrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegistrarCliente.FlatAppearance.BorderSize = 0;
			this.btnRegistrarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
			this.btnRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegistrarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarCliente.Image")));
			this.btnRegistrarCliente.Location = new System.Drawing.Point(23, 11);
			this.btnRegistrarCliente.Name = "btnRegistrarCliente";
			this.btnRegistrarCliente.Size = new System.Drawing.Size(56, 37);
			this.btnRegistrarCliente.TabIndex = 0;
			this.btnRegistrarCliente.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(11)))), ((int)(((byte)(250)))));
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 85);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(724, 409);
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
									this.Column7,
									this.Column8,
									this.Column10,
									this.Column9});
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(47)))), ((int)(((byte)(222)))));
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
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(47)))), ((int)(((byte)(222)))));
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.Size = new System.Drawing.Size(700, 316);
			this.dataGridView1.TabIndex = 0;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(11)))), ((int)(((byte)(250)))));
			this.flowLayoutPanel2.Controls.Add(this.BuscarCedula);
			this.flowLayoutPanel2.Controls.Add(this.BuscarNombre);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 39);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(724, 46);
			this.flowLayoutPanel2.TabIndex = 1;
			// 
			// BuscarCedula
			// 
			this.BuscarCedula.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BuscarCedula.Barra = System.Windows.Forms.ScrollBars.None;
			this.BuscarCedula.CaracterContraseña = false;
			this.BuscarCedula.ColorBorde = System.Drawing.Color.MediumSlateBlue;
			this.BuscarCedula.ColorEnfoque = System.Drawing.Color.HotPink;
			this.BuscarCedula.ColorMarcadorPosicion = System.Drawing.Color.Gray;
			this.BuscarCedula.EstiloLinea = false;
			this.BuscarCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BuscarCedula.ForeColor = System.Drawing.Color.DimGray;
			this.BuscarCedula.Location = new System.Drawing.Point(4, 4);
			this.BuscarCedula.Margin = new System.Windows.Forms.Padding(4);
			this.BuscarCedula.ModoLectura = false;
			this.BuscarCedula.Multilinea = false;
			this.BuscarCedula.Name = "BuscarCedula";
			this.BuscarCedula.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.BuscarCedula.RadioArcos = 5;
			this.BuscarCedula.Size = new System.Drawing.Size(205, 31);
			this.BuscarCedula.TabIndex = 0;
			this.BuscarCedula.TamaBorde = 2;
			this.BuscarCedula.TextoMarcadorPosicion = "Buscar por Cedula";
			this.BuscarCedula.Textos = "";
			this.BuscarCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuscarCedulaKeyPress);
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
			this.BuscarNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuscarNombreKeyPress);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(11)))), ((int)(((byte)(250)))));
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(724, 39);
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
			this.label1.Size = new System.Drawing.Size(332, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Modulo Gestion Clientes";
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Cedula";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 69;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Nombre";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 73;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Apellido";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 75;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Direccion";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 84;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Nro de Residencia";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 135;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Correo";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 67;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "nro.Tlfno";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Width = 81;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "Fecha de Nacimiento";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.Width = 150;
			// 
			// Column10
			// 
			this.Column10.HeaderText = "Fecha de Ingreso";
			this.Column10.Name = "Column10";
			this.Column10.ReadOnly = true;
			this.Column10.Width = 129;
			// 
			// Column9
			// 
			this.Column9.HeaderText = "Estado";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			this.Column9.Width = 69;
			// 
			// FormClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(724, 494);
			this.Controls.Add(this.panel1);
			this.Name = "FormClientes";
			this.Text = "FormClientes";
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
		private System.Windows.Forms.Button BtnRefrescar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada BuscarNombre;
		private ControlesPersonalizados.ControlesBonitos.TexBoxcostomizada BuscarCedula;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
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
		private System.Windows.Forms.Button btnRegistrarCliente;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnActualizarCliente;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnDesactivarProducto;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
	}
}
