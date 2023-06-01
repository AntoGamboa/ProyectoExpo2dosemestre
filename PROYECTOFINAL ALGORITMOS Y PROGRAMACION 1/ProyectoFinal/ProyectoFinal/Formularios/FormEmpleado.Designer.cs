/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 03/05/2023
 * Hora: 05:03 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoFinal.Formularios
{
	partial class FormEmpleado
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleado));
			this.panel1 = new System.Windows.Forms.Panel();
			this.PanelFormularios = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panelMenu = new System.Windows.Forms.Panel();
			this.btnImportar = new System.Windows.Forms.Button();
			this.btnexportar = new System.Windows.Forms.Button();
			this.btnIngresos = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnProductosPrestado = new System.Windows.Forms.Button();
			this.btnGestionPrestamos = new System.Windows.Forms.Button();
			this.btnGestionClientes = new System.Windows.Forms.Button();
			this.btnGestionDvD = new System.Windows.Forms.Button();
			this.pneltitulo = new System.Windows.Forms.Panel();
			this.btnminimizar = new System.Windows.Forms.PictureBox();
			this.btnmenu = new System.Windows.Forms.PictureBox();
			this.btnsalir = new System.Windows.Forms.PictureBox();
			this.btnocultar = new System.Windows.Forms.PictureBox();
			this.btnmaximizar = new System.Windows.Forms.PictureBox();
			this.Fecha = new System.Windows.Forms.Timer(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.panel1.SuspendLayout();
			this.PanelFormularios.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panelMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.pneltitulo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnmenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnsalir)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnocultar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.PanelFormularios);
			this.panel1.Controls.Add(this.panelMenu);
			this.panel1.Controls.Add(this.pneltitulo);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(964, 594);
			this.panel1.TabIndex = 0;
			// 
			// PanelFormularios
			// 
			this.PanelFormularios.BackColor = System.Drawing.SystemColors.Control;
			this.PanelFormularios.Controls.Add(this.label2);
			this.PanelFormularios.Controls.Add(this.label1);
			this.PanelFormularios.Controls.Add(this.pictureBox2);
			this.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelFormularios.Location = new System.Drawing.Point(190, 38);
			this.PanelFormularios.Name = "PanelFormularios";
			this.PanelFormularios.Size = new System.Drawing.Size(774, 556);
			this.PanelFormularios.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(43)))), ((int)(((byte)(246)))));
			this.label2.Location = new System.Drawing.Point(298, 266);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 29);
			this.label2.TabIndex = 2;
			this.label2.Text = "label2";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(43)))), ((int)(((byte)(246)))));
			this.label1.Location = new System.Drawing.Point(178, 233);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(280, 95);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(231, 104);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.panelMenu.Controls.Add(this.btnImportar);
			this.panelMenu.Controls.Add(this.btnexportar);
			this.panelMenu.Controls.Add(this.btnIngresos);
			this.panelMenu.Controls.Add(this.pictureBox1);
			this.panelMenu.Controls.Add(this.btnProductosPrestado);
			this.panelMenu.Controls.Add(this.btnGestionPrestamos);
			this.panelMenu.Controls.Add(this.btnGestionClientes);
			this.panelMenu.Controls.Add(this.btnGestionDvD);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 38);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(190, 556);
			this.panelMenu.TabIndex = 2;
			// 
			// btnImportar
			// 
			this.btnImportar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnImportar.FlatAppearance.BorderSize = 0;
			this.btnImportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(27)))), ((int)(((byte)(222)))));
			this.btnImportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(47)))), ((int)(((byte)(222)))));
			this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnImportar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImportar.ForeColor = System.Drawing.Color.White;
			this.btnImportar.Image = ((System.Drawing.Image)(resources.GetObject("btnImportar.Image")));
			this.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnImportar.Location = new System.Drawing.Point(0, 495);
			this.btnImportar.Name = "btnImportar";
			this.btnImportar.Size = new System.Drawing.Size(190, 49);
			this.btnImportar.TabIndex = 7;
			this.btnImportar.Text = "Importar BD";
			this.btnImportar.UseVisualStyleBackColor = true;
			// 
			// btnexportar
			// 
			this.btnexportar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnexportar.FlatAppearance.BorderSize = 0;
			this.btnexportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(27)))), ((int)(((byte)(222)))));
			this.btnexportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(47)))), ((int)(((byte)(222)))));
			this.btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnexportar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnexportar.ForeColor = System.Drawing.Color.White;
			this.btnexportar.Image = ((System.Drawing.Image)(resources.GetObject("btnexportar.Image")));
			this.btnexportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnexportar.Location = new System.Drawing.Point(0, 432);
			this.btnexportar.Name = "btnexportar";
			this.btnexportar.Size = new System.Drawing.Size(190, 49);
			this.btnexportar.TabIndex = 6;
			this.btnexportar.Text = "Exportar BD";
			this.btnexportar.UseVisualStyleBackColor = true;
			// 
			// btnIngresos
			// 
			this.btnIngresos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnIngresos.FlatAppearance.BorderSize = 0;
			this.btnIngresos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(27)))), ((int)(((byte)(222)))));
			this.btnIngresos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(47)))), ((int)(((byte)(222)))));
			this.btnIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIngresos.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngresos.ForeColor = System.Drawing.Color.White;
			this.btnIngresos.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresos.Image")));
			this.btnIngresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnIngresos.Location = new System.Drawing.Point(0, 368);
			this.btnIngresos.Name = "btnIngresos";
			this.btnIngresos.Size = new System.Drawing.Size(190, 49);
			this.btnIngresos.TabIndex = 5;
			this.btnIngresos.Text = "Ingresos";
			this.btnIngresos.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(184, 69);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnProductosPrestado
			// 
			this.btnProductosPrestado.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnProductosPrestado.FlatAppearance.BorderSize = 0;
			this.btnProductosPrestado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(27)))), ((int)(((byte)(222)))));
			this.btnProductosPrestado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(47)))), ((int)(((byte)(222)))));
			this.btnProductosPrestado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProductosPrestado.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProductosPrestado.ForeColor = System.Drawing.Color.White;
			this.btnProductosPrestado.Image = ((System.Drawing.Image)(resources.GetObject("btnProductosPrestado.Image")));
			this.btnProductosPrestado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProductosPrestado.Location = new System.Drawing.Point(0, 302);
			this.btnProductosPrestado.Name = "btnProductosPrestado";
			this.btnProductosPrestado.Size = new System.Drawing.Size(190, 49);
			this.btnProductosPrestado.TabIndex = 4;
			this.btnProductosPrestado.Text = "Producto Pendientes";
			this.btnProductosPrestado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnProductosPrestado.UseVisualStyleBackColor = true;
			// 
			// btnGestionPrestamos
			// 
			this.btnGestionPrestamos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGestionPrestamos.FlatAppearance.BorderSize = 0;
			this.btnGestionPrestamos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(27)))), ((int)(((byte)(222)))));
			this.btnGestionPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(47)))), ((int)(((byte)(222)))));
			this.btnGestionPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGestionPrestamos.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGestionPrestamos.ForeColor = System.Drawing.Color.White;
			this.btnGestionPrestamos.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionPrestamos.Image")));
			this.btnGestionPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGestionPrestamos.Location = new System.Drawing.Point(0, 233);
			this.btnGestionPrestamos.Name = "btnGestionPrestamos";
			this.btnGestionPrestamos.Size = new System.Drawing.Size(190, 49);
			this.btnGestionPrestamos.TabIndex = 3;
			this.btnGestionPrestamos.Text = "Prestamos";
			this.btnGestionPrestamos.UseVisualStyleBackColor = true;
			// 
			// btnGestionClientes
			// 
			this.btnGestionClientes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGestionClientes.FlatAppearance.BorderSize = 0;
			this.btnGestionClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(27)))), ((int)(((byte)(222)))));
			this.btnGestionClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(47)))), ((int)(((byte)(222)))));
			this.btnGestionClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGestionClientes.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGestionClientes.ForeColor = System.Drawing.Color.White;
			this.btnGestionClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionClientes.Image")));
			this.btnGestionClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGestionClientes.Location = new System.Drawing.Point(0, 162);
			this.btnGestionClientes.Name = "btnGestionClientes";
			this.btnGestionClientes.Size = new System.Drawing.Size(190, 49);
			this.btnGestionClientes.TabIndex = 2;
			this.btnGestionClientes.Text = "Clientes";
			this.btnGestionClientes.UseVisualStyleBackColor = true;
			// 
			// btnGestionDvD
			// 
			this.btnGestionDvD.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGestionDvD.FlatAppearance.BorderSize = 0;
			this.btnGestionDvD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(27)))), ((int)(((byte)(222)))));
			this.btnGestionDvD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(47)))), ((int)(((byte)(222)))));
			this.btnGestionDvD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGestionDvD.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGestionDvD.ForeColor = System.Drawing.Color.White;
			this.btnGestionDvD.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionDvD.Image")));
			this.btnGestionDvD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGestionDvD.Location = new System.Drawing.Point(0, 95);
			this.btnGestionDvD.Name = "btnGestionDvD";
			this.btnGestionDvD.Size = new System.Drawing.Size(190, 49);
			this.btnGestionDvD.TabIndex = 1;
			this.btnGestionDvD.Text = "Gestion DVD";
			this.btnGestionDvD.UseVisualStyleBackColor = true;
			// 
			// pneltitulo
			// 
			this.pneltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(111)))), ((int)(((byte)(250)))));
			this.pneltitulo.Controls.Add(this.btnminimizar);
			this.pneltitulo.Controls.Add(this.btnmenu);
			this.pneltitulo.Controls.Add(this.btnsalir);
			this.pneltitulo.Controls.Add(this.btnocultar);
			this.pneltitulo.Controls.Add(this.btnmaximizar);
			this.pneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pneltitulo.Location = new System.Drawing.Point(0, 0);
			this.pneltitulo.Name = "pneltitulo";
			this.pneltitulo.Size = new System.Drawing.Size(964, 38);
			this.pneltitulo.TabIndex = 3;
			// 
			// btnminimizar
			// 
			this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnminimizar.ErrorImage = null;
			this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
			this.btnminimizar.Location = new System.Drawing.Point(885, 10);
			this.btnminimizar.Name = "btnminimizar";
			this.btnminimizar.Size = new System.Drawing.Size(25, 25);
			this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnminimizar.TabIndex = 0;
			this.btnminimizar.TabStop = false;
			this.btnminimizar.Visible = false;
			// 
			// btnmenu
			// 
			this.btnmenu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnmenu.Image = ((System.Drawing.Image)(resources.GetObject("btnmenu.Image")));
			this.btnmenu.Location = new System.Drawing.Point(3, 5);
			this.btnmenu.Name = "btnmenu";
			this.btnmenu.Size = new System.Drawing.Size(53, 30);
			this.btnmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnmenu.TabIndex = 1;
			this.btnmenu.TabStop = false;
			// 
			// btnsalir
			// 
			this.btnsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
			this.btnsalir.Location = new System.Drawing.Point(927, 8);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(25, 25);
			this.btnsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnsalir.TabIndex = 0;
			this.btnsalir.TabStop = false;
			// 
			// btnocultar
			// 
			this.btnocultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnocultar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnocultar.Image = ((System.Drawing.Image)(resources.GetObject("btnocultar.Image")));
			this.btnocultar.Location = new System.Drawing.Point(844, 10);
			this.btnocultar.Name = "btnocultar";
			this.btnocultar.Size = new System.Drawing.Size(25, 25);
			this.btnocultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnocultar.TabIndex = 0;
			this.btnocultar.TabStop = false;
			// 
			// btnmaximizar
			// 
			this.btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnmaximizar.Image")));
			this.btnmaximizar.Location = new System.Drawing.Point(885, 10);
			this.btnmaximizar.Name = "btnmaximizar";
			this.btnmaximizar.Size = new System.Drawing.Size(25, 25);
			this.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnmaximizar.TabIndex = 0;
			this.btnmaximizar.TabStop = false;
			// 
			// Fecha
			// 
			this.Fecha.Enabled = true;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// FormEmpleado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(964, 594);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormEmpleado";
			this.Opacity = 0.9D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormEmpleado";
			this.panel1.ResumeLayout(false);
			this.PanelFormularios.ResumeLayout(false);
			this.PanelFormularios.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panelMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.pneltitulo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnmenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnsalir)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnocultar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Button btnImportar;
		private System.Windows.Forms.Button btnexportar;
		private System.Windows.Forms.Button btnIngresos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Timer Fecha;
		private System.Windows.Forms.Button btnGestionPrestamos;
		private System.Windows.Forms.Button btnProductosPrestado;
		private System.Windows.Forms.Button btnGestionClientes;
		private System.Windows.Forms.Button btnGestionDvD;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.PictureBox btnmenu;
		private System.Windows.Forms.PictureBox btnminimizar;
		private System.Windows.Forms.PictureBox btnsalir;
		private System.Windows.Forms.PictureBox btnmaximizar;
		private System.Windows.Forms.PictureBox btnocultar;
		private System.Windows.Forms.Panel PanelFormularios;
		private System.Windows.Forms.Panel pneltitulo;
		private System.Windows.Forms.Panel panel1;
	}
}
