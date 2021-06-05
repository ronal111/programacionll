
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvbempleados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selecall = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.ibtnaddempleados = new FontAwesome.Sharp.IconButton();
            this.btbbuscarp = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtbuscarempleado = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbempleados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1337, 615);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Empleado";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvbempleados);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(54, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1234, 303);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contenido";
            // 
            // dgvbempleados
            // 
            this.dgvbempleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvbempleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvbempleados.BackgroundColor = System.Drawing.Color.Black;
            this.dgvbempleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbempleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvbempleados.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvbempleados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvbempleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvbempleados.EnableHeadersVisualStyles = false;
            this.dgvbempleados.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvbempleados.Location = new System.Drawing.Point(3, 18);
            this.dgvbempleados.Name = "dgvbempleados";
            this.dgvbempleados.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvbempleados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvbempleados.RowTemplate.Height = 24;
            this.dgvbempleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvbempleados.Size = new System.Drawing.Size(1228, 282);
            this.dgvbempleados.TabIndex = 15;
            this.dgvbempleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbempleados_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.selecall);
            this.groupBox1.Controls.Add(this.iconButton1);
            this.groupBox1.Controls.Add(this.ibtnaddempleados);
            this.groupBox1.Controls.Add(this.btbbuscarp);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtbuscarempleado);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(50, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1238, 142);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // selecall
            // 
            this.selecall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.selecall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.selecall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.selecall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selecall.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selecall.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.selecall.IconColor = System.Drawing.Color.White;
            this.selecall.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.selecall.IconSize = 35;
            this.selecall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selecall.Location = new System.Drawing.Point(434, 85);
            this.selecall.Name = "selecall";
            this.selecall.Size = new System.Drawing.Size(163, 38);
            this.selecall.TabIndex = 10;
            this.selecall.Text = "Mostrar Todo";
            this.selecall.UseVisualStyleBackColor = false;
            this.selecall.Click += new System.EventHandler(this.selecall_Click);
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
            this.iconButton1.Location = new System.Drawing.Point(722, 40);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(122, 36);
            this.iconButton1.TabIndex = 12;
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
            this.ibtnaddempleados.Location = new System.Drawing.Point(603, 41);
            this.ibtnaddempleados.Name = "ibtnaddempleados";
            this.ibtnaddempleados.Size = new System.Drawing.Size(113, 36);
            this.ibtnaddempleados.TabIndex = 11;
            this.ibtnaddempleados.Text = "Editar";
            this.ibtnaddempleados.UseVisualStyleBackColor = false;
            // 
            // btbbuscarp
            // 
            this.btbbuscarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btbbuscarp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btbbuscarp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btbbuscarp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btbbuscarp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btbbuscarp.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btbbuscarp.IconColor = System.Drawing.Color.White;
            this.btbbuscarp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btbbuscarp.IconSize = 35;
            this.btbbuscarp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbbuscarp.Location = new System.Drawing.Point(434, 41);
            this.btbbuscarp.Name = "btbbuscarp";
            this.btbbuscarp.Size = new System.Drawing.Size(163, 38);
            this.btbbuscarp.TabIndex = 9;
            this.btbbuscarp.Text = "Buscar";
            this.btbbuscarp.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(234, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // txtbuscarempleado
            // 
            this.txtbuscarempleado.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtbuscarempleado.Location = new System.Drawing.Point(66, 49);
            this.txtbuscarempleado.Name = "txtbuscarempleado";
            this.txtbuscarempleado.Size = new System.Drawing.Size(144, 22);
            this.txtbuscarempleado.TabIndex = 7;
            // 
            // FrmBuscarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1337, 615);
            this.Controls.Add(this.groupBox3);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarEmpleado";
            this.Text = "buscar empleado";
            this.Load += new System.EventHandler(this.buscarempleado_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbempleados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvbempleados;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton selecall;
        private FontAwesome.Sharp.IconButton iconButton1;
        public FontAwesome.Sharp.IconButton ibtnaddempleados;
        private FontAwesome.Sharp.IconButton btbbuscarp;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtbuscarempleado;
    }
}