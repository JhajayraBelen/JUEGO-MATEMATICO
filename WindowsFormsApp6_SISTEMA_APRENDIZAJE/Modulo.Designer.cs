namespace WindowsFormsApp6_SISTEMA_APRENDIZAJE
{
    partial class Modulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modulo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.LabelTituloModulos = new System.Windows.Forms.Label();
            this.btnModulo3 = new System.Windows.Forms.Button();
            this.btnModulo2 = new System.Windows.Forms.Button();
            this.btnModulo1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-3, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(869, 498);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistar
            // 
            this.btnRegistar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistar.ForeColor = System.Drawing.Color.Plum;
            this.btnRegistar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistar.Image")));
            this.btnRegistar.Location = new System.Drawing.Point(21, 32);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(140, 50);
            this.btnRegistar.TabIndex = 18;
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // LabelTituloModulos
            // 
            this.LabelTituloModulos.AutoSize = true;
            this.LabelTituloModulos.BackColor = System.Drawing.Color.White;
            this.LabelTituloModulos.Font = new System.Drawing.Font("OCR A Extended", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTituloModulos.Location = new System.Drawing.Point(299, 47);
            this.LabelTituloModulos.Name = "LabelTituloModulos";
            this.LabelTituloModulos.Size = new System.Drawing.Size(141, 35);
            this.LabelTituloModulos.TabIndex = 17;
            this.LabelTituloModulos.Text = "label1";
            // 
            // btnModulo3
            // 
            this.btnModulo3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModulo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModulo3.ForeColor = System.Drawing.Color.Firebrick;
            this.btnModulo3.Image = ((System.Drawing.Image)(resources.GetObject("btnModulo3.Image")));
            this.btnModulo3.Location = new System.Drawing.Point(380, 349);
            this.btnModulo3.Name = "btnModulo3";
            this.btnModulo3.Size = new System.Drawing.Size(150, 58);
            this.btnModulo3.TabIndex = 16;
            this.btnModulo3.UseVisualStyleBackColor = true;
            this.btnModulo3.Click += new System.EventHandler(this.btnModulo3_Click);
            // 
            // btnModulo2
            // 
            this.btnModulo2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModulo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModulo2.ForeColor = System.Drawing.Color.Firebrick;
            this.btnModulo2.Image = ((System.Drawing.Image)(resources.GetObject("btnModulo2.Image")));
            this.btnModulo2.Location = new System.Drawing.Point(578, 198);
            this.btnModulo2.Name = "btnModulo2";
            this.btnModulo2.Size = new System.Drawing.Size(140, 57);
            this.btnModulo2.TabIndex = 15;
            this.btnModulo2.UseVisualStyleBackColor = true;
            this.btnModulo2.Click += new System.EventHandler(this.btnModulo2_Click);
            // 
            // btnModulo1
            // 
            this.btnModulo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModulo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModulo1.ForeColor = System.Drawing.Color.Firebrick;
            this.btnModulo1.Image = ((System.Drawing.Image)(resources.GetObject("btnModulo1.Image")));
            this.btnModulo1.Location = new System.Drawing.Point(194, 198);
            this.btnModulo1.Name = "btnModulo1";
            this.btnModulo1.Size = new System.Drawing.Size(142, 72);
            this.btnModulo1.TabIndex = 14;
            this.btnModulo1.UseVisualStyleBackColor = true;
            this.btnModulo1.Click += new System.EventHandler(this.btnModulo1_Click);
            // 
            // Modulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 486);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.LabelTituloModulos);
            this.Controls.Add(this.btnModulo3);
            this.Controls.Add(this.btnModulo2);
            this.Controls.Add(this.btnModulo1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Modulo";
            this.Text = "Modulo";
            this.Load += new System.EventHandler(this.Modulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Label LabelTituloModulos;
        private System.Windows.Forms.Button btnModulo3;
        private System.Windows.Forms.Button btnModulo2;
        private System.Windows.Forms.Button btnModulo1;
    }
}