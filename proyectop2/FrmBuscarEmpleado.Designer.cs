
namespace proyectop2
{
    partial class FrmBuscarEmpleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnacceder = new System.Windows.Forms.Button();
            this.txtempleado = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvbproductos = new System.Windows.Forms.DataGridView();
            this.rfc = new System.Windows.Forms.DataGridViewLinkColumn();
            this.nombree = new System.Windows.Forms.DataGridViewLinkColumn();
            this.apellidoe = new System.Windows.Forms.DataGridViewLinkColumn();
            this.usuarioe = new System.Windows.Forms.DataGridViewLinkColumn();
            this.contraseñae = new System.Windows.Forms.DataGridViewLinkColumn();
            this.telefono = new System.Windows.Forms.DataGridViewLinkColumn();
            this.edade = new System.Windows.Forms.DataGridViewLinkColumn();
            this.puestoe = new System.Windows.Forms.DataGridViewLinkColumn();
            this.sueldoe = new System.Windows.Forms.DataGridViewLinkColumn();
            this.calleE = new System.Windows.Forms.DataGridViewLinkColumn();
            this.numeroe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloniae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnvertodoe = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnvertodoe);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnacceder);
            this.panel1.Controls.Add(this.txtempleado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 149);
            this.panel1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(819, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 31);
            this.button2.TabIndex = 15;
            this.button2.Text = "ELIMINAR";
            this.button2.UseVisualStyleBackColor = false;
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
            this.button1.Location = new System.Drawing.Point(645, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "EDITAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(278, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // btnacceder
            // 
            this.btnacceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnacceder.FlatAppearance.BorderSize = 0;
            this.btnacceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnacceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnacceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacceder.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnacceder.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnacceder.Location = new System.Drawing.Point(473, 20);
            this.btnacceder.Name = "btnacceder";
            this.btnacceder.Size = new System.Drawing.Size(152, 31);
            this.btnacceder.TabIndex = 12;
            this.btnacceder.Text = "BUSCAR";
            this.btnacceder.UseVisualStyleBackColor = false;
            // 
            // txtempleado
            // 
            this.txtempleado.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtempleado.Location = new System.Drawing.Point(110, 26);
            this.txtempleado.Name = "txtempleado";
            this.txtempleado.Size = new System.Drawing.Size(144, 22);
            this.txtempleado.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvbproductos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 454);
            this.panel2.TabIndex = 12;
            // 
            // dgvbproductos
            // 
            this.dgvbproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvbproductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvbproductos.BackgroundColor = System.Drawing.Color.Black;
            this.dgvbproductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbproductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvbproductos.ColumnHeadersHeight = 29;
            this.dgvbproductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rfc,
            this.nombree,
            this.apellidoe,
            this.usuarioe,
            this.contraseñae,
            this.telefono,
            this.edade,
            this.puestoe,
            this.sueldoe,
            this.calleE,
            this.numeroe,
            this.coloniae,
            this.estado,
            this.localidade});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvbproductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvbproductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvbproductos.EnableHeadersVisualStyles = false;
            this.dgvbproductos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvbproductos.Location = new System.Drawing.Point(0, 0);
            this.dgvbproductos.Name = "dgvbproductos";
            this.dgvbproductos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvbproductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvbproductos.RowTemplate.Height = 24;
            this.dgvbproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvbproductos.Size = new System.Drawing.Size(1080, 454);
            this.dgvbproductos.TabIndex = 5;
            // 
            // rfc
            // 
            this.rfc.HeaderText = "RFC";
            this.rfc.MinimumWidth = 6;
            this.rfc.Name = "rfc";
            this.rfc.Width = 51;
            // 
            // nombree
            // 
            this.nombree.HeaderText = "Nombre";
            this.nombree.MinimumWidth = 6;
            this.nombree.Name = "nombree";
            this.nombree.Width = 91;
            // 
            // apellidoe
            // 
            this.apellidoe.HeaderText = "Apellido";
            this.apellidoe.MinimumWidth = 6;
            this.apellidoe.Name = "apellidoe";
            this.apellidoe.Width = 95;
            // 
            // usuarioe
            // 
            this.usuarioe.HeaderText = "Usuario";
            this.usuarioe.MinimumWidth = 6;
            this.usuarioe.Name = "usuarioe";
            this.usuarioe.Width = 84;
            // 
            // contraseñae
            // 
            this.contraseñae.HeaderText = "Contraseña";
            this.contraseñae.MinimumWidth = 6;
            this.contraseñae.Name = "contraseñae";
            this.contraseñae.Width = 123;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.Width = 93;
            // 
            // edade
            // 
            this.edade.HeaderText = "Edad";
            this.edade.MinimumWidth = 6;
            this.edade.Name = "edade";
            this.edade.Width = 65;
            // 
            // puestoe
            // 
            this.puestoe.HeaderText = "Puesto";
            this.puestoe.MinimumWidth = 6;
            this.puestoe.Name = "puestoe";
            this.puestoe.Width = 76;
            // 
            // sueldoe
            // 
            this.sueldoe.HeaderText = "Sueldo";
            this.sueldoe.MinimumWidth = 6;
            this.sueldoe.Name = "sueldoe";
            this.sueldoe.Text = "";
            this.sueldoe.Width = 79;
            // 
            // calleE
            // 
            this.calleE.HeaderText = "Calle";
            this.calleE.MinimumWidth = 6;
            this.calleE.Name = "calleE";
            this.calleE.Width = 66;
            // 
            // numeroe
            // 
            this.numeroe.HeaderText = "Numero";
            this.numeroe.MinimumWidth = 6;
            this.numeroe.Name = "numeroe";
            this.numeroe.Width = 112;
            // 
            // coloniae
            // 
            this.coloniae.HeaderText = "Colonia";
            this.coloniae.MinimumWidth = 6;
            this.coloniae.Name = "coloniae";
            this.coloniae.Width = 112;
            // 
            // estado
            // 
            this.estado.HeaderText = "estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.Width = 103;
            // 
            // localidade
            // 
            this.localidade.HeaderText = "Localidad";
            this.localidade.MinimumWidth = 6;
            this.localidade.Name = "localidade";
            this.localidade.Width = 133;
            // 
            // btnvertodoe
            // 
            this.btnvertodoe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnvertodoe.FlatAppearance.BorderSize = 0;
            this.btnvertodoe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnvertodoe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnvertodoe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvertodoe.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvertodoe.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnvertodoe.Location = new System.Drawing.Point(473, 57);
            this.btnvertodoe.Name = "btnvertodoe";
            this.btnvertodoe.Size = new System.Drawing.Size(152, 31);
            this.btnvertodoe.TabIndex = 36;
            this.btnvertodoe.Text = "Ver Todo";
            this.btnvertodoe.UseVisualStyleBackColor = false;
            // 
            // FrmBuscarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarEmpleado";
            this.Text = "buscar empleado";
            this.Load += new System.EventHandler(this.buscarempleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbproductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnacceder;
        private System.Windows.Forms.TextBox txtempleado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvbproductos;
        private System.Windows.Forms.DataGridViewLinkColumn rfc;
        private System.Windows.Forms.DataGridViewLinkColumn nombree;
        private System.Windows.Forms.DataGridViewLinkColumn apellidoe;
        private System.Windows.Forms.DataGridViewLinkColumn usuarioe;
        private System.Windows.Forms.DataGridViewLinkColumn contraseñae;
        private System.Windows.Forms.DataGridViewLinkColumn telefono;
        private System.Windows.Forms.DataGridViewLinkColumn edade;
        private System.Windows.Forms.DataGridViewLinkColumn puestoe;
        private System.Windows.Forms.DataGridViewLinkColumn sueldoe;
        private System.Windows.Forms.DataGridViewLinkColumn calleE;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroe;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloniae;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidade;
        private System.Windows.Forms.Button btnvertodoe;
    }
}