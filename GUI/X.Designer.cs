﻿namespace Do_An
{
    partial class X
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ThoatCT = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(187, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn thực sự muốn ?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.btn_ThoatCT);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(105, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 317);
            this.panel1.TabIndex = 3;
            // 
            // btn_ThoatCT
            // 
            this.btn_ThoatCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_ThoatCT.BackColor = System.Drawing.Color.DarkGray;
            this.btn_ThoatCT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ThoatCT.FlatAppearance.BorderSize = 0;
            this.btn_ThoatCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThoatCT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThoatCT.Location = new System.Drawing.Point(368, 163);
            this.btn_ThoatCT.Name = "btn_ThoatCT";
            this.btn_ThoatCT.Size = new System.Drawing.Size(189, 53);
            this.btn_ThoatCT.TabIndex = 71;
            this.btn_ThoatCT.Text = "Thoát chương trình";
            this.btn_ThoatCT.UseVisualStyleBackColor = false;
            this.btn_ThoatCT.Click += new System.EventHandler(this.button1_Click);
            // 
            // button16
            // 
            this.button16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button16.BackColor = System.Drawing.Color.DarkGray;
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button16.Location = new System.Drawing.Point(82, 161);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(163, 53);
            this.button16.TabIndex = 69;
            this.button16.Text = "Đăng xuất";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // X
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(885, 593);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "X";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "X";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button16;
        private Button btn_ThoatCT;
    }
}