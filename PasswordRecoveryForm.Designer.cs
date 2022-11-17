
namespace GroupProject
{
    partial class PasswordRecoveryForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordRecoveryForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.closeButton = new System.Windows.Forms.Button();
            this.codePanel = new System.Windows.Forms.Panel();
            this.confirmButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.recoveryButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.codePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.titleLabel.Location = new System.Drawing.Point(6, 29);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(277, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Восстановление пароля";
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.loginTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(19, 93);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(256, 26);
            this.loginTextBox.TabIndex = 2;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.loginLabel.Location = new System.Drawing.Point(15, 69);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(121, 26);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Логин/Email";
            // 
            // codeTextBox
            // 
            this.codeTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.codeTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeTextBox.Location = new System.Drawing.Point(49, 25);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(110, 26);
            this.codeTextBox.TabIndex = 15;
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.codeLabel.Location = new System.Drawing.Point(2, 25);
            this.codeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(47, 26);
            this.codeLabel.TabIndex = 16;
            this.codeLabel.Text = "Код";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.infoLabel.Location = new System.Drawing.Point(17, 72);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(188, 40);
            this.infoLabel.TabIndex = 18;
            this.infoLabel.Text = "Отправить код повторно \r\nможно спустя \r\n";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.TimerOnTick);
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.closeButton.Location = new System.Drawing.Point(257, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(23, 23);
            this.closeButton.TabIndex = 21;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonOnClicK);
            // 
            // codePanel
            // 
            this.codePanel.Controls.Add(this.confirmButton);
            this.codePanel.Controls.Add(this.infoLabel);
            this.codePanel.Controls.Add(this.codeTextBox);
            this.codePanel.Controls.Add(this.codeLabel);
            this.codePanel.Location = new System.Drawing.Point(5, 169);
            this.codePanel.Name = "codePanel";
            this.codePanel.Size = new System.Drawing.Size(274, 119);
            this.codePanel.TabIndex = 22;
            this.codePanel.Visible = false;
            // 
            // confirmButton
            // 
            this.confirmButton.BorderRadius = 7;
            this.confirmButton.CheckedState.Parent = this.confirmButton;
            this.confirmButton.CustomImages.Parent = this.confirmButton;
            this.confirmButton.FillColor2 = System.Drawing.Color.Pink;
            this.confirmButton.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmButton.ForeColor = System.Drawing.Color.Black;
            this.confirmButton.HoverState.Parent = this.confirmButton;
            this.confirmButton.Location = new System.Drawing.Point(165, 25);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.ShadowDecoration.Parent = this.confirmButton;
            this.confirmButton.Size = new System.Drawing.Size(100, 26);
            this.confirmButton.TabIndex = 24;
            this.confirmButton.Text = "Подтвердить";
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButtonOnClick);
            // 
            // recoveryButton
            // 
            this.recoveryButton.BorderRadius = 7;
            this.recoveryButton.CheckedState.Parent = this.recoveryButton;
            this.recoveryButton.CustomImages.Parent = this.recoveryButton;
            this.recoveryButton.FillColor2 = System.Drawing.Color.Pink;
            this.recoveryButton.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveryButton.ForeColor = System.Drawing.Color.Black;
            this.recoveryButton.HoverState.Parent = this.recoveryButton;
            this.recoveryButton.Location = new System.Drawing.Point(39, 124);
            this.recoveryButton.Name = "recoveryButton";
            this.recoveryButton.ShadowDecoration.Parent = this.recoveryButton;
            this.recoveryButton.Size = new System.Drawing.Size(217, 29);
            this.recoveryButton.TabIndex = 23;
            this.recoveryButton.Text = "Отправить код";
            this.recoveryButton.Click += new System.EventHandler(this.RecoveryButtonOnClick);
            // 
            // PasswordRecoveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(286, 302);
            this.Controls.Add(this.recoveryButton);
            this.Controls.Add(this.codePanel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordRecoveryForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.codePanel.ResumeLayout(false);
            this.codePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel codePanel;
        private Guna.UI2.WinForms.Guna2GradientButton recoveryButton;
        private Guna.UI2.WinForms.Guna2GradientButton confirmButton;
    }
}