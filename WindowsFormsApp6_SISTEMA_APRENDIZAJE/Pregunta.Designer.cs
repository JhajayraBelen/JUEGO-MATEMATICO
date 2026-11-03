namespace WindowsFormsApp6_SISTEMA_APRENDIZAJE
{
    partial class Pregunta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pregunta));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.RdbtOp3Preguntas = new System.Windows.Forms.RadioButton();
            this.RdbtOp2Preguntas = new System.Windows.Forms.RadioButton();
            this.RdbtOp1Preguntas = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblDificultad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-5, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(810, 459);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.BackColor = System.Drawing.Color.White;
            this.lblEnunciado.Font = new System.Drawing.Font("OCR A Extended", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(275, 95);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(55, 13);
            this.lblEnunciado.TabIndex = 19;
            this.lblEnunciado.Text = "label1";
            this.lblEnunciado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.Navy;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(48, 355);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(134, 54);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // RdbtOp3Preguntas
            // 
            this.RdbtOp3Preguntas.AutoSize = true;
            this.RdbtOp3Preguntas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.RdbtOp3Preguntas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdbtOp3Preguntas.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbtOp3Preguntas.Location = new System.Drawing.Point(587, 236);
            this.RdbtOp3Preguntas.Name = "RdbtOp3Preguntas";
            this.RdbtOp3Preguntas.Size = new System.Drawing.Size(124, 17);
            this.RdbtOp3Preguntas.TabIndex = 17;
            this.RdbtOp3Preguntas.TabStop = true;
            this.RdbtOp3Preguntas.Text = "radioButton3";
            this.RdbtOp3Preguntas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RdbtOp3Preguntas.UseVisualStyleBackColor = false;
            // 
            // RdbtOp2Preguntas
            // 
            this.RdbtOp2Preguntas.AutoSize = true;
            this.RdbtOp2Preguntas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.RdbtOp2Preguntas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdbtOp2Preguntas.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbtOp2Preguntas.Location = new System.Drawing.Point(312, 236);
            this.RdbtOp2Preguntas.Name = "RdbtOp2Preguntas";
            this.RdbtOp2Preguntas.Size = new System.Drawing.Size(124, 17);
            this.RdbtOp2Preguntas.TabIndex = 16;
            this.RdbtOp2Preguntas.TabStop = true;
            this.RdbtOp2Preguntas.Text = "radioButton2";
            this.RdbtOp2Preguntas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RdbtOp2Preguntas.UseVisualStyleBackColor = false;
            // 
            // RdbtOp1Preguntas
            // 
            this.RdbtOp1Preguntas.AutoSize = true;
            this.RdbtOp1Preguntas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.RdbtOp1Preguntas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdbtOp1Preguntas.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbtOp1Preguntas.Location = new System.Drawing.Point(58, 236);
            this.RdbtOp1Preguntas.Name = "RdbtOp1Preguntas";
            this.RdbtOp1Preguntas.Size = new System.Drawing.Size(124, 17);
            this.RdbtOp1Preguntas.TabIndex = 15;
            this.RdbtOp1Preguntas.TabStop = true;
            this.RdbtOp1Preguntas.Text = "radioButton1";
            this.RdbtOp1Preguntas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RdbtOp1Preguntas.UseVisualStyleBackColor = false;
            this.RdbtOp1Preguntas.CheckedChanged += new System.EventHandler(this.RdbtOp1Preguntas_CheckedChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.Navy;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(342, 355);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(136, 54);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // lblDificultad
            // 
            this.lblDificultad.AutoSize = true;
            this.lblDificultad.BackColor = System.Drawing.Color.White;
            this.lblDificultad.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDificultad.Location = new System.Drawing.Point(742, 152);
            this.lblDificultad.Name = "lblDificultad";
            this.lblDificultad.Size = new System.Drawing.Size(19, 18);
            this.lblDificultad.TabIndex = 13;
            this.lblDificultad.Text = "n";
            // 
            // Pregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.RdbtOp3Preguntas);
            this.Controls.Add(this.RdbtOp2Preguntas);
            this.Controls.Add(this.RdbtOp1Preguntas);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblDificultad);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Pregunta";
            this.Text = "Pregunta";
            this.Load += new System.EventHandler(this.Pregunta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RadioButton RdbtOp3Preguntas;
        private System.Windows.Forms.RadioButton RdbtOp2Preguntas;
        private System.Windows.Forms.RadioButton RdbtOp1Preguntas;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblDificultad;
    }
}