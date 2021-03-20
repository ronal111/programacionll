
namespace proyectop2
{
    partial class buscarproducto
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvbproductos = new System.Windows.Forms.DataGridView();
            this.codigop = new System.Windows.Forms.DataGridViewLinkColumn();
            this.categoriap = new System.Windows.Forms.DataGridViewLinkColumn();
            this.marcap = new System.Windows.Forms.DataGridViewLinkColumn();
            this.modelop = new System.Windows.Forms.DataGridViewLinkColumn();
            this.nombrep = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colorp = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cantidadp = new System.Windows.Forms.DataGridViewLinkColumn();
            this.descripcionp = new System.Windows.Forms.DataGridViewLinkColumn();
            this.precio = new System.Windows.Forms.DataGridViewLinkColumn();
            this.preciov = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(235, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 22);
            this.textBox1.TabIndex = 2;
            // 
            // dgvbproductos
            // 
            this.dgvbproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvbproductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvbproductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvbproductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbproductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvbproductos.ColumnHeadersHeight = 29;
            this.dgvbproductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigop,
            this.categoriap,
            this.marcap,
            this.modelop,
            this.nombrep,
            this.colorp,
            this.cantidadp,
            this.descripcionp,
            this.precio,
            this.preciov});
            this.dgvbproductos.EnableHeadersVisualStyles = false;
            this.dgvbproductos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvbproductos.Location = new System.Drawing.Point(27, 101);
            this.dgvbproductos.Name = "dgvbproductos";
            this.dgvbproductos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvbproductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvbproductos.RowTemplate.Height = 24;
            this.dgvbproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbproductos.Size = new System.Drawing.Size(1160, 608);
            this.dgvbproductos.TabIndex = 3;
            // 
            // codigop
            // 
            this.codigop.HeaderText = "codigo";
            this.codigop.MinimumWidth = 6;
            this.codigop.Name = "codigop";
            this.codigop.Width = 74;
            // 
            // categoriap
            // 
            this.categoriap.HeaderText = "categoria";
            this.categoriap.MinimumWidth = 6;
            this.categoriap.Name = "categoriap";
            this.categoriap.Width = 94;
            // 
            // marcap
            // 
            this.marcap.HeaderText = "marca";
            this.marcap.MinimumWidth = 6;
            this.marcap.Name = "marcap";
            this.marcap.Width = 69;
            // 
            // modelop
            // 
            this.modelop.HeaderText = "modelo";
            this.modelop.MinimumWidth = 6;
            this.modelop.Name = "modelop";
            this.modelop.Width = 79;
            // 
            // nombrep
            // 
            this.nombrep.HeaderText = "nombre";
            this.nombrep.MinimumWidth = 6;
            this.nombrep.Name = "nombrep";
            this.nombrep.Width = 79;
            // 
            // colorp
            // 
            this.colorp.HeaderText = "color";
            this.colorp.MinimumWidth = 6;
            this.colorp.Name = "colorp";
            this.colorp.Width = 57;
            // 
            // cantidadp
            // 
            this.cantidadp.HeaderText = "disponibles";
            this.cantidadp.MinimumWidth = 6;
            this.cantidadp.Name = "cantidadp";
            this.cantidadp.Width = 108;
            // 
            // descripcionp
            // 
            this.descripcionp.HeaderText = "descripcion";
            this.descripcionp.MinimumWidth = 6;
            this.descripcionp.Name = "descripcionp";
            this.descripcionp.Width = 112;
            // 
            // precio
            // 
            this.precio.HeaderText = "precio compra";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.Width = 138;
            // 
            // preciov
            // 
            this.preciov.HeaderText = "precio venta";
            this.preciov.MinimumWidth = 6;
            this.preciov.Name = "preciov";
            this.preciov.Width = 119;
            // 
            // buscarproducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.dgvbproductos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "buscarproducto";
            this.Text = "buscarproducto";
            this.Load += new System.EventHandler(this.buscarproducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvbproductos;
        private System.Windows.Forms.DataGridViewLinkColumn codigop;
        private System.Windows.Forms.DataGridViewLinkColumn categoriap;
        private System.Windows.Forms.DataGridViewLinkColumn marcap;
        private System.Windows.Forms.DataGridViewLinkColumn modelop;
        private System.Windows.Forms.DataGridViewLinkColumn nombrep;
        private System.Windows.Forms.DataGridViewLinkColumn colorp;
        private System.Windows.Forms.DataGridViewLinkColumn cantidadp;
        private System.Windows.Forms.DataGridViewLinkColumn descripcionp;
        private System.Windows.Forms.DataGridViewLinkColumn precio;
        private System.Windows.Forms.DataGridViewLinkColumn preciov;
    }
}