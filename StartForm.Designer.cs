
namespace GroupProject
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.infoTabControl = new VisualPlus.Toolkit.Controls.Navigation.VisualTabControl();
            this.entranceTabPage = new VisualPlus.Toolkit.Child.VisualTabPage();
            this.enterButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.autoCheckBox = new System.Windows.Forms.CheckBox();
            this.forgotLinkLabel = new System.Windows.Forms.LinkLabel();
            this.rememberCheckBox = new System.Windows.Forms.CheckBox();
            this.settingsPictureBox = new System.Windows.Forms.PictureBox();
            this.referencePictureBox = new System.Windows.Forms.PictureBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.registrationTabPage = new VisualPlus.Toolkit.Child.VisualTabPage();
            this.pasLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.registrationButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.setPictureBox = new System.Windows.Forms.PictureBox();
            this.manPictureBox = new System.Windows.Forms.PictureBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.regPasTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.regLogTextBox = new System.Windows.Forms.TextBox();
            this.passwordConfirmLabel = new System.Windows.Forms.Label();
            this.passwordConfirmTextBox = new System.Windows.Forms.TextBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.titlePictureBox = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.infoTabControl.SuspendLayout();
            this.entranceTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencePictureBox)).BeginInit();
            this.registrationTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // infoTabControl
            // 
            this.infoTabControl.Controls.Add(this.entranceTabPage);
            this.infoTabControl.Controls.Add(this.registrationTabPage);
            this.infoTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.infoTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoTabControl.ItemSize = new System.Drawing.Size(157, 50);
            this.infoTabControl.Location = new System.Drawing.Point(458, 46);
            this.infoTabControl.MinimumSize = new System.Drawing.Size(144, 85);
            this.infoTabControl.Name = "infoTabControl";
            this.infoTabControl.SelectedIndex = 0;
            this.infoTabControl.SelectorAlignment = System.Windows.Forms.TabAlignment.Bottom;
            this.infoTabControl.SelectorSpacing = 10;
            this.infoTabControl.SelectorThickness = 5;
            this.infoTabControl.SelectorType = VisualPlus.Toolkit.Controls.Navigation.VisualTabControl.SelectorTypes.Line;
            this.infoTabControl.SelectorVisible = true;
            this.infoTabControl.Separator = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.infoTabControl.SeparatorSpacing = 2;
            this.infoTabControl.SeparatorThickness = 2F;
            this.infoTabControl.Size = new System.Drawing.Size(337, 419);
            this.infoTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.infoTabControl.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.infoTabControl.TabIndex = 0;
            this.infoTabControl.TabMenu = System.Drawing.Color.LavenderBlush;
            this.infoTabControl.TabSelector = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.infoTabControl.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.infoTabControl.SelectedIndexChanged += new System.EventHandler(this.InfoTabControlOnSelectedIndexChanged);
            // 
            // entranceTabPage
            // 
            this.entranceTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.entranceTabPage.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.entranceTabPage.Border.Rounding = 6;
            this.entranceTabPage.Border.Thickness = 1;
            this.entranceTabPage.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rectangle;
            this.entranceTabPage.Border.Visible = false;
            this.entranceTabPage.Controls.Add(this.enterButton);
            this.entranceTabPage.Controls.Add(this.autoCheckBox);
            this.entranceTabPage.Controls.Add(this.forgotLinkLabel);
            this.entranceTabPage.Controls.Add(this.rememberCheckBox);
            this.entranceTabPage.Controls.Add(this.settingsPictureBox);
            this.entranceTabPage.Controls.Add(this.referencePictureBox);
            this.entranceTabPage.Controls.Add(this.passwordTextBox);
            this.entranceTabPage.Controls.Add(this.loginTextBox);
            this.entranceTabPage.Controls.Add(this.passwordLabel);
            this.entranceTabPage.Controls.Add(this.loginLabel);
            this.entranceTabPage.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entranceTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.entranceTabPage.HeaderImage = null;
            this.entranceTabPage.Image = null;
            this.entranceTabPage.ImageSize = new System.Drawing.Size(16, 16);
            this.entranceTabPage.Location = new System.Drawing.Point(4, 54);
            this.entranceTabPage.Name = "entranceTabPage";
            this.entranceTabPage.Rectangle = new System.Drawing.Rectangle(2, 2, 157, 50);
            this.entranceTabPage.Size = new System.Drawing.Size(329, 361);
            this.entranceTabPage.TabHover = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.entranceTabPage.TabIndex = 0;
            this.entranceTabPage.TabNormal = System.Drawing.Color.LavenderBlush;
            this.entranceTabPage.TabSelected = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.entranceTabPage.Text = "Вход";
            this.entranceTabPage.TextAlignment = System.Drawing.StringAlignment.Center;
            this.entranceTabPage.TextImageRelation = VisualPlus.Toolkit.Child.VisualTabPage.TextImageRelations.Text;
            this.entranceTabPage.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.entranceTabPage.TextSelected = System.Drawing.Color.LavenderBlush;
            // 
            // enterButton
            // 
            this.enterButton.BorderRadius = 7;
            this.enterButton.CheckedState.Parent = this.enterButton;
            this.enterButton.CustomImages.Parent = this.enterButton;
            this.enterButton.FillColor2 = System.Drawing.Color.Pink;
            this.enterButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.enterButton.ForeColor = System.Drawing.Color.Black;
            this.enterButton.HoverState.Parent = this.enterButton;
            this.enterButton.Location = new System.Drawing.Point(110, 261);
            this.enterButton.Name = "enterButton";
            this.enterButton.ShadowDecoration.Parent = this.enterButton;
            this.enterButton.Size = new System.Drawing.Size(88, 29);
            this.enterButton.TabIndex = 17;
            this.enterButton.Text = "Войти";
            this.enterButton.Click += new System.EventHandler(this.EnterButtonOnClick);
            // 
            // autoCheckBox
            // 
            this.autoCheckBox.AutoSize = true;
            this.autoCheckBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autoCheckBox.Location = new System.Drawing.Point(88, 296);
            this.autoCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.autoCheckBox.Name = "autoCheckBox";
            this.autoCheckBox.Size = new System.Drawing.Size(137, 18);
            this.autoCheckBox.TabIndex = 16;
            this.autoCheckBox.Text = "Работать автономно";
            this.autoCheckBox.UseVisualStyleBackColor = true;
            this.autoCheckBox.CheckedChanged += new System.EventHandler(this.AutoCheckBoxOnCheckedChanged);
            this.autoCheckBox.CheckStateChanged += new System.EventHandler(this.AutoCheckBoxOnCheckedChanged);
            // 
            // forgotLinkLabel
            // 
            this.forgotLinkLabel.AutoSize = true;
            this.forgotLinkLabel.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forgotLinkLabel.Location = new System.Drawing.Point(182, 149);
            this.forgotLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.forgotLinkLabel.Name = "forgotLinkLabel";
            this.forgotLinkLabel.Size = new System.Drawing.Size(101, 15);
            this.forgotLinkLabel.TabIndex = 13;
            this.forgotLinkLabel.TabStop = true;
            this.forgotLinkLabel.Text = "Забыли пароль?";
            this.forgotLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotLinkLabelOnLinkClicked);
            // 
            // rememberCheckBox
            // 
            this.rememberCheckBox.AutoSize = true;
            this.rememberCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rememberCheckBox.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rememberCheckBox.Location = new System.Drawing.Point(33, 151);
            this.rememberCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.rememberCheckBox.Name = "rememberCheckBox";
            this.rememberCheckBox.Size = new System.Drawing.Size(125, 19);
            this.rememberCheckBox.TabIndex = 11;
            this.rememberCheckBox.Text = "Запомнить меня";
            this.rememberCheckBox.UseVisualStyleBackColor = false;
            this.rememberCheckBox.CheckedChanged += new System.EventHandler(this.RememberCheckBoxOnCheckedChanged);
            // 
            // settingsPictureBox
            // 
            this.settingsPictureBox.Image = global::GroupProject.Properties.Resources.settings;
            this.settingsPictureBox.Location = new System.Drawing.Point(31, 261);
            this.settingsPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.settingsPictureBox.Name = "settingsPictureBox";
            this.settingsPictureBox.Size = new System.Drawing.Size(49, 53);
            this.settingsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsPictureBox.TabIndex = 15;
            this.settingsPictureBox.TabStop = false;
            this.settingsPictureBox.Click += new System.EventHandler(this.SettingsPictureBoxOnClick);
            // 
            // referencePictureBox
            // 
            this.referencePictureBox.Image = global::GroupProject.Properties.Resources.manual;
            this.referencePictureBox.Location = new System.Drawing.Point(229, 261);
            this.referencePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.referencePictureBox.Name = "referencePictureBox";
            this.referencePictureBox.Size = new System.Drawing.Size(49, 53);
            this.referencePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.referencePictureBox.TabIndex = 14;
            this.referencePictureBox.TabStop = false;
            this.referencePictureBox.Click += new System.EventHandler(this.ReferencePictureBoxOnClick);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.passwordTextBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(36, 127);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(247, 22);
            this.passwordTextBox.TabIndex = 9;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.loginTextBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(36, 54);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(247, 22);
            this.loginTextBox.TabIndex = 8;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(31, 100);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(82, 25);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Пароль";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(31, 27);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(70, 25);
            this.loginLabel.TabIndex = 10;
            this.loginLabel.Text = "Логин";
            // 
            // registrationTabPage
            // 
            this.registrationTabPage.AutoScroll = true;
            this.registrationTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.registrationTabPage.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.registrationTabPage.Border.Rounding = 6;
            this.registrationTabPage.Border.Thickness = 1;
            this.registrationTabPage.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rectangle;
            this.registrationTabPage.Border.Visible = false;
            this.registrationTabPage.Controls.Add(this.pasLabel);
            this.registrationTabPage.Controls.Add(this.numberTextBox);
            this.registrationTabPage.Controls.Add(this.nameTextBox);
            this.registrationTabPage.Controls.Add(this.nameLabel);
            this.registrationTabPage.Controls.Add(this.numberLabel);
            this.registrationTabPage.Controls.Add(this.registrationButton);
            this.registrationTabPage.Controls.Add(this.setPictureBox);
            this.registrationTabPage.Controls.Add(this.manPictureBox);
            this.registrationTabPage.Controls.Add(this.emailTextBox);
            this.registrationTabPage.Controls.Add(this.regPasTextBox);
            this.registrationTabPage.Controls.Add(this.emailLabel);
            this.registrationTabPage.Controls.Add(this.regLogTextBox);
            this.registrationTabPage.Controls.Add(this.passwordConfirmLabel);
            this.registrationTabPage.Controls.Add(this.passwordConfirmTextBox);
            this.registrationTabPage.Controls.Add(this.logLabel);
            this.registrationTabPage.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.registrationTabPage.HeaderImage = null;
            this.registrationTabPage.Image = null;
            this.registrationTabPage.ImageSize = new System.Drawing.Size(16, 16);
            this.registrationTabPage.Location = new System.Drawing.Point(4, 54);
            this.registrationTabPage.Name = "registrationTabPage";
            this.registrationTabPage.Rectangle = new System.Drawing.Rectangle(159, 2, 157, 50);
            this.registrationTabPage.Size = new System.Drawing.Size(329, 361);
            this.registrationTabPage.TabHover = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.registrationTabPage.TabIndex = 1;
            this.registrationTabPage.TabNormal = System.Drawing.Color.LavenderBlush;
            this.registrationTabPage.TabSelected = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.registrationTabPage.Text = "Регистрация";
            this.registrationTabPage.TextAlignment = System.Drawing.StringAlignment.Center;
            this.registrationTabPage.TextImageRelation = VisualPlus.Toolkit.Child.VisualTabPage.TextImageRelations.Text;
            this.registrationTabPage.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.registrationTabPage.TextSelected = System.Drawing.Color.LavenderBlush;
            // 
            // pasLabel
            // 
            this.pasLabel.AutoSize = true;
            this.pasLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pasLabel.Location = new System.Drawing.Point(13, 96);
            this.pasLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pasLabel.Name = "pasLabel";
            this.pasLabel.Size = new System.Drawing.Size(82, 22);
            this.pasLabel.TabIndex = 19;
            this.pasLabel.Text = "Пароль*";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberTextBox.Location = new System.Drawing.Point(159, 231);
            this.numberTextBox.Mask = "8-(000)-000-00-00";
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(159, 26);
            this.numberTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.nameTextBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(159, 15);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(159, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(13, 11);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 22);
            this.nameLabel.TabIndex = 29;
            this.nameLabel.Text = "Имя ";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.Location = new System.Drawing.Point(13, 219);
            this.numberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(79, 38);
            this.numberLabel.TabIndex = 27;
            this.numberLabel.Text = "Номер \r\nтелефона";
            // 
            // registrationButton
            // 
            this.registrationButton.BorderRadius = 7;
            this.registrationButton.CheckedState.Parent = this.registrationButton;
            this.registrationButton.CustomImages.Parent = this.registrationButton;
            this.registrationButton.FillColor2 = System.Drawing.Color.Pink;
            this.registrationButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.registrationButton.ForeColor = System.Drawing.Color.Black;
            this.registrationButton.HoverState.Parent = this.registrationButton;
            this.registrationButton.Location = new System.Drawing.Point(102, 306);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.ShadowDecoration.Parent = this.registrationButton;
            this.registrationButton.Size = new System.Drawing.Size(134, 29);
            this.registrationButton.TabIndex = 6;
            this.registrationButton.Text = "Зарегестрироваться";
            this.registrationButton.Click += new System.EventHandler(this.RegistrationButtonOnClick);
            // 
            // setPictureBox
            // 
            this.setPictureBox.Image = global::GroupProject.Properties.Resources.settings;
            this.setPictureBox.Location = new System.Drawing.Point(17, 293);
            this.setPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.setPictureBox.Name = "setPictureBox";
            this.setPictureBox.Size = new System.Drawing.Size(49, 53);
            this.setPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.setPictureBox.TabIndex = 25;
            this.setPictureBox.TabStop = false;
            this.setPictureBox.Click += new System.EventHandler(this.SettingsPictureBoxOnClick);
            // 
            // manPictureBox
            // 
            this.manPictureBox.Image = global::GroupProject.Properties.Resources.manual;
            this.manPictureBox.Location = new System.Drawing.Point(269, 293);
            this.manPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.manPictureBox.Name = "manPictureBox";
            this.manPictureBox.Size = new System.Drawing.Size(49, 53);
            this.manPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.manPictureBox.TabIndex = 24;
            this.manPictureBox.TabStop = false;
            this.manPictureBox.Click += new System.EventHandler(this.ReferencePictureBoxOnClick);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.emailTextBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(159, 190);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(159, 22);
            this.emailTextBox.TabIndex = 4;
            // 
            // regPasTextBox
            // 
            this.regPasTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.regPasTextBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regPasTextBox.Location = new System.Drawing.Point(159, 100);
            this.regPasTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.regPasTextBox.Name = "regPasTextBox";
            this.regPasTextBox.Size = new System.Drawing.Size(159, 22);
            this.regPasTextBox.TabIndex = 2;
            this.regPasTextBox.UseSystemPasswordChar = true;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(13, 186);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(64, 22);
            this.emailLabel.TabIndex = 23;
            this.emailLabel.Text = "Email*";
            // 
            // regLogTextBox
            // 
            this.regLogTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.regLogTextBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regLogTextBox.Location = new System.Drawing.Point(159, 55);
            this.regLogTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.regLogTextBox.Name = "regLogTextBox";
            this.regLogTextBox.Size = new System.Drawing.Size(159, 22);
            this.regLogTextBox.TabIndex = 1;
            // 
            // passwordConfirmLabel
            // 
            this.passwordConfirmLabel.AutoSize = true;
            this.passwordConfirmLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordConfirmLabel.Location = new System.Drawing.Point(13, 131);
            this.passwordConfirmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordConfirmLabel.Name = "passwordConfirmLabel";
            this.passwordConfirmLabel.Size = new System.Drawing.Size(129, 38);
            this.passwordConfirmLabel.TabIndex = 21;
            this.passwordConfirmLabel.Text = "Подтверждение \r\nпароля*";
            // 
            // passwordConfirmTextBox
            // 
            this.passwordConfirmTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.passwordConfirmTextBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordConfirmTextBox.Location = new System.Drawing.Point(159, 147);
            this.passwordConfirmTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordConfirmTextBox.Name = "passwordConfirmTextBox";
            this.passwordConfirmTextBox.Size = new System.Drawing.Size(159, 22);
            this.passwordConfirmTextBox.TabIndex = 3;
            this.passwordConfirmTextBox.UseSystemPasswordChar = true;
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logLabel.Location = new System.Drawing.Point(13, 51);
            this.logLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(71, 22);
            this.logLabel.TabIndex = 18;
            this.logLabel.Text = "Логин*";
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(71)))), ((int)(((byte)(70)))));
            this.closeButton.Location = new System.Drawing.Point(768, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(23, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonOnClick);
            // 
            // titlePictureBox
            // 
            this.titlePictureBox.Image = global::GroupProject.Properties.Resources.Фон2;
            this.titlePictureBox.Location = new System.Drawing.Point(12, 48);
            this.titlePictureBox.Name = "titlePictureBox";
            this.titlePictureBox.Size = new System.Drawing.Size(440, 413);
            this.titlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titlePictureBox.TabIndex = 2;
            this.titlePictureBox.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(801, 477);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.WindowsMediaPlayerOnPlayStateChange);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(801, 477);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.titlePictureBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.infoTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StartFormOnLoad);
            this.infoTabControl.ResumeLayout(false);
            this.entranceTabPage.ResumeLayout(false);
            this.entranceTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencePictureBox)).EndInit();
            this.registrationTabPage.ResumeLayout(false);
            this.registrationTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public VisualPlus.Toolkit.Controls.Navigation.VisualTabControl infoTabControl;
        public VisualPlus.Toolkit.Child.VisualTabPage entranceTabPage;
        private VisualPlus.Toolkit.Child.VisualTabPage registrationTabPage;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox titlePictureBox;
        private Guna.UI2.WinForms.Guna2GradientButton enterButton;
        private System.Windows.Forms.CheckBox autoCheckBox;
        private System.Windows.Forms.LinkLabel forgotLinkLabel;
        public System.Windows.Forms.CheckBox rememberCheckBox;
        private System.Windows.Forms.PictureBox settingsPictureBox;
        private System.Windows.Forms.PictureBox referencePictureBox;
        public System.Windows.Forms.TextBox passwordTextBox;
        public System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private Guna.UI2.WinForms.Guna2GradientButton registrationButton;
        private System.Windows.Forms.PictureBox setPictureBox;
        private System.Windows.Forms.PictureBox manPictureBox;
        public System.Windows.Forms.TextBox emailTextBox;
        public System.Windows.Forms.TextBox regPasTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label pasLabel;
        public System.Windows.Forms.TextBox regLogTextBox;
        private System.Windows.Forms.Label passwordConfirmLabel;
        public System.Windows.Forms.TextBox passwordConfirmTextBox;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Label numberLabel;
        public System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.MaskedTextBox numberTextBox;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

