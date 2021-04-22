
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
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.ibtnaddempleados = new FontAwesome.Sharp.IconButton();
            this.btbbuscarp = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtbuscarempleado = new System.Windows.Forms.TextBox();
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
            this.localidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.ibtnaddempleados);
            this.panel1.Controls.Add(this.btbbuscarp);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtbuscarempleado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 149);
            this.panel1.TabIndex = 11;
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
            this.iconButton2.Location = new System.Drawing.Point(478, 62);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(163, 38);
            this.iconButton2.TabIndex = 40;
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
            this.iconButton1.Location = new System.Drawing.Point(766, 17);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(122, 36);
            this.iconButton1.TabIndex = 39;
            this.iconButton1.Text = "Eliminar";
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
            this.ibtnaddempleados.Location = new System.Drawing.Point(647, 18);
            this.ibtnaddempleados.Name = "ibtnaddempleados";
            this.ibtnaddempleados.Size = new System.Drawing.Size(113, 36);
            this.ibtnaddempleados.TabIndex = 38;
            this.ibtnaddempleados.Text = "Editar";
            this.ibtnaddempleados.UseVisualStyleBackColor = false;
            this.ibtnaddempleados.Click += new System.EventHandler(this.ibtnaddempleados_Click);
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
            this.btbbuscarp.Location = new System.Drawing.Point(478, 18);
            this.btbbuscarp.Name = "btbbuscarp";
            this.btbbuscarp.Size = new System.Drawing.Size(163, 38);
            this.btbbuscarp.TabIndex = 37;
            this.btbbuscarp.Text = "Buscar";
            this.btbbuscarp.UseVisualStyleBackColor = false;
            this.btbbuscarp.Click += new System.EventHandler(this.btbbuscarp_Click);
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
            // txtbuscarempleado
            // 
            this.txtbuscarempleado.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtbuscarempleado.Location = new System.Drawing.Point(110, 26);
            this.txtbuscarempleado.Name = "txtbuscarempleado";
            this.txtbuscarempleado.Size = new System.Drawing.Size(144, 22);
            this.txtbuscarempleado.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvbproductos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1384, 454);
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
            this.localidade,
            this.clestado});
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
            this.dgvbproductos.Size = new System.Drawing.Size(1384, 454);
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
            // localidade
            // 
            this.localidade.HeaderText = "Localidad";
            this.localidade.MinimumWidth = 6;
            this.localidade.Name = "localidade";
            this.localidade.Width = 133;
            // 
            // clestado
            // 
            this.clestado.HeaderText = "Estado";
            this.clestado.MinimumWidth = 6;
            this.clestado.Name = "clestado";
            this.clestado.Width = 101;
            // 
            // FrmBuscarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1384, 615);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtbuscarempleado;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn localidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clestado;
        private FontAwesome.Sharp.IconButton btbbuscarp;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        public FontAwesome.Sharp.IconButton ibtnaddempleados;
    }
}