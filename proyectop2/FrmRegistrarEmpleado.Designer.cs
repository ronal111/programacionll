
namespace proyectop2
{
    partial class FrmRegistrarEmpleado
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btbbuscarE = new FontAwesome.Sharp.IconButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dgvempleados = new System.Windows.Forms.DataGridView();
            this.btnmostartodo = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxedad = new System.Windows.Forms.NumericUpDown();
            this.Actualizar = new FontAwesome.Sharp.IconButton();
            this.txtsueldo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtrfc = new System.Windows.Forms.TextBox();
            this.lblrfc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigopos = new System.Windows.Forms.TextBox();
            this.txtnumerointerior = new System.Windows.Forms.TextBox();
            this.txtmunicipio = new System.Windows.Forms.TextBox();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.cboxcolonia = new System.Windows.Forms.ComboBox();
            this.txtcalle = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lblmuni = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtpuesto = new System.Windows.Forms.TextBox();
            this.txttelefonoe = new System.Windows.Forms.TextBox();
            this.txtempleado = new System.Windows.Forms.TextBox();
            this.lblcompañiaprov = new System.Windows.Forms.Label();
            this.lblnomEmp = new System.Windows.Forms.Label();
            this.lblcoreo = new System.Windows.Forms.Label();
            this.lbltelp = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btbbuscarE);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.dgvempleados);
            this.groupBox2.Controls.Add(this.btnmostartodo);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(19, 496);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1266, 326);
            this.groupBox2.TabIndex = 138;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Empleado";
            // 
            // btbbuscarE
            // 
            this.btbbuscarE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btbbuscarE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btbbuscarE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btbbuscarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbbuscarE.ForeColor = System.Drawing.Color.White;
            this.btbbuscarE.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btbbuscarE.IconColor = System.Drawing.Color.White;
            this.btbbuscarE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btbbuscarE.IconSize = 35;
            this.btbbuscarE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbbuscarE.Location = new System.Drawing.Point(519, 14);
            this.btbbuscarE.Name = "btbbuscarE";
            this.btbbuscarE.Size = new System.Drawing.Size(163, 38);
            this.btbbuscarE.TabIndex = 137;
            this.btbbuscarE.Text = "Buscar";
            this.btbbuscarE.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox4.Location = new System.Drawing.Point(314, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(175, 28);
            this.textBox4.TabIndex = 167;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dgvempleados
            // 
            this.dgvempleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvempleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvempleados.BackgroundColor = System.Drawing.Color.Black;
            this.dgvempleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvempleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvempleados.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvempleados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvempleados.EnableHeadersVisualStyles = false;
            this.dgvempleados.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvempleados.Location = new System.Drawing.Point(53, 69);
            this.dgvempleados.Name = "dgvempleados";
            this.dgvempleados.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvempleados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvempleados.RowTemplate.Height = 24;
            this.dgvempleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvempleados.Size = new System.Drawing.Size(1193, 211);
            this.dgvempleados.TabIndex = 20;
            this.dgvempleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvempleados_CellContentClick);
            // 
            // btnmostartodo
            // 
            this.btnmostartodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnmostartodo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnmostartodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnmostartodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmostartodo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmostartodo.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnmostartodo.IconColor = System.Drawing.Color.White;
            this.btnmostartodo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnmostartodo.IconSize = 35;
            this.btnmostartodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmostartodo.Location = new System.Drawing.Point(688, 14);
            this.btnmostartodo.Name = "btnmostartodo";
            this.btnmostartodo.Size = new System.Drawing.Size(171, 38);
            this.btnmostartodo.TabIndex = 18;
            this.btnmostartodo.Text = "Mostrar Todo";
            this.btnmostartodo.UseVisualStyleBackColor = false;
            this.btnmostartodo.Click += new System.EventHandler(this.mostar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxedad);
            this.groupBox1.Controls.Add(this.Actualizar);
            this.groupBox1.Controls.Add(this.txtsueldo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtrfc);
            this.groupBox1.Controls.Add(this.lblrfc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtcodigopos);
            this.groupBox1.Controls.Add(this.txtnumerointerior);
            this.groupBox1.Controls.Add(this.txtmunicipio);
            this.groupBox1.Controls.Add(this.txtestado);
            this.groupBox1.Controls.Add(this.cboxcolonia);
            this.groupBox1.Controls.Add(this.txtcalle);
            this.groupBox1.Controls.Add(this.txtnumero);
            this.groupBox1.Controls.Add(this.lblmuni);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.txtapellido);
            this.groupBox1.Controls.Add(this.txtpuesto);
            this.groupBox1.Controls.Add(this.txttelefonoe);
            this.groupBox1.Controls.Add(this.txtempleado);
            this.groupBox1.Controls.Add(this.lblcompañiaprov);
            this.groupBox1.Controls.Add(this.lblnomEmp);
            this.groupBox1.Controls.Add(this.lblcoreo);
            this.groupBox1.Controls.Add(this.lbltelp);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1266, 417);
            this.groupBox1.TabIndex = 137;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regristrar Empleado";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboxedad
            // 
            this.cboxedad.Location = new System.Drawing.Point(314, 187);
            this.cboxedad.Name = "cboxedad";
            this.cboxedad.Size = new System.Drawing.Size(175, 22);
            this.cboxedad.TabIndex = 166;
            this.cboxedad.ValueChanged += new System.EventHandler(this.cboxedad_ValueChanged);
            // 
            // Actualizar
            // 
            this.Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Actualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Actualizar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.Actualizar.IconColor = System.Drawing.Color.White;
            this.Actualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Actualizar.IconSize = 35;
            this.Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Actualizar.Location = new System.Drawing.Point(922, 341);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(172, 43);
            this.Actualizar.TabIndex = 21;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = false;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // txtsueldo
            // 
            this.txtsueldo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtsueldo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsueldo.ForeColor = System.Drawing.SystemColors.Info;
            this.txtsueldo.Location = new System.Drawing.Point(314, 292);
            this.txtsueldo.Name = "txtsueldo";
            this.txtsueldo.Size = new System.Drawing.Size(175, 28);
            this.txtsueldo.TabIndex = 165;
            this.txtsueldo.TextChanged += new System.EventHandler(this.txtsueldo_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(201, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 23);
            this.label8.TabIndex = 164;
            this.label8.Text = "Sueldo:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(203, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 163;
            this.label7.Text = "Puesto:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtrfc
            // 
            this.txtrfc.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtrfc.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrfc.ForeColor = System.Drawing.SystemColors.Info;
            this.txtrfc.Location = new System.Drawing.Point(314, 66);
            this.txtrfc.Name = "txtrfc";
            this.txtrfc.Size = new System.Drawing.Size(175, 28);
            this.txtrfc.TabIndex = 162;
            this.txtrfc.TextChanged += new System.EventHandler(this.txtrfc_TextChanged);
            // 
            // lblrfc
            // 
            this.lblrfc.AutoSize = true;
            this.lblrfc.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrfc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblrfc.Location = new System.Drawing.Point(229, 71);
            this.lblrfc.Name = "lblrfc";
            this.lblrfc.Size = new System.Drawing.Size(54, 23);
            this.lblrfc.TabIndex = 161;
            this.lblrfc.Text = "RFC:";
            this.lblrfc.Click += new System.EventHandler(this.lblrfc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(558, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 159;
            this.label2.Text = "Codigo Postal:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(543, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 158;
            this.label1.Text = "Numero Interior:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtcodigopos
            // 
            this.txtcodigopos.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtcodigopos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigopos.ForeColor = System.Drawing.SystemColors.Info;
            this.txtcodigopos.Location = new System.Drawing.Point(727, 177);
            this.txtcodigopos.Name = "txtcodigopos";
            this.txtcodigopos.Size = new System.Drawing.Size(175, 28);
            this.txtcodigopos.TabIndex = 157;
            this.txtcodigopos.TextChanged += new System.EventHandler(this.insertar_Domicilio);
            // 
            // txtnumerointerior
            // 
            this.txtnumerointerior.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtnumerointerior.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumerointerior.ForeColor = System.Drawing.SystemColors.Info;
            this.txtnumerointerior.Location = new System.Drawing.Point(727, 143);
            this.txtnumerointerior.Name = "txtnumerointerior";
            this.txtnumerointerior.Size = new System.Drawing.Size(175, 28);
            this.txtnumerointerior.TabIndex = 156;
            this.txtnumerointerior.TextChanged += new System.EventHandler(this.txtnumerointerior_TextChanged);
            // 
            // txtmunicipio
            // 
            this.txtmunicipio.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtmunicipio.Enabled = false;
            this.txtmunicipio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmunicipio.ForeColor = System.Drawing.SystemColors.Info;
            this.txtmunicipio.Location = new System.Drawing.Point(727, 285);
            this.txtmunicipio.Name = "txtmunicipio";
            this.txtmunicipio.Size = new System.Drawing.Size(175, 28);
            this.txtmunicipio.TabIndex = 155;
            this.txtmunicipio.TextChanged += new System.EventHandler(this.txtmunicipio_TextChanged);
            // 
            // txtestado
            // 
            this.txtestado.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtestado.Enabled = false;
            this.txtestado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestado.ForeColor = System.Drawing.SystemColors.Info;
            this.txtestado.Location = new System.Drawing.Point(727, 245);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(175, 28);
            this.txtestado.TabIndex = 154;
            this.txtestado.TextChanged += new System.EventHandler(this.txtestado_TextChanged);
            // 
            // cboxcolonia
            // 
            this.cboxcolonia.BackColor = System.Drawing.Color.Black;
            this.cboxcolonia.ForeColor = System.Drawing.Color.White;
            this.cboxcolonia.FormattingEnabled = true;
            this.cboxcolonia.Location = new System.Drawing.Point(727, 211);
            this.cboxcolonia.Name = "cboxcolonia";
            this.cboxcolonia.Size = new System.Drawing.Size(175, 24);
            this.cboxcolonia.TabIndex = 153;
            this.cboxcolonia.SelectedIndexChanged += new System.EventHandler(this.cboxcolonia_SelectedIndexChanged);
            // 
            // txtcalle
            // 
            this.txtcalle.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtcalle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcalle.ForeColor = System.Drawing.Color.White;
            this.txtcalle.Location = new System.Drawing.Point(727, 66);
            this.txtcalle.Name = "txtcalle";
            this.txtcalle.Size = new System.Drawing.Size(175, 28);
            this.txtcalle.TabIndex = 152;
            this.txtcalle.TextChanged += new System.EventHandler(this.txtcalle_TextChanged);
            // 
            // txtnumero
            // 
            this.txtnumero.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtnumero.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.ForeColor = System.Drawing.SystemColors.Info;
            this.txtnumero.Location = new System.Drawing.Point(727, 100);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(175, 28);
            this.txtnumero.TabIndex = 146;
            this.txtnumero.TextChanged += new System.EventHandler(this.txtnumero_TextChanged);
            // 
            // lblmuni
            // 
            this.lblmuni.AutoSize = true;
            this.lblmuni.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmuni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmuni.Location = new System.Drawing.Point(596, 285);
            this.lblmuni.Name = "lblmuni";
            this.lblmuni.Size = new System.Drawing.Size(112, 23);
            this.lblmuni.TabIndex = 151;
            this.lblmuni.Text = "Municipio:";
            this.lblmuni.Click += new System.EventHandler(this.lblmuni_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(629, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 150;
            this.label3.Text = "Estado:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(616, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 149;
            this.label4.Text = "Colonia:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(614, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 148;
            this.label5.Text = "Numero:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(642, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 147;
            this.label6.Text = "Calle:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            this.btncancelar.Location = new System.Drawing.Point(1105, 284);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(141, 40);
            this.btncancelar.TabIndex = 14;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnguardar.IconColor = System.Drawing.Color.White;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 35;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(922, 285);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(172, 39);
            this.btnguardar.TabIndex = 13;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtapellido
            // 
            this.txtapellido.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtapellido.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.ForeColor = System.Drawing.SystemColors.Info;
            this.txtapellido.Location = new System.Drawing.Point(314, 149);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(175, 28);
            this.txtapellido.TabIndex = 2;
            this.txtapellido.TextChanged += new System.EventHandler(this.txtapellido_TextChanged);
            // 
            // txtpuesto
            // 
            this.txtpuesto.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtpuesto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpuesto.ForeColor = System.Drawing.SystemColors.Info;
            this.txtpuesto.Location = new System.Drawing.Point(314, 258);
            this.txtpuesto.Name = "txtpuesto";
            this.txtpuesto.Size = new System.Drawing.Size(175, 28);
            this.txtpuesto.TabIndex = 3;
            this.txtpuesto.TextChanged += new System.EventHandler(this.txtpuesto_TextChanged);
            // 
            // txttelefonoe
            // 
            this.txttelefonoe.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txttelefonoe.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefonoe.ForeColor = System.Drawing.SystemColors.Info;
            this.txttelefonoe.Location = new System.Drawing.Point(314, 221);
            this.txttelefonoe.Name = "txttelefonoe";
            this.txttelefonoe.Size = new System.Drawing.Size(175, 28);
            this.txttelefonoe.TabIndex = 4;
            this.txttelefonoe.TextChanged += new System.EventHandler(this.txttelefonoe_TextChanged);
            // 
            // txtempleado
            // 
            this.txtempleado.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtempleado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempleado.ForeColor = System.Drawing.SystemColors.Info;
            this.txtempleado.Location = new System.Drawing.Point(314, 111);
            this.txtempleado.Name = "txtempleado";
            this.txtempleado.Size = new System.Drawing.Size(175, 28);
            this.txtempleado.TabIndex = 1;
            this.txtempleado.TextChanged += new System.EventHandler(this.txtempleado_TextChanged);
            // 
            // lblcompañiaprov
            // 
            this.lblcompañiaprov.AutoSize = true;
            this.lblcompañiaprov.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompañiaprov.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcompañiaprov.Location = new System.Drawing.Point(187, 149);
            this.lblcompañiaprov.Name = "lblcompañiaprov";
            this.lblcompañiaprov.Size = new System.Drawing.Size(98, 23);
            this.lblcompañiaprov.TabIndex = 134;
            this.lblcompañiaprov.Text = "Apellido:";
            this.lblcompañiaprov.Click += new System.EventHandler(this.lblcompañiaprov_Click);
            // 
            // lblnomEmp
            // 
            this.lblnomEmp.AutoSize = true;
            this.lblnomEmp.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblnomEmp.Location = new System.Drawing.Point(188, 116);
            this.lblnomEmp.Name = "lblnomEmp";
            this.lblnomEmp.Size = new System.Drawing.Size(95, 23);
            this.lblnomEmp.TabIndex = 133;
            this.lblnomEmp.Text = "Nombre:";
            this.lblnomEmp.Click += new System.EventHandler(this.lblnomEmp_Click);
            // 
            // lblcoreo
            // 
            this.lblcoreo.AutoSize = true;
            this.lblcoreo.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoreo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcoreo.Location = new System.Drawing.Point(218, 187);
            this.lblcoreo.Name = "lblcoreo";
            this.lblcoreo.Size = new System.Drawing.Size(65, 23);
            this.lblcoreo.TabIndex = 135;
            this.lblcoreo.Text = "Edad:";
            this.lblcoreo.Click += new System.EventHandler(this.lblcoreo_Click);
            // 
            // lbltelp
            // 
            this.lbltelp.AutoSize = true;
            this.lbltelp.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltelp.Location = new System.Drawing.Point(184, 221);
            this.lbltelp.Name = "lbltelp";
            this.lbltelp.Size = new System.Drawing.Size(99, 23);
            this.lbltelp.TabIndex = 136;
            this.lbltelp.Text = "Telefono:";
            this.lbltelp.Click += new System.EventHandler(this.lbltelp_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmRegistrarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1305, 852);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarEmpleado";
            this.Text = "FrmEmpleadoReg";
            this.Load += new System.EventHandler(this.FrmEmpleadoReg_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btbbuscarE;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dgvempleados;
        private FontAwesome.Sharp.IconButton btnmostartodo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown cboxedad;
        private FontAwesome.Sharp.IconButton Actualizar;
        private System.Windows.Forms.TextBox txtsueldo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtrfc;
        private System.Windows.Forms.Label lblrfc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigopos;
        private System.Windows.Forms.TextBox txtnumerointerior;
        private System.Windows.Forms.TextBox txtmunicipio;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.ComboBox cboxcolonia;
        private System.Windows.Forms.TextBox txtcalle;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lblmuni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtpuesto;
        private System.Windows.Forms.TextBox txttelefonoe;
        private System.Windows.Forms.TextBox txtempleado;
        private System.Windows.Forms.Label lblcompañiaprov;
        private System.Windows.Forms.Label lblnomEmp;
        private System.Windows.Forms.Label lblcoreo;
        private System.Windows.Forms.Label lbltelp;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}