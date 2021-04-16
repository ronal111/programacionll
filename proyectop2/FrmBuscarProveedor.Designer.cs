
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnbuscarp = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtempleado = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnvertodop = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbproveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvbproveedores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvbproveedores.RowTemplate.Height = 24;
            this.dgvbproveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbproveedores.Size = new System.Drawing.Size(1122, 526);
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
            this.panel1.Controls.Add(this.btnvertodop);
            this.panel1.Controls.Add(this.btnbuscarp);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtempleado);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 179);
            this.panel1.TabIndex = 31;
            // 
            // btnbuscarp
            // 
            this.btnbuscarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnbuscarp.FlatAppearance.BorderSize = 0;
            this.btnbuscarp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnbuscarp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnbuscarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarp.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnbuscarp.Location = new System.Drawing.Point(481, 12);
            this.btnbuscarp.Name = "btnbuscarp";
            this.btnbuscarp.Size = new System.Drawing.Size(152, 31);
            this.btnbuscarp.TabIndex = 32;
            this.btnbuscarp.Text = "BUSCAR";
            this.btnbuscarp.UseVisualStyleBackColor = false;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(639, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 31);
            this.button1.TabIndex = 33;
            this.button1.Text = "EDITAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtempleado
            // 
            this.txtempleado.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtempleado.Location = new System.Drawing.Point(108, 18);
            this.txtempleado.Name = "txtempleado";
            this.txtempleado.Size = new System.Drawing.Size(144, 22);
            this.txtempleado.TabIndex = 31;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.Location = new System.Drawing.Point(797, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 31);
            this.button4.TabIndex = 34;
            this.button4.Text = "ELIMINAR";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnvertodop
            // 
            this.btnvertodop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnvertodop.FlatAppearance.BorderSize = 0;
            this.btnvertodop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnvertodop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnvertodop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvertodop.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvertodop.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnvertodop.Location = new System.Drawing.Point(481, 49);
            this.btnvertodop.Name = "btnvertodop";
            this.btnvertodop.Size = new System.Drawing.Size(152, 31);
            this.btnvertodop.TabIndex = 36;
            this.btnvertodop.Text = "Ver Todo";
            this.btnvertodop.UseVisualStyleBackColor = false;
            // 
            // FrmBuscarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1122, 766);
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
        private System.Windows.Forms.Button btnbuscarp;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtempleado;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewLinkColumn nombreprov;
        private System.Windows.Forms.DataGridViewLinkColumn compañiap;
        private System.Windows.Forms.DataGridViewLinkColumn correoprov;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoprov;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionprov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numeroprov;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloniap;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadop;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadp;
        private System.Windows.Forms.Button btnvertodop;
    }
}