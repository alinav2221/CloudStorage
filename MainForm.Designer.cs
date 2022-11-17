
namespace GroupProject
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ZipFiles", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("CloudFiles", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuSeparator = new ns1.BunifuSeparator();
            this.addButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.syncButton = new System.Windows.Forms.Button();
            this.filesListView = new System.Windows.Forms.ListView();
            this.closeButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.delPctureBox = new System.Windows.Forms.PictureBox();
            this.changeUserLinkLabel = new System.Windows.Forms.LinkLabel();
            this.managementButton = new System.Windows.Forms.Button();
            this.manualButton = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cloudMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zipMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.delPctureBox)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuSeparator
            // 
            this.bunifuSeparator.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuSeparator.ForeColor = System.Drawing.Color.Moccasin;
            this.bunifuSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(181)))));
            this.bunifuSeparator.LineThickness = 1;
            this.bunifuSeparator.Location = new System.Drawing.Point(142, 94);
            this.bunifuSeparator.Name = "bunifuSeparator";
            this.bunifuSeparator.Size = new System.Drawing.Size(5, 364);
            this.bunifuSeparator.TabIndex = 1;
            this.bunifuSeparator.Transparency = 255;
            this.bunifuSeparator.Vertical = true;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.Moccasin;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.LavenderBlush;
            this.addButton.Location = new System.Drawing.Point(15, 94);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(115, 37);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButtonOnClick);
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.exportButton.FlatAppearance.BorderColor = System.Drawing.Color.Moccasin;
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exportButton.ForeColor = System.Drawing.Color.LavenderBlush;
            this.exportButton.Location = new System.Drawing.Point(15, 147);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(115, 37);
            this.exportButton.TabIndex = 3;
            this.exportButton.Text = "Извлечь";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.ExportButtonOnClick);
            // 
            // syncButton
            // 
            this.syncButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.syncButton.FlatAppearance.BorderColor = System.Drawing.Color.Moccasin;
            this.syncButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.syncButton.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.syncButton.ForeColor = System.Drawing.Color.LavenderBlush;
            this.syncButton.Location = new System.Drawing.Point(15, 211);
            this.syncButton.Name = "syncButton";
            this.syncButton.Size = new System.Drawing.Size(115, 37);
            this.syncButton.TabIndex = 4;
            this.syncButton.Text = "Синхронизировать";
            this.syncButton.UseVisualStyleBackColor = false;
            this.syncButton.Click += new System.EventHandler(this.SyncButtonOnClick);
            // 
            // filesListView
            // 
            this.filesListView.BackColor = System.Drawing.Color.LavenderBlush;
            this.filesListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filesListView.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            listViewGroup1.Header = "ZipFiles";
            listViewGroup1.Name = "zipListViewGroup";
            listViewGroup2.Header = "CloudFiles";
            listViewGroup2.Name = "cloudListViewGroup";
            this.filesListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.filesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.filesListView.HideSelection = false;
            this.filesListView.Location = new System.Drawing.Point(153, 98);
            this.filesListView.Name = "filesListView";
            this.filesListView.ShowItemToolTips = true;
            this.filesListView.Size = new System.Drawing.Size(616, 279);
            this.filesListView.TabIndex = 6;
            this.filesListView.UseCompatibleStateImageBehavior = false;
            this.filesListView.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.FilesListViewOnItemMouseHover);
            this.filesListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.FilesListViewOnItemSelectionChanged);
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeButton.Location = new System.Drawing.Point(749, 7);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonOnClick);
            // 
            // settingsButton
            // 
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.settingsButton.Location = new System.Drawing.Point(476, 7);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(86, 25);
            this.settingsButton.TabIndex = 9;
            this.settingsButton.Text = "Настройки";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButtonOnClick);
            // 
            // infoButton
            // 
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.infoButton.Location = new System.Drawing.Point(646, 7);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(95, 25);
            this.infoButton.TabIndex = 10;
            this.infoButton.Text = "О программе";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.InfoButtonOnClick);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.infoLabel.Location = new System.Drawing.Point(8, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(132, 26);
            this.infoLabel.TabIndex = 11;
            this.infoLabel.Text = "Пользователь";
            // 
            // delPctureBox
            // 
            this.delPctureBox.Image = global::GroupProject.Properties.Resources.del;
            this.delPctureBox.Location = new System.Drawing.Point(158, 383);
            this.delPctureBox.Name = "delPctureBox";
            this.delPctureBox.Size = new System.Drawing.Size(72, 65);
            this.delPctureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.delPctureBox.TabIndex = 14;
            this.delPctureBox.TabStop = false;
            this.delPctureBox.Click += new System.EventHandler(this.DelButtonOnClick);
            // 
            // changeUserLinkLabel
            // 
            this.changeUserLinkLabel.AutoSize = true;
            this.changeUserLinkLabel.Location = new System.Drawing.Point(10, 35);
            this.changeUserLinkLabel.Name = "changeUserLinkLabel";
            this.changeUserLinkLabel.Size = new System.Drawing.Size(125, 13);
            this.changeUserLinkLabel.TabIndex = 15;
            this.changeUserLinkLabel.TabStop = true;
            this.changeUserLinkLabel.Text = "Сменить пользователя";
            this.changeUserLinkLabel.Click += new System.EventHandler(this.ChageButtonOnClick);
            // 
            // managementButton
            // 
            this.managementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managementButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.managementButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.managementButton.Location = new System.Drawing.Point(273, 7);
            this.managementButton.Name = "managementButton";
            this.managementButton.Size = new System.Drawing.Size(197, 25);
            this.managementButton.TabIndex = 16;
            this.managementButton.Text = "Управление пользователями";
            this.managementButton.UseVisualStyleBackColor = true;
            this.managementButton.Visible = false;
            this.managementButton.Click += new System.EventHandler(this.ManagementButtonOnClick);
            // 
            // manualButton
            // 
            this.manualButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manualButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manualButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.manualButton.Location = new System.Drawing.Point(568, 7);
            this.manualButton.Name = "manualButton";
            this.manualButton.Size = new System.Drawing.Size(72, 25);
            this.manualButton.TabIndex = 18;
            this.manualButton.Text = "Справка";
            this.manualButton.UseVisualStyleBackColor = true;
            this.manualButton.Click += new System.EventHandler(this.ManualButtonOnClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cloudMenuItem,
            this.zipMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(185, 48);
            // 
            // cloudMenuItem
            // 
            this.cloudMenuItem.Name = "cloudMenuItem";
            this.cloudMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cloudMenuItem.Text = "Перенос на облако ";
            this.cloudMenuItem.Click += new System.EventHandler(this.CloudMenuItemOnClick);
            // 
            // zipMenuItem
            // 
            this.zipMenuItem.Name = "zipMenuItem";
            this.zipMenuItem.Size = new System.Drawing.Size(184, 22);
            this.zipMenuItem.Text = "Перенести в папку";
            this.zipMenuItem.Click += new System.EventHandler(this.ZipMenuItemOnClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(786, 456);
            this.Controls.Add(this.manualButton);
            this.Controls.Add(this.managementButton);
            this.Controls.Add(this.changeUserLinkLabel);
            this.Controls.Add(this.delPctureBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.filesListView);
            this.Controls.Add(this.syncButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.bunifuSeparator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainFormOnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.delPctureBox)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.BunifuSeparator bunifuSeparator;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button syncButton;
        private System.Windows.Forms.ListView filesListView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.PictureBox delPctureBox;
        private System.Windows.Forms.LinkLabel changeUserLinkLabel;
        private System.Windows.Forms.Button managementButton;
        private System.Windows.Forms.Button manualButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cloudMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zipMenuItem;
    }
}