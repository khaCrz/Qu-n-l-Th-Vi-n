
namespace QLThu_Vien1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_muon = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.button_lichsumuotra = new System.Windows.Forms.Button();
            this.button_thongtincanhan = new System.Windows.Forms.Button();
            this.button_thuviensach = new System.Windows.Forms.Button();
            this.panel_main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel3);
            this.panel_main.Controls.Add(this.panel1);
            this.panel_main.Location = new System.Drawing.Point(3, 2);
            this.panel_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1117, 498);
            this.panel_main.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panel3.Location = new System.Drawing.Point(201, 9);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(909, 479);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_muon);
            this.panel1.Controls.Add(this.button_lichsumuotra);
            this.panel1.Controls.Add(this.button_thongtincanhan);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button_login);
            this.panel1.Controls.Add(this.button_thuviensach);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 488);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 139);
            this.panel2.TabIndex = 5;
            // 
            // button_muon
            // 
            this.button_muon.Location = new System.Drawing.Point(0, 353);
            this.button_muon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_muon.Name = "button_muon";
            this.button_muon.Size = new System.Drawing.Size(192, 66);
            this.button_muon.TabIndex = 4;
            this.button_muon.Text = "Chức năng mượn";
            this.button_muon.UseVisualStyleBackColor = true;
            this.button_muon.Click += new System.EventHandler(this.button_muon_Click);
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(0, 443);
            this.button_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(192, 45);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "Đăng nhập";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_lichsumuotra
            // 
            this.button_lichsumuotra.Location = new System.Drawing.Point(0, 283);
            this.button_lichsumuotra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_lichsumuotra.Name = "button_lichsumuotra";
            this.button_lichsumuotra.Size = new System.Drawing.Size(192, 66);
            this.button_lichsumuotra.TabIndex = 2;
            this.button_lichsumuotra.Text = "Lịch sử mượn trả";
            this.button_lichsumuotra.UseVisualStyleBackColor = true;
            this.button_lichsumuotra.Click += new System.EventHandler(this.button_lichsumuotra_Click);
            // 
            // button_thongtincanhan
            // 
            this.button_thongtincanhan.Location = new System.Drawing.Point(0, 213);
            this.button_thongtincanhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_thongtincanhan.Name = "button_thongtincanhan";
            this.button_thongtincanhan.Size = new System.Drawing.Size(192, 66);
            this.button_thongtincanhan.TabIndex = 1;
            this.button_thongtincanhan.Text = "Thông tin cá nhân";
            this.button_thongtincanhan.UseVisualStyleBackColor = true;
            this.button_thongtincanhan.Click += new System.EventHandler(this.button_thongtincanhan_Click);
            // 
            // button_thuviensach
            // 
            this.button_thuviensach.Location = new System.Drawing.Point(0, 143);
            this.button_thuviensach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_thuviensach.Name = "button_thuviensach";
            this.button_thuviensach.Size = new System.Drawing.Size(192, 66);
            this.button_thuviensach.TabIndex = 0;
            this.button_thuviensach.Text = "Thư viện sách";
            this.button_thuviensach.UseVisualStyleBackColor = true;
            this.button_thuviensach.Click += new System.EventHandler(this.button_thuviensach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 507);
            this.Controls.Add(this.panel_main);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_main.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_muon;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_lichsumuotra;
        private System.Windows.Forms.Button button_thongtincanhan;
        private System.Windows.Forms.Button button_thuviensach;
        private System.Windows.Forms.Panel panel3;
    }
}

