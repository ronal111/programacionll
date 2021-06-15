
namespace proyectop2
{
    partial class FRM_Modelos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbuscarmodelos = new System.Windows.Forms.TextBox();
            this.dgvmodelo = new System.Windows.Forms.DataGridView();
            this.mostarmodelos = new FontAwesome.Sharp.IconButton();
            this.gbreprod = new System.Windows.Forms.GroupBox();
            this.cboxmarca = new System.Windows.Forms.ComboBox();
            this.lblidmodelo = new System.Windows.Forms.Label();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.lblfkmarca = new System.Windows.Forms.Label();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmodelo)).BeginInit();
            this.gbreprod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbuscarmodelos);
            this.groupBox2.Controls.Add(this.dgvmodelo);
            this.groupBox2.Controls.Add(this.mostarmodelos);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 235);
            this.groupBox2.TabIndex = 146;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Modelo";
            // 
            // txtbuscarmodelos
            // 
            this.txtbuscarmodelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtbuscarmodelos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscarmodelos.ForeColor = System.Drawing.Color.White;
            this.txtbuscarmodelos.Location = new System.Drawing.Point(20, 20);
            this.txtbuscarmodelos.Name = "txtbuscarmodelos";
            this.txtbuscarmodelos.Size = new System.Drawing.Size(175, 28);
            this.txtbuscarmodelos.TabIndex = 160;
            this.txtbuscarmodelos.TextChanged += new System.EventHandler(this.txtbuscarmodelos_TextChanged);
            // 
            // dgvmodelo
            // 
            this.dgvmodelo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvmodelo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvmodelo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvmodelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvmodelo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvmodelo.ColumnHeadersHeight = 29;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvmodelo.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvmodelo.EnableHeadersVisualStyles = false;
            this.dgvmodelo.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvmodelo.Location = new System.Drawing.Point(20, 77);
            this.dgvmodelo.Name = "dgvmodelo";
            this.dgvmodelo.RowHeadersWidth = 51;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvmodelo.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvmodelo.RowTemplate.Height = 24;
            this.dgvmodelo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvmodelo.Size = new System.Drawing.Size(476, 125);
            this.dgvmodelo.TabIndex = 20;
            this.dgvmodelo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmodelo_CellContentClick);
            // 
            // mostarmodelos
            // 
            this.mostarmodelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mostarmodelos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mostarmodelos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.mostarmodelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mostarmodelos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mostarmodelos.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.mostarmodelos.IconColor = System.Drawing.Color.White;
            this.mostarmodelos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mostarmodelos.IconSize = 35;
            this.mostarmodelos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mostarmodelos.Location = new System.Drawing.Point(240, 14);
            this.mostarmodelos.Name = "mostarmodelos";
            this.mostarmodelos.Size = new System.Drawing.Size(171, 34);
            this.mostarmodelos.TabIndex = 18;
            this.mostarmodelos.Text = "Mostrar Todo";
            this.mostarmodelos.UseVisualStyleBackColor = false;
            this.mostarmodelos.Click += new System.EventHandler(this.mostarmodelos_Click);
            // 
            // gbreprod
            // 
            this.gbreprod.Controls.Add(this.cboxmarca);
            this.gbreprod.Controls.Add(this.lblidmodelo);
            this.gbreprod.Controls.Add(this.btnActualizar);
            this.gbreprod.Controls.Add(this.lblfkmarca);
            this.gbreprod.Controls.Add(this.btncancelar);
            this.gbreprod.Controls.Add(this.btnGuardar);
            this.gbreprod.Controls.Add(this.label6);
            this.gbreprod.Controls.Add(this.txtmodelo);
            this.gbreprod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbreprod.Location = new System.Drawing.Point(12, 12);
            this.gbreprod.Name = "gbreprod";
            this.gbreprod.Size = new System.Drawing.Size(635, 186);
            this.gbreprod.TabIndex = 145;
            this.gbreprod.TabStop = false;
            this.gbreprod.Text = "Registrar Modelo";
            // 
            // cboxmarca
            // 
            this.cboxmarca.FormattingEnabled = true;
            this.cboxmarca.Location = new System.Drawing.Point(336, 53);
            this.cboxmarca.Name = "cboxmarca";
            this.cboxmarca.Size = new System.Drawing.Size(150, 24);
            this.cboxmarca.TabIndex = 57;
            // 
            // lblidmodelo
            // 
            this.lblidmodelo.AutoSize = true;
            this.lblidmodelo.Location = new System.Drawing.Point(43, 87);
            this.lblidmodelo.Name = "lblidmodelo";
            this.lblidmodelo.Size = new System.Drawing.Size(0, 17);
            this.lblidmodelo.TabIndex = 56;
            this.lblidmodelo.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnActualizar.Enabled = false;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnActualizar.IconColor = System.Drawing.Color.White;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 35;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(236, 123);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(179, 36);
            this.btnActualizar.TabIndex = 55;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblfkmarca
            // 
            this.lblfkmarca.AutoSize = true;
            this.lblfkmarca.Location = new System.Drawing.Point(90, 133);
            this.lblfkmarca.Name = "lblfkmarca";
            this.lblfkmarca.Size = new System.Drawing.Size(0, 17);
            this.lblfkmarca.TabIndex = 51;
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
            this.btncancelar.Location = new System.Drawing.Point(425, 123);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(160, 36);
            this.btncancelar.TabIndex = 16;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 35;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(37, 123);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(179, 36);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(33, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Modelo:";
            // 
            // txtmodelo
            // 
            this.txtmodelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtmodelo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodelo.ForeColor = System.Drawing.SystemColors.Info;
            this.txtmodelo.Location = new System.Drawing.Point(133, 50);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(175, 28);
            this.txtmodelo.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FRM_Modelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(660, 459);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbreprod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Modelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Modelos";
            this.Load += new System.EventHandler(this.FRM_Modelos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmodelo)).EndInit();
            this.gbreprod.ResumeLayout(false);
            this.gbreprod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbuscarmodelos;
        private System.Windows.Forms.DataGridView dgvmodelo;
        private FontAwesome.Sharp.IconButton mostarmodelos;
        private System.Windows.Forms.GroupBox gbreprod;
        private System.Windows.Forms.Label lblidmodelo;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private System.Windows.Forms.Label lblfkmarca;
        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.ComboBox cboxmarca;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}