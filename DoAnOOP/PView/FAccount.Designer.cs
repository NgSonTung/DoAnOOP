﻿
namespace DoAnOOP.PView
{
    partial class FAccount
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
            this.txtHelp = new System.Windows.Forms.TabControl();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.themAccBTN = new System.Windows.Forms.Button();
            this.capNhatAcc = new System.Windows.Forms.Button();
            this.xoaAccBTN = new System.Windows.Forms.Button();
            this.timKiemAccBTN = new System.Windows.Forms.Button();
            this.panel23 = new System.Windows.Forms.Panel();
            this.IdAccTXT = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.PassTXT = new System.Windows.Forms.TextBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.userNameTXT = new System.Windows.Forms.TextBox();
            this.xemAccBTN = new System.Windows.Forms.Button();
            this.timkiemAccTXT = new System.Windows.Forms.TextBox();
            this.huongDanMonTXT = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AuthTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panel23.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel20.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHelp
            // 
            this.txtHelp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHelp.Controls.Add(this.tabPage1);
            this.txtHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHelp.Location = new System.Drawing.Point(2, 1);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.SelectedIndex = 0;
            this.txtHelp.Size = new System.Drawing.Size(1155, 611);
            this.txtHelp.TabIndex = 53;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(26, 84);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.Size = new System.Drawing.Size(753, 457);
            this.dgvAccount.TabIndex = 29;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick_1);
            // 
            // themAccBTN
            // 
            this.themAccBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.themAccBTN.ForeColor = System.Drawing.Color.White;
            this.themAccBTN.Location = new System.Drawing.Point(26, 21);
            this.themAccBTN.Name = "themAccBTN";
            this.themAccBTN.Size = new System.Drawing.Size(97, 35);
            this.themAccBTN.TabIndex = 15;
            this.themAccBTN.Text = "Thêm";
            this.themAccBTN.UseVisualStyleBackColor = false;
            this.themAccBTN.Click += new System.EventHandler(this.themAccBTN_Click_1);
            // 
            // capNhatAcc
            // 
            this.capNhatAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.capNhatAcc.ForeColor = System.Drawing.Color.White;
            this.capNhatAcc.Location = new System.Drawing.Point(254, 21);
            this.capNhatAcc.Name = "capNhatAcc";
            this.capNhatAcc.Size = new System.Drawing.Size(97, 35);
            this.capNhatAcc.TabIndex = 17;
            this.capNhatAcc.Text = "Cập Nhật";
            this.capNhatAcc.UseVisualStyleBackColor = false;
            this.capNhatAcc.Click += new System.EventHandler(this.capNhatAcc_Click);
            // 
            // xoaAccBTN
            // 
            this.xoaAccBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.xoaAccBTN.ForeColor = System.Drawing.Color.White;
            this.xoaAccBTN.Location = new System.Drawing.Point(139, 21);
            this.xoaAccBTN.Name = "xoaAccBTN";
            this.xoaAccBTN.Size = new System.Drawing.Size(97, 35);
            this.xoaAccBTN.TabIndex = 16;
            this.xoaAccBTN.Text = "Xóa";
            this.xoaAccBTN.UseVisualStyleBackColor = false;
            this.xoaAccBTN.Click += new System.EventHandler(this.xoaAccBTN_Click);
            // 
            // timKiemAccBTN
            // 
            this.timKiemAccBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.timKiemAccBTN.ForeColor = System.Drawing.Color.White;
            this.timKiemAccBTN.Location = new System.Drawing.Point(796, 117);
            this.timKiemAccBTN.Name = "timKiemAccBTN";
            this.timKiemAccBTN.Size = new System.Drawing.Size(151, 35);
            this.timKiemAccBTN.TabIndex = 19;
            this.timKiemAccBTN.Text = "Tìm kiếm";
            this.timKiemAccBTN.UseVisualStyleBackColor = false;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.label19);
            this.panel23.Controls.Add(this.IdAccTXT);
            this.panel23.Location = new System.Drawing.Point(796, 161);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(316, 31);
            this.panel23.TabIndex = 22;
            // 
            // IdAccTXT
            // 
            this.IdAccTXT.Location = new System.Drawing.Point(125, 4);
            this.IdAccTXT.Name = "IdAccTXT";
            this.IdAccTXT.ReadOnly = true;
            this.IdAccTXT.Size = new System.Drawing.Size(188, 24);
            this.IdAccTXT.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(8, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 16);
            this.label19.TabIndex = 1;
            this.label19.Text = "Mã Tài Khoản";
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.PassTXT);
            this.panel22.Controls.Add(this.label16);
            this.panel22.Location = new System.Drawing.Point(796, 243);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(316, 31);
            this.panel22.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(8, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 16);
            this.label16.TabIndex = 1;
            this.label16.Text = "Password";
            // 
            // PassTXT
            // 
            this.PassTXT.Location = new System.Drawing.Point(128, 3);
            this.PassTXT.Name = "PassTXT";
            this.PassTXT.Size = new System.Drawing.Size(188, 24);
            this.PassTXT.TabIndex = 3;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.userNameTXT);
            this.panel20.Controls.Add(this.label14);
            this.panel20.Location = new System.Drawing.Point(796, 202);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(316, 31);
            this.panel20.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(8, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "Tài Khoản";
            // 
            // userNameTXT
            // 
            this.userNameTXT.Location = new System.Drawing.Point(128, 4);
            this.userNameTXT.Name = "userNameTXT";
            this.userNameTXT.Size = new System.Drawing.Size(188, 24);
            this.userNameTXT.TabIndex = 2;
            // 
            // xemAccBTN
            // 
            this.xemAccBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.xemAccBTN.ForeColor = System.Drawing.Color.White;
            this.xemAccBTN.Location = new System.Drawing.Point(961, 117);
            this.xemAccBTN.Name = "xemAccBTN";
            this.xemAccBTN.Size = new System.Drawing.Size(151, 35);
            this.xemAccBTN.TabIndex = 20;
            this.xemAccBTN.Text = "Xem";
            this.xemAccBTN.UseVisualStyleBackColor = false;
            this.xemAccBTN.Click += new System.EventHandler(this.xemAccBTN_Click);
            // 
            // timkiemAccTXT
            // 
            this.timkiemAccTXT.Location = new System.Drawing.Point(796, 84);
            this.timkiemAccTXT.Name = "timkiemAccTXT";
            this.timkiemAccTXT.Size = new System.Drawing.Size(316, 24);
            this.timkiemAccTXT.TabIndex = 18;
            // 
            // huongDanMonTXT
            // 
            this.huongDanMonTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.huongDanMonTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huongDanMonTXT.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.huongDanMonTXT.Location = new System.Drawing.Point(796, 437);
            this.huongDanMonTXT.Multiline = true;
            this.huongDanMonTXT.Name = "huongDanMonTXT";
            this.huongDanMonTXT.Size = new System.Drawing.Size(316, 104);
            this.huongDanMonTXT.TabIndex = 30;
            this.huongDanMonTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
            this.huongDanMonTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(918, 418);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 16);
            this.label20.TabIndex = 31;
            this.label20.Text = "Hướng dẫn";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.huongDanMonTXT);
            this.tabPage1.Controls.Add(this.timkiemAccTXT);
            this.tabPage1.Controls.Add(this.xemAccBTN);
            this.tabPage1.Controls.Add(this.panel20);
            this.tabPage1.Controls.Add(this.panel22);
            this.tabPage1.Controls.Add(this.panel23);
            this.tabPage1.Controls.Add(this.timKiemAccBTN);
            this.tabPage1.Controls.Add(this.xoaAccBTN);
            this.tabPage1.Controls.Add(this.capNhatAcc);
            this.tabPage1.Controls.Add(this.themAccBTN);
            this.tabPage1.Controls.Add(this.dgvAccount);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1147, 580);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Môn học";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AuthTXT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(796, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 31);
            this.panel1.TabIndex = 25;
            // 
            // AuthTXT
            // 
            this.AuthTXT.Location = new System.Drawing.Point(128, 3);
            this.AuthTXT.Name = "AuthTXT";
            this.AuthTXT.Size = new System.Drawing.Size(188, 24);
            this.AuthTXT.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Auth";
            // 
            // FAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 613);
            this.Controls.Add(this.txtHelp);
            this.Name = "FAccount";
            this.Text = "FAccount";
            this.Load += new System.EventHandler(this.FAccount_Load);
            this.txtHelp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl txtHelp;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox AuthTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox huongDanMonTXT;
        private System.Windows.Forms.TextBox timkiemAccTXT;
        private System.Windows.Forms.Button xemAccBTN;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TextBox userNameTXT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.TextBox PassTXT;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox IdAccTXT;
        private System.Windows.Forms.Button timKiemAccBTN;
        private System.Windows.Forms.Button xoaAccBTN;
        private System.Windows.Forms.Button capNhatAcc;
        private System.Windows.Forms.Button themAccBTN;
        private System.Windows.Forms.DataGridView dgvAccount;
    }
}