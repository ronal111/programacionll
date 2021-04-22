
namespace proyectop2
{
    partial class FrmBuscarProveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvbproveedores = new System.Windows.Forms.DataGridView();
            this.nombreprov = new System.Windows.Forms.DataGridViewLinkColumn();
            this.compañiap = new System.Windows.Forms.DataGridViewLinkColumn();
            this.correoprov = new System.Windows.Forms.DataGridViewLinkColumn();
            this.telefonoprov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionprov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numeroprov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloniap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.ibtnaddempleados = new FontAwesome.Sharp.IconButton();
            this.btbbuscarp = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtbuscarproveedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbproveedores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvbproveedores
            // 
            this.dgvbproveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvbproveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvbproveedores.BackgroundColor = System.Drawing.Color.Black;
            this.dgvbproveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbproveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvbproveedores.ColumnHeadersHeight = 29;
            this.dgvbproveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreprov,
            this.compañiap,
            this.correoprov,
            this.telefonoprov,
            this.direccionprov,
            this.Numeroprov,
            this.coloniap,
            this.estadop,
            this.localidadp});
            this.dgvbproveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvbproveedores.EnableHeadersVisualStyles = false;
            this.dgvbproveedores.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvbproveedores.Location = new System.Drawing.Point(0, 179);
            this.dgvbproveedores.Name = "dgvbproveedores";
            this.dgvbproveedores.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvbproveedores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvbproveedores.RowTemplate.Height = 24;
            this.dgvbproveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbproveedores.Size = new System.Drawing.Size(1178, 526);
            this.dgvbproveedores.TabIndex = 30;
            // 
            // nombreprov
            // 
            this.nombreprov.HeaderText = "Nombre ";
            this.nombreprov.MinimumWidth = 6;
            this.nombreprov.Name = "nombreprov";
            this.nombreprov.Width = 96;
            // 
            // compañiap
            // 
            this.compañiap.HeaderText = "Compañia";
            this.compañiap.MinimumWidth = 6;
            this.compañiap.Name = "compañiap";
            this.compañiap.Width = 116;
            // 
            // correoprov
            // 
            this.correoprov.HeaderText = "Correo Electronico";
            this.correoprov.MinimumWidth = 6;
            this.correoprov.Name = "correoprov";
            this.correoprov.Width = 187;
            // 
            // telefonoprov
            // 
            this.telefonoprov.HeaderText = "Telefono";
            this.telefonoprov.MinimumWidth = 6;
            this.telefonoprov.Name = "telefonoprov";
            this.telefonoprov.Width = 116;
            // 
            // direccionprov
            // 
            this.direccionprov.HeaderText = "Direccion";
            this.direccionprov.MinimumWidth = 6;
            this.direccionprov.Name = "direccionprov";
            this.direccionprov.Width = 127;
            // 
            // Numeroprov
            // 
            this.Numeroprov.HeaderText = "Numero";
            this.Numeroprov.MinimumWidth = 6;
            this.Numeroprov.Name = "Numeroprov";
            this.Numeroprov.Width = 112;
            // 
            // coloniap
            // 
            this.coloniap.HeaderText = "Colonia";
            this.coloniap.MinimumWidth = 6;
            this.coloniap.Name = "coloniap";
            this.coloniap.Width = 112;
            // 
            // estadop
            // 
            this.estadop.HeaderText = "Estado";
            this.estadop.MinimumWidth = 6;
            this.estadop.Name = "estadop";
            this.estadop.Width = 101;
            // 
            // localidadp
            // 
            this.localidadp.HeaderText = "Localidad";
            this.localidadp.MinimumWidth = 6;
            this.localidadp.Name = "localidadp";
            this.localidadp.Width = 133;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.ibtnaddempleados);
            this.panel1.Controls.Add(this.btbbuscarp);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtbuscarproveedor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 179);
            this.panel1.TabIndex = 31;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(485, 54);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(163, 38);
            this.iconButton2.TabIndex = 48;
            this.iconButton2.Text = "Mostrar Todo";
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Dizzy;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(773, 12);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(113, 36);
            this.iconButton1.TabIndex = 47;
            this.iconButton1.Text = "Eliminar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // ibtnaddempleados
            // 
            this.ibtnaddempleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ibtnaddempleados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ibtnaddempleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ibtnaddempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnaddempleados.ForeColor = System.Drawing.Color.White;
            this.ibtnaddempleados.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.ibtnaddempleados.IconColor = System.Drawing.Color.White;
            this.ibtnaddempleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnaddempleados.IconSize = 30;
            this.ibtnaddempleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnaddempleados.Location = new System.Drawing.Point(654, 11);
            this.ibtnaddempleados.Name = "ibtnaddempleados";
            this.ibtnaddempleados.Size = new System.Drawing.Size(113, 36);
            this.ibtnaddempleados.TabIndex = 46;
            this.ibtnaddempleados.Text = "Editar";
            this.ibtnaddempleados.UseVisualStyleBackColor = false;
            // 
            // btbbuscarp
            // 
            this.btbbuscarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btbbuscarp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btbbuscarp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btbbuscarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbbuscarp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btbbuscarp.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btbbuscarp.IconColor = System.Drawing.Color.White;
            this.btbbuscarp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btbbuscarp.IconSize = 35;
            this.btbbuscarp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbbuscarp.Location = new System.Drawing.Point(485, 10);
            this.btbbuscarp.Name = "btbbuscarp";
            this.btbbuscarp.Size = new System.Drawing.Size(163, 38);
            this.btbbuscarp.TabIndex = 45;
            this.btbbuscarp.Text = "Buscar";
            this.btbbuscarp.UseVisualStyleBackColor = false;
            this.btbbuscarp.Click += new System.EventHandler(this.btbbuscarp_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(283, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 24);
            this.comboBox1.TabIndex = 30;
            // 
            // txtbuscarproveedor
            // 
            this.txtbuscarproveedor.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtbuscarproveedor.Location = new System.Drawing.Point(108, 18);
            this.txtbuscarproveedor.Name = "txtbuscarproveedor";
            this.txtbuscarproveedor.Size = new System.Drawing.Size(144, 22);
            this.txtbuscarproveedor.TabIndex = 31;
            // 
            // FrmBuscarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1178, 766);
            this.Controls.Add(this.dgvbproveedores);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarProveedor";
            this.Text = "FrmBuscarProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvbproveedores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbproveedores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtbuscarproveedor;
        private System.Windows.Forms.DataGridViewLinkColumn nombreprov;
        private System.Windows.Forms.DataGridViewLinkColumn compañiap;
        private System.Windows.Forms.DataGridViewLinkColumn correoprov;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoprov;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionprov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numeroprov;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloniap;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadop;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadp;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton ibtnaddempleados;
        private FontAwesome.Sharp.IconButton btbbuscarp;
    }
}