namespace PiKanban
{
    partial class Form1
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
            this.lstBP = new System.Windows.Forms.ListBox();
            this.lstMP = new System.Windows.Forms.ListBox();
            this.lstAP = new System.Windows.Forms.ListBox();
            this.lstAM = new System.Windows.Forms.ListBox();
            this.lstMM = new System.Windows.Forms.ListBox();
            this.lstBM = new System.Windows.Forms.ListBox();
            this.lstAG = new System.Windows.Forms.ListBox();
            this.lstMG = new System.Windows.Forms.ListBox();
            this.lstBG = new System.Windows.Forms.ListBox();
            this.lblTamP = new System.Windows.Forms.Label();
            this.lblTamM = new System.Windows.Forms.Label();
            this.lblTamG = new System.Windows.Forms.Label();
            this.lblConB = new System.Windows.Forms.Label();
            this.lblConM = new System.Windows.Forms.Label();
            this.lblConA = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.lstIssues = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBP
            // 
            this.lstBP.FormattingEnabled = true;
            this.lstBP.Location = new System.Drawing.Point(100, 77);
            this.lstBP.Name = "lstBP";
            this.lstBP.Size = new System.Drawing.Size(120, 95);
            this.lstBP.TabIndex = 1;
            // 
            // lstMP
            // 
            this.lstMP.FormattingEnabled = true;
            this.lstMP.Location = new System.Drawing.Point(546, 77);
            this.lstMP.Name = "lstMP";
            this.lstMP.Size = new System.Drawing.Size(120, 95);
            this.lstMP.TabIndex = 2;
            // 
            // lstAP
            // 
            this.lstAP.FormattingEnabled = true;
            this.lstAP.Location = new System.Drawing.Point(323, 77);
            this.lstAP.Name = "lstAP";
            this.lstAP.Size = new System.Drawing.Size(120, 95);
            this.lstAP.TabIndex = 3;
            // 
            // lstAM
            // 
            this.lstAM.FormattingEnabled = true;
            this.lstAM.Location = new System.Drawing.Point(100, 211);
            this.lstAM.Name = "lstAM";
            this.lstAM.Size = new System.Drawing.Size(120, 95);
            this.lstAM.TabIndex = 6;
            // 
            // lstMM
            // 
            this.lstMM.FormattingEnabled = true;
            this.lstMM.Location = new System.Drawing.Point(323, 211);
            this.lstMM.Name = "lstMM";
            this.lstMM.Size = new System.Drawing.Size(120, 95);
            this.lstMM.TabIndex = 5;
            // 
            // lstBM
            // 
            this.lstBM.FormattingEnabled = true;
            this.lstBM.Location = new System.Drawing.Point(546, 211);
            this.lstBM.Name = "lstBM";
            this.lstBM.Size = new System.Drawing.Size(120, 95);
            this.lstBM.TabIndex = 4;
            // 
            // lstAG
            // 
            this.lstAG.FormattingEnabled = true;
            this.lstAG.Location = new System.Drawing.Point(100, 347);
            this.lstAG.Name = "lstAG";
            this.lstAG.Size = new System.Drawing.Size(120, 95);
            this.lstAG.TabIndex = 9;
            // 
            // lstMG
            // 
            this.lstMG.FormattingEnabled = true;
            this.lstMG.Location = new System.Drawing.Point(323, 347);
            this.lstMG.Name = "lstMG";
            this.lstMG.Size = new System.Drawing.Size(120, 95);
            this.lstMG.TabIndex = 8;
            // 
            // lstBG
            // 
            this.lstBG.FormattingEnabled = true;
            this.lstBG.Location = new System.Drawing.Point(546, 347);
            this.lstBG.Name = "lstBG";
            this.lstBG.Size = new System.Drawing.Size(120, 95);
            this.lstBG.TabIndex = 7;
            // 
            // lblTamP
            // 
            this.lblTamP.AutoSize = true;
            this.lblTamP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamP.Location = new System.Drawing.Point(32, 126);
            this.lblTamP.Name = "lblTamP";
            this.lblTamP.Size = new System.Drawing.Size(26, 25);
            this.lblTamP.TabIndex = 10;
            this.lblTamP.Text = "P";
            // 
            // lblTamM
            // 
            this.lblTamM.AutoSize = true;
            this.lblTamM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamM.Location = new System.Drawing.Point(32, 238);
            this.lblTamM.Name = "lblTamM";
            this.lblTamM.Size = new System.Drawing.Size(30, 25);
            this.lblTamM.TabIndex = 11;
            this.lblTamM.Text = "M";
            // 
            // lblTamG
            // 
            this.lblTamG.AutoSize = true;
            this.lblTamG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamG.Location = new System.Drawing.Point(32, 375);
            this.lblTamG.Name = "lblTamG";
            this.lblTamG.Size = new System.Drawing.Size(28, 25);
            this.lblTamG.TabIndex = 12;
            this.lblTamG.Text = "G";
            // 
            // lblConB
            // 
            this.lblConB.AutoSize = true;
            this.lblConB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConB.Location = new System.Drawing.Point(579, 13);
            this.lblConB.Name = "lblConB";
            this.lblConB.Size = new System.Drawing.Size(26, 25);
            this.lblConB.TabIndex = 13;
            this.lblConB.Text = "B";
            // 
            // lblConM
            // 
            this.lblConM.AutoSize = true;
            this.lblConM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConM.Location = new System.Drawing.Point(363, 13);
            this.lblConM.Name = "lblConM";
            this.lblConM.Size = new System.Drawing.Size(30, 25);
            this.lblConM.TabIndex = 14;
            this.lblConM.Text = "M";
            // 
            // lblConA
            // 
            this.lblConA.AutoSize = true;
            this.lblConA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConA.Location = new System.Drawing.Point(144, 13);
            this.lblConA.Name = "lblConA";
            this.lblConA.Size = new System.Drawing.Size(26, 25);
            this.lblConA.TabIndex = 15;
            this.lblConA.Text = "A";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(212, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(690, 599);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstAP);
            this.tabPage1.Controls.Add(this.lblConA);
            this.tabPage1.Controls.Add(this.lstBP);
            this.tabPage1.Controls.Add(this.lblConM);
            this.tabPage1.Controls.Add(this.lstMP);
            this.tabPage1.Controls.Add(this.lblConB);
            this.tabPage1.Controls.Add(this.lstBM);
            this.tabPage1.Controls.Add(this.lblTamG);
            this.tabPage1.Controls.Add(this.lstMM);
            this.tabPage1.Controls.Add(this.lblTamM);
            this.tabPage1.Controls.Add(this.lstAM);
            this.tabPage1.Controls.Add(this.lblTamP);
            this.tabPage1.Controls.Add(this.lstBG);
            this.tabPage1.Controls.Add(this.lstAG);
            this.tabPage1.Controls.Add(this.lstMG);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(682, 573);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tamanho/Conhecimento";
            this.tabPage1.ToolTipText = "Tamanho/Conhecimento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(743, 573);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SP1";
            this.tabPage2.ToolTipText = "SP1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(743, 573);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SP2";
            this.tabPage3.ToolTipText = "SP2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(743, 573);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "SP3";
            this.tabPage4.ToolTipText = "SP4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(743, 573);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "SP4";
            this.tabPage5.ToolTipText = "SP5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(743, 573);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "SP5";
            this.tabPage6.ToolTipText = "SP6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(743, 573);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "SP6";
            this.tabPage7.ToolTipText = "SP6";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // lstIssues
            // 
            this.lstIssues.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstIssues.GridLines = true;
            this.lstIssues.Location = new System.Drawing.Point(0, 0);
            this.lstIssues.MultiSelect = false;
            this.lstIssues.Name = "lstIssues";
            this.lstIssues.OwnerDraw = true;
            this.lstIssues.Size = new System.Drawing.Size(212, 599);
            this.lstIssues.TabIndex = 17;
            this.lstIssues.TileSize = new System.Drawing.Size(168, 60);
            this.lstIssues.UseCompatibleStateImageBehavior = false;
            this.lstIssues.View = System.Windows.Forms.View.Tile;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 599);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lstIssues);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstBP;
        private System.Windows.Forms.ListBox lstMP;
        private System.Windows.Forms.ListBox lstAP;
        private System.Windows.Forms.ListBox lstAM;
        private System.Windows.Forms.ListBox lstMM;
        private System.Windows.Forms.ListBox lstBM;
        private System.Windows.Forms.ListBox lstAG;
        private System.Windows.Forms.ListBox lstMG;
        private System.Windows.Forms.ListBox lstBG;
        private System.Windows.Forms.Label lblTamP;
        private System.Windows.Forms.Label lblTamM;
        private System.Windows.Forms.Label lblTamG;
        private System.Windows.Forms.Label lblConB;
        private System.Windows.Forms.Label lblConM;
        private System.Windows.Forms.Label lblConA;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.ListView lstIssues;
    }
}

