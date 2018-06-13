namespace exercícios
{
    partial class ex3
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
            this.btnExecutar = new System.Windows.Forms.Button();
            this.txbLadoA = new System.Windows.Forms.TextBox();
            this.txbLadoB = new System.Windows.Forms.TextBox();
            this.txbLadoC = new System.Windows.Forms.TextBox();
            this.lblLadoA = new System.Windows.Forms.Label();
            this.lblLadoB = new System.Windows.Forms.Label();
            this.lblLadoC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(158, 46);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 46);
            this.btnExecutar.TabIndex = 0;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // txbLadoA
            // 
            this.txbLadoA.Location = new System.Drawing.Point(52, 34);
            this.txbLadoA.Name = "txbLadoA";
            this.txbLadoA.Size = new System.Drawing.Size(100, 20);
            this.txbLadoA.TabIndex = 1;
            // 
            // txbLadoB
            // 
            this.txbLadoB.Location = new System.Drawing.Point(52, 60);
            this.txbLadoB.Name = "txbLadoB";
            this.txbLadoB.Size = new System.Drawing.Size(100, 20);
            this.txbLadoB.TabIndex = 2;
            // 
            // txbLadoC
            // 
            this.txbLadoC.Location = new System.Drawing.Point(52, 86);
            this.txbLadoC.Name = "txbLadoC";
            this.txbLadoC.Size = new System.Drawing.Size(100, 20);
            this.txbLadoC.TabIndex = 3;
            // 
            // lblLadoA
            // 
            this.lblLadoA.AutoSize = true;
            this.lblLadoA.Location = new System.Drawing.Point(5, 37);
            this.lblLadoA.Name = "lblLadoA";
            this.lblLadoA.Size = new System.Drawing.Size(41, 13);
            this.lblLadoA.TabIndex = 4;
            this.lblLadoA.Text = "Lado A";
            // 
            // lblLadoB
            // 
            this.lblLadoB.AutoSize = true;
            this.lblLadoB.Location = new System.Drawing.Point(5, 63);
            this.lblLadoB.Name = "lblLadoB";
            this.lblLadoB.Size = new System.Drawing.Size(41, 13);
            this.lblLadoB.TabIndex = 5;
            this.lblLadoB.Text = "Lado B";
            // 
            // lblLadoC
            // 
            this.lblLadoC.AutoSize = true;
            this.lblLadoC.Location = new System.Drawing.Point(5, 89);
            this.lblLadoC.Name = "lblLadoC";
            this.lblLadoC.Size = new System.Drawing.Size(41, 13);
            this.lblLadoC.TabIndex = 6;
            this.lblLadoC.Text = "Lado C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Insira as medidas de cada lado do triangulo:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(5, 113);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 8;
            // 
            // ex3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 135);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLadoC);
            this.Controls.Add(this.lblLadoB);
            this.Controls.Add(this.lblLadoA);
            this.Controls.Add(this.txbLadoC);
            this.Controls.Add(this.txbLadoB);
            this.Controls.Add(this.txbLadoA);
            this.Controls.Add(this.btnExecutar);
            this.Name = "ex3";
            this.Text = "Ex. 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.TextBox txbLadoA;
        private System.Windows.Forms.TextBox txbLadoB;
        private System.Windows.Forms.TextBox txbLadoC;
        private System.Windows.Forms.Label lblLadoA;
        private System.Windows.Forms.Label lblLadoB;
        private System.Windows.Forms.Label lblLadoC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResult;
    }
}