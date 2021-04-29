
namespace proyectop2
{
    partial class FrmBusquedaEmergente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusquedaEmergente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvbproductos = new System.Windows.Forms.DataGridView();
            this.codigop = new System.Windows.Forms.DataGridViewLinkColumn();
            this.nombrep = new System.Windows.Forms.DataGridViewLinkColumn();
            this.marcap = new System.Windows.Forms.DataGridViewLinkColumn();
            this.modelop = new System.Windows.Forms.DataGridViewLinkColumn();
            this.categoriap = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cantidadp = new System.Windows.Forms.DataGridViewLinkColumn();
            this.preciov = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnmini = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvbproductos);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 415);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "busqueda emergente";
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
            this.codigop,
            this.nombrep,
            this.marcap,
            this.modelop,
            this.categoriap,
            this.cantidadp,
            this.preciov});
            this.dgvbproductos.EnableHeadersVisualStyles = false;
            this.dgvbproductos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvbproductos.Location = new System.Drawing.Point(6, 21);
            this.dgvbproductos.Name = "dgvbproductos";
            this.dgvbproductos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvbproductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvbproductos.RowTemplate.Height = 24;
            this.dgvbproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbproductos.Size = new System.Drawing.Size(935, 358);
            this.dgvbproductos.TabIndex = 39;
            // 
            // codigop
            // 
            this.codigop.HeaderText = "Codigo De Producto";
            this.codigop.MinimumWidth = 6;
            this.codigop.Name = "codigop";
            this.codigop.Width = 204;
            // 
            // nombrep
            // 
            this.nombrep.HeaderText = "Nombre";
            this.nombrep.MinimumWidth = 6;
            this.nombrep.Name = "nombrep";
            this.nombrep.Width = 91;
            // 
            // marcap
            // 
            this.marcap.HeaderText = "Marca";
            this.marcap.MinimumWidth = 6;
            this.marcap.Name = "marcap";
            this.marcap.Width = 77;
            // 
            // modelop
            // 
            this.modelop.HeaderText = "Modelo";
            this.modelop.MinimumWidth = 6;
            this.modelop.Name = "modelop";
            this.modelop.Width = 87;
            // 
            // categoriap
            // 
            this.categoriap.HeaderText = "Categoria";
            this.categoriap.MinimumWidth = 6;
            this.categoriap.Name = "categoriap";
            this.categoriap.Width = 111;
            // 
            // cantidadp
            // 
            this.cantidadp.HeaderText = "Descripcion";
            this.cantidadp.MinimumWidth = 6;
            this.cantidadp.Name = "cantidadp";
            this.cantidadp.Width = 125;
            // 
            // preciov
            // 
            this.preciov.HeaderText = "Precio Venta";
            this.preciov.MinimumWidth = 6;
            this.preciov.Name = "preciov";
            this.preciov.Width = 134;
            // 
            // btnmini
            // 
            this.btnmini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmini.Image = ((System.Drawing.Image)(resources.GetObject("btnmini.Image")));
            this.btnmini.Location = new System.Drawing.Point(893, 12);
            this.btnmini.Name = "btnmini";
            this.btnmini.Size = new System.Drawing.Size(33, 25);
            this.btnmini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmini.TabIndex = 41;
            this.btnmini.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(932, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // FrmBusquedaEmergente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(988, 548);
            this.Controls.Add(this.btnmini);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBusquedaEmergente";
            this.Text = "FrmBusquedaEmergente";
            this.Load += new System.EventHandler(this.FrmBusquedaEmergente_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvbproductos;
        private System.Windows.Forms.DataGridViewLinkColumn codigop;
        private System.Windows.Forms.DataGridViewLinkColumn nombrep;
        private System.Windows.Forms.DataGridViewLinkColumn marcap;
        private System.Windows.Forms.DataGridViewLinkColumn modelop;
        private System.Windows.Forms.DataGridViewLinkColumn categoriap;
        private System.Windows.Forms.DataGridViewLinkColumn cantidadp;
        private System.Windows.Forms.DataGridViewLinkColumn preciov;
        private System.Windows.Forms.PictureBox btnmini;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}