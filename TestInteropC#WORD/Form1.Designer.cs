namespace TestInteropC_WORD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnWord = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.txtDatoE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnWord
            // 
            this.BtnWord.Location = new System.Drawing.Point(466, 58);
            this.BtnWord.Name = "BtnWord";
            this.BtnWord.Size = new System.Drawing.Size(98, 48);
            this.BtnWord.TabIndex = 0;
            this.BtnWord.Text = "Guardar word";
            this.BtnWord.UseVisualStyleBackColor = true;
            this.BtnWord.Click += new System.EventHandler(this.BtnWord_Click);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(183, 58);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 22);
            this.txtDato.TabIndex = 1;
            this.txtDato.Text = "Hola Mundo";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(466, 189);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(106, 44);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "Guardar excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // txtDatoE
            // 
            this.txtDatoE.Location = new System.Drawing.Point(183, 189);
            this.txtDatoE.Name = "txtDatoE";
            this.txtDatoE.Size = new System.Drawing.Size(100, 22);
            this.txtDatoE.TabIndex = 3;
            this.txtDatoE.Text = "Hola Mundo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDatoE);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.BtnWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnWord;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.TextBox txtDatoE;
    }
}

