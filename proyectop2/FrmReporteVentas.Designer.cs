
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btbbuscarp = new FontAwesome.Sharp.IconButton();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblganancia = new System.Windows.Forms.Label();
            this.lbltotalventas = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbproductos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(462, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 66;
            this.label1.Text = "Total En Ventas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(782, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 67;
            this.label2.Text = "Ganancia libre:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btbbuscarp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 116);
            this.panel1.TabIndex = 92;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarForeColor = System.Drawing.Color.DimGray;
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePicker2.Location = new System.Drawing.Point(262, 57);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.DimGray;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 22);
            this.dateTimePicker1.TabIndex = 1;
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
            this.btbbuscarp.Location = new System.Drawing.Point(549, 49);
            this.btbbuscarp.Name = "btbbuscarp";
            this.btbbuscarp.Size = new System.Drawing.Size(158, 43);
            this.btbbuscarp.TabIndex = 3;
            this.btbbuscarp.Text = "Buscar";
            this.btbbuscarp.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvbproductos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1387, 471);
            this.panel2.TabIndex = 93;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvbproductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvbproductos.RowTemplate.Height = 24;
            this.dgvbproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbproductos.Size = new System.Drawing.Size(1387, 471);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.lblganancia);
            this.panel3.Controls.Add(this.lbltotalventas);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 587);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1387, 116);
            this.panel3.TabIndex = 94;
            // 
            // lblganancia
            // 
            this.lblganancia.AutoSize = true;
            this.lblganancia.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblganancia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblganancia.Location = new System.Drawing.Point(943, 76);
            this.lblganancia.Name = "lblganancia";
            this.lblganancia.Size = new System.Drawing.Size(150, 23);
            this.lblganancia.TabIndex = 94;
            this.lblganancia.Text = "______________";
            // 
            // lbltotalventas
            // 
            this.lbltotalventas.AutoSize = true;
            this.lbltotalventas.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalventas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltotalventas.Location = new System.Drawing.Point(630, 76);
            this.lbltotalventas.Name = "lbltotalventas";
            this.lbltotalventas.Size = new System.Drawing.Size(150, 23);
            this.lbltotalventas.TabIndex = 93;
            this.lbltotalventas.Text = "______________";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(879, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Imprimir Reporte";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(705, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1387, 725);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteVentas";
            this.Text = "FrmReporteVentas";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbproductos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblganancia;
        private System.Windows.Forms.Label lbltotalventas;
        private System.Windows.Forms.DataGridView dgvbproductos;
        private FontAwesome.Sharp.IconButton btbbuscarp;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridViewLinkColumn folioventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechav;
        private System.Windows.Forms.DataGridViewLinkColumn nombrep;
        private System.Windows.Forms.DataGridViewLinkColumn marcap;
        private System.Windows.Forms.DataGridViewLinkColumn modelop;
        private System.Windows.Forms.DataGridViewLinkColumn cantidadp;
        private System.Windows.Forms.DataGridViewLinkColumn precio;
        private System.Windows.Forms.DataGridViewLinkColumn preciov;
    }
}