namespace WindowsFormsApp6_SISTEMA_APRENDIZAJE
{
    partial class Registrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.LabelContraNuevaLogin = new System.Windows.Forms.Label();
            this.LabelUsuarioNuevoLogin = new System.Windows.Forms.Label();
            this.txtContraseñaR = new System.Windows.Forms.TextBox();
            this.txtUsuarioR = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 30);
            this.label1.TabIndex = 29;
            this.label1.Text = "REGISTRATE";
            // 
            // LabelContraNuevaLogin
            // 
            this.LabelContraNuevaLogin.AutoSize = true;
            this.LabelContraNuevaLogin.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelContraNuevaLogin.Location = new System.Drawing.Point(48, 243);
            this.LabelContraNuevaLogin.Name = "LabelContraNuevaLogin";
            this.LabelContraNuevaLogin.Size = new System.Drawing.Size(97, 13);
            this.LabelContraNuevaLogin.TabIndex = 28;
            this.LabelContraNuevaLogin.Text = "CONTRASEÑA";
            // 
            // LabelUsuarioNuevoLogin
            // 
            this.LabelUsuarioNuevoLogin.AutoSize = true;
            this.LabelUsuarioNuevoLogin.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuarioNuevoLogin.Location = new System.Drawing.Point(75, 159);
            this.LabelUsuarioNuevoLogin.Name = "LabelUsuarioNuevoLogin";
            this.LabelUsuarioNuevoLogin.Size = new System.Drawing.Size(70, 13);
            this.LabelUsuarioNuevoLogin.TabIndex = 27;
            this.LabelUsuarioNuevoLogin.Text = "USUARIO";
            // 
            // txtContraseñaR
            // 
            this.txtContraseñaR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContraseñaR.ForeColor = System.Drawing.Color.White;
            this.txtContraseñaR.Location = new System.Drawing.Point(167, 238);
            this.txtContraseñaR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContraseñaR.Name = "txtContraseñaR";
            this.txtContraseñaR.Size = new System.Drawing.Size(143, 22);
            this.txtContraseñaR.TabIndex = 26;
            // 
            // txtUsuarioR
            // 
            this.txtUsuarioR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuarioR.ForeColor = System.Drawing.Color.White;
            this.txtUsuarioR.Location = new System.Drawing.Point(167, 154);
            this.txtUsuarioR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuarioR.Name = "txtUsuarioR";
            this.txtUsuarioR.Size = new System.Drawing.Size(143, 22);
            this.txtUsuarioR.TabIndex = 25;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(78, 288);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(205, 32);
            this.btnRegistrar.TabIndex = 24;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(78, 67);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(205, 73);
            this.picBox1.TabIndex = 30;
            this.picBox1.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.DarkGray;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Location = new System.Drawing.Point(12, 355);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(92, 38);
            this.btnRegresar.TabIndex = 31;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(377, 405);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelContraNuevaLogin);
            this.Controls.Add(this.LabelUsuarioNuevoLogin);
            this.Controls.Add(this.txtContraseñaR);
            this.Controls.Add(this.txtUsuarioR);
            this.Controls.Add(this.btnRegistrar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registrar";
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.Registrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelContraNuevaLogin;
        private System.Windows.Forms.Label LabelUsuarioNuevoLogin;
        private System.Windows.Forms.TextBox txtContraseñaR;
        private System.Windows.Forms.TextBox txtUsuarioR;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.Button btnRegresar;
    }
}