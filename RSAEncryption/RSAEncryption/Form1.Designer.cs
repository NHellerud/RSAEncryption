namespace RSAEncryption
{
    partial class RSAEncryption
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
            this.OverviewButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NetworkButton = new System.Windows.Forms.Button();
            this.ValuesButton = new System.Windows.Forms.Button();
            this.EavesdropperButton = new System.Windows.Forms.Button();
            this.EavesdropperPanel = new System.Windows.Forms.Panel();
            this.EavesdropperGoButton = new System.Windows.Forms.Button();
            this.EavesdropperMessageTextBox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.EavesdropperServerPrivateKeyBTextBox = new System.Windows.Forms.TextBox();
            this.EavesdropperServerPrivateKeyATextBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.EavesdropperClientPrivateKeyBTextBox = new System.Windows.Forms.TextBox();
            this.EavesdropperClientPrivateKeyATextBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.OverviewPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            RSAEncryption.OverviewServerPrivateKeyTextBox = new System.Windows.Forms.TextBox();
            RSAEncryption.OverviewServerPublicKeyTextBox = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.OverviewServerPortTextBox = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.OverviewServerIPTextBox = new System.Windows.Forms.TextBox();
            RSAEncryption.OverviewClientPrivateKeyTextBox = new System.Windows.Forms.TextBox();
            RSAEncryption.OverviewClientPublicKeyTextBox = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.OverviewClientPortTextBox = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.OverviewClientIPTextBox = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.ValuesPanel = new System.Windows.Forms.Panel();
            this.ValuesMessageTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.ValuesGenerateButton = new System.Windows.Forms.Button();
            this.MaxKeyValueTextBox = new System.Windows.Forms.TextBox();
            this.MinKeyValueTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NetworkPanel = new System.Windows.Forms.Panel();
            this.NetworkServerTextBox = new System.Windows.Forms.TextBox();
            this.NetworkClientTextBox = new System.Windows.Forms.TextBox();
            this.NetworkPortTextBox = new System.Windows.Forms.TextBox();
            this.ServerCheckBox = new System.Windows.Forms.CheckBox();
            this.ClientCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.EavesdropperPanel.SuspendLayout();
            this.OverviewPanel.SuspendLayout();
            this.ValuesPanel.SuspendLayout();
            this.NetworkPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OverviewButton
            // 
            this.OverviewButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OverviewButton.Location = new System.Drawing.Point(3, 12);
            this.OverviewButton.Name = "OverviewButton";
            this.OverviewButton.Size = new System.Drawing.Size(144, 75);
            this.OverviewButton.TabIndex = 0;
            this.OverviewButton.Text = "Overview";
            this.OverviewButton.UseVisualStyleBackColor = true;
            this.OverviewButton.Click += new System.EventHandler(this.OverviewButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.NetworkButton);
            this.panel1.Controls.Add(this.ValuesButton);
            this.panel1.Controls.Add(this.EavesdropperButton);
            this.panel1.Controls.Add(this.OverviewButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 550);
            this.panel1.TabIndex = 1;
            // 
            // NetworkButton
            // 
            this.NetworkButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NetworkButton.Location = new System.Drawing.Point(3, 255);
            this.NetworkButton.Name = "NetworkButton";
            this.NetworkButton.Size = new System.Drawing.Size(144, 75);
            this.NetworkButton.TabIndex = 2;
            this.NetworkButton.Text = "Network";
            this.NetworkButton.UseVisualStyleBackColor = true;
            this.NetworkButton.Click += new System.EventHandler(this.NetworkButton_Click);
            // 
            // ValuesButton
            // 
            this.ValuesButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ValuesButton.Location = new System.Drawing.Point(3, 174);
            this.ValuesButton.Name = "ValuesButton";
            this.ValuesButton.Size = new System.Drawing.Size(144, 75);
            this.ValuesButton.TabIndex = 2;
            this.ValuesButton.Text = "Values";
            this.ValuesButton.UseVisualStyleBackColor = true;
            this.ValuesButton.Click += new System.EventHandler(this.ValuesButton_Click);
            // 
            // EavesdropperButton
            // 
            this.EavesdropperButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EavesdropperButton.Location = new System.Drawing.Point(3, 93);
            this.EavesdropperButton.Name = "EavesdropperButton";
            this.EavesdropperButton.Size = new System.Drawing.Size(144, 75);
            this.EavesdropperButton.TabIndex = 2;
            this.EavesdropperButton.Text = "Eavesdropper";
            this.EavesdropperButton.UseVisualStyleBackColor = true;
            this.EavesdropperButton.Click += new System.EventHandler(this.EavesdropperButton_Click);
            // 
            // EavesdropperPanel
            // 
            this.EavesdropperPanel.Controls.Add(this.EavesdropperGoButton);
            this.EavesdropperPanel.Controls.Add(this.EavesdropperMessageTextBox);
            this.EavesdropperPanel.Controls.Add(this.label25);
            this.EavesdropperPanel.Controls.Add(this.EavesdropperServerPrivateKeyBTextBox);
            this.EavesdropperPanel.Controls.Add(this.EavesdropperServerPrivateKeyATextBox);
            this.EavesdropperPanel.Controls.Add(this.label23);
            this.EavesdropperPanel.Controls.Add(this.label24);
            this.EavesdropperPanel.Controls.Add(this.EavesdropperClientPrivateKeyBTextBox);
            this.EavesdropperPanel.Controls.Add(this.EavesdropperClientPrivateKeyATextBox);
            this.EavesdropperPanel.Controls.Add(this.label22);
            this.EavesdropperPanel.Controls.Add(this.label21);
            this.EavesdropperPanel.Controls.Add(this.label20);
            this.EavesdropperPanel.Controls.Add(this.label19);
            this.EavesdropperPanel.Controls.Add(this.label18);
            this.EavesdropperPanel.Location = new System.Drawing.Point(158, 0);
            this.EavesdropperPanel.Name = "EavesdropperPanel";
            this.EavesdropperPanel.Size = new System.Drawing.Size(825, 550);
            this.EavesdropperPanel.TabIndex = 33;
            // 
            // EavesdropperGoButton
            // 
            this.EavesdropperGoButton.Location = new System.Drawing.Point(301, 416);
            this.EavesdropperGoButton.Name = "EavesdropperGoButton";
            this.EavesdropperGoButton.Size = new System.Drawing.Size(135, 61);
            this.EavesdropperGoButton.TabIndex = 13;
            this.EavesdropperGoButton.Text = "Go";
            this.EavesdropperGoButton.UseVisualStyleBackColor = true;
            // 
            // EavesdropperMessageTextBox
            // 
            this.EavesdropperMessageTextBox.Location = new System.Drawing.Point(320, 339);
            this.EavesdropperMessageTextBox.Name = "EavesdropperMessageTextBox";
            this.EavesdropperMessageTextBox.ReadOnly = true;
            this.EavesdropperMessageTextBox.Size = new System.Drawing.Size(100, 22);
            this.EavesdropperMessageTextBox.TabIndex = 12;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(325, 305);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(93, 25);
            this.label25.TabIndex = 11;
            this.label25.Text = "Message";
            // 
            // EavesdropperServerPrivateKeyBTextBox
            // 
            this.EavesdropperServerPrivateKeyBTextBox.Location = new System.Drawing.Point(511, 200);
            this.EavesdropperServerPrivateKeyBTextBox.Name = "EavesdropperServerPrivateKeyBTextBox";
            this.EavesdropperServerPrivateKeyBTextBox.ReadOnly = true;
            this.EavesdropperServerPrivateKeyBTextBox.Size = new System.Drawing.Size(100, 22);
            this.EavesdropperServerPrivateKeyBTextBox.TabIndex = 10;
            // 
            // EavesdropperServerPrivateKeyATextBox
            // 
            this.EavesdropperServerPrivateKeyATextBox.Location = new System.Drawing.Point(511, 162);
            this.EavesdropperServerPrivateKeyATextBox.Name = "EavesdropperServerPrivateKeyATextBox";
            this.EavesdropperServerPrivateKeyATextBox.ReadOnly = true;
            this.EavesdropperServerPrivateKeyATextBox.Size = new System.Drawing.Size(100, 22);
            this.EavesdropperServerPrivateKeyATextBox.TabIndex = 9;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(398, 202);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(93, 17);
            this.label23.TabIndex = 8;
            this.label23.Text = "Private Key B";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(398, 165);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(93, 17);
            this.label24.TabIndex = 7;
            this.label24.Text = "Private Key A";
            // 
            // EavesdropperClientPrivateKeyBTextBox
            // 
            this.EavesdropperClientPrivateKeyBTextBox.Location = new System.Drawing.Point(216, 200);
            this.EavesdropperClientPrivateKeyBTextBox.Name = "EavesdropperClientPrivateKeyBTextBox";
            this.EavesdropperClientPrivateKeyBTextBox.ReadOnly = true;
            this.EavesdropperClientPrivateKeyBTextBox.Size = new System.Drawing.Size(100, 22);
            this.EavesdropperClientPrivateKeyBTextBox.TabIndex = 6;
            // 
            // EavesdropperClientPrivateKeyATextBox
            // 
            this.EavesdropperClientPrivateKeyATextBox.Location = new System.Drawing.Point(216, 162);
            this.EavesdropperClientPrivateKeyATextBox.Name = "EavesdropperClientPrivateKeyATextBox";
            this.EavesdropperClientPrivateKeyATextBox.ReadOnly = true;
            this.EavesdropperClientPrivateKeyATextBox.Size = new System.Drawing.Size(100, 22);
            this.EavesdropperClientPrivateKeyATextBox.TabIndex = 5;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(103, 202);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 17);
            this.label22.TabIndex = 4;
            this.label22.Text = "Private Key B";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(103, 165);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 17);
            this.label21.TabIndex = 3;
            this.label21.Text = "Private Key A";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(472, 121);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 25);
            this.label20.TabIndex = 2;
            this.label20.Text = "Server";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(211, 121);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 25);
            this.label19.TabIndex = 1;
            this.label19.Text = "Client";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(285, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(192, 32);
            this.label18.TabIndex = 0;
            this.label18.Text = "Eavesdropper";
            // 
            // OverviewPanel
            // 
            this.OverviewPanel.Controls.Add(this.button2);
            this.OverviewPanel.Controls.Add(this.button3);
            this.OverviewPanel.Controls.Add(this.textBox6);
            this.OverviewPanel.Controls.Add(this.label34);
            this.OverviewPanel.Controls.Add(this.textBox7);
            this.OverviewPanel.Controls.Add(this.textBox8);
            this.OverviewPanel.Controls.Add(this.label35);
            this.OverviewPanel.Controls.Add(this.label36);
            this.OverviewPanel.Controls.Add(this.label37);
            this.OverviewPanel.Controls.Add(this.label38);
            this.OverviewPanel.Controls.Add(RSAEncryption.OverviewServerPrivateKeyTextBox);
            this.OverviewPanel.Controls.Add(RSAEncryption.OverviewServerPublicKeyTextBox);
            this.OverviewPanel.Controls.Add(this.label40);
            this.OverviewPanel.Controls.Add(this.label41);
            this.OverviewPanel.Controls.Add(this.OverviewServerPortTextBox);
            this.OverviewPanel.Controls.Add(this.label42);
            this.OverviewPanel.Controls.Add(this.label43);
            this.OverviewPanel.Controls.Add(this.OverviewServerIPTextBox);
            this.OverviewPanel.Controls.Add(RSAEncryption.OverviewClientPrivateKeyTextBox);
            this.OverviewPanel.Controls.Add(RSAEncryption.OverviewClientPublicKeyTextBox);
            this.OverviewPanel.Controls.Add(this.label45);
            this.OverviewPanel.Controls.Add(this.label46);
            this.OverviewPanel.Controls.Add(this.OverviewClientPortTextBox);
            this.OverviewPanel.Controls.Add(this.label47);
            this.OverviewPanel.Controls.Add(this.label48);
            this.OverviewPanel.Controls.Add(this.label49);
            this.OverviewPanel.Controls.Add(this.OverviewClientIPTextBox);
            this.OverviewPanel.Controls.Add(this.label50);
            this.OverviewPanel.Location = new System.Drawing.Point(156, 0);
            this.OverviewPanel.Name = "OverviewPanel";
            this.OverviewPanel.Size = new System.Drawing.Size(825, 550);
            this.OverviewPanel.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(723, 518);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(604, 518);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Prev";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(257, 403);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 29;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(186, 406);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(65, 17);
            this.label34.TabIndex = 28;
            this.label34.Text = "Message";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(401, 361);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(101, 22);
            this.textBox7.TabIndex = 27;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(256, 361);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(101, 22);
            this.textBox8.TabIndex = 26;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(366, 364);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(25, 17);
            this.label35.TabIndex = 25;
            this.label35.Text = "To";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(186, 364);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(40, 17);
            this.label36.TabIndex = 24;
            this.label36.Text = "From";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(315, 326);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(93, 25);
            this.label37.TabIndex = 23;
            this.label37.Text = "Message";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(510, 70);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(70, 25);
            this.label38.TabIndex = 22;
            this.label38.Text = "Server";
            // 
            // OverviewServerPrivateKeyTextBox
            // 
            RSAEncryption.OverviewServerPrivateKeyTextBox.Location = new System.Drawing.Point(634, 224);
            RSAEncryption.OverviewServerPrivateKeyTextBox.Name = "OverviewServerPrivateKeyTextBox";
            RSAEncryption.OverviewServerPrivateKeyTextBox.ReadOnly = true;
            RSAEncryption.OverviewServerPrivateKeyTextBox.Size = new System.Drawing.Size(100, 22);
            RSAEncryption.OverviewServerPrivateKeyTextBox.TabIndex = 20;
            // 
            // OverviewServerPublicKeyTextBox
            // 
            RSAEncryption.OverviewServerPublicKeyTextBox.Location = new System.Drawing.Point(634, 185);
            RSAEncryption.OverviewServerPublicKeyTextBox.Name = "OverviewServerPublicKeyTextBox";
            RSAEncryption.OverviewServerPublicKeyTextBox.ReadOnly = true;
            RSAEncryption.OverviewServerPublicKeyTextBox.Size = new System.Drawing.Size(100, 22);
            RSAEncryption.OverviewServerPublicKeyTextBox.TabIndex = 19;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(512, 224);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(78, 17);
            this.label40.TabIndex = 17;
            this.label40.Text = "Private key";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(512, 185);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(72, 17);
            this.label41.TabIndex = 16;
            this.label41.Text = "Public key";
            // 
            // OverviewServerPortTextBox
            // 
            this.OverviewServerPortTextBox.Location = new System.Drawing.Point(634, 146);
            this.OverviewServerPortTextBox.Name = "OverviewServerPortTextBox";
            this.OverviewServerPortTextBox.ReadOnly = true;
            this.OverviewServerPortTextBox.Size = new System.Drawing.Size(100, 22);
            this.OverviewServerPortTextBox.TabIndex = 15;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(512, 146);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(34, 17);
            this.label42.TabIndex = 14;
            this.label42.Text = "Port";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(512, 107);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(76, 17);
            this.label43.TabIndex = 13;
            this.label43.Text = "IP Address";
            // 
            // OverviewServerIPTextBox
            // 
            this.OverviewServerIPTextBox.Location = new System.Drawing.Point(634, 107);
            this.OverviewServerIPTextBox.Name = "OverviewServerIPTextBox";
            this.OverviewServerIPTextBox.ReadOnly = true;
            this.OverviewServerIPTextBox.Size = new System.Drawing.Size(100, 22);
            this.OverviewServerIPTextBox.TabIndex = 12;
            // 
            // OverviewClientPrivateKeyTextBox
            // 
            RSAEncryption.OverviewClientPrivateKeyTextBox.Location = new System.Drawing.Point(189, 224);
            RSAEncryption.OverviewClientPrivateKeyTextBox.Name = "OverviewClientPrivateKeyTextBox";
            RSAEncryption.OverviewClientPrivateKeyTextBox.ReadOnly = true;
            RSAEncryption.OverviewClientPrivateKeyTextBox.Size = new System.Drawing.Size(100, 22);
            RSAEncryption.OverviewClientPrivateKeyTextBox.TabIndex = 10;
            // 
            // OverviewClientPublicKeyTextBox
            // 
            RSAEncryption.OverviewClientPublicKeyTextBox.Location = new System.Drawing.Point(189, 185);
            RSAEncryption.OverviewClientPublicKeyTextBox.Name = "OverviewClientPublicKeyTextBox";
            RSAEncryption.OverviewClientPublicKeyTextBox.ReadOnly = true;
            RSAEncryption.OverviewClientPublicKeyTextBox.Size = new System.Drawing.Size(100, 22);
            RSAEncryption.OverviewClientPublicKeyTextBox.TabIndex = 9;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(67, 224);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(78, 17);
            this.label45.TabIndex = 7;
            this.label45.Text = "Private key";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(67, 185);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(72, 17);
            this.label46.TabIndex = 6;
            this.label46.Text = "Public key";
            // 
            // OverviewClientPortTextBox
            // 
            this.OverviewClientPortTextBox.Location = new System.Drawing.Point(189, 146);
            this.OverviewClientPortTextBox.Name = "OverviewClientPortTextBox";
            this.OverviewClientPortTextBox.ReadOnly = true;
            this.OverviewClientPortTextBox.Size = new System.Drawing.Size(100, 22);
            this.OverviewClientPortTextBox.TabIndex = 5;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(67, 146);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(34, 17);
            this.label47.TabIndex = 4;
            this.label47.Text = "Port";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(67, 107);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(76, 17);
            this.label48.TabIndex = 3;
            this.label48.Text = "IP Address";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(65, 70);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(62, 25);
            this.label49.TabIndex = 2;
            this.label49.Text = "Client";
            // 
            // OverviewClientIPTextBox
            // 
            this.OverviewClientIPTextBox.Location = new System.Drawing.Point(189, 107);
            this.OverviewClientIPTextBox.Name = "OverviewClientIPTextBox";
            this.OverviewClientIPTextBox.ReadOnly = true;
            this.OverviewClientIPTextBox.Size = new System.Drawing.Size(100, 22);
            this.OverviewClientIPTextBox.TabIndex = 1;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(308, 23);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(155, 38);
            this.label50.TabIndex = 0;
            this.label50.Text = "Overview";
            // 
            // ValuesPanel
            // 
            this.ValuesPanel.Controls.Add(this.ValuesMessageTextBox);
            this.ValuesPanel.Controls.Add(this.label5);
            this.ValuesPanel.Controls.Add(this.StartButton);
            this.ValuesPanel.Controls.Add(this.ValuesGenerateButton);
            this.ValuesPanel.Controls.Add(this.MaxKeyValueTextBox);
            this.ValuesPanel.Controls.Add(this.MinKeyValueTextBox);
            this.ValuesPanel.Controls.Add(this.label4);
            this.ValuesPanel.Controls.Add(this.label3);
            this.ValuesPanel.Controls.Add(this.label2);
            this.ValuesPanel.Controls.Add(this.label1);
            this.ValuesPanel.Location = new System.Drawing.Point(156, 0);
            this.ValuesPanel.Name = "ValuesPanel";
            this.ValuesPanel.Size = new System.Drawing.Size(825, 550);
            this.ValuesPanel.TabIndex = 34;
            // 
            // ValuesMessageTextBox
            // 
            this.ValuesMessageTextBox.Location = new System.Drawing.Point(401, 140);
            this.ValuesMessageTextBox.Name = "ValuesMessageTextBox";
            this.ValuesMessageTextBox.Size = new System.Drawing.Size(321, 22);
            this.ValuesMessageTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(472, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Message";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(477, 245);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(150, 59);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // ValuesGenerateButton
            // 
            this.ValuesGenerateButton.Location = new System.Drawing.Point(101, 245);
            this.ValuesGenerateButton.Name = "ValuesGenerateButton";
            this.ValuesGenerateButton.Size = new System.Drawing.Size(150, 59);
            this.ValuesGenerateButton.TabIndex = 6;
            this.ValuesGenerateButton.Text = "Generate";
            this.ValuesGenerateButton.UseVisualStyleBackColor = true;
            this.ValuesGenerateButton.Click += new System.EventHandler(this.ValuesGenerateButton_Click);
            // 
            // MaxKeyValueTextBox
            // 
            this.MaxKeyValueTextBox.Location = new System.Drawing.Point(216, 179);
            this.MaxKeyValueTextBox.Name = "MaxKeyValueTextBox";
            this.MaxKeyValueTextBox.Size = new System.Drawing.Size(100, 22);
            this.MaxKeyValueTextBox.TabIndex = 5;
            // 
            // MinKeyValueTextBox
            // 
            this.MinKeyValueTextBox.Location = new System.Drawing.Point(216, 145);
            this.MinKeyValueTextBox.Name = "MinKeyValueTextBox";
            this.MinKeyValueTextBox.Size = new System.Drawing.Size(100, 22);
            this.MinKeyValueTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "MaxValue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "MinValue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "KeyGenerator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Values";
            // 
            // NetworkPanel
            // 
            this.NetworkPanel.Controls.Add(this.NetworkServerTextBox);
            this.NetworkPanel.Controls.Add(this.NetworkClientTextBox);
            this.NetworkPanel.Controls.Add(this.NetworkPortTextBox);
            this.NetworkPanel.Controls.Add(this.ServerCheckBox);
            this.NetworkPanel.Controls.Add(this.ClientCheckBox);
            this.NetworkPanel.Controls.Add(this.label7);
            this.NetworkPanel.Controls.Add(this.label6);
            this.NetworkPanel.Location = new System.Drawing.Point(156, 0);
            this.NetworkPanel.Name = "NetworkPanel";
            this.NetworkPanel.Size = new System.Drawing.Size(825, 550);
            this.NetworkPanel.TabIndex = 34;
            // 
            // NetworkServerTextBox
            // 
            this.NetworkServerTextBox.Location = new System.Drawing.Point(385, 161);
            this.NetworkServerTextBox.Name = "NetworkServerTextBox";
            this.NetworkServerTextBox.Size = new System.Drawing.Size(243, 22);
            this.NetworkServerTextBox.TabIndex = 6;
            // 
            // NetworkClientTextBox
            // 
            this.NetworkClientTextBox.Location = new System.Drawing.Point(385, 127);
            this.NetworkClientTextBox.Name = "NetworkClientTextBox";
            this.NetworkClientTextBox.Size = new System.Drawing.Size(243, 22);
            this.NetworkClientTextBox.TabIndex = 5;
            // 
            // NetworkPortTextBox
            // 
            this.NetworkPortTextBox.Location = new System.Drawing.Point(385, 93);
            this.NetworkPortTextBox.Name = "NetworkPortTextBox";
            this.NetworkPortTextBox.Size = new System.Drawing.Size(243, 22);
            this.NetworkPortTextBox.TabIndex = 4;
            // 
            // ServerCheckBox
            // 
            this.ServerCheckBox.AutoSize = true;
            this.ServerCheckBox.Location = new System.Drawing.Point(135, 161);
            this.ServerCheckBox.Name = "ServerCheckBox";
            this.ServerCheckBox.Size = new System.Drawing.Size(144, 21);
            this.ServerCheckBox.TabIndex = 3;
            this.ServerCheckBox.Text = "Server IP Address";
            this.ServerCheckBox.UseVisualStyleBackColor = true;
            // 
            // ClientCheckBox
            // 
            this.ClientCheckBox.AutoSize = true;
            this.ClientCheckBox.Location = new System.Drawing.Point(135, 125);
            this.ClientCheckBox.Name = "ClientCheckBox";
            this.ClientCheckBox.Size = new System.Drawing.Size(137, 21);
            this.ClientCheckBox.TabIndex = 2;
            this.ClientCheckBox.Text = "Client IP Address";
            this.ClientCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Port Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Network";
            // 
            // RSAEncryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.ValuesPanel);
            this.Controls.Add(this.NetworkPanel);
            this.Controls.Add(this.OverviewPanel);
            this.Controls.Add(this.EavesdropperPanel);
            this.Controls.Add(this.panel1);
            this.Name = "RSAEncryption";
            this.Text = "RSAEncryption";
            this.Load += new System.EventHandler(this.RSAEncryption_Load);
            this.panel1.ResumeLayout(false);
            this.EavesdropperPanel.ResumeLayout(false);
            this.EavesdropperPanel.PerformLayout();
            this.OverviewPanel.ResumeLayout(false);
            this.OverviewPanel.PerformLayout();
            this.ValuesPanel.ResumeLayout(false);
            this.ValuesPanel.PerformLayout();
            this.NetworkPanel.ResumeLayout(false);
            this.NetworkPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OverviewButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NetworkButton;
        private System.Windows.Forms.Button ValuesButton;
        private System.Windows.Forms.Button EavesdropperButton;
        private System.Windows.Forms.Panel EavesdropperPanel;
        private System.Windows.Forms.Button EavesdropperGoButton;
        private System.Windows.Forms.TextBox EavesdropperMessageTextBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox EavesdropperServerPrivateKeyBTextBox;
        private System.Windows.Forms.TextBox EavesdropperServerPrivateKeyATextBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox EavesdropperClientPrivateKeyBTextBox;
        private System.Windows.Forms.TextBox EavesdropperClientPrivateKeyATextBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel OverviewPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private static System.Windows.Forms.TextBox OverviewServerPrivateKeyTextBox;
        private static System.Windows.Forms.TextBox OverviewServerPublicKeyTextBox;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox OverviewServerPortTextBox;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox OverviewServerIPTextBox;
        private static System.Windows.Forms.TextBox OverviewClientPrivateKeyTextBox;
        private static System.Windows.Forms.TextBox OverviewClientPublicKeyTextBox;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox OverviewClientPortTextBox;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox OverviewClientIPTextBox;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Panel ValuesPanel;
        private System.Windows.Forms.TextBox ValuesMessageTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ValuesGenerateButton;
        private System.Windows.Forms.TextBox MaxKeyValueTextBox;
        private System.Windows.Forms.TextBox MinKeyValueTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel NetworkPanel;
        private System.Windows.Forms.TextBox NetworkServerTextBox;
        private System.Windows.Forms.TextBox NetworkClientTextBox;
        private System.Windows.Forms.TextBox NetworkPortTextBox;
        private System.Windows.Forms.CheckBox ServerCheckBox;
        private System.Windows.Forms.CheckBox ClientCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

