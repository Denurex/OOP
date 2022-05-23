
namespace lab1
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.StatusMemo = new System.Windows.Forms.RichTextBox();
            this.AccountsButton = new System.Windows.Forms.Button();
            this.CreditButton = new System.Windows.Forms.Button();
            this.InstallmentButton = new System.Windows.Forms.Button();
            this.OpenAccountButton = new System.Windows.Forms.Button();
            this.SumEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BankBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AccountsBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TakeCreditButton = new System.Windows.Forms.Button();
            this.TakeInsButton = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.StatButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.salprgEdit = new System.Windows.Forms.TextBox();
            this.salprgButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StatusMemo
            // 
            this.StatusMemo.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusMemo.Location = new System.Drawing.Point(90, 83);
            this.StatusMemo.Margin = new System.Windows.Forms.Padding(2);
            this.StatusMemo.Name = "StatusMemo";
            this.StatusMemo.Size = new System.Drawing.Size(430, 353);
            this.StatusMemo.TabIndex = 0;
            this.StatusMemo.Text = "";
            // 
            // AccountsButton
            // 
            this.AccountsButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.AccountsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AccountsButton.Location = new System.Drawing.Point(803, 309);
            this.AccountsButton.Margin = new System.Windows.Forms.Padding(2);
            this.AccountsButton.Name = "AccountsButton";
            this.AccountsButton.Size = new System.Drawing.Size(137, 25);
            this.AccountsButton.TabIndex = 1;
            this.AccountsButton.Text = "Show account";
            this.AccountsButton.UseVisualStyleBackColor = false;
            this.AccountsButton.Click += new System.EventHandler(this.AccountsButton_Click);
            // 
            // CreditButton
            // 
            this.CreditButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.CreditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreditButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreditButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CreditButton.Location = new System.Drawing.Point(637, 449);
            this.CreditButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreditButton.Name = "CreditButton";
            this.CreditButton.Size = new System.Drawing.Size(165, 31);
            this.CreditButton.TabIndex = 2;
            this.CreditButton.Text = "Show credits";
            this.CreditButton.UseVisualStyleBackColor = false;
            this.CreditButton.Click += new System.EventHandler(this.CreditButton_Click);
            // 
            // InstallmentButton
            // 
            this.InstallmentButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.InstallmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstallmentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstallmentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InstallmentButton.Location = new System.Drawing.Point(870, 405);
            this.InstallmentButton.Margin = new System.Windows.Forms.Padding(2);
            this.InstallmentButton.Name = "InstallmentButton";
            this.InstallmentButton.Size = new System.Drawing.Size(165, 31);
            this.InstallmentButton.TabIndex = 3;
            this.InstallmentButton.Text = "Show installments";
            this.InstallmentButton.UseVisualStyleBackColor = false;
            this.InstallmentButton.Click += new System.EventHandler(this.InstallmentButton_Click);
            // 
            // OpenAccountButton
            // 
            this.OpenAccountButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.OpenAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenAccountButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenAccountButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpenAccountButton.Location = new System.Drawing.Point(981, 115);
            this.OpenAccountButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenAccountButton.Name = "OpenAccountButton";
            this.OpenAccountButton.Size = new System.Drawing.Size(133, 27);
            this.OpenAccountButton.TabIndex = 4;
            this.OpenAccountButton.Text = "Open account";
            this.OpenAccountButton.UseVisualStyleBackColor = false;
            this.OpenAccountButton.Click += new System.EventHandler(this.OpenAccountButton_Click);
            // 
            // SumEdit
            // 
            this.SumEdit.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumEdit.Location = new System.Drawing.Point(803, 115);
            this.SumEdit.Margin = new System.Windows.Forms.Padding(2);
            this.SumEdit.Multiline = true;
            this.SumEdit.Name = "SumEdit";
            this.SumEdit.Size = new System.Drawing.Size(137, 25);
            this.SumEdit.TabIndex = 5;
            this.SumEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SumEdit_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(799, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter sum";
            // 
            // BankBox
            // 
            this.BankBox.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankBox.FormattingEnabled = true;
            this.BankBox.Location = new System.Drawing.Point(637, 117);
            this.BankBox.Margin = new System.Windows.Forms.Padding(2);
            this.BankBox.Name = "BankBox";
            this.BankBox.Size = new System.Drawing.Size(120, 23);
            this.BankBox.TabIndex = 11;
            this.BankBox.SelectedIndexChanged += new System.EventHandler(this.BankBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(633, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Choose bank";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AccountsBox
            // 
            this.AccountsBox.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountsBox.FormattingEnabled = true;
            this.AccountsBox.Location = new System.Drawing.Point(637, 309);
            this.AccountsBox.Margin = new System.Windows.Forms.Padding(2);
            this.AccountsBox.Name = "AccountsBox";
            this.AccountsBox.Size = new System.Drawing.Size(122, 23);
            this.AccountsBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(633, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Choose account";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(376, 440);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TakeCreditButton
            // 
            this.TakeCreditButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.TakeCreditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TakeCreditButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TakeCreditButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TakeCreditButton.Location = new System.Drawing.Point(637, 405);
            this.TakeCreditButton.Margin = new System.Windows.Forms.Padding(2);
            this.TakeCreditButton.Name = "TakeCreditButton";
            this.TakeCreditButton.Size = new System.Drawing.Size(165, 31);
            this.TakeCreditButton.TabIndex = 16;
            this.TakeCreditButton.Text = "Take credit";
            this.TakeCreditButton.UseVisualStyleBackColor = false;
            this.TakeCreditButton.Click += new System.EventHandler(this.TakeCreditButton_Click);
            // 
            // TakeInsButton
            // 
            this.TakeInsButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.TakeInsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TakeInsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TakeInsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TakeInsButton.Location = new System.Drawing.Point(870, 449);
            this.TakeInsButton.Margin = new System.Windows.Forms.Padding(2);
            this.TakeInsButton.Name = "TakeInsButton";
            this.TakeInsButton.Size = new System.Drawing.Size(165, 31);
            this.TakeInsButton.TabIndex = 17;
            this.TakeInsButton.Text = "Take installment";
            this.TakeInsButton.UseVisualStyleBackColor = false;
            this.TakeInsButton.Click += new System.EventHandler(this.TakeInsButton_Click);
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogOut.Location = new System.Drawing.Point(1202, 774);
            this.LogOut.Margin = new System.Windows.Forms.Padding(2);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(71, 26);
            this.LogOut.TabIndex = 18;
            this.LogOut.Text = "Logout";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // StatButton
            // 
            this.StatButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.StatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StatButton.Location = new System.Drawing.Point(90, 440);
            this.StatButton.Margin = new System.Windows.Forms.Padding(2);
            this.StatButton.Name = "StatButton";
            this.StatButton.Size = new System.Drawing.Size(282, 40);
            this.StatButton.TabIndex = 19;
            this.StatButton.Text = "My statistics";
            this.StatButton.UseVisualStyleBackColor = false;
            this.StatButton.Click += new System.EventHandler(this.StatButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(633, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sum";
            // 
            // salprgEdit
            // 
            this.salprgEdit.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salprgEdit.Location = new System.Drawing.Point(637, 207);
            this.salprgEdit.Margin = new System.Windows.Forms.Padding(2);
            this.salprgEdit.Multiline = true;
            this.salprgEdit.Name = "salprgEdit";
            this.salprgEdit.Size = new System.Drawing.Size(116, 23);
            this.salprgEdit.TabIndex = 21;
            this.salprgEdit.TextChanged += new System.EventHandler(this.salprgEdit_TextChanged);
            this.salprgEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salprgEdit_KeyPress);
            // 
            // salprgButton
            // 
            this.salprgButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.salprgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salprgButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.salprgButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.salprgButton.Location = new System.Drawing.Point(803, 207);
            this.salprgButton.Margin = new System.Windows.Forms.Padding(2);
            this.salprgButton.Name = "salprgButton";
            this.salprgButton.Size = new System.Drawing.Size(137, 28);
            this.salprgButton.TabIndex = 20;
            this.salprgButton.Text = "Take salary project";
            this.salprgButton.UseVisualStyleBackColor = false;
            this.salprgButton.Click += new System.EventHandler(this.salprgButton_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(84, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 43);
            this.label5.TabIndex = 23;
            this.label5.Text = "Hello, client";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 749);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.salprgEdit);
            this.Controls.Add(this.salprgButton);
            this.Controls.Add(this.StatButton);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.TakeInsButton);
            this.Controls.Add(this.TakeCreditButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AccountsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BankBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SumEdit);
            this.Controls.Add(this.OpenAccountButton);
            this.Controls.Add(this.InstallmentButton);
            this.Controls.Add(this.CreditButton);
            this.Controls.Add(this.AccountsButton);
            this.Controls.Add(this.StatusMemo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox StatusMemo;
        private System.Windows.Forms.Button AccountsButton;
        private System.Windows.Forms.Button CreditButton;
        private System.Windows.Forms.Button InstallmentButton;
        private System.Windows.Forms.Button OpenAccountButton;
        private System.Windows.Forms.TextBox SumEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BankBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AccountsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button TakeCreditButton;
        private System.Windows.Forms.Button TakeInsButton;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button StatButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salprgEdit;
        private System.Windows.Forms.Button salprgButton;
        private System.Windows.Forms.Label label5;
    }
}