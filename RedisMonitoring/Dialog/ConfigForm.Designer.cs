namespace RedisMonitoring.Dialog
{
    partial class ConfigForm
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
            this.connectButton = new System.Windows.Forms.Button();
            this.connectionStringTextBox = new System.Windows.Forms.TextBox();
            this.connectionStringLabel = new System.Windows.Forms.Label();
            this.errorMassageLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.connectButton.Location = new System.Drawing.Point(12, 132);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(99, 37);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // connectionStringTextBox
            // 
            this.connectionStringTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionStringTextBox.Location = new System.Drawing.Point(12, 28);
            this.connectionStringTextBox.Multiline = true;
            this.connectionStringTextBox.Name = "connectionStringTextBox";
            this.connectionStringTextBox.Size = new System.Drawing.Size(519, 59);
            this.connectionStringTextBox.TabIndex = 1;
            // 
            // connectionStringLabel
            // 
            this.connectionStringLabel.AutoSize = true;
            this.connectionStringLabel.Location = new System.Drawing.Point(12, 9);
            this.connectionStringLabel.Name = "connectionStringLabel";
            this.connectionStringLabel.Size = new System.Drawing.Size(88, 13);
            this.connectionStringLabel.TabIndex = 2;
            this.connectionStringLabel.Text = "ConnectionString";
            // 
            // errorMassageLabel
            // 
            this.errorMassageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.errorMassageLabel.AutoSize = true;
            this.errorMassageLabel.Location = new System.Drawing.Point(117, 146);
            this.errorMassageLabel.Name = "errorMassageLabel";
            this.errorMassageLabel.Size = new System.Drawing.Size(0, 13);
            this.errorMassageLabel.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 90);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(12, 106);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(519, 20);
            this.passwordTextBox.TabIndex = 4;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 181);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.errorMassageLabel);
            this.Controls.Add(this.connectionStringLabel);
            this.Controls.Add(this.connectionStringTextBox);
            this.Controls.Add(this.connectButton);
            this.Name = "ConfigForm";
            this.Text = "Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox connectionStringTextBox;
        private System.Windows.Forms.Label connectionStringLabel;
        private System.Windows.Forms.Label errorMassageLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}