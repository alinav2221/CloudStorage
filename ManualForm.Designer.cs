
namespace GroupProject
{
    partial class ManualForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualForm));
            this.manualToolStrip = new System.Windows.Forms.ToolStrip();
            this.title = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clear = new System.Windows.Forms.ToolStripLabel();
            this.regToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.localToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.driveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.closeButton = new System.Windows.Forms.Button();
            this.infoWebBrowser = new System.Windows.Forms.WebBrowser();
            this.manualToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // manualToolStrip
            // 
            this.manualToolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.manualToolStrip.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.manualToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.title,
            this.toolStripSeparator1,
            this.clear,
            this.regToolStripButton,
            this.localToolStripButton,
            this.driveToolStripButton});
            this.manualToolStrip.Location = new System.Drawing.Point(0, 0);
            this.manualToolStrip.Name = "manualToolStrip";
            this.manualToolStrip.Size = new System.Drawing.Size(203, 363);
            this.manualToolStrip.TabIndex = 1;
            this.manualToolStrip.Text = "Руководство";
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(200, 26);
            this.title.Text = "Руководство";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // clear
            // 
            this.clear.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(200, 17);
            this.clear.Text = "hgjg";
            // 
            // regToolStripButton
            // 
            this.regToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.regToolStripButton.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("regToolStripButton.Image")));
            this.regToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.regToolStripButton.Name = "regToolStripButton";
            this.regToolStripButton.Size = new System.Drawing.Size(200, 24);
            this.regToolStripButton.Text = "Регистрация";
            this.regToolStripButton.Click += new System.EventHandler(this.RegToolStripButtonOnClick);
            // 
            // localToolStripButton
            // 
            this.localToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.localToolStripButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.localToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("localToolStripButton.Image")));
            this.localToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.localToolStripButton.Name = "localToolStripButton";
            this.localToolStripButton.Size = new System.Drawing.Size(200, 22);
            this.localToolStripButton.Text = "Авторизация и восстановление";
            this.localToolStripButton.Click += new System.EventHandler(this.LocalToolStripButtonOnClick);
            // 
            // driveToolStripButton
            // 
            this.driveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.driveToolStripButton.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("driveToolStripButton.Image")));
            this.driveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.driveToolStripButton.Name = "driveToolStripButton";
            this.driveToolStripButton.Size = new System.Drawing.Size(200, 24);
            this.driveToolStripButton.Text = "Работа с файлами";
            this.driveToolStripButton.Click += new System.EventHandler(this.DriveToolStripButtonOnClick);
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.Moccasin;
            this.closeButton.Location = new System.Drawing.Point(673, 8);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonOnClick);
            // 
            // infoWebBrowser
            // 
            this.infoWebBrowser.Location = new System.Drawing.Point(215, 41);
            this.infoWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.infoWebBrowser.Name = "infoWebBrowser";
            this.infoWebBrowser.Size = new System.Drawing.Size(483, 310);
            this.infoWebBrowser.TabIndex = 10;
            // 
            // ManualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(710, 363);
            this.Controls.Add(this.infoWebBrowser);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.manualToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManualForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководство";
            this.manualToolStrip.ResumeLayout(false);
            this.manualToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip manualToolStrip;
        private System.Windows.Forms.ToolStripButton regToolStripButton;
        private System.Windows.Forms.ToolStripButton localToolStripButton;
        private System.Windows.Forms.ToolStripButton driveToolStripButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ToolStripLabel title;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel clear;
        private System.Windows.Forms.WebBrowser infoWebBrowser;
    }
}