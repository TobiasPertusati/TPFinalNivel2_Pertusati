namespace Interfaz
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.txtFiltroRapido = new System.Windows.Forms.TextBox();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.btnBusquedaFiltrada = new System.Windows.Forms.Button();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lbCampo = new System.Windows.Forms.Label();
            this.lbCriterio = new System.Windows.Forms.Label();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.txtFiltroDB = new System.Windows.Forms.TextBox();
            this.btnBusquedaDB = new System.Windows.Forms.Button();
            this.lbEncabezado = new System.Windows.Forms.Label();
            this.pnlBarraBotones = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.pnlBotonBuscarDB = new System.Windows.Forms.Panel();
            this.pnlBusquedaDB = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.pnlBarraBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.pnlBusquedaDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AllowUserToResizeColumns = false;
            this.dgvArticulos.AllowUserToResizeRows = false;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvArticulos.EnableHeadersVisualStyles = false;
            this.dgvArticulos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(200)))));
            this.dgvArticulos.Location = new System.Drawing.Point(143, 130);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgvArticulos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(810, 530);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnModificar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(3, 232);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(131, 32);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "     Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(3, 341);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 32);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "    Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVer
            // 
            this.btnVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnVer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(3, 449);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(131, 32);
            this.btnVer.TabIndex = 5;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // txtFiltroRapido
            // 
            this.txtFiltroRapido.BackColor = System.Drawing.Color.SeaShell;
            this.txtFiltroRapido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroRapido.Location = new System.Drawing.Point(212, 104);
            this.txtFiltroRapido.MaxLength = 50;
            this.txtFiltroRapido.Name = "txtFiltroRapido";
            this.txtFiltroRapido.Size = new System.Drawing.Size(229, 20);
            this.txtFiltroRapido.TabIndex = 6;
            this.txtFiltroRapido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbBuscar.Location = new System.Drawing.Point(143, 102);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(65, 21);
            this.lbBuscar.TabIndex = 7;
            this.lbBuscar.Text = "Buscar:";
            // 
            // btnBusquedaFiltrada
            // 
            this.btnBusquedaFiltrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusquedaFiltrada.FlatAppearance.BorderSize = 0;
            this.btnBusquedaFiltrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBusquedaFiltrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusquedaFiltrada.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnBusquedaFiltrada.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBusquedaFiltrada.Image = ((System.Drawing.Image)(resources.GetObject("btnBusquedaFiltrada.Image")));
            this.btnBusquedaFiltrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusquedaFiltrada.Location = new System.Drawing.Point(4, 554);
            this.btnBusquedaFiltrada.Name = "btnBusquedaFiltrada";
            this.btnBusquedaFiltrada.Size = new System.Drawing.Size(131, 32);
            this.btnBusquedaFiltrada.TabIndex = 8;
            this.btnBusquedaFiltrada.Text = "    Buscar";
            this.btnBusquedaFiltrada.UseVisualStyleBackColor = true;
            this.btnBusquedaFiltrada.Click += new System.EventHandler(this.btnBusquedaFiltrada_Click);
            // 
            // cboCampo
            // 
            this.cboCampo.BackColor = System.Drawing.Color.SeaShell;
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(82, 23);
            this.cboCampo.MaxDropDownItems = 4;
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(159, 21);
            this.cboCampo.TabIndex = 9;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.BackColor = System.Drawing.Color.SeaShell;
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(323, 24);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(159, 21);
            this.cboCriterio.TabIndex = 10;
            // 
            // lbCampo
            // 
            this.lbCampo.AutoSize = true;
            this.lbCampo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCampo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbCampo.Location = new System.Drawing.Point(2, 20);
            this.lbCampo.Name = "lbCampo";
            this.lbCampo.Size = new System.Drawing.Size(74, 21);
            this.lbCampo.TabIndex = 11;
            this.lbCampo.Text = "Campo:";
            // 
            // lbCriterio
            // 
            this.lbCriterio.AutoSize = true;
            this.lbCriterio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCriterio.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbCriterio.Location = new System.Drawing.Point(247, 22);
            this.lbCriterio.Name = "lbCriterio";
            this.lbCriterio.Size = new System.Drawing.Size(70, 21);
            this.lbCriterio.TabIndex = 12;
            this.lbCriterio.Text = "Criterio:";
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbFiltro.Location = new System.Drawing.Point(496, 23);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(50, 21);
            this.lbFiltro.TabIndex = 13;
            this.lbFiltro.Text = "Filtro:";
            // 
            // txtFiltroDB
            // 
            this.txtFiltroDB.BackColor = System.Drawing.Color.SeaShell;
            this.txtFiltroDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroDB.Location = new System.Drawing.Point(544, 24);
            this.txtFiltroDB.MaxLength = 50;
            this.txtFiltroDB.Name = "txtFiltroDB";
            this.txtFiltroDB.Size = new System.Drawing.Size(163, 20);
            this.txtFiltroDB.TabIndex = 14;
            this.txtFiltroDB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltroDB_KeyPress);
            // 
            // btnBusquedaDB
            // 
            this.btnBusquedaDB.FlatAppearance.BorderSize = 0;
            this.btnBusquedaDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBusquedaDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusquedaDB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaDB.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBusquedaDB.Location = new System.Drawing.Point(727, 16);
            this.btnBusquedaDB.Name = "btnBusquedaDB";
            this.btnBusquedaDB.Size = new System.Drawing.Size(89, 32);
            this.btnBusquedaDB.TabIndex = 15;
            this.btnBusquedaDB.Text = "Buscar";
            this.btnBusquedaDB.UseVisualStyleBackColor = true;
            this.btnBusquedaDB.Click += new System.EventHandler(this.btnBusquedaDB_Click);
            // 
            // lbEncabezado
            // 
            this.lbEncabezado.AutoSize = true;
            this.lbEncabezado.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEncabezado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbEncabezado.Location = new System.Drawing.Point(579, 9);
            this.lbEncabezado.Name = "lbEncabezado";
            this.lbEncabezado.Size = new System.Drawing.Size(415, 44);
            this.lbEncabezado.TabIndex = 17;
            this.lbEncabezado.Text = "Catalogo de Articulos";
            // 
            // pnlBarraBotones
            // 
            this.pnlBarraBotones.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlBarraBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnlBarraBotones.Controls.Add(this.panel5);
            this.pnlBarraBotones.Controls.Add(this.panel6);
            this.pnlBarraBotones.Controls.Add(this.panel4);
            this.pnlBarraBotones.Controls.Add(this.panel3);
            this.pnlBarraBotones.Controls.Add(this.panel2);
            this.pnlBarraBotones.Controls.Add(this.btnAdd);
            this.pnlBarraBotones.Controls.Add(this.btnModificar);
            this.pnlBarraBotones.Controls.Add(this.btnEliminar);
            this.pnlBarraBotones.Controls.Add(this.btnVer);
            this.pnlBarraBotones.Controls.Add(this.btnBusquedaFiltrada);
            this.pnlBarraBotones.Location = new System.Drawing.Point(1, 1);
            this.pnlBarraBotones.Name = "pnlBarraBotones";
            this.pnlBarraBotones.Size = new System.Drawing.Size(137, 729);
            this.pnlBarraBotones.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(-2, 449);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 32);
            this.panel5.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(-1, 554);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 32);
            this.panel6.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(-2, 341);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 32);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(-2, 232);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 32);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(-2, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 32);
            this.panel2.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(3, 129);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "   Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrescar.FlatAppearance.BorderSize = 0;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.Location = new System.Drawing.Point(443, 103);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(21, 21);
            this.btnRefrescar.TabIndex = 16;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(959, 202);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(384, 358);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 1;
            this.pbxImagen.TabStop = false;
            // 
            // pnlBotonBuscarDB
            // 
            this.pnlBotonBuscarDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.pnlBotonBuscarDB.Location = new System.Drawing.Point(724, 16);
            this.pnlBotonBuscarDB.Name = "pnlBotonBuscarDB";
            this.pnlBotonBuscarDB.Size = new System.Drawing.Size(5, 32);
            this.pnlBotonBuscarDB.TabIndex = 14;
            // 
            // pnlBusquedaDB
            // 
            this.pnlBusquedaDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnlBusquedaDB.Controls.Add(this.cboCampo);
            this.pnlBusquedaDB.Controls.Add(this.pnlBotonBuscarDB);
            this.pnlBusquedaDB.Controls.Add(this.cboCriterio);
            this.pnlBusquedaDB.Controls.Add(this.lbCampo);
            this.pnlBusquedaDB.Controls.Add(this.lbCriterio);
            this.pnlBusquedaDB.Controls.Add(this.lbFiltro);
            this.pnlBusquedaDB.Controls.Add(this.btnBusquedaDB);
            this.pnlBusquedaDB.Controls.Add(this.txtFiltroDB);
            this.pnlBusquedaDB.Location = new System.Drawing.Point(137, 666);
            this.pnlBusquedaDB.Name = "pnlBusquedaDB";
            this.pnlBusquedaDB.Size = new System.Drawing.Size(833, 64);
            this.pnlBusquedaDB.TabIndex = 20;
            this.pnlBusquedaDB.Visible = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(1351, 729);
            this.Controls.Add(this.pnlBusquedaDB);
            this.Controls.Add(this.lbEncabezado);
            this.Controls.Add(this.pnlBarraBotones);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.txtFiltroRapido);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.dgvArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1367, 768);
            this.MinimumSize = new System.Drawing.Size(1367, 768);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.pnlBarraBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.pnlBusquedaDB.ResumeLayout(false);
            this.pnlBusquedaDB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.TextBox txtFiltroRapido;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.Button btnBusquedaFiltrada;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label lbCampo;
        private System.Windows.Forms.Label lbCriterio;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.TextBox txtFiltroDB;
        private System.Windows.Forms.Button btnBusquedaDB;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Label lbEncabezado;
        private System.Windows.Forms.Panel pnlBarraBotones;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnlBotonBuscarDB;
        private System.Windows.Forms.Panel pnlBusquedaDB;
    }
}

