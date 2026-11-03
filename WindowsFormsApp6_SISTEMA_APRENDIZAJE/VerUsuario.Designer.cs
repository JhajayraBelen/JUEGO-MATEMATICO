namespace WindowsFormsApp6_SISTEMA_APRENDIZAJE
{
    partial class VerUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerUsuario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.USUARIOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(759, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(485, 198);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(192, 67);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.Black;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USUARIOS});
            this.dgvUsuarios.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvUsuarios.Location = new System.Drawing.Point(55, 34);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(223, 290);
            this.dgvUsuarios.TabIndex = 4;
            // 
            // USUARIOS
            // 
            this.USUARIOS.HeaderText = "USUARIOS";
            this.USUARIOS.MinimumWidth = 6;
            this.USUARIOS.Name = "USUARIOS";
            this.USUARIOS.Width = 125;
            // 
            // txtEliminar
            // 
            this.txtEliminar.BackColor = System.Drawing.Color.DimGray;
            this.txtEliminar.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliminar.ForeColor = System.Drawing.Color.Black;
            this.txtEliminar.Location = new System.Drawing.Point(472, 118);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(193, 31);
            this.txtEliminar.TabIndex = 3;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(30, 340);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(137, 47);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // VerUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 409);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VerUsuario";
            this.Text = "VerUsuario";
            this.Load += new System.EventHandler(this.VerUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIOS;
        private System.Windows.Forms.Button btnRegresar;
    }
}