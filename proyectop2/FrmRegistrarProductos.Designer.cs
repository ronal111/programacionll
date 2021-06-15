
namespace proyectop2
{
    partial class FrmRegistrarProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbreprod = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.cboxest = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblfkmarca = new System.Windows.Forms.Label();
            this.cbocproveedor = new System.Windows.Forms.ComboBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.ibtañadirmarca = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.cboxmodelo = new System.Windows.Forms.ComboBox();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtventa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpreciocompra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnombreproducto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboxmarca = new System.Windows.Forms.ComboBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.cboxcat = new System.Windows.Forms.ComboBox();
            this.lblest = new System.Windows.Forms.Label();
            this.txtproductocodigo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.mostarprodutos = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbreprod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gbreprod
            // 
            this.gbreprod.Controls.Add(this.btnActualizar);
            this.gbreprod.Controls.Add(this.cboxest);
            this.gbreprod.Controls.Add(this.label1);
            this.gbreprod.Controls.Add(this.lblfkmarca);
            this.gbreprod.Controls.Add(this.cbocproveedor);
            this.gbreprod.Controls.Add(this.iconButton2);
            this.gbreprod.Controls.Add(this.ibtañadirmarca);
            this.gbreprod.Controls.Add(this.iconButton3);
            this.gbreprod.Controls.Add(this.cboxmodelo);
            this.gbreprod.Controls.Add(this.btncancelar);
            this.gbreprod.Controls.Add(this.label2);
            this.gbreprod.Controls.Add(this.btnGuardar);
            this.gbreprod.Controls.Add(this.label3);
            this.gbreprod.Controls.Add(this.label4);
            this.gbreprod.Controls.Add(this.txtventa);
            this.gbreprod.Controls.Add(this.label5);
            this.gbreprod.Controls.Add(this.txtpreciocompra);
            this.gbreprod.Controls.Add(this.label6);
            this.gbreprod.Controls.Add(this.txtcolor);
            this.gbreprod.Controls.Add(this.label7);
            this.gbreprod.Controls.Add(this.txtnombreproducto);
            this.gbreprod.Controls.Add(this.label12);
            this.gbreprod.Controls.Add(this.label13);
            this.gbreprod.Controls.Add(this.cboxmarca);
            this.gbreprod.Controls.Add(this.numericUpDown2);
            this.gbreprod.Controls.Add(this.cboxcat);
            this.gbreprod.Controls.Add(this.lblest);
            this.gbreprod.Controls.Add(this.txtproductocodigo);
            this.gbreprod.Controls.Add(this.label15);
            this.gbreprod.Controls.Add(this.label8);
            this.gbreprod.Controls.Add(this.txtdescripcion);
            this.gbreprod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbreprod.Location = new System.Drawing.Point(12, 11);
            this.gbreprod.Name = "gbreprod";
            this.gbreprod.Size = new System.Drawing.Size(1494, 512);
            this.gbreprod.TabIndex = 115;
            this.gbreprod.TabStop = false;
            this.gbreprod.Text = "Registrar Productos";
            this.gbreprod.Enter += new System.EventHandler(this.gbreprod_Enter);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnActualizar.Enabled = false;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnActualizar.IconColor = System.Drawing.Color.White;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 35;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(650, 407);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(179, 36);
            this.btnActualizar.TabIndex = 55;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cboxest
            // 
            this.cboxest.BackColor = System.Drawing.Color.Black;
            this.cboxest.ForeColor = System.Drawing.Color.White;
            this.cboxest.FormattingEnabled = true;
            this.cboxest.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cboxest.Location = new System.Drawing.Point(769, 164);
            this.cboxest.Name = "cboxest";
            this.cboxest.Size = new System.Drawing.Size(175, 24);
            this.cboxest.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(556, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 53;
            this.label1.Text = "precio de compra:";
            // 
            // lblfkmarca
            // 
            this.lblfkmarca.AutoSize = true;
            this.lblfkmarca.Location = new System.Drawing.Point(176, 261);
            this.lblfkmarca.Name = "lblfkmarca";
            this.lblfkmarca.Size = new System.Drawing.Size(0, 17);
            this.lblfkmarca.TabIndex = 51;
            // 
            // cbocproveedor
            // 
            this.cbocproveedor.BackColor = System.Drawing.Color.Black;
            this.cbocproveedor.ForeColor = System.Drawing.Color.White;
            this.cbocproveedor.FormattingEnabled = true;
            this.cbocproveedor.Location = new System.Drawing.Point(768, 282);
            this.cbocproveedor.Name = "cbocproveedor";
            this.cbocproveedor.Size = new System.Drawing.Size(175, 24);
            this.cbocproveedor.TabIndex = 50;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(982, 84);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(292, 41);
            this.iconButton2.TabIndex = 12;
            this.iconButton2.Text = "Anadir Nueva Categoria";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // ibtañadirmarca
            // 
            this.ibtañadirmarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ibtañadirmarca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ibtañadirmarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ibtañadirmarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtañadirmarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtañadirmarca.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ibtañadirmarca.IconColor = System.Drawing.Color.White;
            this.ibtañadirmarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtañadirmarca.IconSize = 35;
            this.ibtañadirmarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtañadirmarca.Location = new System.Drawing.Point(982, 142);
            this.ibtañadirmarca.Name = "ibtañadirmarca";
            this.ibtañadirmarca.Size = new System.Drawing.Size(292, 41);
            this.ibtañadirmarca.TabIndex = 13;
            this.ibtañadirmarca.Text = "Anadir Nueva Marca";
            this.ibtañadirmarca.UseVisualStyleBackColor = false;
            this.ibtañadirmarca.Click += new System.EventHandler(this.ibtañadircalle_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.iconButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.iconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 35;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(982, 207);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(292, 41);
            this.iconButton3.TabIndex = 14;
            this.iconButton3.Text = "Anadir Nuevo Modelo";
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // cboxmodelo
            // 
            this.cboxmodelo.BackColor = System.Drawing.Color.Black;
            this.cboxmodelo.ForeColor = System.Drawing.Color.White;
            this.cboxmodelo.FormattingEnabled = true;
            this.cboxmodelo.Location = new System.Drawing.Point(326, 253);
            this.cboxmodelo.Name = "cboxmodelo";
            this.cboxmodelo.Size = new System.Drawing.Size(175, 24);
            this.cboxmodelo.TabIndex = 4;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.Dizzy;
            this.btncancelar.IconColor = System.Drawing.Color.White;
            this.btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncancelar.IconSize = 35;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(864, 403);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(160, 40);
            this.btncancelar.TabIndex = 16;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(102, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "codigo del producto:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 35;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(650, 345);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(179, 40);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(209, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(240, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "marca:";
            // 
            // txtventa
            // 
            this.txtventa.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtventa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtventa.ForeColor = System.Drawing.SystemColors.Info;
            this.txtventa.Location = new System.Drawing.Point(769, 245);
            this.txtventa.Name = "txtventa";
            this.txtventa.Size = new System.Drawing.Size(175, 28);
            this.txtventa.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(228, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "modelo:";
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtpreciocompra.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreciocompra.ForeColor = System.Drawing.SystemColors.Info;
            this.txtpreciocompra.Location = new System.Drawing.Point(768, 204);
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.Size = new System.Drawing.Size(175, 28);
            this.txtpreciocompra.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(119, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Nombre comercial:";
            // 
            // txtcolor
            // 
            this.txtcolor.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtcolor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcolor.ForeColor = System.Drawing.SystemColors.Info;
            this.txtcolor.Location = new System.Drawing.Point(768, 84);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(175, 28);
            this.txtcolor.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(189, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 23);
            this.label7.TabIndex = 42;
            this.label7.Text = "descripcion:";
            // 
            // txtnombreproducto
            // 
            this.txtnombreproducto.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtnombreproducto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreproducto.ForeColor = System.Drawing.SystemColors.Info;
            this.txtnombreproducto.Location = new System.Drawing.Point(326, 174);
            this.txtnombreproducto.Name = "txtnombreproducto";
            this.txtnombreproducto.Size = new System.Drawing.Size(175, 28);
            this.txtnombreproducto.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(684, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 23);
            this.label12.TabIndex = 43;
            this.label12.Text = "color:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(646, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 23);
            this.label13.TabIndex = 44;
            this.label13.Text = "cantidad:";
            // 
            // cboxmarca
            // 
            this.cboxmarca.BackColor = System.Drawing.Color.Black;
            this.cboxmarca.ForeColor = System.Drawing.Color.White;
            this.cboxmarca.FormattingEnabled = true;
            this.cboxmarca.Items.AddRange(new object[] {
            "selecciona una marca"});
            this.cboxmarca.Location = new System.Drawing.Point(326, 216);
            this.cboxmarca.Name = "cboxmarca";
            this.cboxmarca.Size = new System.Drawing.Size(175, 24);
            this.cboxmarca.TabIndex = 3;
            this.cboxmarca.SelectedIndexChanged += new System.EventHandler(this.insertar_modelo);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.Black;
            this.numericUpDown2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.ForeColor = System.Drawing.SystemColors.Info;
            this.numericUpDown2.Location = new System.Drawing.Point(770, 125);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(174, 28);
            this.numericUpDown2.TabIndex = 8;
            // 
            // cboxcat
            // 
            this.cboxcat.BackColor = System.Drawing.Color.Black;
            this.cboxcat.ForeColor = System.Drawing.Color.White;
            this.cboxcat.FormattingEnabled = true;
            this.cboxcat.Location = new System.Drawing.Point(326, 141);
            this.cboxcat.Name = "cboxcat";
            this.cboxcat.Size = new System.Drawing.Size(175, 24);
            this.cboxcat.TabIndex = 2;
            // 
            // lblest
            // 
            this.lblest.AutoSize = true;
            this.lblest.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblest.Location = new System.Drawing.Point(670, 165);
            this.lblest.Name = "lblest";
            this.lblest.Size = new System.Drawing.Size(80, 23);
            this.lblest.TabIndex = 46;
            this.lblest.Text = "Estado:";
            // 
            // txtproductocodigo
            // 
            this.txtproductocodigo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtproductocodigo.Enabled = false;
            this.txtproductocodigo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductocodigo.ForeColor = System.Drawing.SystemColors.Info;
            this.txtproductocodigo.Location = new System.Drawing.Point(326, 99);
            this.txtproductocodigo.Name = "txtproductocodigo";
            this.txtproductocodigo.Size = new System.Drawing.Size(80, 28);
            this.txtproductocodigo.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(569, 248);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(181, 23);
            this.label15.TabIndex = 47;
            this.label15.Text = "precio de ventas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(633, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 23);
            this.label8.TabIndex = 49;
            this.label8.Text = "proveedor:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(326, 312);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(277, 131);
            this.txtdescripcion.TabIndex = 6;
            this.txtdescripcion.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.txtbuscar);
            this.groupBox2.Controls.Add(this.dgvproductos);
            this.groupBox2.Controls.Add(this.mostarprodutos);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 543);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1494, 291);
            this.groupBox2.TabIndex = 136;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Proveedor";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Black;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(345, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 24);
            this.comboBox1.TabIndex = 161;
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtbuscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.ForeColor = System.Drawing.Color.White;
            this.txtbuscar.Location = new System.Drawing.Point(134, 21);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(175, 28);
            this.txtbuscar.TabIndex = 160;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
            // 
            // dgvproductos
            // 
            this.dgvproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvproductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvproductos.BackgroundColor = System.Drawing.Color.Black;
            this.dgvproductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvproductos.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvproductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvproductos.EnableHeadersVisualStyles = false;
            this.dgvproductos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvproductos.Location = new System.Drawing.Point(46, 68);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvproductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvproductos.RowTemplate.Height = 24;
            this.dgvproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvproductos.Size = new System.Drawing.Size(1406, 121);
            this.dgvproductos.TabIndex = 20;
            this.dgvproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductos_CellContentClick);
            // 
            // mostarprodutos
            // 
            this.mostarprodutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mostarprodutos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mostarprodutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.mostarprodutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mostarprodutos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mostarprodutos.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.mostarprodutos.IconColor = System.Drawing.Color.White;
            this.mostarprodutos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mostarprodutos.IconSize = 35;
            this.mostarprodutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mostarprodutos.Location = new System.Drawing.Point(603, 15);
            this.mostarprodutos.Name = "mostarprodutos";
            this.mostarprodutos.Size = new System.Drawing.Size(171, 40);
            this.mostarprodutos.TabIndex = 18;
            this.mostarprodutos.Text = "Mostrar Todo";
            this.mostarprodutos.UseVisualStyleBackColor = false;
            this.mostarprodutos.Click += new System.EventHandler(this.mostarprodutos_Click);
            // 
            // FrmRegistrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1532, 856);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbreprod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarProductos";
            this.Text = "productos";
            this.Load += new System.EventHandler(this.FrmRegistrarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbreprod.ResumeLayout(false);
            this.gbreprod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbreprod;
        private System.Windows.Forms.ComboBox cbocproveedor;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton ibtañadirmarca;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.ComboBox cboxmodelo;
        private FontAwesome.Sharp.IconButton btncancelar;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtventa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpreciocompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnombreproducto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboxmarca;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ComboBox cboxcat;
        private System.Windows.Forms.Label lblest;
        private System.Windows.Forms.TextBox txtproductocodigo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtdescripcion;
        private System.Windows.Forms.Label lblfkmarca;
        private System.Windows.Forms.ComboBox cboxest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dgvproductos;
        private FontAwesome.Sharp.IconButton mostarprodutos;
        private FontAwesome.Sharp.IconButton btnActualizar;
    }
}