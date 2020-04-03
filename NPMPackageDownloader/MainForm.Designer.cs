namespace NPMPackageDownloader
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnCheck = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxVersion = new System.Windows.Forms.ComboBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.progressBarDownload = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.comboBoxRegistry = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelRegistry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(15, 125);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(428, 41);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(16, 92);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(425, 25);
            this.textBoxName.TabIndex = 1;
            // 
            // comboBoxVersion
            // 
            this.comboBoxVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVersion.Enabled = false;
            this.comboBoxVersion.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVersion.FormattingEnabled = true;
            this.comboBoxVersion.Location = new System.Drawing.Point(17, 198);
            this.comboBoxVersion.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVersion.Name = "comboBoxVersion";
            this.comboBoxVersion.Size = new System.Drawing.Size(425, 25);
            this.comboBoxVersion.TabIndex = 3;
            // 
            // btnDownload
            // 
            this.btnDownload.Enabled = false;
            this.btnDownload.Location = new System.Drawing.Point(17, 237);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(427, 41);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // progressBarDownload
            // 
            this.progressBarDownload.Location = new System.Drawing.Point(18, 310);
            this.progressBarDownload.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(427, 26);
            this.progressBarDownload.TabIndex = 5;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(14, 292);
            this.labelProgress.Margin = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(71, 15);
            this.labelProgress.TabIndex = 6;
            this.labelProgress.Text = "Progress";
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Location = new System.Drawing.Point(13, 13);
            this.labelTip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(79, 15);
            this.labelTip.TabIndex = 7;
            this.labelTip.Text = "Registry:";
            // 
            // comboBoxRegistry
            // 
            this.comboBoxRegistry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegistry.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRegistry.FormattingEnabled = true;
            this.comboBoxRegistry.Location = new System.Drawing.Point(15, 33);
            this.comboBoxRegistry.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxRegistry.Name = "comboBoxRegistry";
            this.comboBoxRegistry.Size = new System.Drawing.Size(425, 25);
            this.comboBoxRegistry.TabIndex = 8;
            this.comboBoxRegistry.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegistry_SelectedIndexChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 73);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(111, 15);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Package Name:";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(13, 180);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(71, 15);
            this.labelVersion.TabIndex = 10;
            this.labelVersion.Text = "Versions";
            // 
            // labelRegistry
            // 
            this.labelRegistry.AutoSize = true;
            this.labelRegistry.ForeColor = System.Drawing.Color.SlateGray;
            this.labelRegistry.Location = new System.Drawing.Point(99, 13);
            this.labelRegistry.Name = "labelRegistry";
            this.labelRegistry.Size = new System.Drawing.Size(103, 15);
            this.labelRegistry.TabIndex = 11;
            this.labelRegistry.Text = "Registry URL";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 355);
            this.Controls.Add(this.labelRegistry);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBoxRegistry);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.progressBarDownload);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.comboBoxVersion);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.btnCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NPM Package Downloader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxVersion;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ProgressBar progressBarDownload;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.ComboBox comboBoxRegistry;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelRegistry;
    }
}

