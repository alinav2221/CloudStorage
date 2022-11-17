
namespace GroupProject
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.pathCheckBox = new System.Windows.Forms.CheckBox();
            this.showPanel = new System.Windows.Forms.Panel();
            this.wayButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.zipPathTextBox = new System.Windows.Forms.TextBox();
            this.wayLabel = new System.Windows.Forms.Label();
            this.cryptCheckBox = new System.Windows.Forms.CheckBox();
            this.delAddCheckBox = new System.Windows.Forms.CheckBox();
            this.delExCheckBox = new System.Windows.Forms.CheckBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.titAddLabel = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.extLabel = new System.Windows.Forms.Label();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.allLabel = new System.Windows.Forms.Label();
            this.zipRadioButton = new System.Windows.Forms.RadioButton();
            this.ftpRadioButton = new System.Windows.Forms.RadioButton();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.showPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.titleLabel.Location = new System.Drawing.Point(112, 12);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(142, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Настройки";
            // 
            // pathCheckBox
            // 
            this.pathCheckBox.AutoSize = true;
            this.pathCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pathCheckBox.Location = new System.Drawing.Point(56, 172);
            this.pathCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.pathCheckBox.Name = "pathCheckBox";
            this.pathCheckBox.Size = new System.Drawing.Size(209, 26);
            this.pathCheckBox.TabIndex = 1;
            this.pathCheckBox.Text = "Выбрать другой путь ZIP";
            this.pathCheckBox.UseVisualStyleBackColor = true;
            this.pathCheckBox.CheckedChanged += new System.EventHandler(this.WayCheckBoxOnCheckedChanged);
            // 
            // showPanel
            // 
            this.showPanel.Controls.Add(this.wayButton);
            this.showPanel.Controls.Add(this.zipPathTextBox);
            this.showPanel.Controls.Add(this.wayLabel);
            this.showPanel.Location = new System.Drawing.Point(78, 202);
            this.showPanel.Margin = new System.Windows.Forms.Padding(2);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(290, 34);
            this.showPanel.TabIndex = 2;
            this.showPanel.Visible = false;
            // 
            // wayButton
            // 
            this.wayButton.BorderRadius = 7;
            this.wayButton.CheckedState.Parent = this.wayButton;
            this.wayButton.CustomImages.Parent = this.wayButton;
            this.wayButton.FillColor2 = System.Drawing.Color.Pink;
            this.wayButton.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wayButton.ForeColor = System.Drawing.Color.Black;
            this.wayButton.HoverState.Parent = this.wayButton;
            this.wayButton.Location = new System.Drawing.Point(207, 6);
            this.wayButton.Name = "wayButton";
            this.wayButton.ShadowDecoration.Parent = this.wayButton;
            this.wayButton.Size = new System.Drawing.Size(68, 20);
            this.wayButton.TabIndex = 25;
            this.wayButton.Text = "Обзор";
            this.wayButton.Click += new System.EventHandler(this.WayButtonOnClick);
            // 
            // zipPathTextBox
            // 
            this.zipPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zipPathTextBox.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zipPathTextBox.Location = new System.Drawing.Point(48, 4);
            this.zipPathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.zipPathTextBox.Name = "zipPathTextBox";
            this.zipPathTextBox.Size = new System.Drawing.Size(154, 20);
            this.zipPathTextBox.TabIndex = 1;
            // 
            // wayLabel
            // 
            this.wayLabel.AutoSize = true;
            this.wayLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wayLabel.Location = new System.Drawing.Point(2, 4);
            this.wayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wayLabel.Name = "wayLabel";
            this.wayLabel.Size = new System.Drawing.Size(46, 22);
            this.wayLabel.TabIndex = 0;
            this.wayLabel.Text = "Путь";
            // 
            // cryptCheckBox
            // 
            this.cryptCheckBox.AutoSize = true;
            this.cryptCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cryptCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cryptCheckBox.Location = new System.Drawing.Point(56, 124);
            this.cryptCheckBox.Name = "cryptCheckBox";
            this.cryptCheckBox.Size = new System.Drawing.Size(186, 26);
            this.cryptCheckBox.TabIndex = 3;
            this.cryptCheckBox.Text = "Шифрование данных ";
            this.cryptCheckBox.UseVisualStyleBackColor = true;
            this.cryptCheckBox.CheckedChanged += new System.EventHandler(this.CryptCheckBoxOnCheckedChanged);
            // 
            // delAddCheckBox
            // 
            this.delAddCheckBox.AutoSize = true;
            this.delAddCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delAddCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.delAddCheckBox.Location = new System.Drawing.Point(56, 387);
            this.delAddCheckBox.Name = "delAddCheckBox";
            this.delAddCheckBox.Size = new System.Drawing.Size(265, 26);
            this.delAddCheckBox.TabIndex = 4;
            this.delAddCheckBox.Text = "Удаление файла при добавлении";
            this.delAddCheckBox.UseVisualStyleBackColor = true;
            this.delAddCheckBox.CheckedChanged += new System.EventHandler(this.DelAddCheckBoxOnCheckedChanged);
            // 
            // delExCheckBox
            // 
            this.delExCheckBox.AutoSize = true;
            this.delExCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delExCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.delExCheckBox.Location = new System.Drawing.Point(56, 473);
            this.delExCheckBox.Name = "delExCheckBox";
            this.delExCheckBox.Size = new System.Drawing.Size(263, 26);
            this.delExCheckBox.TabIndex = 5;
            this.delExCheckBox.Text = "Удаление файла при извлечении";
            this.delExCheckBox.UseVisualStyleBackColor = true;
            this.delExCheckBox.CheckedChanged += new System.EventHandler(this.DelExCheckBoxOnCheckedChanged);
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.Moccasin;
            this.closeButton.Location = new System.Drawing.Point(347, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonOnClick);
            // 
            // titAddLabel
            // 
            this.titAddLabel.AutoSize = true;
            this.titAddLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titAddLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.titAddLabel.Location = new System.Drawing.Point(11, 240);
            this.titAddLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titAddLabel.Name = "titAddLabel";
            this.titAddLabel.Size = new System.Drawing.Size(133, 28);
            this.titAddLabel.TabIndex = 10;
            this.titAddLabel.Text = "Добавление";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(16, 271);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(337, 10);
            this.guna2Separator1.TabIndex = 11;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(16, 457);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(337, 10);
            this.guna2Separator2.TabIndex = 15;
            // 
            // extLabel
            // 
            this.extLabel.AutoSize = true;
            this.extLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.extLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.extLabel.Location = new System.Drawing.Point(11, 426);
            this.extLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.extLabel.Name = "extLabel";
            this.extLabel.Size = new System.Drawing.Size(130, 28);
            this.extLabel.TabIndex = 14;
            this.extLabel.Text = "Извлечение";
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Location = new System.Drawing.Point(16, 99);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(337, 10);
            this.guna2Separator3.TabIndex = 17;
            // 
            // allLabel
            // 
            this.allLabel.AutoSize = true;
            this.allLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.allLabel.Location = new System.Drawing.Point(11, 68);
            this.allLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.allLabel.Name = "allLabel";
            this.allLabel.Size = new System.Drawing.Size(83, 28);
            this.allLabel.TabIndex = 16;
            this.allLabel.Text = "Общие";
            // 
            // zipRadioButton
            // 
            this.zipRadioButton.AutoSize = true;
            this.zipRadioButton.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.zipRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.zipRadioButton.Location = new System.Drawing.Point(56, 287);
            this.zipRadioButton.Name = "zipRadioButton";
            this.zipRadioButton.Size = new System.Drawing.Size(220, 26);
            this.zipRadioButton.TabIndex = 18;
            this.zipRadioButton.TabStop = true;
            this.zipRadioButton.Text = "Добавление только в папку";
            this.zipRadioButton.UseVisualStyleBackColor = true;
            this.zipRadioButton.CheckedChanged += new System.EventHandler(this.ZipRadioButtonOnCheckedChanged);
            // 
            // ftpRadioButton
            // 
            this.ftpRadioButton.AutoSize = true;
            this.ftpRadioButton.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.ftpRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ftpRadioButton.Location = new System.Drawing.Point(56, 319);
            this.ftpRadioButton.Name = "ftpRadioButton";
            this.ftpRadioButton.Size = new System.Drawing.Size(234, 26);
            this.ftpRadioButton.TabIndex = 19;
            this.ftpRadioButton.TabStop = true;
            this.ftpRadioButton.Text = "Добавление только на сервер";
            this.ftpRadioButton.UseVisualStyleBackColor = true;
            this.ftpRadioButton.CheckedChanged += new System.EventHandler(this.FtpRadioButtonOnCheckedChanged);
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.allRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.allRadioButton.Location = new System.Drawing.Point(56, 351);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(273, 26);
            this.allRadioButton.TabIndex = 20;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "Добавление и  на сервер, и в папку";
            this.allRadioButton.UseVisualStyleBackColor = true;
            this.allRadioButton.CheckedChanged += new System.EventHandler(this.AllRadioButtonOnCheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(384, 529);
            this.Controls.Add(this.allRadioButton);
            this.Controls.Add(this.ftpRadioButton);
            this.Controls.Add(this.zipRadioButton);
            this.Controls.Add(this.guna2Separator3);
            this.Controls.Add(this.allLabel);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.extLabel);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.titAddLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.delExCheckBox);
            this.Controls.Add(this.delAddCheckBox);
            this.Controls.Add(this.cryptCheckBox);
            this.Controls.Add(this.showPanel);
            this.Controls.Add(this.pathCheckBox);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SettingsFormOnLoad);
            this.showPanel.ResumeLayout(false);
            this.showPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.CheckBox pathCheckBox;
        private System.Windows.Forms.Panel showPanel;
        private System.Windows.Forms.TextBox zipPathTextBox;
        private System.Windows.Forms.Label wayLabel;
        private Guna.UI2.WinForms.Guna2GradientButton wayButton;
        private System.Windows.Forms.CheckBox cryptCheckBox;
        private System.Windows.Forms.CheckBox delAddCheckBox;
        private System.Windows.Forms.CheckBox delExCheckBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label titAddLabel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Label extLabel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private System.Windows.Forms.Label allLabel;
        private System.Windows.Forms.RadioButton zipRadioButton;
        private System.Windows.Forms.RadioButton ftpRadioButton;
        private System.Windows.Forms.RadioButton allRadioButton;
    }
}