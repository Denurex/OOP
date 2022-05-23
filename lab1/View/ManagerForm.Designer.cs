
namespace lab1
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.Status = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProjB = new System.Windows.Forms.ComboBox();
            this.AllCrBut = new System.Windows.Forms.Button();
            this.AllInsBut = new System.Windows.Forms.Button();
            this.AllPrBut = new System.Windows.Forms.Button();
            this.ShowPrj = new System.Windows.Forms.Button();
            this.DeclPrj = new System.Windows.Forms.Button();
            this.ConfPrj = new System.Windows.Forms.Button();
            this.CredB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InstB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LogoutB = new System.Windows.Forms.Button();
            this.ShowCr = new System.Windows.Forms.Button();
            this.DeclCr = new System.Windows.Forms.Button();
            this.ConfCr = new System.Windows.Forms.Button();
            this.ShowInst = new System.Windows.Forms.Button();
            this.DeclInst = new System.Windows.Forms.Button();
            this.ConfInst = new System.Windows.Forms.Button();
            this.ClearM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status.Location = new System.Drawing.Point(82, 63);
            this.Status.Margin = new System.Windows.Forms.Padding(2);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(485, 316);
            this.Status.TabIndex = 0;
            this.Status.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(730, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Projects";
            // 
            // ProjB
            // 
            this.ProjB.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProjB.FormattingEnabled = true;
            this.ProjB.Location = new System.Drawing.Point(734, 89);
            this.ProjB.Margin = new System.Windows.Forms.Padding(2);
            this.ProjB.Name = "ProjB";
            this.ProjB.Size = new System.Drawing.Size(401, 23);
            this.ProjB.TabIndex = 2;
            // 
            // AllCrBut
            // 
            this.AllCrBut.BackColor = System.Drawing.SystemColors.Highlight;
            this.AllCrBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllCrBut.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllCrBut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AllCrBut.Location = new System.Drawing.Point(82, 389);
            this.AllCrBut.Margin = new System.Windows.Forms.Padding(2);
            this.AllCrBut.Name = "AllCrBut";
            this.AllCrBut.Size = new System.Drawing.Size(141, 30);
            this.AllCrBut.TabIndex = 4;
            this.AllCrBut.Text = "Credits";
            this.AllCrBut.UseVisualStyleBackColor = false;
            this.AllCrBut.Click += new System.EventHandler(this.AllCrBut_Click);
            // 
            // AllInsBut
            // 
            this.AllInsBut.BackColor = System.Drawing.SystemColors.Highlight;
            this.AllInsBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllInsBut.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllInsBut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AllInsBut.Location = new System.Drawing.Point(245, 389);
            this.AllInsBut.Margin = new System.Windows.Forms.Padding(2);
            this.AllInsBut.Name = "AllInsBut";
            this.AllInsBut.Size = new System.Drawing.Size(154, 30);
            this.AllInsBut.TabIndex = 5;
            this.AllInsBut.Text = "Installments";
            this.AllInsBut.UseVisualStyleBackColor = false;
            this.AllInsBut.Click += new System.EventHandler(this.AllInsBut_Click);
            // 
            // AllPrBut
            // 
            this.AllPrBut.BackColor = System.Drawing.SystemColors.Highlight;
            this.AllPrBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllPrBut.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllPrBut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AllPrBut.Location = new System.Drawing.Point(420, 389);
            this.AllPrBut.Margin = new System.Windows.Forms.Padding(2);
            this.AllPrBut.Name = "AllPrBut";
            this.AllPrBut.Size = new System.Drawing.Size(147, 30);
            this.AllPrBut.TabIndex = 6;
            this.AllPrBut.Text = "Projects";
            this.AllPrBut.UseVisualStyleBackColor = false;
            this.AllPrBut.Click += new System.EventHandler(this.AllPrBut_Click);
            // 
            // ShowPrj
            // 
            this.ShowPrj.BackColor = System.Drawing.SystemColors.Highlight;
            this.ShowPrj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPrj.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowPrj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowPrj.Location = new System.Drawing.Point(1001, 116);
            this.ShowPrj.Margin = new System.Windows.Forms.Padding(2);
            this.ShowPrj.Name = "ShowPrj";
            this.ShowPrj.Size = new System.Drawing.Size(134, 30);
            this.ShowPrj.TabIndex = 9;
            this.ShowPrj.Text = "Show";
            this.ShowPrj.UseVisualStyleBackColor = false;
            this.ShowPrj.Click += new System.EventHandler(this.ShowPrj_Click);
            // 
            // DeclPrj
            // 
            this.DeclPrj.BackColor = System.Drawing.SystemColors.Highlight;
            this.DeclPrj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeclPrj.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeclPrj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeclPrj.Location = new System.Drawing.Point(866, 116);
            this.DeclPrj.Margin = new System.Windows.Forms.Padding(2);
            this.DeclPrj.Name = "DeclPrj";
            this.DeclPrj.Size = new System.Drawing.Size(134, 30);
            this.DeclPrj.TabIndex = 8;
            this.DeclPrj.Text = "Decline";
            this.DeclPrj.UseVisualStyleBackColor = false;
            this.DeclPrj.Click += new System.EventHandler(this.DeclPrj_Click);
            // 
            // ConfPrj
            // 
            this.ConfPrj.BackColor = System.Drawing.SystemColors.Highlight;
            this.ConfPrj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfPrj.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfPrj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConfPrj.Location = new System.Drawing.Point(734, 116);
            this.ConfPrj.Margin = new System.Windows.Forms.Padding(2);
            this.ConfPrj.Name = "ConfPrj";
            this.ConfPrj.Size = new System.Drawing.Size(134, 30);
            this.ConfPrj.TabIndex = 7;
            this.ConfPrj.Text = "Confirm";
            this.ConfPrj.UseVisualStyleBackColor = false;
            this.ConfPrj.Click += new System.EventHandler(this.ConfPrj_Click);
            // 
            // CredB
            // 
            this.CredB.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CredB.FormattingEnabled = true;
            this.CredB.Location = new System.Drawing.Point(734, 200);
            this.CredB.Margin = new System.Windows.Forms.Padding(2);
            this.CredB.Name = "CredB";
            this.CredB.Size = new System.Drawing.Size(401, 23);
            this.CredB.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(730, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Credits";
            // 
            // InstB
            // 
            this.InstB.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstB.FormattingEnabled = true;
            this.InstB.Location = new System.Drawing.Point(734, 311);
            this.InstB.Margin = new System.Windows.Forms.Padding(2);
            this.InstB.Name = "InstB";
            this.InstB.Size = new System.Drawing.Size(401, 23);
            this.InstB.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(730, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Installments";
            // 
            // LogoutB
            // 
            this.LogoutB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LogoutB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogoutB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogoutB.Location = new System.Drawing.Point(1177, 769);
            this.LogoutB.Margin = new System.Windows.Forms.Padding(2);
            this.LogoutB.Name = "LogoutB";
            this.LogoutB.Size = new System.Drawing.Size(96, 31);
            this.LogoutB.TabIndex = 20;
            this.LogoutB.Text = "Logout";
            this.LogoutB.UseVisualStyleBackColor = false;
            this.LogoutB.Click += new System.EventHandler(this.LogoutB_Click);
            // 
            // ShowCr
            // 
            this.ShowCr.BackColor = System.Drawing.SystemColors.Highlight;
            this.ShowCr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowCr.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowCr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowCr.Location = new System.Drawing.Point(1001, 225);
            this.ShowCr.Margin = new System.Windows.Forms.Padding(2);
            this.ShowCr.Name = "ShowCr";
            this.ShowCr.Size = new System.Drawing.Size(134, 30);
            this.ShowCr.TabIndex = 23;
            this.ShowCr.Text = "Show";
            this.ShowCr.UseVisualStyleBackColor = false;
            this.ShowCr.Click += new System.EventHandler(this.ShowCr_Click);
            // 
            // DeclCr
            // 
            this.DeclCr.BackColor = System.Drawing.SystemColors.Highlight;
            this.DeclCr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeclCr.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeclCr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeclCr.Location = new System.Drawing.Point(866, 225);
            this.DeclCr.Margin = new System.Windows.Forms.Padding(2);
            this.DeclCr.Name = "DeclCr";
            this.DeclCr.Size = new System.Drawing.Size(134, 30);
            this.DeclCr.TabIndex = 22;
            this.DeclCr.Text = "Decline";
            this.DeclCr.UseVisualStyleBackColor = false;
            this.DeclCr.Click += new System.EventHandler(this.DeclCr_Click);
            // 
            // ConfCr
            // 
            this.ConfCr.BackColor = System.Drawing.SystemColors.Highlight;
            this.ConfCr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfCr.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfCr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConfCr.Location = new System.Drawing.Point(734, 225);
            this.ConfCr.Margin = new System.Windows.Forms.Padding(2);
            this.ConfCr.Name = "ConfCr";
            this.ConfCr.Size = new System.Drawing.Size(134, 30);
            this.ConfCr.TabIndex = 21;
            this.ConfCr.Text = "Confirm";
            this.ConfCr.UseVisualStyleBackColor = false;
            this.ConfCr.Click += new System.EventHandler(this.ConfCr_Click);
            // 
            // ShowInst
            // 
            this.ShowInst.BackColor = System.Drawing.SystemColors.Highlight;
            this.ShowInst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowInst.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowInst.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowInst.Location = new System.Drawing.Point(1001, 336);
            this.ShowInst.Margin = new System.Windows.Forms.Padding(2);
            this.ShowInst.Name = "ShowInst";
            this.ShowInst.Size = new System.Drawing.Size(134, 30);
            this.ShowInst.TabIndex = 26;
            this.ShowInst.Text = "Show";
            this.ShowInst.UseVisualStyleBackColor = false;
            this.ShowInst.Click += new System.EventHandler(this.ShowInst_Click);
            // 
            // DeclInst
            // 
            this.DeclInst.BackColor = System.Drawing.SystemColors.Highlight;
            this.DeclInst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeclInst.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeclInst.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeclInst.Location = new System.Drawing.Point(866, 336);
            this.DeclInst.Margin = new System.Windows.Forms.Padding(2);
            this.DeclInst.Name = "DeclInst";
            this.DeclInst.Size = new System.Drawing.Size(147, 30);
            this.DeclInst.TabIndex = 25;
            this.DeclInst.Text = "Decline";
            this.DeclInst.UseVisualStyleBackColor = false;
            this.DeclInst.Click += new System.EventHandler(this.DeclInst_Click);
            // 
            // ConfInst
            // 
            this.ConfInst.BackColor = System.Drawing.SystemColors.Highlight;
            this.ConfInst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfInst.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfInst.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConfInst.Location = new System.Drawing.Point(734, 336);
            this.ConfInst.Margin = new System.Windows.Forms.Padding(2);
            this.ConfInst.Name = "ConfInst";
            this.ConfInst.Size = new System.Drawing.Size(147, 30);
            this.ConfInst.TabIndex = 24;
            this.ConfInst.Text = "Confirm";
            this.ConfInst.UseVisualStyleBackColor = false;
            this.ConfInst.Click += new System.EventHandler(this.ConfInst_Click);
            // 
            // ClearM
            // 
            this.ClearM.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClearM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearM.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClearM.Location = new System.Drawing.Point(478, 28);
            this.ClearM.Margin = new System.Windows.Forms.Padding(2);
            this.ClearM.Name = "ClearM";
            this.ClearM.Size = new System.Drawing.Size(89, 31);
            this.ClearM.TabIndex = 27;
            this.ClearM.Text = "Clear";
            this.ClearM.UseVisualStyleBackColor = false;
            this.ClearM.Click += new System.EventHandler(this.ClearM_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 749);
            this.Controls.Add(this.ClearM);
            this.Controls.Add(this.ShowInst);
            this.Controls.Add(this.DeclInst);
            this.Controls.Add(this.ConfInst);
            this.Controls.Add(this.ShowCr);
            this.Controls.Add(this.DeclCr);
            this.Controls.Add(this.ConfCr);
            this.Controls.Add(this.LogoutB);
            this.Controls.Add(this.InstB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CredB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShowPrj);
            this.Controls.Add(this.DeclPrj);
            this.Controls.Add(this.ConfPrj);
            this.Controls.Add(this.AllPrBut);
            this.Controls.Add(this.AllInsBut);
            this.Controls.Add(this.AllCrBut);
            this.Controls.Add(this.ProjB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Status);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerForm";
            this.Text = "Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProjB;
        private System.Windows.Forms.Button AllCrBut;
        private System.Windows.Forms.Button AllInsBut;
        private System.Windows.Forms.Button AllPrBut;
        private System.Windows.Forms.Button ShowPrj;
        private System.Windows.Forms.Button DeclPrj;
        private System.Windows.Forms.Button ConfPrj;
        private System.Windows.Forms.ComboBox CredB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox InstB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LogoutB;
        private System.Windows.Forms.Button ShowCr;
        private System.Windows.Forms.Button DeclCr;
        private System.Windows.Forms.Button ConfCr;
        private System.Windows.Forms.Button ShowInst;
        private System.Windows.Forms.Button DeclInst;
        private System.Windows.Forms.Button ConfInst;
        private System.Windows.Forms.Button ClearM;
    }
}