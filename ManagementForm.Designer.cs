
namespace GroupProject
{
    partial class ManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementForm));
            this.closeButton = new System.Windows.Forms.Button();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.infoLabel = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.delUserButton = new System.Windows.Forms.Button();
            this.updatePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeButton.Location = new System.Drawing.Point(763, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonOnClick);
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Location = new System.Drawing.Point(12, 133);
            this.usersDataGridView.MultiSelect = false;
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.Size = new System.Drawing.Size(776, 305);
            this.usersDataGridView.TabIndex = 10;
            this.usersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGridViewOnCellClick);
            this.usersDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGridViewOnCellEndEdit);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.infoLabel.Location = new System.Drawing.Point(7, 12);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(265, 26);
            this.infoLabel.TabIndex = 12;
            this.infoLabel.Text = "Управление пользователями";
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.addUserButton.Location = new System.Drawing.Point(412, 92);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(185, 25);
            this.addUserButton.TabIndex = 13;
            this.addUserButton.Text = "Добавить пользователя";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.AddUserButtonOnClick);
            // 
            // delUserButton
            // 
            this.delUserButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.delUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delUserButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.delUserButton.Location = new System.Drawing.Point(603, 92);
            this.delUserButton.Name = "delUserButton";
            this.delUserButton.Size = new System.Drawing.Size(185, 25);
            this.delUserButton.TabIndex = 15;
            this.delUserButton.Text = "Удалить пользователя";
            this.delUserButton.UseVisualStyleBackColor = false;
            this.delUserButton.Click += new System.EventHandler(this.DelUserButtonOnClick);
            // 
            // updatePictureBox
            // 
            this.updatePictureBox.Image = global::GroupProject.Properties.Resources.arrow_reload_refresh_sync_icon_176208;
            this.updatePictureBox.Location = new System.Drawing.Point(377, 92);
            this.updatePictureBox.Name = "updatePictureBox";
            this.updatePictureBox.Size = new System.Drawing.Size(29, 25);
            this.updatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.updatePictureBox.TabIndex = 16;
            this.updatePictureBox.TabStop = false;
            this.updatePictureBox.Click += new System.EventHandler(this.UpdatePictureBoxOnClick);
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updatePictureBox);
            this.Controls.Add(this.delUserButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.usersDataGridView);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagementForm";
            this.Load += new System.EventHandler(this.ManagementFormOnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button delUserButton;
        private System.Windows.Forms.PictureBox updatePictureBox;
    }
}