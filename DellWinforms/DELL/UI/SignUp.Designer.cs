﻿namespace DELL.UI
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.BottomContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.Inputs = new System.Windows.Forms.TableLayoutPanel();
            this.Contact = new Guna.UI.WinForms.GunaLabel();
            this.DOB = new Guna.UI.WinForms.GunaLabel();
            this.Address = new Guna.UI.WinForms.GunaLabel();
            this.Gender = new Guna.UI.WinForms.GunaLabel();
            this.Username = new Guna.UI.WinForms.GunaLabel();
            this.Password = new Guna.UI.WinForms.GunaLabel();
            this.IName = new Guna.UI.WinForms.GunaLabel();
            this.Email = new Guna.UI.WinForms.GunaLabel();
            this.NInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.UInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.PInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.EInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.CInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.AInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.GInput = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DOBI = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.SignUpbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SignIn = new System.Windows.Forms.LinkLabel();
            this.Exitbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Back = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.TopContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.Logo = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.BottomContainer.SuspendLayout();
            this.Inputs.SuspendLayout();
            this.TopContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.BottomContainer);
            this.MainPanel.Controls.Add(this.TopContainer);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.FillColor = System.Drawing.Color.Lavender;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(784, 561);
            this.MainPanel.TabIndex = 0;
            // 
            // BottomContainer
            // 
            this.BottomContainer.Controls.Add(this.Inputs);
            this.BottomContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomContainer.Location = new System.Drawing.Point(0, 150);
            this.BottomContainer.Name = "BottomContainer";
            this.BottomContainer.Size = new System.Drawing.Size(784, 411);
            this.BottomContainer.TabIndex = 1;
            // 
            // Inputs
            // 
            this.Inputs.BackColor = System.Drawing.Color.GhostWhite;
            this.Inputs.ColumnCount = 7;
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.46055F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.20111F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.295F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.302407F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.11686F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.64033F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.98374F));
            this.Inputs.Controls.Add(this.Contact, 4, 3);
            this.Inputs.Controls.Add(this.DOB, 4, 1);
            this.Inputs.Controls.Add(this.Address, 4, 4);
            this.Inputs.Controls.Add(this.Gender, 4, 2);
            this.Inputs.Controls.Add(this.Username, 1, 2);
            this.Inputs.Controls.Add(this.Password, 1, 3);
            this.Inputs.Controls.Add(this.IName, 1, 1);
            this.Inputs.Controls.Add(this.Email, 1, 4);
            this.Inputs.Controls.Add(this.NInput, 2, 1);
            this.Inputs.Controls.Add(this.UInput, 2, 2);
            this.Inputs.Controls.Add(this.PInput, 2, 3);
            this.Inputs.Controls.Add(this.EInput, 2, 4);
            this.Inputs.Controls.Add(this.CInput, 5, 3);
            this.Inputs.Controls.Add(this.AInput, 5, 4);
            this.Inputs.Controls.Add(this.GInput, 5, 2);
            this.Inputs.Controls.Add(this.DOBI, 5, 1);
            this.Inputs.Controls.Add(this.SignUpbtn, 5, 5);
            this.Inputs.Controls.Add(this.SignIn, 2, 5);
            this.Inputs.Controls.Add(this.Exitbtn, 5, 6);
            this.Inputs.Controls.Add(this.Back, 1, 6);
            this.Inputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inputs.ForeColor = System.Drawing.Color.Black;
            this.Inputs.Location = new System.Drawing.Point(0, 0);
            this.Inputs.Name = "Inputs";
            this.Inputs.RowCount = 8;
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.Inputs.Size = new System.Drawing.Size(784, 411);
            this.Inputs.TabIndex = 0;
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contact.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.Location = new System.Drawing.Point(396, 139);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(120, 46);
            this.Contact.TabIndex = 3;
            this.Contact.Text = "Contact";
            this.Contact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DOB.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.Location = new System.Drawing.Point(396, 47);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(120, 46);
            this.DOB.TabIndex = 10;
            this.DOB.Text = "Date of birth";
            this.DOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Address.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(396, 185);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(120, 46);
            this.Address.TabIndex = 5;
            this.Address.Text = "Address";
            this.Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gender.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(396, 93);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(120, 46);
            this.Gender.TabIndex = 9;
            this.Gender.Text = "Gender";
            this.Gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Username.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(85, 93);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(121, 46);
            this.Username.TabIndex = 6;
            this.Username.Text = "Username";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Password.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(85, 139);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(121, 46);
            this.Password.TabIndex = 7;
            this.Password.Text = "Password";
            this.Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IName
            // 
            this.IName.AutoSize = true;
            this.IName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IName.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IName.Location = new System.Drawing.Point(85, 47);
            this.IName.Name = "IName";
            this.IName.Size = new System.Drawing.Size(121, 46);
            this.IName.TabIndex = 4;
            this.IName.Text = "Name";
            this.IName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Email.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(85, 185);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(121, 46);
            this.Email.TabIndex = 8;
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NInput
            // 
            this.NInput.AutoRoundedCorners = true;
            this.NInput.BorderRadius = 16;
            this.NInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NInput.DefaultText = "";
            this.NInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NInput.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.NInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NInput.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NInput.ForeColor = System.Drawing.Color.Black;
            this.NInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NInput.Location = new System.Drawing.Point(214, 53);
            this.NInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NInput.Name = "NInput";
            this.NInput.PasswordChar = '\0';
            this.NInput.PlaceholderText = "Enter name";
            this.NInput.SelectedText = "";
            this.NInput.Size = new System.Drawing.Size(156, 34);
            this.NInput.TabIndex = 11;
            // 
            // UInput
            // 
            this.UInput.AutoRoundedCorners = true;
            this.UInput.BorderRadius = 16;
            this.UInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UInput.DefaultText = "";
            this.UInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UInput.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.UInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UInput.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UInput.ForeColor = System.Drawing.Color.Black;
            this.UInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UInput.Location = new System.Drawing.Point(214, 99);
            this.UInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.UInput.Name = "UInput";
            this.UInput.PasswordChar = '\0';
            this.UInput.PlaceholderText = "John123 etc.";
            this.UInput.SelectedText = "";
            this.UInput.Size = new System.Drawing.Size(156, 34);
            this.UInput.TabIndex = 12;
            // 
            // PInput
            // 
            this.PInput.AutoRoundedCorners = true;
            this.PInput.BorderRadius = 16;
            this.PInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PInput.DefaultText = "";
            this.PInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PInput.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.PInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PInput.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PInput.ForeColor = System.Drawing.Color.Black;
            this.PInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PInput.Location = new System.Drawing.Point(214, 145);
            this.PInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PInput.Name = "PInput";
            this.PInput.PasswordChar = '●';
            this.PInput.PlaceholderText = "******";
            this.PInput.SelectedText = "";
            this.PInput.Size = new System.Drawing.Size(156, 34);
            this.PInput.TabIndex = 13;
            this.PInput.UseSystemPasswordChar = true;
            // 
            // EInput
            // 
            this.EInput.AutoRoundedCorners = true;
            this.EInput.BorderRadius = 16;
            this.EInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EInput.DefaultText = "";
            this.EInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EInput.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.EInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EInput.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EInput.ForeColor = System.Drawing.Color.Black;
            this.EInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EInput.Location = new System.Drawing.Point(214, 191);
            this.EInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.EInput.Name = "EInput";
            this.EInput.PasswordChar = '\0';
            this.EInput.PlaceholderText = "aaa@gmail.com";
            this.EInput.SelectedText = "";
            this.EInput.Size = new System.Drawing.Size(156, 34);
            this.EInput.TabIndex = 14;
            // 
            // CInput
            // 
            this.CInput.AutoRoundedCorners = true;
            this.CInput.BorderRadius = 16;
            this.CInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CInput.DefaultText = "";
            this.CInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CInput.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.CInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CInput.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CInput.ForeColor = System.Drawing.Color.Black;
            this.CInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CInput.Location = new System.Drawing.Point(524, 145);
            this.CInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CInput.Name = "CInput";
            this.CInput.PasswordChar = '\0';
            this.CInput.PlaceholderText = "";
            this.CInput.SelectedText = "";
            this.CInput.Size = new System.Drawing.Size(167, 34);
            this.CInput.TabIndex = 15;
            // 
            // AInput
            // 
            this.AInput.AutoRoundedCorners = true;
            this.AInput.BorderRadius = 16;
            this.AInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AInput.DefaultText = "";
            this.AInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AInput.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.AInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AInput.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AInput.ForeColor = System.Drawing.Color.Black;
            this.AInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AInput.Location = new System.Drawing.Point(524, 191);
            this.AInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.AInput.Name = "AInput";
            this.AInput.PasswordChar = '\0';
            this.AInput.PlaceholderText = "";
            this.AInput.SelectedText = "";
            this.AInput.Size = new System.Drawing.Size(167, 34);
            this.AInput.TabIndex = 16;
            // 
            // GInput
            // 
            this.GInput.AutoRoundedCorners = true;
            this.GInput.BackColor = System.Drawing.Color.Transparent;
            this.GInput.BorderRadius = 17;
            this.GInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GInput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GInput.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.GInput.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GInput.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.GInput.ForeColor = System.Drawing.Color.Black;
            this.GInput.ItemHeight = 30;
            this.GInput.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.GInput.Location = new System.Drawing.Point(522, 96);
            this.GInput.Name = "GInput";
            this.GInput.Size = new System.Drawing.Size(171, 36);
            this.GInput.Sorted = true;
            this.GInput.TabIndex = 17;
            // 
            // DOBI
            // 
            this.DOBI.AutoRoundedCorners = true;
            this.DOBI.BorderRadius = 19;
            this.DOBI.Checked = true;
            this.DOBI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DOBI.FillColor = System.Drawing.Color.White;
            this.DOBI.FocusedColor = System.Drawing.Color.White;
            this.DOBI.Font = new System.Drawing.Font("Sitka Text", 8F);
            this.DOBI.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DOBI.Location = new System.Drawing.Point(522, 50);
            this.DOBI.MaxDate = new System.DateTime(2024, 4, 1, 0, 0, 0, 0);
            this.DOBI.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DOBI.Name = "DOBI";
            this.DOBI.Size = new System.Drawing.Size(171, 40);
            this.DOBI.TabIndex = 18;
            this.DOBI.Value = new System.DateTime(2024, 4, 1, 0, 0, 0, 0);
            // 
            // SignUpbtn
            // 
            this.SignUpbtn.AllowAnimations = true;
            this.SignUpbtn.AllowMouseEffects = true;
            this.SignUpbtn.AllowToggling = false;
            this.SignUpbtn.AnimationSpeed = 200;
            this.SignUpbtn.AutoGenerateColors = false;
            this.SignUpbtn.AutoRoundBorders = false;
            this.SignUpbtn.AutoSizeLeftIcon = true;
            this.SignUpbtn.AutoSizeRightIcon = true;
            this.SignUpbtn.BackColor = System.Drawing.Color.Transparent;
            this.SignUpbtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.SignUpbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignUpbtn.BackgroundImage")));
            this.SignUpbtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignUpbtn.ButtonText = "Sign Up";
            this.SignUpbtn.ButtonTextMarginLeft = 0;
            this.SignUpbtn.ColorContrastOnClick = 45;
            this.SignUpbtn.ColorContrastOnHover = 45;
            this.SignUpbtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.SignUpbtn.CustomizableEdges = borderEdges1;
            this.SignUpbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SignUpbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SignUpbtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SignUpbtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SignUpbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignUpbtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.SignUpbtn.Font = new System.Drawing.Font("Sitka Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpbtn.ForeColor = System.Drawing.SystemColors.Info;
            this.SignUpbtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignUpbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SignUpbtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SignUpbtn.IconMarginLeft = 11;
            this.SignUpbtn.IconPadding = 10;
            this.SignUpbtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SignUpbtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SignUpbtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SignUpbtn.IconSize = 25;
            this.SignUpbtn.IdleBorderColor = System.Drawing.Color.LightBlue;
            this.SignUpbtn.IdleBorderRadius = 50;
            this.SignUpbtn.IdleBorderThickness = 2;
            this.SignUpbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.SignUpbtn.IdleIconLeftImage = null;
            this.SignUpbtn.IdleIconRightImage = null;
            this.SignUpbtn.IndicateFocus = false;
            this.SignUpbtn.Location = new System.Drawing.Point(522, 234);
            this.SignUpbtn.Name = "SignUpbtn";
            this.SignUpbtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SignUpbtn.OnDisabledState.BorderRadius = 50;
            this.SignUpbtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignUpbtn.OnDisabledState.BorderThickness = 2;
            this.SignUpbtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SignUpbtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SignUpbtn.OnDisabledState.IconLeftImage = null;
            this.SignUpbtn.OnDisabledState.IconRightImage = null;
            this.SignUpbtn.onHoverState.BorderColor = System.Drawing.Color.DarkBlue;
            this.SignUpbtn.onHoverState.BorderRadius = 50;
            this.SignUpbtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignUpbtn.onHoverState.BorderThickness = 2;
            this.SignUpbtn.onHoverState.FillColor = System.Drawing.Color.Blue;
            this.SignUpbtn.onHoverState.ForeColor = System.Drawing.Color.Cyan;
            this.SignUpbtn.onHoverState.IconLeftImage = null;
            this.SignUpbtn.onHoverState.IconRightImage = null;
            this.SignUpbtn.OnIdleState.BorderColor = System.Drawing.Color.LightBlue;
            this.SignUpbtn.OnIdleState.BorderRadius = 50;
            this.SignUpbtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignUpbtn.OnIdleState.BorderThickness = 2;
            this.SignUpbtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.SignUpbtn.OnIdleState.ForeColor = System.Drawing.SystemColors.Info;
            this.SignUpbtn.OnIdleState.IconLeftImage = null;
            this.SignUpbtn.OnIdleState.IconRightImage = null;
            this.SignUpbtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SignUpbtn.OnPressedState.BorderRadius = 50;
            this.SignUpbtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignUpbtn.OnPressedState.BorderThickness = 2;
            this.SignUpbtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SignUpbtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SignUpbtn.OnPressedState.IconLeftImage = null;
            this.SignUpbtn.OnPressedState.IconRightImage = null;
            this.SignUpbtn.Size = new System.Drawing.Size(171, 57);
            this.SignUpbtn.TabIndex = 19;
            this.SignUpbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignUpbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SignUpbtn.TextMarginLeft = 0;
            this.SignUpbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.SignUpbtn.UseDefaultRadiusAndThickness = true;
            this.SignUpbtn.Click += new System.EventHandler(this.SignUpbtn_Click);
            // 
            // SignIn
            // 
            this.SignIn.AutoSize = true;
            this.SignIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignIn.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.SignIn.LinkColor = System.Drawing.Color.Silver;
            this.SignIn.Location = new System.Drawing.Point(212, 231);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(160, 63);
            this.SignIn.TabIndex = 20;
            this.SignIn.TabStop = true;
            this.SignIn.Tag = "";
            this.SignIn.Text = "Already have an account?\r\n Sign In now!";
            this.SignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Registernow_LinkClicked);
            // 
            // Exitbtn
            // 
            this.Exitbtn.AllowAnimations = true;
            this.Exitbtn.AllowMouseEffects = true;
            this.Exitbtn.AllowToggling = false;
            this.Exitbtn.AnimationSpeed = 200;
            this.Exitbtn.AutoGenerateColors = false;
            this.Exitbtn.AutoRoundBorders = false;
            this.Exitbtn.AutoSizeLeftIcon = true;
            this.Exitbtn.AutoSizeRightIcon = true;
            this.Exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.Exitbtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.Exitbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exitbtn.BackgroundImage")));
            this.Exitbtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exitbtn.ButtonText = "Exit";
            this.Exitbtn.ButtonTextMarginLeft = 0;
            this.Exitbtn.ColorContrastOnClick = 45;
            this.Exitbtn.ColorContrastOnHover = 45;
            this.Exitbtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.Exitbtn.CustomizableEdges = borderEdges2;
            this.Exitbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Exitbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Exitbtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Exitbtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Exitbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exitbtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.Exitbtn.Font = new System.Drawing.Font("Sitka Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.ForeColor = System.Drawing.SystemColors.Info;
            this.Exitbtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exitbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Exitbtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Exitbtn.IconMarginLeft = 11;
            this.Exitbtn.IconPadding = 10;
            this.Exitbtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exitbtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Exitbtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Exitbtn.IconSize = 25;
            this.Exitbtn.IdleBorderColor = System.Drawing.Color.LightBlue;
            this.Exitbtn.IdleBorderRadius = 50;
            this.Exitbtn.IdleBorderThickness = 2;
            this.Exitbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.Exitbtn.IdleIconLeftImage = null;
            this.Exitbtn.IdleIconRightImage = null;
            this.Exitbtn.IndicateFocus = false;
            this.Exitbtn.Location = new System.Drawing.Point(570, 297);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Exitbtn.OnDisabledState.BorderRadius = 50;
            this.Exitbtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exitbtn.OnDisabledState.BorderThickness = 2;
            this.Exitbtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Exitbtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Exitbtn.OnDisabledState.IconLeftImage = null;
            this.Exitbtn.OnDisabledState.IconRightImage = null;
            this.Exitbtn.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.Exitbtn.onHoverState.BorderRadius = 50;
            this.Exitbtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exitbtn.onHoverState.BorderThickness = 2;
            this.Exitbtn.onHoverState.FillColor = System.Drawing.Color.Red;
            this.Exitbtn.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.Exitbtn.onHoverState.IconLeftImage = null;
            this.Exitbtn.onHoverState.IconRightImage = null;
            this.Exitbtn.OnIdleState.BorderColor = System.Drawing.Color.LightBlue;
            this.Exitbtn.OnIdleState.BorderRadius = 50;
            this.Exitbtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exitbtn.OnIdleState.BorderThickness = 2;
            this.Exitbtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.Exitbtn.OnIdleState.ForeColor = System.Drawing.SystemColors.Info;
            this.Exitbtn.OnIdleState.IconLeftImage = null;
            this.Exitbtn.OnIdleState.IconRightImage = null;
            this.Exitbtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Exitbtn.OnPressedState.BorderRadius = 50;
            this.Exitbtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exitbtn.OnPressedState.BorderThickness = 2;
            this.Exitbtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Exitbtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Exitbtn.OnPressedState.IconLeftImage = null;
            this.Exitbtn.OnPressedState.IconRightImage = null;
            this.Exitbtn.Size = new System.Drawing.Size(123, 56);
            this.Exitbtn.TabIndex = 22;
            this.Exitbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exitbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Exitbtn.TextMarginLeft = 0;
            this.Exitbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.Exitbtn.UseDefaultRadiusAndThickness = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Back
            // 
            this.Back.AllowAnimations = true;
            this.Back.AllowMouseEffects = true;
            this.Back.AllowToggling = false;
            this.Back.AnimationSpeed = 200;
            this.Back.AutoGenerateColors = false;
            this.Back.AutoRoundBorders = false;
            this.Back.AutoSizeLeftIcon = true;
            this.Back.AutoSizeRightIcon = true;
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Back.ButtonText = "Back";
            this.Back.ButtonTextMarginLeft = 0;
            this.Back.ColorContrastOnClick = 45;
            this.Back.ColorContrastOnHover = 45;
            this.Back.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.Back.CustomizableEdges = borderEdges3;
            this.Back.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Back.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Back.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Back.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Back.Dock = System.Windows.Forms.DockStyle.Right;
            this.Back.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.Back.Font = new System.Drawing.Font("Sitka Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.Info;
            this.Back.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Back.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Back.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Back.IconMarginLeft = 11;
            this.Back.IconPadding = 10;
            this.Back.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Back.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Back.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Back.IconSize = 25;
            this.Back.IdleBorderColor = System.Drawing.Color.LightBlue;
            this.Back.IdleBorderRadius = 50;
            this.Back.IdleBorderThickness = 2;
            this.Back.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.Back.IdleIconLeftImage = null;
            this.Back.IdleIconRightImage = null;
            this.Back.IndicateFocus = false;
            this.Back.Location = new System.Drawing.Point(85, 297);
            this.Back.Name = "Back";
            this.Back.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Back.OnDisabledState.BorderRadius = 50;
            this.Back.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Back.OnDisabledState.BorderThickness = 2;
            this.Back.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Back.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Back.OnDisabledState.IconLeftImage = null;
            this.Back.OnDisabledState.IconRightImage = null;
            this.Back.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.Back.onHoverState.BorderRadius = 50;
            this.Back.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Back.onHoverState.BorderThickness = 2;
            this.Back.onHoverState.FillColor = System.Drawing.Color.Red;
            this.Back.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.Back.onHoverState.IconLeftImage = null;
            this.Back.onHoverState.IconRightImage = null;
            this.Back.OnIdleState.BorderColor = System.Drawing.Color.LightBlue;
            this.Back.OnIdleState.BorderRadius = 50;
            this.Back.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Back.OnIdleState.BorderThickness = 2;
            this.Back.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.Back.OnIdleState.ForeColor = System.Drawing.SystemColors.Info;
            this.Back.OnIdleState.IconLeftImage = null;
            this.Back.OnIdleState.IconRightImage = null;
            this.Back.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Back.OnPressedState.BorderRadius = 50;
            this.Back.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Back.OnPressedState.BorderThickness = 2;
            this.Back.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Back.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Back.OnPressedState.IconLeftImage = null;
            this.Back.OnPressedState.IconRightImage = null;
            this.Back.Size = new System.Drawing.Size(121, 56);
            this.Back.TabIndex = 23;
            this.Back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Back.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Back.TextMarginLeft = 0;
            this.Back.TextPadding = new System.Windows.Forms.Padding(0);
            this.Back.UseDefaultRadiusAndThickness = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // TopContainer
            // 
            this.TopContainer.BackColor = System.Drawing.Color.Transparent;
            this.TopContainer.Controls.Add(this.Logo);
            this.TopContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopContainer.Location = new System.Drawing.Point(0, 0);
            this.TopContainer.Name = "TopContainer";
            this.TopContainer.Size = new System.Drawing.Size(784, 150);
            this.TopContainer.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo.Font = new System.Drawing.Font("Sitka Heading", 72F, System.Drawing.FontStyle.Bold);
            this.Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(784, 150);
            this.Logo.TabIndex = 1;
            this.Logo.Text = "Sign Up";
            this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MainPanel);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.MainPanel.ResumeLayout(false);
            this.BottomContainer.ResumeLayout(false);
            this.Inputs.ResumeLayout(false);
            this.Inputs.PerformLayout();
            this.TopContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private Guna.UI2.WinForms.Guna2Panel TopContainer;
        private Guna.UI2.WinForms.Guna2Panel BottomContainer;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.TableLayoutPanel Inputs;
        private Guna.UI.WinForms.GunaLabel Contact;
        private Guna.UI.WinForms.GunaLabel Address;
        private Guna.UI.WinForms.GunaLabel Gender;
        private Guna.UI.WinForms.GunaLabel DOB;
        private Guna.UI.WinForms.GunaLabel IName;
        private Guna.UI.WinForms.GunaLabel Username;
        private Guna.UI.WinForms.GunaLabel Password;
        private Guna.UI.WinForms.GunaLabel Email;
        private Guna.UI2.WinForms.Guna2TextBox NInput;
        private Guna.UI2.WinForms.Guna2TextBox UInput;
        private Guna.UI2.WinForms.Guna2TextBox PInput;
        private Guna.UI2.WinForms.Guna2TextBox EInput;
        private Guna.UI2.WinForms.Guna2TextBox CInput;
        private Guna.UI2.WinForms.Guna2TextBox AInput;
        private Guna.UI2.WinForms.Guna2ComboBox GInput;
        private Guna.UI2.WinForms.Guna2DateTimePicker DOBI;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SignUpbtn;
        private System.Windows.Forms.LinkLabel SignIn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Exitbtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Back;
    }
}