namespace WindowsFormsApp6_SISTEMA_APRENDIZAJE
{
    partial class PanelPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNombrePanelPrincipal = new System.Windows.Forms.Label();
            this.ButtonRegresarPanelPrincipal = new System.Windows.Forms.Button();
            this.btnComunicacion = new System.Windows.Forms.Button();
            this.btnMatematica = new System.Windows.Forms.Button();
            this.btnPro = new System.Windows.Forms.Button();
            this.DgTabPanPrin = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgTabPanPrin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 456);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelNombrePanelPrincipal
            // 
            this.labelNombrePanelPrincipal.AutoSize = true;
            this.labelNombrePanelPrincipal.BackColor = System.Drawing.Color.Gold;
            this.labelNombrePanelPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombrePanelPrincipal.Location = new System.Drawing.Point(729, 60);
            this.labelNombrePanelPrincipal.Name = "labelNombrePanelPrincipal";
            this.labelNombrePanelPrincipal.Size = new System.Drawing.Size(59, 20);
            this.labelNombrePanelPrincipal.TabIndex = 16;
            this.labelNombrePanelPrincipal.Text = "label2";
            // 
            // ButtonRegresarPanelPrincipal
            // 
            this.ButtonRegresarPanelPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRegresarPanelPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRegresarPanelPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRegresarPanelPrincipal.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.ButtonRegresarPanelPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRegresarPanelPrincipal.Image")));
            this.ButtonRegresarPanelPrincipal.Location = new System.Drawing.Point(21, 390);
            this.ButtonRegresarPanelPrincipal.Name = "ButtonRegresarPanelPrincipal";
            this.ButtonRegresarPanelPrincipal.Size = new System.Drawing.Size(134, 36);
            this.ButtonRegresarPanelPrincipal.TabIndex = 14;
            this.ButtonRegresarPanelPrincipal.UseVisualStyleBackColor = true;
            this.ButtonRegresarPanelPrincipal.Click += new System.EventHandler(this.ButtonRegresarPanelPrincipal_Click_1);
            // 
            // btnComunicacion
            // 
            this.btnComunicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComunicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComunicacion.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComunicacion.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnComunicacion.Image = ((System.Drawing.Image)(resources.GetObject("btnComunicacion.Image")));
            this.btnComunicacion.Location = new System.Drawing.Point(244, 219);
            this.btnComunicacion.Name = "btnComunicacion";
            this.btnComunicacion.Size = new System.Drawing.Size(178, 44);
            this.btnComunicacion.TabIndex = 13;
            this.btnComunicacion.UseVisualStyleBackColor = true;
            this.btnComunicacion.Click += new System.EventHandler(this.btnComunicacion_Click);
            // 
            // btnMatematica
            // 
            this.btnMatematica.BackColor = System.Drawing.Color.Transparent;
            this.btnMatematica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatematica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatematica.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatematica.ForeColor = System.Drawing.Color.Sienna;
            this.btnMatematica.Image = ((System.Drawing.Image)(resources.GetObject("btnMatematica.Image")));
            this.btnMatematica.Location = new System.Drawing.Point(254, 102);
            this.btnMatematica.Name = "btnMatematica";
            this.btnMatematica.Size = new System.Drawing.Size(168, 49);
            this.btnMatematica.TabIndex = 12;
            this.btnMatematica.UseVisualStyleBackColor = false;
            this.btnMatematica.Click += new System.EventHandler(this.btnMatematica_Click);
            // 
            // btnPro
            // 
            this.btnPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPro.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPro.ForeColor = System.Drawing.Color.Olive;
            this.btnPro.Image = ((System.Drawing.Image)(resources.GetObject("btnPro.Image")));
            this.btnPro.Location = new System.Drawing.Point(244, 338);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(181, 43);
            this.btnPro.TabIndex = 18;
            this.btnPro.UseVisualStyleBackColor = true;
            this.btnPro.Click += new System.EventHandler(this.btnPro_Click);
            // 
            // DgTabPanPrin
            // 
            this.DgTabPanPrin.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.DgTabPanPrin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgTabPanPrin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Puntaje});
            this.DgTabPanPrin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DgTabPanPrin.Location = new System.Drawing.Point(483, 148);
            this.DgTabPanPrin.Name = "DgTabPanPrin";
            this.DgTabPanPrin.RowHeadersWidth = 51;
            this.DgTabPanPrin.RowTemplate.Height = 24;
            this.DgTabPanPrin.Size = new System.Drawing.Size(274, 167);
            this.DgTabPanPrin.TabIndex = 19;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Puntaje
            // 
            this.Puntaje.HeaderText = "Puntaje";
            this.Puntaje.MinimumWidth = 6;
            this.Puntaje.Name = "Puntaje";
            this.Puntaje.Width = 125;
            // 
            // PanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgTabPanPrin);
            this.Controls.Add(this.btnPro);
            this.Controls.Add(this.labelNombrePanelPrincipal);
            this.Controls.Add(this.ButtonRegresarPanelPrincipal);
            this.Controls.Add(this.btnComunicacion);
            this.Controls.Add(this.btnMatematica);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PanelPrincipal";
            this.Text = "PanelPrincipal";
            this.Load += new System.EventHandler(this.PanelPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgTabPanPrin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNombrePanelPrincipal;
        private System.Windows.Forms.Button ButtonRegresarPanelPrincipal;
        private System.Windows.Forms.Button btnComunicacion;
        private System.Windows.Forms.Button btnMatematica;
        private System.Windows.Forms.Button btnPro;
        private System.Windows.Forms.DataGridView DgTabPanPrin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntaje;
    }
}