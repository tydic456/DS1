﻿namespace Menus
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teste1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teste2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnteste1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnteste2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnteste3 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(366, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teste1ToolStripMenuItem,
            this.teste2ToolStripMenuItem});
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.arquivosToolStripMenuItem.Text = "Arquivos";
            // 
            // teste1ToolStripMenuItem
            // 
            this.teste1ToolStripMenuItem.Name = "teste1ToolStripMenuItem";
            this.teste1ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.teste1ToolStripMenuItem.Text = "Teste 1";
            this.teste1ToolStripMenuItem.Click += new System.EventHandler(this.teste1ToolStripMenuItem_Click);
            // 
            // teste2ToolStripMenuItem
            // 
            this.teste2ToolStripMenuItem.Name = "teste2ToolStripMenuItem";
            this.teste2ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.teste2ToolStripMenuItem.Text = "Teste 2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnteste1,
            this.toolStripSeparator1,
            this.btnteste2,
            this.toolStripSeparator2,
            this.btnteste3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(366, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnteste1
            // 
            this.btnteste1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnteste1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnteste1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnteste1.Name = "btnteste1";
            this.btnteste1.Size = new System.Drawing.Size(23, 22);
            this.btnteste1.Text = "toolStripButton1";
            this.btnteste1.ToolTipText = "Teste :)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnteste2
            // 
            this.btnteste2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnteste2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnteste2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnteste2.Name = "btnteste2";
            this.btnteste2.Size = new System.Drawing.Size(23, 22);
            this.btnteste2.Text = "toolStripButton2";
            this.btnteste2.ToolTipText = "Teste também :)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnteste3
            // 
            this.btnteste3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnteste3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnteste3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnteste3.Name = "btnteste3";
            this.btnteste3.Size = new System.Drawing.Size(23, 22);
            this.btnteste3.Text = "toolStripButton3";
            this.btnteste3.ToolTipText = "Sair";
            this.btnteste3.Click += new System.EventHandler(this.btnteste3_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblData,
            this.lblHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 191);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(366, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblData
            // 
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(34, 17);
            this.lblData.Text = "Data:";
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(36, 17);
            this.lblHora.Text = "Hora:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 213);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Exemplo Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teste1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teste2ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnteste1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnteste2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnteste3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.Timer timer1;
    }
}

