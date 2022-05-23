
namespace lab1
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.AccountMemo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SavingButton = new System.Windows.Forms.Button();
            this.SavingEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CashOutButton = new System.Windows.Forms.Button();
            this.CashOutEdit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TransferEdit = new System.Windows.Forms.Button();
            this.TransferSumEdit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AccumulationButton = new System.Windows.Forms.Button();
            this.AccumulationPercentEdit = new System.Windows.Forms.TextBox();
            this.AccumulationEdit = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.FreezingButton = new System.Windows.Forms.Button();
            this.BlockButton = new System.Windows.Forms.Button();
            this.NumberTransBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AccumMemo = new System.Windows.Forms.RichTextBox();
            this.SavingMemo = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountMemo
            // 
            this.AccountMemo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AccountMemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountMemo.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountMemo.Location = new System.Drawing.Point(10, 45);
            this.AccountMemo.Margin = new System.Windows.Forms.Padding(2);
            this.AccountMemo.Name = "AccountMemo";
            this.AccountMemo.ReadOnly = true;
            this.AccountMemo.Size = new System.Drawing.Size(271, 64);
            this.AccountMemo.TabIndex = 0;
            this.AccountMemo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(59, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(5, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "How much money do you want to invest?";
            // 
            // SavingButton
            // 
            this.SavingButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SavingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavingButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SavingButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SavingButton.Location = new System.Drawing.Point(153, 39);
            this.SavingButton.Margin = new System.Windows.Forms.Padding(2);
            this.SavingButton.Name = "SavingButton";
            this.SavingButton.Size = new System.Drawing.Size(132, 30);
            this.SavingButton.TabIndex = 3;
            this.SavingButton.Text = "Save";
            this.SavingButton.UseVisualStyleBackColor = false;
            this.SavingButton.Click += new System.EventHandler(this.SavingButton_Click);
            // 
            // SavingEdit
            // 
            this.SavingEdit.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SavingEdit.Location = new System.Drawing.Point(9, 39);
            this.SavingEdit.Margin = new System.Windows.Forms.Padding(2);
            this.SavingEdit.Multiline = true;
            this.SavingEdit.Name = "SavingEdit";
            this.SavingEdit.Size = new System.Drawing.Size(132, 30);
            this.SavingEdit.TabIndex = 4;
            this.SavingEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SavingEdit_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(5, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "How much money do you want to cash out?";
            // 
            // CashOutButton
            // 
            this.CashOutButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.CashOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashOutButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CashOutButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CashOutButton.Location = new System.Drawing.Point(153, 135);
            this.CashOutButton.Margin = new System.Windows.Forms.Padding(2);
            this.CashOutButton.Name = "CashOutButton";
            this.CashOutButton.Size = new System.Drawing.Size(132, 30);
            this.CashOutButton.TabIndex = 3;
            this.CashOutButton.Text = "Cash out";
            this.CashOutButton.UseVisualStyleBackColor = false;
            this.CashOutButton.Click += new System.EventHandler(this.CashOutButton_Click);
            // 
            // CashOutEdit
            // 
            this.CashOutEdit.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CashOutEdit.Location = new System.Drawing.Point(9, 135);
            this.CashOutEdit.Margin = new System.Windows.Forms.Padding(2);
            this.CashOutEdit.Multiline = true;
            this.CashOutEdit.Name = "CashOutEdit";
            this.CashOutEdit.Size = new System.Drawing.Size(131, 30);
            this.CashOutEdit.TabIndex = 4;
            this.CashOutEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CashOutEdit_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(5, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "How much money do you want to transfer?";
            // 
            // TransferEdit
            // 
            this.TransferEdit.BackColor = System.Drawing.SystemColors.Highlight;
            this.TransferEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransferEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransferEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TransferEdit.Location = new System.Drawing.Point(153, 305);
            this.TransferEdit.Margin = new System.Windows.Forms.Padding(2);
            this.TransferEdit.Name = "TransferEdit";
            this.TransferEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TransferEdit.Size = new System.Drawing.Size(132, 30);
            this.TransferEdit.TabIndex = 3;
            this.TransferEdit.Text = "Transfer";
            this.TransferEdit.UseVisualStyleBackColor = false;
            this.TransferEdit.Click += new System.EventHandler(this.TransferEdit_Click);
            // 
            // TransferSumEdit
            // 
            this.TransferSumEdit.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransferSumEdit.Location = new System.Drawing.Point(9, 225);
            this.TransferSumEdit.Margin = new System.Windows.Forms.Padding(2);
            this.TransferSumEdit.Multiline = true;
            this.TransferSumEdit.Name = "TransferSumEdit";
            this.TransferSumEdit.Size = new System.Drawing.Size(131, 30);
            this.TransferSumEdit.TabIndex = 4;
            this.TransferSumEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TransferSumEdit_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(5, 281);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Number of recepient";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(379, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Accumulation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(401, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Percent";
            // 
            // AccumulationButton
            // 
            this.AccumulationButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.AccumulationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccumulationButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccumulationButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AccumulationButton.Location = new System.Drawing.Point(362, 159);
            this.AccumulationButton.Margin = new System.Windows.Forms.Padding(2);
            this.AccumulationButton.Name = "AccumulationButton";
            this.AccumulationButton.Size = new System.Drawing.Size(131, 30);
            this.AccumulationButton.TabIndex = 3;
            this.AccumulationButton.Text = "Accumulate";
            this.AccumulationButton.UseVisualStyleBackColor = false;
            this.AccumulationButton.Click += new System.EventHandler(this.AccumulationButton_Click);
            // 
            // AccumulationPercentEdit
            // 
            this.AccumulationPercentEdit.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccumulationPercentEdit.Location = new System.Drawing.Point(362, 114);
            this.AccumulationPercentEdit.Margin = new System.Windows.Forms.Padding(2);
            this.AccumulationPercentEdit.Multiline = true;
            this.AccumulationPercentEdit.Name = "AccumulationPercentEdit";
            this.AccumulationPercentEdit.Size = new System.Drawing.Size(131, 30);
            this.AccumulationPercentEdit.TabIndex = 4;
            this.AccumulationPercentEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccumulationPercentEdit_KeyPress);
            // 
            // AccumulationEdit
            // 
            this.AccumulationEdit.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccumulationEdit.Location = new System.Drawing.Point(362, 44);
            this.AccumulationEdit.Margin = new System.Windows.Forms.Padding(2);
            this.AccumulationEdit.Multiline = true;
            this.AccumulationEdit.Name = "AccumulationEdit";
            this.AccumulationEdit.Size = new System.Drawing.Size(131, 30);
            this.AccumulationEdit.TabIndex = 4;
            this.AccumulationEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccumulationEdit_KeyPress);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackButton.Location = new System.Drawing.Point(1202, 774);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(71, 26);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // FreezingButton
            // 
            this.FreezingButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.FreezingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FreezingButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FreezingButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FreezingButton.Location = new System.Drawing.Point(686, 60);
            this.FreezingButton.Margin = new System.Windows.Forms.Padding(2);
            this.FreezingButton.Name = "FreezingButton";
            this.FreezingButton.Size = new System.Drawing.Size(132, 30);
            this.FreezingButton.TabIndex = 7;
            this.FreezingButton.Text = "Freeze";
            this.FreezingButton.UseVisualStyleBackColor = false;
            this.FreezingButton.Click += new System.EventHandler(this.FreezingButton_Click);
            // 
            // BlockButton
            // 
            this.BlockButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.BlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlockButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlockButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BlockButton.Location = new System.Drawing.Point(686, 21);
            this.BlockButton.Margin = new System.Windows.Forms.Padding(2);
            this.BlockButton.Name = "BlockButton";
            this.BlockButton.Size = new System.Drawing.Size(132, 30);
            this.BlockButton.TabIndex = 9;
            this.BlockButton.Text = "Block";
            this.BlockButton.UseVisualStyleBackColor = false;
            this.BlockButton.Click += new System.EventHandler(this.BlockButton_Click);
            // 
            // NumberTransBox
            // 
            this.NumberTransBox.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberTransBox.FormattingEnabled = true;
            this.NumberTransBox.Location = new System.Drawing.Point(9, 311);
            this.NumberTransBox.Margin = new System.Windows.Forms.Padding(2);
            this.NumberTransBox.Name = "NumberTransBox";
            this.NumberTransBox.Size = new System.Drawing.Size(132, 23);
            this.NumberTransBox.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.SavingButton);
            this.groupBox2.Controls.Add(this.FreezingButton);
            this.groupBox2.Controls.Add(this.BlockButton);
            this.groupBox2.Controls.Add(this.NumberTransBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.AccumulationEdit);
            this.groupBox2.Controls.Add(this.CashOutButton);
            this.groupBox2.Controls.Add(this.AccumulationPercentEdit);
            this.groupBox2.Controls.Add(this.SavingEdit);
            this.groupBox2.Controls.Add(this.AccumulationButton);
            this.groupBox2.Controls.Add(this.TransferEdit);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CashOutEdit);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TransferSumEdit);
            this.groupBox2.Location = new System.Drawing.Point(434, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(834, 358);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(5, 132);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "On Accumulation";
            // 
            // AccumMemo
            // 
            this.AccumMemo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AccumMemo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccumMemo.Location = new System.Drawing.Point(9, 161);
            this.AccumMemo.Margin = new System.Windows.Forms.Padding(2);
            this.AccumMemo.Name = "AccumMemo";
            this.AccumMemo.ReadOnly = true;
            this.AccumMemo.Size = new System.Drawing.Size(272, 59);
            this.AccumMemo.TabIndex = 10;
            this.AccumMemo.Text = "";
            // 
            // SavingMemo
            // 
            this.SavingMemo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SavingMemo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SavingMemo.Location = new System.Drawing.Point(63, 127);
            this.SavingMemo.Margin = new System.Windows.Forms.Padding(2);
            this.SavingMemo.Name = "SavingMemo";
            this.SavingMemo.ReadOnly = true;
            this.SavingMemo.Size = new System.Drawing.Size(272, 62);
            this.SavingMemo.TabIndex = 0;
            this.SavingMemo.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(5, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bank deposit";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AccumMemo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.AccountMemo);
            this.groupBox1.Location = new System.Drawing.Point(54, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 243);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.SavingMemo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox AccountMemo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SavingButton;
        private System.Windows.Forms.TextBox SavingEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CashOutButton;
        private System.Windows.Forms.TextBox CashOutEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button TransferEdit;
        private System.Windows.Forms.TextBox TransferSumEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AccumulationButton;
        private System.Windows.Forms.TextBox AccumulationPercentEdit;
        private System.Windows.Forms.TextBox AccumulationEdit;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button FreezingButton;
        private System.Windows.Forms.Button BlockButton;
        private System.Windows.Forms.ComboBox NumberTransBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox AccumMemo;
        private System.Windows.Forms.RichTextBox SavingMemo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}