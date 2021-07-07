
namespace proyectop2
{
    partial class FrmReporteVentas
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvbproductos = new System.Windows.Forms.DataGridView();
            this.folioventa = new System.Windows.Forms.DataGridViewLinkColumn();
            this.fechav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrep = new System.Windows.Forms.DataGridViewLinkColumn();
            this.marcap = new System.Windows.Forms.DataGridViewLinkColumn();
            this.modelop = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cantidadp = new System.Windows.Forms.DataGridViewLinkColumn();
            this.precio = new System.Windows.Forms.DataGridViewLinkColumn();
            this.preciov = new System.Windows.Forms.DataGridViewLinkColumn();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reporteventas1 = new proyectop2.reportes.reporteventas();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbproductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.crystalReportViewer1);
            this.panel2.Controls.Add(this.dgvbproductos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1387, 727);
            this.panel2.TabIndex = 93;
            // 
            // dgvbproductos
            // 
            this.dgvbproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvbproductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvbproductos.BackgroundColor = System.Drawing.Color.Black;
            this.dgvbproductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbproductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvbproductos.ColumnHeadersHeight = 29;
            this.dgvbproductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folioventa,
            this.fechav,
            this.nombrep,
            this.marcap,
            this.modelop,
            this.cantidadp,
            this.precio,
            this.preciov});
            this.dgvbproductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvbproductos.EnableHeadersVisualStyles = false;
            this.dgvbproductos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvbproductos.Location = new System.Drawing.Point(0, 0);
            this.dgvbproductos.Name = "dgvbproductos";
            this.dgvbproductos.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvbproductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvbproductos.RowTemplate.Height = 24;
            this.dgvbproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbproductos.Size = new System.Drawing.Size(1387, 727);
            this.dgvbproductos.TabIndex = 4;
            // 
            // folioventa
            // 
            this.folioventa.HeaderText = "Folio De Venta";
            this.folioventa.MinimumWidth = 6;
            this.folioventa.Name = "folioventa";
            this.folioventa.Width = 149;
            // 
            // fechav
            // 
            this.fechav.HeaderText = "Fecha De Venta";
            this.fechav.MinimumWidth = 6;
            this.fechav.Name = "fechav";
            this.fechav.Width = 186;
            // 
            // nombrep
            // 
            this.nombrep.HeaderText = "nombre";
            this.nombrep.MinimumWidth = 6;
            this.nombrep.Name = "nombrep";
            this.nombrep.Width = 88;
            // 
            // marcap
            // 
            this.marcap.HeaderText = "marca";
            this.marcap.MinimumWidth = 6;
            this.marcap.Name = "marcap";
            this.marcap.Width = 78;
            // 
            // modelop
            // 
            this.modelop.HeaderText = "modelo";
            this.modelop.MinimumWidth = 6;
            this.modelop.Name = "modelop";
            this.modelop.Width = 88;
            // 
            // cantidadp
            // 
            this.cantidadp.HeaderText = "Vendidos";
            this.cantidadp.MinimumWidth = 6;
            this.cantidadp.Name = "cantidadp";
            this.cantidadp.Width = 103;
            // 
            // precio
            // 
            this.precio.HeaderText = "precio compra";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.Width = 155;
            // 
            // preciov
            // 
            this.preciov.HeaderText = "precio venta";
            this.preciov.MinimumWidth = 6;
            this.preciov.Name = "preciov";
            this.preciov.Width = 134;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1387, 727);
            this.crystalReportViewer1.TabIndex = 5;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = this.reporteventas1;
            this.crystalReportViewer2.Size = new System.Drawing.Size(1387, 727);
            this.crystalReportViewer2.TabIndex = 6;
            this.crystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crystalReportViewer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 727);
            this.panel1.TabIndex = 7;
            // 
            // FrmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1387, 725);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteVentas";
            this.Text = "FrmReporteVentas";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbproductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvbproductos;
        private System.Windows.Forms.DataGridViewLinkColumn folioventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechav;
        private System.Windows.Forms.DataGridViewLinkColumn nombrep;
        private System.Windows.Forms.DataGridViewLinkColumn marcap;
        private System.Windows.Forms.DataGridViewLinkColumn modelop;
        private System.Windows.Forms.DataGridViewLinkColumn cantidadp;
        private System.Windows.Forms.DataGridViewLinkColumn precio;
        private System.Windows.Forms.DataGridViewLinkColumn preciov;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private reportes.reporteventas reporteventas1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panel1;
    }
}