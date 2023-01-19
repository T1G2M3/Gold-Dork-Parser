namespace Gold_Dork_Parser
{
	// Token: 0x02000002 RID: 2
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x0600001C RID: 28 RVA: 0x0000325C File Offset: 0x0000145C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			try
			{
				base.Dispose(disposing);
			}
			catch
			{
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000329C File Offset: 0x0000149C
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.label8 = new System.Windows.Forms.Label();
            this.Golden_Bullet = new Guna.UI.WinForms.GunaAdvenceButton();
            this.MinimizeButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ExitButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.UrlBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.Save_Public_TextBox = new Guna.UI.WinForms.GunaMediumCheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ProxyAPI_Checbox = new Guna.UI.WinForms.GunaMediumCheckBox();
            this.Proxyless_Checkbox = new Guna.UI.WinForms.GunaMediumCheckBox();
            this.Protocol_Dropdown = new Guna.UI.WinForms.GunaComboBox();
            this.Proxy = new Guna.UI.WinForms.GunaAdvenceButton();
            this.Stop = new Guna.UI.WinForms.GunaAdvenceButton();
            this.Dork = new Guna.UI.WinForms.GunaAdvenceButton();
            this.Start = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelCompleted = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelGathered = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LabelError = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelDuplicates = new System.Windows.Forms.Label();
            this.LabelPublic = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LabelPrivate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LabelDorks = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelBots = new System.Windows.Forms.Label();
            this.LabelProxy = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Logs = new System.Windows.Forms.RichTextBox();
            this.Bots_Scroll = new Guna.UI.WinForms.GunaTrackBar();
            this.Pages_Scroll = new Guna.UI.WinForms.GunaMetroTrackBar();
            this.Timeout_Scroll = new Guna.UI.WinForms.GunaMetroTrackBar();
            this.Timeout_Numeric = new System.Windows.Forms.NumericUpDown();
            this.OKButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.Proxyscrape_Button = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ProxyAPI_Textbox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Pages_Numeric = new System.Windows.Forms.NumericUpDown();
            this.Bots_Numeric = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.Progressbar = new System.Windows.Forms.ProgressBar();
            this.gunaElipsePanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Timeout_Numeric)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pages_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bots_Numeric)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 3;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.gunaElipsePanel1.Controls.Add(this.label8);
            this.gunaElipsePanel1.Controls.Add(this.Golden_Bullet);
            this.gunaElipsePanel1.Controls.Add(this.MinimizeButton);
            this.gunaElipsePanel1.Controls.Add(this.ExitButton);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(848, 27);
            this.gunaElipsePanel1.TabIndex = 0;
            this.gunaElipsePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaElipsePanel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(377, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Gold Dork Parser";
            // 
            // Golden_Bullet
            // 
            this.Golden_Bullet.Animated = true;
            this.Golden_Bullet.AnimationHoverSpeed = 0.1F;
            this.Golden_Bullet.AnimationSpeed = 0.1F;
            this.Golden_Bullet.BackColor = System.Drawing.Color.Transparent;
            this.Golden_Bullet.BaseColor = System.Drawing.Color.Transparent;
            this.Golden_Bullet.BorderColor = System.Drawing.Color.Black;
            this.Golden_Bullet.CheckedBaseColor = System.Drawing.Color.Gray;
            this.Golden_Bullet.CheckedBorderColor = System.Drawing.Color.Black;
            this.Golden_Bullet.CheckedForeColor = System.Drawing.Color.White;
            this.Golden_Bullet.CheckedImage = null;
            this.Golden_Bullet.CheckedLineColor = System.Drawing.Color.DimGray;
            this.Golden_Bullet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Golden_Bullet.FocusedColor = System.Drawing.Color.Empty;
            this.Golden_Bullet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Golden_Bullet.ForeColor = System.Drawing.Color.White;
            this.Golden_Bullet.Image = null;
            this.Golden_Bullet.ImageSize = new System.Drawing.Size(20, 20);
            this.Golden_Bullet.LineColor = System.Drawing.Color.DarkRed;
            this.Golden_Bullet.Location = new System.Drawing.Point(3, 3);
            this.Golden_Bullet.Name = "Golden_Bullet";
            this.Golden_Bullet.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.Golden_Bullet.OnHoverBorderColor = System.Drawing.Color.White;
            this.Golden_Bullet.OnHoverForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Golden_Bullet.OnHoverImage = null;
            this.Golden_Bullet.OnHoverLineColor = System.Drawing.Color.Black;
            this.Golden_Bullet.OnPressedColor = System.Drawing.Color.White;
            this.Golden_Bullet.OnPressedDepth = 100;
            this.Golden_Bullet.Radius = 6;
            this.Golden_Bullet.Size = new System.Drawing.Size(113, 21);
            this.Golden_Bullet.TabIndex = 3;
            this.Golden_Bullet.Text = "By Golden Bullet";
            this.Golden_Bullet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.Golden_Bullet, "This tool is developed by Golden Bullet\r\n\r\nTelegram - @Golden_Bullet69\r\n\r\nClick t" +
        "his button to redirect to my telegram");
            this.Golden_Bullet.Click += new System.EventHandler(this.Golden_Bullet_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Animated = true;
            this.MinimizeButton.AnimationHoverSpeed = 0.1F;
            this.MinimizeButton.AnimationSpeed = 0.1F;
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.BaseColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.BorderColor = System.Drawing.Color.Black;
            this.MinimizeButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.MinimizeButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.MinimizeButton.CheckedForeColor = System.Drawing.Color.White;
            this.MinimizeButton.CheckedImage = null;
            this.MinimizeButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.MinimizeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MinimizeButton.FocusedColor = System.Drawing.Color.Empty;
            this.MinimizeButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Image = null;
            this.MinimizeButton.ImageSize = new System.Drawing.Size(20, 20);
            this.MinimizeButton.LineColor = System.Drawing.Color.DarkRed;
            this.MinimizeButton.Location = new System.Drawing.Point(748, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.MinimizeButton.OnHoverBorderColor = System.Drawing.Color.White;
            this.MinimizeButton.OnHoverForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MinimizeButton.OnHoverImage = null;
            this.MinimizeButton.OnHoverLineColor = System.Drawing.Color.Black;
            this.MinimizeButton.OnPressedColor = System.Drawing.Color.White;
            this.MinimizeButton.OnPressedDepth = 100;
            this.MinimizeButton.Radius = 6;
            this.MinimizeButton.Size = new System.Drawing.Size(41, 21);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.MinimizeButton, "Minimize");
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Animated = true;
            this.ExitButton.AnimationHoverSpeed = 0.1F;
            this.ExitButton.AnimationSpeed = 0.1F;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BaseColor = System.Drawing.Color.Transparent;
            this.ExitButton.BorderColor = System.Drawing.Color.Black;
            this.ExitButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ExitButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.ExitButton.CheckedForeColor = System.Drawing.Color.White;
            this.ExitButton.CheckedImage = null;
            this.ExitButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExitButton.FocusedColor = System.Drawing.Color.Empty;
            this.ExitButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Image = null;
            this.ExitButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ExitButton.LineColor = System.Drawing.Color.DarkRed;
            this.ExitButton.Location = new System.Drawing.Point(795, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.OnHoverBaseColor = System.Drawing.Color.DarkRed;
            this.ExitButton.OnHoverBorderColor = System.Drawing.Color.DimGray;
            this.ExitButton.OnHoverForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.OnHoverImage = null;
            this.ExitButton.OnHoverLineColor = System.Drawing.Color.Black;
            this.ExitButton.OnPressedColor = System.Drawing.Color.Red;
            this.ExitButton.OnPressedDepth = 100;
            this.ExitButton.Radius = 6;
            this.ExitButton.Size = new System.Drawing.Size(41, 21);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "X";
            this.ExitButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.ExitButton, "Close");
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaElipsePanel1;
            // 
            // UrlBox
            // 
            this.UrlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.UrlBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UrlBox.BulletIndent = 1;
            this.UrlBox.DetectUrls = false;
            this.UrlBox.EnableAutoDragDrop = true;
            this.UrlBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UrlBox.Location = new System.Drawing.Point(179, 332);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.ReadOnly = true;
            this.UrlBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.UrlBox.Size = new System.Drawing.Size(666, 97);
            this.UrlBox.TabIndex = 2;
            this.UrlBox.Text = "";
            this.toolTip1.SetToolTip(this.UrlBox, "Good Links will be displayed here");
            this.UrlBox.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 396);
            this.panel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.Save_Public_TextBox);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.ProxyAPI_Checbox);
            this.groupBox2.Controls.Add(this.Proxyless_Checkbox);
            this.groupBox2.Controls.Add(this.Protocol_Dropdown);
            this.groupBox2.Controls.Add(this.Proxy);
            this.groupBox2.Controls.Add(this.Stop);
            this.groupBox2.Controls.Add(this.Dork);
            this.groupBox2.Controls.Add(this.Start);
            this.groupBox2.Location = new System.Drawing.Point(3, -3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 404);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 364);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(132, 18);
            this.label21.TabIndex = 13;
            this.label21.Text = "Save Public Links :";
            // 
            // Save_Public_TextBox
            // 
            this.Save_Public_TextBox.BaseColor = System.Drawing.Color.White;
            this.Save_Public_TextBox.Checked = true;
            this.Save_Public_TextBox.CheckedOffColor = System.Drawing.Color.Gray;
            this.Save_Public_TextBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Save_Public_TextBox.FillColor = System.Drawing.Color.White;
            this.Save_Public_TextBox.Location = new System.Drawing.Point(144, 364);
            this.Save_Public_TextBox.Name = "Save_Public_TextBox";
            this.Save_Public_TextBox.Size = new System.Drawing.Size(20, 20);
            this.Save_Public_TextBox.TabIndex = 12;
            this.toolTip1.SetToolTip(this.Save_Public_TextBox, "Uncheck me to not save public links");
            this.Save_Public_TextBox.CheckedChanged += new System.EventHandler(this.Save_Public_TextBox_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(9, 327);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 20);
            this.label20.TabIndex = 11;
            this.label20.Text = "Proxy API :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(9, 292);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 20);
            this.label19.TabIndex = 10;
            this.label19.Text = "Proxyless :";
            // 
            // ProxyAPI_Checbox
            // 
            this.ProxyAPI_Checbox.BaseColor = System.Drawing.Color.White;
            this.ProxyAPI_Checbox.CheckedOffColor = System.Drawing.Color.Gray;
            this.ProxyAPI_Checbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProxyAPI_Checbox.FillColor = System.Drawing.Color.White;
            this.ProxyAPI_Checbox.Location = new System.Drawing.Point(144, 327);
            this.ProxyAPI_Checbox.Name = "ProxyAPI_Checbox";
            this.ProxyAPI_Checbox.Size = new System.Drawing.Size(20, 20);
            this.ProxyAPI_Checbox.TabIndex = 9;
            this.toolTip1.SetToolTip(this.ProxyAPI_Checbox, "Check me to enable scraping prooxy from api");
            this.ProxyAPI_Checbox.CheckedChanged += new System.EventHandler(this.ProxyAPI_Checbox_CheckedChanged);
            // 
            // Proxyless_Checkbox
            // 
            this.Proxyless_Checkbox.BaseColor = System.Drawing.Color.White;
            this.Proxyless_Checkbox.CheckedOffColor = System.Drawing.Color.Gray;
            this.Proxyless_Checkbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Proxyless_Checkbox.FillColor = System.Drawing.Color.White;
            this.Proxyless_Checkbox.Location = new System.Drawing.Point(144, 292);
            this.Proxyless_Checkbox.Name = "Proxyless_Checkbox";
            this.Proxyless_Checkbox.Size = new System.Drawing.Size(20, 20);
            this.Proxyless_Checkbox.TabIndex = 8;
            this.toolTip1.SetToolTip(this.Proxyless_Checkbox, "Check me if you wanna use proxyless\r\n\r\nMuch faster parsing\r\nRecommended to use a " +
        "VPN\r\nRecommended to use less bots");
            this.Proxyless_Checkbox.CheckedChanged += new System.EventHandler(this.Proxyless_Checkbox_CheckedChanged);
            // 
            // Protocol_Dropdown
            // 
            this.Protocol_Dropdown.BackColor = System.Drawing.Color.Transparent;
            this.Protocol_Dropdown.BaseColor = System.Drawing.Color.White;
            this.Protocol_Dropdown.BorderColor = System.Drawing.Color.Silver;
            this.Protocol_Dropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Protocol_Dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Protocol_Dropdown.FocusedColor = System.Drawing.Color.Empty;
            this.Protocol_Dropdown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Protocol_Dropdown.ForeColor = System.Drawing.Color.Black;
            this.Protocol_Dropdown.FormattingEnabled = true;
            this.Protocol_Dropdown.Items.AddRange(new object[] {
            "HTTP",
            "SOCKS4",
            "SOCKS5"});
            this.Protocol_Dropdown.Location = new System.Drawing.Point(6, 247);
            this.Protocol_Dropdown.Name = "Protocol_Dropdown";
            this.Protocol_Dropdown.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Protocol_Dropdown.OnHoverItemForeColor = System.Drawing.Color.White;
            this.Protocol_Dropdown.Size = new System.Drawing.Size(161, 26);
            this.Protocol_Dropdown.TabIndex = 7;
            this.toolTip1.SetToolTip(this.Protocol_Dropdown, "Your Proxy Protocol");
            this.Protocol_Dropdown.SelectedIndexChanged += new System.EventHandler(this.Protocol_Dropdown_SelectedIndexChanged);
            // 
            // Proxy
            // 
            this.Proxy.Animated = true;
            this.Proxy.AnimationHoverSpeed = 0.1F;
            this.Proxy.AnimationSpeed = 0.1F;
            this.Proxy.BackColor = System.Drawing.Color.Transparent;
            this.Proxy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Proxy.BorderColor = System.Drawing.Color.Black;
            this.Proxy.BorderSize = 2;
            this.Proxy.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.Proxy.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.Proxy.CheckedForeColor = System.Drawing.Color.White;
            this.Proxy.CheckedImage = null;
            this.Proxy.CheckedLineColor = System.Drawing.Color.Black;
            this.Proxy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Proxy.FocusedColor = System.Drawing.Color.Empty;
            this.Proxy.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proxy.ForeColor = System.Drawing.Color.White;
            this.Proxy.Image = null;
            this.Proxy.ImageSize = new System.Drawing.Size(20, 20);
            this.Proxy.LineColor = System.Drawing.Color.DarkOrange;
            this.Proxy.Location = new System.Drawing.Point(6, 184);
            this.Proxy.Name = "Proxy";
            this.Proxy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Proxy.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Proxy.OnHoverForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Proxy.OnHoverImage = null;
            this.Proxy.OnHoverLineColor = System.Drawing.Color.Black;
            this.Proxy.OnPressedColor = System.Drawing.Color.White;
            this.Proxy.OnPressedDepth = 100;
            this.Proxy.Radius = 3;
            this.Proxy.Size = new System.Drawing.Size(158, 50);
            this.Proxy.TabIndex = 6;
            this.Proxy.Text = "Proxy";
            this.Proxy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.Proxy, "load proxy from file");
            this.Proxy.Click += new System.EventHandler(this.Proxy_Click);
            // 
            // Stop
            // 
            this.Stop.Animated = true;
            this.Stop.AnimationHoverSpeed = 0.1F;
            this.Stop.AnimationSpeed = 0.1F;
            this.Stop.BackColor = System.Drawing.Color.Transparent;
            this.Stop.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Stop.BorderColor = System.Drawing.Color.Black;
            this.Stop.BorderSize = 2;
            this.Stop.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.Stop.CheckedBorderColor = System.Drawing.Color.Black;
            this.Stop.CheckedForeColor = System.Drawing.Color.White;
            this.Stop.CheckedImage = null;
            this.Stop.CheckedLineColor = System.Drawing.Color.Black;
            this.Stop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Stop.FocusedColor = System.Drawing.Color.Empty;
            this.Stop.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.ForeColor = System.Drawing.Color.White;
            this.Stop.Image = null;
            this.Stop.ImageSize = new System.Drawing.Size(20, 20);
            this.Stop.LineColor = System.Drawing.Color.DarkOrange;
            this.Stop.Location = new System.Drawing.Point(6, 72);
            this.Stop.Name = "Stop";
            this.Stop.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Stop.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Stop.OnHoverForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Stop.OnHoverImage = null;
            this.Stop.OnHoverLineColor = System.Drawing.Color.Black;
            this.Stop.OnPressedColor = System.Drawing.Color.White;
            this.Stop.OnPressedDepth = 100;
            this.Stop.Radius = 3;
            this.Stop.Size = new System.Drawing.Size(158, 50);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "Stop";
            this.Stop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.Stop, "Gracefully stops the parser");
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Dork
            // 
            this.Dork.Animated = true;
            this.Dork.AnimationHoverSpeed = 0.1F;
            this.Dork.AnimationSpeed = 0.1F;
            this.Dork.BackColor = System.Drawing.Color.Transparent;
            this.Dork.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Dork.BorderColor = System.Drawing.Color.Black;
            this.Dork.BorderSize = 2;
            this.Dork.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.Dork.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.Dork.CheckedForeColor = System.Drawing.Color.White;
            this.Dork.CheckedImage = null;
            this.Dork.CheckedLineColor = System.Drawing.Color.Black;
            this.Dork.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Dork.FocusedColor = System.Drawing.Color.Empty;
            this.Dork.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dork.ForeColor = System.Drawing.Color.White;
            this.Dork.Image = null;
            this.Dork.ImageSize = new System.Drawing.Size(20, 20);
            this.Dork.LineColor = System.Drawing.Color.DarkOrange;
            this.Dork.Location = new System.Drawing.Point(6, 128);
            this.Dork.Name = "Dork";
            this.Dork.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Dork.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Dork.OnHoverForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dork.OnHoverImage = null;
            this.Dork.OnHoverLineColor = System.Drawing.Color.Black;
            this.Dork.OnPressedColor = System.Drawing.Color.White;
            this.Dork.OnPressedDepth = 100;
            this.Dork.Radius = 3;
            this.Dork.Size = new System.Drawing.Size(158, 50);
            this.Dork.TabIndex = 4;
            this.Dork.Text = "Dork";
            this.Dork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.Dork, "Load dorks");
            this.Dork.Click += new System.EventHandler(this.Dork_Click);
            // 
            // Start
            // 
            this.Start.Animated = true;
            this.Start.AnimationHoverSpeed = 0.1F;
            this.Start.AnimationSpeed = 0.1F;
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Start.BorderColor = System.Drawing.Color.Black;
            this.Start.BorderSize = 2;
            this.Start.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.Start.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.Start.CheckedForeColor = System.Drawing.Color.White;
            this.Start.CheckedImage = null;
            this.Start.CheckedLineColor = System.Drawing.Color.Black;
            this.Start.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Start.FocusedColor = System.Drawing.Color.Empty;
            this.Start.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Image = null;
            this.Start.ImageSize = new System.Drawing.Size(20, 20);
            this.Start.LineColor = System.Drawing.Color.DarkOrange;
            this.Start.Location = new System.Drawing.Point(6, 16);
            this.Start.Name = "Start";
            this.Start.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Start.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Start.OnHoverForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Start.OnHoverImage = null;
            this.Start.OnHoverLineColor = System.Drawing.Color.Black;
            this.Start.OnPressedColor = System.Drawing.Color.White;
            this.Start.OnPressedDepth = 100;
            this.Start.Radius = 3;
            this.Start.Size = new System.Drawing.Size(158, 50);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.Start, "Start the parser");
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(664, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 293);
            this.panel2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelCompleted);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LabelGathered);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LabelError);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LabelDuplicates);
            this.groupBox1.Controls.Add(this.LabelPublic);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.LabelPrivate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.LabelDorks);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LabelBots);
            this.groupBox1.Controls.Add(this.LabelProxy);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(3, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 296);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // LabelCompleted
            // 
            this.LabelCompleted.AutoSize = true;
            this.LabelCompleted.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCompleted.ForeColor = System.Drawing.Color.LightGray;
            this.LabelCompleted.Location = new System.Drawing.Point(100, 107);
            this.LabelCompleted.Name = "LabelCompleted";
            this.LabelCompleted.Size = new System.Drawing.Size(17, 19);
            this.LabelCompleted.TabIndex = 17;
            this.LabelCompleted.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dorks :";
            // 
            // LabelGathered
            // 
            this.LabelGathered.AutoSize = true;
            this.LabelGathered.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGathered.ForeColor = System.Drawing.Color.RosyBrown;
            this.LabelGathered.Location = new System.Drawing.Point(100, 134);
            this.LabelGathered.Name = "LabelGathered";
            this.LabelGathered.Size = new System.Drawing.Size(17, 19);
            this.LabelGathered.TabIndex = 16;
            this.LabelGathered.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RosyBrown;
            this.label6.Location = new System.Drawing.Point(6, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gathered";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.PeachPuff;
            this.label7.Location = new System.Drawing.Point(6, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Duplicates :";
            // 
            // LabelError
            // 
            this.LabelError.AutoSize = true;
            this.LabelError.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelError.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelError.Location = new System.Drawing.Point(99, 254);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(17, 19);
            this.LabelError.TabIndex = 15;
            this.LabelError.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(8, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Error :";
            // 
            // LabelDuplicates
            // 
            this.LabelDuplicates.AutoSize = true;
            this.LabelDuplicates.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDuplicates.ForeColor = System.Drawing.Color.PeachPuff;
            this.LabelDuplicates.Location = new System.Drawing.Point(100, 163);
            this.LabelDuplicates.Name = "LabelDuplicates";
            this.LabelDuplicates.Size = new System.Drawing.Size(17, 19);
            this.LabelDuplicates.TabIndex = 7;
            this.LabelDuplicates.Text = "0";
            // 
            // LabelPublic
            // 
            this.LabelPublic.AutoSize = true;
            this.LabelPublic.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPublic.ForeColor = System.Drawing.Color.Red;
            this.LabelPublic.Location = new System.Drawing.Point(100, 224);
            this.LabelPublic.Name = "LabelPublic";
            this.LabelPublic.Size = new System.Drawing.Size(17, 19);
            this.LabelPublic.TabIndex = 14;
            this.LabelPublic.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Proxy :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label9.Location = new System.Drawing.Point(7, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Bots :";
            // 
            // LabelPrivate
            // 
            this.LabelPrivate.AutoSize = true;
            this.LabelPrivate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrivate.ForeColor = System.Drawing.Color.Olive;
            this.LabelPrivate.Location = new System.Drawing.Point(100, 195);
            this.LabelPrivate.Name = "LabelPrivate";
            this.LabelPrivate.Size = new System.Drawing.Size(17, 19);
            this.LabelPrivate.TabIndex = 13;
            this.LabelPrivate.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(8, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Private :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(6, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Completed :";
            // 
            // LabelDorks
            // 
            this.LabelDorks.AutoSize = true;
            this.LabelDorks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDorks.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LabelDorks.Location = new System.Drawing.Point(100, 16);
            this.LabelDorks.Name = "LabelDorks";
            this.LabelDorks.Size = new System.Drawing.Size(17, 19);
            this.LabelDorks.TabIndex = 12;
            this.LabelDorks.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(8, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Public :";
            // 
            // LabelBots
            // 
            this.LabelBots.AutoSize = true;
            this.LabelBots.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBots.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.LabelBots.Location = new System.Drawing.Point(100, 79);
            this.LabelBots.Name = "LabelBots";
            this.LabelBots.Size = new System.Drawing.Size(33, 19);
            this.LabelBots.TabIndex = 10;
            this.LabelBots.Text = "200";
            // 
            // LabelProxy
            // 
            this.LabelProxy.AutoSize = true;
            this.LabelProxy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProxy.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LabelProxy.Location = new System.Drawing.Point(100, 47);
            this.LabelProxy.Name = "LabelProxy";
            this.LabelProxy.Size = new System.Drawing.Size(17, 19);
            this.LabelProxy.TabIndex = 11;
            this.LabelProxy.Text = "0";
            // 
            // Logs
            // 
            this.Logs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Logs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Logs.BulletIndent = 1;
            this.Logs.DetectUrls = false;
            this.Logs.EnableAutoDragDrop = true;
            this.Logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs.ForeColor = System.Drawing.Color.Gainsboro;
            this.Logs.Location = new System.Drawing.Point(179, 33);
            this.Logs.Name = "Logs";
            this.Logs.ReadOnly = true;
            this.Logs.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Logs.Size = new System.Drawing.Size(479, 161);
            this.Logs.TabIndex = 5;
            this.Logs.Text = "";
            this.toolTip1.SetToolTip(this.Logs, "Logs will be shown here");
            this.Logs.WordWrap = false;
            // 
            // Bots_Scroll
            // 
            this.Bots_Scroll.Location = new System.Drawing.Point(62, 31);
            this.Bots_Scroll.Maximum = 400;
            this.Bots_Scroll.Minimum = 1;
            this.Bots_Scroll.Name = "Bots_Scroll";
            this.Bots_Scroll.Size = new System.Drawing.Size(335, 29);
            this.Bots_Scroll.TabIndex = 6;
            this.toolTip1.SetToolTip(this.Bots_Scroll, "The amount of bots you want ot use");
            this.Bots_Scroll.TrackColor = System.Drawing.Color.DimGray;
            this.Bots_Scroll.TrackHoverColor = System.Drawing.Color.Gray;
            this.Bots_Scroll.TrackIdleColor = System.Drawing.Color.Silver;
            this.Bots_Scroll.TrackPressedColor = System.Drawing.Color.MediumTurquoise;
            this.Bots_Scroll.Value = 200;
            this.Bots_Scroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Bots_Scroll_Scroll);
            // 
            // Pages_Scroll
            // 
            this.Pages_Scroll.Location = new System.Drawing.Point(66, 0);
            this.Pages_Scroll.Minimum = 1;
            this.Pages_Scroll.Name = "Pages_Scroll";
            this.Pages_Scroll.Size = new System.Drawing.Size(331, 31);
            this.Pages_Scroll.TabIndex = 15;
            this.toolTip1.SetToolTip(this.Pages_Scroll, "The upper limit of number pages you want to parse\r\n\r\nThis depends on the quality " +
        "of your dorks");
            this.Pages_Scroll.TrackColor = System.Drawing.Color.DimGray;
            this.Pages_Scroll.TrackHoverColor = System.Drawing.Color.Gray;
            this.Pages_Scroll.TrackIdleColor = System.Drawing.Color.Silver;
            this.Pages_Scroll.TrackPressedColor = System.Drawing.Color.PaleTurquoise;
            this.Pages_Scroll.Value = 20;
            this.Pages_Scroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Pages_Scroll_Scroll);
            // 
            // Timeout_Scroll
            // 
            this.Timeout_Scroll.Location = new System.Drawing.Point(83, 11);
            this.Timeout_Scroll.Maximum = 20;
            this.Timeout_Scroll.Minimum = 1;
            this.Timeout_Scroll.Name = "Timeout_Scroll";
            this.Timeout_Scroll.Size = new System.Drawing.Size(342, 10);
            this.Timeout_Scroll.TabIndex = 17;
            this.toolTip1.SetToolTip(this.Timeout_Scroll, "The connection timeout");
            this.Timeout_Scroll.TrackColor = System.Drawing.Color.DimGray;
            this.Timeout_Scroll.TrackHoverColor = System.Drawing.Color.Gray;
            this.Timeout_Scroll.TrackIdleColor = System.Drawing.Color.Silver;
            this.Timeout_Scroll.TrackPressedColor = System.Drawing.Color.PaleTurquoise;
            this.Timeout_Scroll.Value = 10;
            this.Timeout_Scroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Timeout_Scroll_Scroll);
            // 
            // Timeout_Numeric
            // 
            this.Timeout_Numeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timeout_Numeric.Location = new System.Drawing.Point(431, 6);
            this.Timeout_Numeric.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Timeout_Numeric.Name = "Timeout_Numeric";
            this.Timeout_Numeric.Size = new System.Drawing.Size(51, 22);
            this.Timeout_Numeric.TabIndex = 17;
            this.Timeout_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.Timeout_Numeric, "The connection timeout");
            this.Timeout_Numeric.ValueChanged += new System.EventHandler(this.Timeout_Numeric_ValueChanged);
            // 
            // OKButton
            // 
            this.OKButton.Animated = true;
            this.OKButton.AnimationHoverSpeed = 0.1F;
            this.OKButton.AnimationSpeed = 0.1F;
            this.OKButton.BackColor = System.Drawing.Color.Transparent;
            this.OKButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.OKButton.BorderColor = System.Drawing.Color.Black;
            this.OKButton.BorderSize = 2;
            this.OKButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.OKButton.CheckedBorderColor = System.Drawing.Color.DimGray;
            this.OKButton.CheckedForeColor = System.Drawing.Color.White;
            this.OKButton.CheckedImage = null;
            this.OKButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.OKButton.Enabled = false;
            this.OKButton.FocusedColor = System.Drawing.Color.Empty;
            this.OKButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.ForeColor = System.Drawing.Color.White;
            this.OKButton.Image = null;
            this.OKButton.ImageSize = new System.Drawing.Size(20, 20);
            this.OKButton.LineColor = System.Drawing.Color.DarkOrange;
            this.OKButton.Location = new System.Drawing.Point(431, 34);
            this.OKButton.Name = "OKButton";
            this.OKButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.OKButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.OKButton.OnHoverForeColor = System.Drawing.SystemColors.ControlLight;
            this.OKButton.OnHoverImage = null;
            this.OKButton.OnHoverLineColor = System.Drawing.Color.Black;
            this.OKButton.OnPressedColor = System.Drawing.Color.White;
            this.OKButton.OnPressedDepth = 100;
            this.OKButton.Radius = 3;
            this.OKButton.Size = new System.Drawing.Size(48, 23);
            this.OKButton.TabIndex = 15;
            this.OKButton.Text = "OK";
            this.OKButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.OKButton, "Click me to scrape proxy");
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // Proxyscrape_Button
            // 
            this.Proxyscrape_Button.Animated = true;
            this.Proxyscrape_Button.AnimationHoverSpeed = 0.1F;
            this.Proxyscrape_Button.AnimationSpeed = 0.1F;
            this.Proxyscrape_Button.BackColor = System.Drawing.Color.Transparent;
            this.Proxyscrape_Button.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Proxyscrape_Button.BorderColor = System.Drawing.Color.Black;
            this.Proxyscrape_Button.BorderSize = 2;
            this.Proxyscrape_Button.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.Proxyscrape_Button.CheckedBorderColor = System.Drawing.Color.DimGray;
            this.Proxyscrape_Button.CheckedForeColor = System.Drawing.Color.White;
            this.Proxyscrape_Button.CheckedImage = null;
            this.Proxyscrape_Button.CheckedLineColor = System.Drawing.Color.DimGray;
            this.Proxyscrape_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Proxyscrape_Button.Enabled = false;
            this.Proxyscrape_Button.FocusedColor = System.Drawing.Color.Empty;
            this.Proxyscrape_Button.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proxyscrape_Button.ForeColor = System.Drawing.Color.White;
            this.Proxyscrape_Button.Image = null;
            this.Proxyscrape_Button.ImageSize = new System.Drawing.Size(20, 20);
            this.Proxyscrape_Button.LineColor = System.Drawing.Color.DarkOrange;
            this.Proxyscrape_Button.Location = new System.Drawing.Point(3, 37);
            this.Proxyscrape_Button.Name = "Proxyscrape_Button";
            this.Proxyscrape_Button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Proxyscrape_Button.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Proxyscrape_Button.OnHoverForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Proxyscrape_Button.OnHoverImage = null;
            this.Proxyscrape_Button.OnHoverLineColor = System.Drawing.Color.Black;
            this.Proxyscrape_Button.OnPressedColor = System.Drawing.Color.White;
            this.Proxyscrape_Button.OnPressedDepth = 100;
            this.Proxyscrape_Button.Radius = 3;
            this.Proxyscrape_Button.Size = new System.Drawing.Size(74, 20);
            this.Proxyscrape_Button.TabIndex = 14;
            this.Proxyscrape_Button.Text = "Proxyscrape";
            this.Proxyscrape_Button.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.Proxyscrape_Button, "Put the proxyscrape.com Socks4 proxy API on the API box");
            this.Proxyscrape_Button.Click += new System.EventHandler(this.Proxyscrape_Button_Click);
            // 
            // ProxyAPI_Textbox
            // 
            this.ProxyAPI_Textbox.Enabled = false;
            this.ProxyAPI_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProxyAPI_Textbox.Location = new System.Drawing.Point(83, 37);
            this.ProxyAPI_Textbox.Name = "ProxyAPI_Textbox";
            this.ProxyAPI_Textbox.Size = new System.Drawing.Size(342, 22);
            this.ProxyAPI_Textbox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.ProxyAPI_Textbox, "Put your proxy api here");
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel3.Controls.Add(this.Bots_Scroll);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.Pages_Scroll);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.Pages_Numeric);
            this.panel3.Controls.Add(this.Bots_Numeric);
            this.panel3.Location = new System.Drawing.Point(179, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(482, 60);
            this.panel3.TabIndex = 4;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(0, 5);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 24);
            this.label23.TabIndex = 16;
            this.label23.Text = "Page :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(0, 33);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 24);
            this.label22.TabIndex = 14;
            this.label22.Text = "Bots :";
            // 
            // Pages_Numeric
            // 
            this.Pages_Numeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pages_Numeric.Location = new System.Drawing.Point(403, 3);
            this.Pages_Numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Pages_Numeric.Name = "Pages_Numeric";
            this.Pages_Numeric.Size = new System.Drawing.Size(76, 26);
            this.Pages_Numeric.TabIndex = 1;
            this.Pages_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pages_Numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Pages_Numeric.ValueChanged += new System.EventHandler(this.Pages_Numeric_ValueChanged);
            // 
            // Bots_Numeric
            // 
            this.Bots_Numeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bots_Numeric.Location = new System.Drawing.Point(403, 31);
            this.Bots_Numeric.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.Bots_Numeric.Name = "Bots_Numeric";
            this.Bots_Numeric.Size = new System.Drawing.Size(76, 26);
            this.Bots_Numeric.TabIndex = 0;
            this.Bots_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bots_Numeric.ValueChanged += new System.EventHandler(this.Bots_Numeric_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel4.Controls.Add(this.Timeout_Scroll);
            this.panel4.Controls.Add(this.Timeout_Numeric);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Controls.Add(this.OKButton);
            this.panel4.Controls.Add(this.Proxyscrape_Button);
            this.panel4.Controls.Add(this.ProxyAPI_Textbox);
            this.panel4.Location = new System.Drawing.Point(179, 200);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(482, 60);
            this.panel4.TabIndex = 5;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(3, 6);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 20);
            this.label24.TabIndex = 17;
            this.label24.Text = "Timeout :";
            // 
            // Progressbar
            // 
            this.Progressbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Progressbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Progressbar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Progressbar.Location = new System.Drawing.Point(0, 435);
            this.Progressbar.Name = "Progressbar";
            this.Progressbar.Size = new System.Drawing.Size(848, 10);
            this.Progressbar.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(848, 445);
            this.Controls.Add(this.Progressbar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Logs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UrlBox);
            this.Controls.Add(this.gunaElipsePanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Form1";
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Timeout_Numeric)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pages_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bots_Numeric)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

		}

		// Token: 0x04000016 RID: 22
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000017 RID: 23
		private global::Guna.UI.WinForms.GunaElipse gunaElipse1;

		// Token: 0x04000018 RID: 24
		private global::Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;

		// Token: 0x04000019 RID: 25
		private global::Guna.UI.WinForms.GunaAdvenceButton ExitButton;

		// Token: 0x0400001A RID: 26
		private global::Guna.UI.WinForms.GunaAdvenceButton MinimizeButton;

		// Token: 0x0400001B RID: 27
		private global::Guna.UI.WinForms.GunaDragControl gunaDragControl1;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.RichTextBox UrlBox;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Label LabelCompleted;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Label LabelGathered;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Label LabelError;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Label LabelDuplicates;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Label LabelPublic;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Label LabelPrivate;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Label LabelDorks;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Label LabelBots;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.Label LabelProxy;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.RichTextBox Logs;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000037 RID: 55
		private global::Guna.UI.WinForms.GunaAdvenceButton Start;

		// Token: 0x04000038 RID: 56
		private global::Guna.UI.WinForms.GunaAdvenceButton Proxy;

		// Token: 0x04000039 RID: 57
		private global::Guna.UI.WinForms.GunaAdvenceButton Stop;

		// Token: 0x0400003A RID: 58
		private global::Guna.UI.WinForms.GunaAdvenceButton Dork;

		// Token: 0x0400003B RID: 59
		private global::Guna.UI.WinForms.GunaComboBox Protocol_Dropdown;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Label label20;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.Label label19;

		// Token: 0x0400003E RID: 62
		private global::Guna.UI.WinForms.GunaMediumCheckBox ProxyAPI_Checbox;

		// Token: 0x0400003F RID: 63
		private global::Guna.UI.WinForms.GunaMediumCheckBox Proxyless_Checkbox;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Label label21;

		// Token: 0x04000041 RID: 65
		private global::Guna.UI.WinForms.GunaMediumCheckBox Save_Public_TextBox;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.NumericUpDown Pages_Numeric;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.NumericUpDown Bots_Numeric;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Label label23;

		// Token: 0x04000045 RID: 69
		private global::Guna.UI.WinForms.GunaMetroTrackBar Pages_Scroll;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Label label22;

		// Token: 0x04000047 RID: 71
		private global::Guna.UI.WinForms.GunaAdvenceButton OKButton;

		// Token: 0x04000048 RID: 72
		private global::Guna.UI.WinForms.GunaAdvenceButton Proxyscrape_Button;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.TextBox ProxyAPI_Textbox;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Label label24;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.NumericUpDown Timeout_Numeric;

		// Token: 0x0400004C RID: 76
		private global::Guna.UI.WinForms.GunaMetroTrackBar Timeout_Scroll;

		// Token: 0x0400004D RID: 77
		private global::Guna.UI.WinForms.GunaTrackBar Bots_Scroll;

		// Token: 0x0400004E RID: 78
		private global::Guna.UI.WinForms.GunaAdvenceButton Golden_Bullet;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.ProgressBar Progressbar;
	}
}
