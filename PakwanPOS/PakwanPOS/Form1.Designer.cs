namespace PakwanPOS
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_signin = new System.Windows.Forms.Button();
            this.textBox_PasswordSignIN = new System.Windows.Forms.TextBox();
            this.textBox_userNamesignIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_bill = new System.Windows.Forms.Button();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.btn_items = new System.Windows.Forms.Button();
            this.btn_viewDB = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.btn_signin);
            this.panel1.Controls.Add(this.textBox_PasswordSignIN);
            this.panel1.Controls.Add(this.textBox_userNamesignIn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // btn_signin
            // 
            this.btn_signin.Location = new System.Drawing.Point(259, 245);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(301, 32);
            this.btn_signin.TabIndex = 4;
            this.btn_signin.Text = "Signin";
            this.btn_signin.UseVisualStyleBackColor = true;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // textBox_PasswordSignIN
            // 
            this.textBox_PasswordSignIN.Location = new System.Drawing.Point(346, 209);
            this.textBox_PasswordSignIN.Name = "textBox_PasswordSignIN";
            this.textBox_PasswordSignIN.Size = new System.Drawing.Size(214, 20);
            this.textBox_PasswordSignIN.TabIndex = 3;
            // 
            // textBox_userNamesignIn
            // 
            this.textBox_userNamesignIn.Location = new System.Drawing.Point(346, 176);
            this.textBox_userNamesignIn.Name = "textBox_userNamesignIn";
            this.textBox_userNamesignIn.Size = new System.Drawing.Size(214, 20);
            this.textBox_userNamesignIn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Snow;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.flowLayoutPanel1.Controls.Add(this.Btn_bill);
            this.flowLayoutPanel1.Controls.Add(this.btn_purchase);
            this.flowLayoutPanel1.Controls.Add(this.btn_items);
            this.flowLayoutPanel1.Controls.Add(this.btn_viewDB);
            this.flowLayoutPanel1.Controls.Add(this.btn_about);
            this.flowLayoutPanel1.Controls.Add(this.btn_logout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Visible = false;
            // 
            // Btn_bill
            // 
            this.Btn_bill.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_bill.Location = new System.Drawing.Point(0, 0);
            this.Btn_bill.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_bill.Name = "Btn_bill";
            this.Btn_bill.Size = new System.Drawing.Size(200, 62);
            this.Btn_bill.TabIndex = 0;
            this.Btn_bill.Text = "Billing";
            this.Btn_bill.UseVisualStyleBackColor = false;
            // 
            // btn_purchase
            // 
            this.btn_purchase.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purchase.Location = new System.Drawing.Point(0, 62);
            this.btn_purchase.Margin = new System.Windows.Forms.Padding(0);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(200, 62);
            this.btn_purchase.TabIndex = 3;
            this.btn_purchase.Text = "Purchase";
            this.btn_purchase.UseVisualStyleBackColor = false;
            // 
            // btn_items
            // 
            this.btn_items.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_items.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_items.Location = new System.Drawing.Point(0, 124);
            this.btn_items.Margin = new System.Windows.Forms.Padding(0);
            this.btn_items.Name = "btn_items";
            this.btn_items.Size = new System.Drawing.Size(200, 62);
            this.btn_items.TabIndex = 4;
            this.btn_items.Text = "Add Items";
            this.btn_items.UseVisualStyleBackColor = false;
            // 
            // btn_viewDB
            // 
            this.btn_viewDB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_viewDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewDB.Location = new System.Drawing.Point(0, 186);
            this.btn_viewDB.Margin = new System.Windows.Forms.Padding(0);
            this.btn_viewDB.Name = "btn_viewDB";
            this.btn_viewDB.Size = new System.Drawing.Size(200, 62);
            this.btn_viewDB.TabIndex = 2;
            this.btn_viewDB.Text = "View Database and Reporting";
            this.btn_viewDB.UseVisualStyleBackColor = false;
            // 
            // btn_about
            // 
            this.btn_about.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Location = new System.Drawing.Point(0, 248);
            this.btn_about.Margin = new System.Windows.Forms.Padding(0);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(200, 62);
            this.btn_about.TabIndex = 1;
            this.btn_about.Text = "About";
            this.btn_about.UseVisualStyleBackColor = false;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Location = new System.Drawing.Point(0, 310);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(0);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(200, 62);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "     ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.TextBox textBox_PasswordSignIN;
        private System.Windows.Forms.TextBox textBox_userNamesignIn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Btn_bill;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.Button btn_items;
        private System.Windows.Forms.Button btn_viewDB;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_logout;
    }
}

