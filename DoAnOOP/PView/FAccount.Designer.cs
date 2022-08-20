
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbmAuth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.huongDanMonTXT = new System.Windows.Forms.TextBox();
            this.timkiemAccTXT = new System.Windows.Forms.TextBox();
            this.xemAccBTN = new System.Windows.Forms.Button();
            this.panel20 = new System.Windows.Forms.Panel();
            this.userNameTXT = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.PassTXT = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.IdAccTXT = new System.Windows.Forms.TextBox();
            this.timKiemAccBTN = new System.Windows.Forms.Button();
            this.xoaAccBTN = new System.Windows.Forms.Button();
            this.capNhatAcc = new System.Windows.Forms.Button();
            this.themAccBTN = new System.Windows.Forms.Button();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.txtHelp = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.txtHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(104)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.manageAccountsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 12, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1540, 38);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.managerToolStripMenuItem.Margin = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Padding = new System.Windows.Forms.Padding(40, 0, 4, 0);
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.managerToolStripMenuItem.Text = "Admin";
            this.managerToolStripMenuItem.Click += new System.EventHandler(this.managerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem1.Margin = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Padding = new System.Windows.Forms.Padding(40, 0, 4, 0);
            this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 24);
            this.toolStripMenuItem1.Text = "Logout";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // manageAccountsToolStripMenuItem
            // 
            this.manageAccountsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.manageAccountsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.manageAccountsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.manageAccountsToolStripMenuItem.Name = "manageAccountsToolStripMenuItem";
            this.manageAccountsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.manageAccountsToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.manageAccountsToolStripMenuItem.Text = "Manage Data";
            this.manageAccountsToolStripMenuItem.Click += new System.EventHandler(this.manageAccountsToolStripMenuItem_Click);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1532, 715);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Account";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbmAuth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1061, 345);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 38);
            this.panel1.TabIndex = 25;
            // 
            // cbmAuth
            // 
            this.cbmAuth.FormattingEnabled = true;
            this.cbmAuth.Items.AddRange(new object[] {
            "Quản Trị Viên",
            "Giáo Viên"});
            this.cbmAuth.Location = new System.Drawing.Point(171, 9);
            this.cbmAuth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbmAuth.Name = "cbmAuth";
            this.cbmAuth.Size = new System.Drawing.Size(249, 32);
            this.cbmAuth.TabIndex = 2;
            this.cbmAuth.SelectedIndexChanged += new System.EventHandler(this.cbmAuth_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Auth";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(1224, 514);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 20);
            this.label20.TabIndex = 31;
            this.label20.Text = "Hướng dẫn";
            // 
            // huongDanMonTXT
            // 
            this.huongDanMonTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.huongDanMonTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huongDanMonTXT.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.huongDanMonTXT.Location = new System.Drawing.Point(1061, 538);
            this.huongDanMonTXT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.huongDanMonTXT.Multiline = true;
            this.huongDanMonTXT.Name = "huongDanMonTXT";
            this.huongDanMonTXT.ReadOnly = true;
            this.huongDanMonTXT.Size = new System.Drawing.Size(420, 127);
            this.huongDanMonTXT.TabIndex = 30;
            this.huongDanMonTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
            this.huongDanMonTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timkiemAccTXT
            // 
            this.timkiemAccTXT.Location = new System.Drawing.Point(1061, 103);
            this.timkiemAccTXT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timkiemAccTXT.Name = "timkiemAccTXT";
            this.timkiemAccTXT.Size = new System.Drawing.Size(420, 29);
            this.timkiemAccTXT.TabIndex = 18;
            // 
            // xemAccBTN
            // 
            this.xemAccBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.xemAccBTN.ForeColor = System.Drawing.Color.White;
            this.xemAccBTN.Location = new System.Drawing.Point(1281, 144);
            this.xemAccBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xemAccBTN.Name = "xemAccBTN";
            this.xemAccBTN.Size = new System.Drawing.Size(201, 43);
            this.xemAccBTN.TabIndex = 20;
            this.xemAccBTN.Text = "Xem";
            this.xemAccBTN.UseVisualStyleBackColor = false;
            this.xemAccBTN.Click += new System.EventHandler(this.xemAccBTN_Click);
            this.xemAccBTN.MouseHover += new System.EventHandler(this.xemAccBTN_MouseHover);
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.userNameTXT);
            this.panel20.Controls.Add(this.label14);
            this.panel20.Location = new System.Drawing.Point(1061, 249);
            this.panel20.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(421, 38);
            this.panel20.TabIndex = 23;
            // 
            // userNameTXT
            // 
            this.userNameTXT.Location = new System.Drawing.Point(171, 5);
            this.userNameTXT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userNameTXT.Name = "userNameTXT";
            this.userNameTXT.Size = new System.Drawing.Size(249, 29);
            this.userNameTXT.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(11, 9);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Tài Khoản";
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.PassTXT);
            this.panel22.Controls.Add(this.label16);
            this.panel22.Location = new System.Drawing.Point(1061, 299);
            this.panel22.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(421, 38);
            this.panel22.TabIndex = 24;
            // 
            // PassTXT
            // 
            this.PassTXT.Location = new System.Drawing.Point(171, 4);
            this.PassTXT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PassTXT.Name = "PassTXT";
            this.PassTXT.Size = new System.Drawing.Size(249, 29);
            this.PassTXT.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(11, 9);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "Password";
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.label19);
            this.panel23.Controls.Add(this.IdAccTXT);
            this.panel23.Location = new System.Drawing.Point(1061, 198);
            this.panel23.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(421, 38);
            this.panel23.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(11, 11);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 20);
            this.label19.TabIndex = 1;
            this.label19.Text = "Mã Tài Khoản";
            // 
            // IdAccTXT
            // 
            this.IdAccTXT.Location = new System.Drawing.Point(167, 5);
            this.IdAccTXT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IdAccTXT.Name = "IdAccTXT";
            this.IdAccTXT.ReadOnly = true;
            this.IdAccTXT.Size = new System.Drawing.Size(249, 29);
            this.IdAccTXT.TabIndex = 0;
            // 
            // timKiemAccBTN
            // 
            this.timKiemAccBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.timKiemAccBTN.ForeColor = System.Drawing.Color.White;
            this.timKiemAccBTN.Location = new System.Drawing.Point(1061, 144);
            this.timKiemAccBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timKiemAccBTN.Name = "timKiemAccBTN";
            this.timKiemAccBTN.Size = new System.Drawing.Size(201, 43);
            this.timKiemAccBTN.TabIndex = 19;
            this.timKiemAccBTN.Text = "Tìm kiếm";
            this.timKiemAccBTN.UseVisualStyleBackColor = false;
            this.timKiemAccBTN.Click += new System.EventHandler(this.timKiemAccBTN_Click);
            this.timKiemAccBTN.MouseLeave += new System.EventHandler(this.timKiemAccBTN_MouseLeave);
            this.timKiemAccBTN.MouseHover += new System.EventHandler(this.timKiemAccBTN_MouseHover);
            // 
            // xoaAccBTN
            // 
            this.xoaAccBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.xoaAccBTN.ForeColor = System.Drawing.Color.White;
            this.xoaAccBTN.Location = new System.Drawing.Point(185, 26);
            this.xoaAccBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xoaAccBTN.Name = "xoaAccBTN";
            this.xoaAccBTN.Size = new System.Drawing.Size(129, 43);
            this.xoaAccBTN.TabIndex = 16;
            this.xoaAccBTN.Text = "Xóa";
            this.xoaAccBTN.UseVisualStyleBackColor = false;
            this.xoaAccBTN.Click += new System.EventHandler(this.xoaAccBTN_Click);
            this.xoaAccBTN.MouseLeave += new System.EventHandler(this.xoaAccBTN_MouseLeave);
            this.xoaAccBTN.MouseHover += new System.EventHandler(this.xoaAccBTN_MouseHover);
            // 
            // capNhatAcc
            // 
            this.capNhatAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.capNhatAcc.ForeColor = System.Drawing.Color.White;
            this.capNhatAcc.Location = new System.Drawing.Point(339, 26);
            this.capNhatAcc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.capNhatAcc.Name = "capNhatAcc";
            this.capNhatAcc.Size = new System.Drawing.Size(129, 43);
            this.capNhatAcc.TabIndex = 17;
            this.capNhatAcc.Text = "Cập Nhật";
            this.capNhatAcc.UseVisualStyleBackColor = false;
            this.capNhatAcc.Click += new System.EventHandler(this.capNhatAcc_Click);
            this.capNhatAcc.MouseLeave += new System.EventHandler(this.capNhatAcc_MouseLeave);
            this.capNhatAcc.MouseHover += new System.EventHandler(this.capNhatAcc_MouseHover);
            // 
            // themAccBTN
            // 
            this.themAccBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.themAccBTN.ForeColor = System.Drawing.Color.White;
            this.themAccBTN.Location = new System.Drawing.Point(35, 26);
            this.themAccBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.themAccBTN.Name = "themAccBTN";
            this.themAccBTN.Size = new System.Drawing.Size(129, 43);
            this.themAccBTN.TabIndex = 15;
            this.themAccBTN.Text = "Thêm";
            this.themAccBTN.UseVisualStyleBackColor = false;
            this.themAccBTN.Click += new System.EventHandler(this.themAccBTN_Click_1);
            this.themAccBTN.MouseLeave += new System.EventHandler(this.themAccBTN_MouseLeave);
            this.themAccBTN.MouseHover += new System.EventHandler(this.themAccBTN_MouseHover);
            // 
            // dgvAccount
            // 
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(35, 103);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.Size = new System.Drawing.Size(1004, 562);
            this.dgvAccount.TabIndex = 29;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick_1);
            // 
            // txtHelp
            // 
            this.txtHelp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHelp.Controls.Add(this.tabPage1);
            this.txtHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHelp.Location = new System.Drawing.Point(3, 47);
            this.txtHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.SelectedIndex = 0;
            this.txtHelp.Size = new System.Drawing.Size(1540, 752);
            this.txtHelp.TabIndex = 53;
            // 
            // FAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1540, 864);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtHelp);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FAccount";
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.FAccount_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.txtHelp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageAccountsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbmAuth;
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
        private System.Windows.Forms.TabControl txtHelp;
    }
}