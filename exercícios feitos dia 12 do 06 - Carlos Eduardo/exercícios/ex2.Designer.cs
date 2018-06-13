namespace exercícios
{
    partial class ex2
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
            this.txb1 = new System.Windows.Forms.TextBox();
            this.btnexe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(12, 29);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(403, 20);
            this.txb1.TabIndex = 0;
            // 
            // btnexe
            // 
            this.btnexe.Location = new System.Drawing.Point(421, 16);
            this.btnexe.Name = "btnexe";
            this.btnexe.Size = new System.Drawing.Size(75, 45);
            this.btnexe.TabIndex = 1;
            this.btnexe.Text = "Executar";
            this.btnexe.UseVisualStyleBackColor = true;
            this.btnexe.Click += new System.EventHandler(this.btnexe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira o valor abaixo:";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(12, 56);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 13);
            this.lblresult.TabIndex = 3;
            // 
            // ex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 80);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexe);
            this.Controls.Add(this.txb1);
            this.Name = "ex2";
            this.Text = "Ex. 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.Button btnexe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblresult;
    }
}