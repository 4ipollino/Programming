using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Reflection;
// TODO: Add the using directives to enable localization in this application.

namespace UsabilityDemo
{
	/// <summary>
	/// Summary description for UsabilityDemo.
	/// </summary>
	public class UsabilityDemo : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox OutputTextBox;
		private System.Windows.Forms.Button DateButton;
		private System.Windows.Forms.Button CurrencyButton;
		private System.Windows.Forms.Button StringButton;
		private System.Windows.Forms.Button AppExitButton;
		private System.Windows.Forms.MainMenu UsabilityDemoMenu;
		private System.Windows.Forms.MenuItem HelpMenu;
		private System.Windows.Forms.MenuItem HelpMenuItem;
		private System.Windows.Forms.HelpProvider UsabilityDemoHelpProvider;
		private System.Windows.Forms.ToolTip UsabilityDemoToolTip;
		private System.ComponentModel.IContainer components;

		public string ChosenCulture;
		private bool EnableButtons = false;
		private System.Windows.Forms.Button CultureButton;

		// TODO: Declare a private resource manager variable.

		public UsabilityDemo()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// Set the culture to the default and create a Resource Manager.
			ChosenCulture = CultureInfo.InstalledUICulture.ToString();

			// TODO: Create an object instance of the resource manager.

		}

		public UsabilityDemo (string clientCulture)
		{
			InitializeComponent();

			ChosenCulture = clientCulture;
			EnableButtons = true;

			// TODO: Create an object instance of the resource manager.
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(UsabilityDemo));
			this.OutputTextBox = new System.Windows.Forms.TextBox();
			this.DateButton = new System.Windows.Forms.Button();
			this.CurrencyButton = new System.Windows.Forms.Button();
			this.StringButton = new System.Windows.Forms.Button();
			this.AppExitButton = new System.Windows.Forms.Button();
			this.UsabilityDemoMenu = new System.Windows.Forms.MainMenu();
			this.HelpMenu = new System.Windows.Forms.MenuItem();
			this.HelpMenuItem = new System.Windows.Forms.MenuItem();
			this.UsabilityDemoHelpProvider = new System.Windows.Forms.HelpProvider();
			this.CultureButton = new System.Windows.Forms.Button();
			this.UsabilityDemoToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// OutputTextBox
			// 
			this.OutputTextBox.AccessibleDescription = ((string)(resources.GetObject("OutputTextBox.AccessibleDescription")));
			this.OutputTextBox.AccessibleName = resources.GetString("OutputTextBox.AccessibleName");
			this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("OutputTextBox.Anchor")));
			this.OutputTextBox.AutoSize = ((bool)(resources.GetObject("OutputTextBox.AutoSize")));
			this.OutputTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OutputTextBox.BackgroundImage")));
			this.OutputTextBox.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("OutputTextBox.Dock")));
			this.OutputTextBox.Enabled = ((bool)(resources.GetObject("OutputTextBox.Enabled")));
			this.OutputTextBox.Font = ((System.Drawing.Font)(resources.GetObject("OutputTextBox.Font")));
			this.UsabilityDemoHelpProvider.SetHelpKeyword(this.OutputTextBox, resources.GetString("OutputTextBox.HelpKeyword"));
			this.UsabilityDemoHelpProvider.SetHelpNavigator(this.OutputTextBox, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("OutputTextBox.HelpNavigator"))));
			this.UsabilityDemoHelpProvider.SetHelpString(this.OutputTextBox, resources.GetString("OutputTextBox.HelpString"));
			this.OutputTextBox.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("OutputTextBox.ImeMode")));
			this.OutputTextBox.Location = ((System.Drawing.Point)(resources.GetObject("OutputTextBox.Location")));
			this.OutputTextBox.MaxLength = ((int)(resources.GetObject("OutputTextBox.MaxLength")));
			this.OutputTextBox.Multiline = ((bool)(resources.GetObject("OutputTextBox.Multiline")));
			this.OutputTextBox.Name = "OutputTextBox";
			this.OutputTextBox.PasswordChar = ((char)(resources.GetObject("OutputTextBox.PasswordChar")));
			this.OutputTextBox.ReadOnly = true;
			this.OutputTextBox.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("OutputTextBox.RightToLeft")));
			this.OutputTextBox.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("OutputTextBox.ScrollBars")));
			this.UsabilityDemoHelpProvider.SetShowHelp(this.OutputTextBox, ((bool)(resources.GetObject("OutputTextBox.ShowHelp"))));
			this.OutputTextBox.Size = ((System.Drawing.Size)(resources.GetObject("OutputTextBox.Size")));
			this.OutputTextBox.TabIndex = ((int)(resources.GetObject("OutputTextBox.TabIndex")));
			this.OutputTextBox.TabStop = false;
			this.OutputTextBox.Text = resources.GetString("OutputTextBox.Text");
			this.OutputTextBox.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("OutputTextBox.TextAlign")));
			this.UsabilityDemoToolTip.SetToolTip(this.OutputTextBox, resources.GetString("OutputTextBox.ToolTip"));
			this.OutputTextBox.Visible = ((bool)(resources.GetObject("OutputTextBox.Visible")));
			this.OutputTextBox.WordWrap = ((bool)(resources.GetObject("OutputTextBox.WordWrap")));
			// 
			// DateButton
			// 
			this.DateButton.AccessibleDescription = ((string)(resources.GetObject("DateButton.AccessibleDescription")));
			this.DateButton.AccessibleName = resources.GetString("DateButton.AccessibleName");
			this.DateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("DateButton.Anchor")));
			this.DateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DateButton.BackgroundImage")));
			this.DateButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("DateButton.Dock")));
			this.DateButton.Enabled = ((bool)(resources.GetObject("DateButton.Enabled")));
			this.DateButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("DateButton.FlatStyle")));
			this.DateButton.Font = ((System.Drawing.Font)(resources.GetObject("DateButton.Font")));
			this.UsabilityDemoHelpProvider.SetHelpKeyword(this.DateButton, resources.GetString("DateButton.HelpKeyword"));
			this.UsabilityDemoHelpProvider.SetHelpNavigator(this.DateButton, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("DateButton.HelpNavigator"))));
			this.UsabilityDemoHelpProvider.SetHelpString(this.DateButton, resources.GetString("DateButton.HelpString"));
			this.DateButton.Image = ((System.Drawing.Image)(resources.GetObject("DateButton.Image")));
			this.DateButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("DateButton.ImageAlign")));
			this.DateButton.ImageIndex = ((int)(resources.GetObject("DateButton.ImageIndex")));
			this.DateButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("DateButton.ImeMode")));
			this.DateButton.Location = ((System.Drawing.Point)(resources.GetObject("DateButton.Location")));
			this.DateButton.Name = "DateButton";
			this.DateButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("DateButton.RightToLeft")));
			this.UsabilityDemoHelpProvider.SetShowHelp(this.DateButton, ((bool)(resources.GetObject("DateButton.ShowHelp"))));
			this.DateButton.Size = ((System.Drawing.Size)(resources.GetObject("DateButton.Size")));
			this.DateButton.TabIndex = ((int)(resources.GetObject("DateButton.TabIndex")));
			this.DateButton.Text = resources.GetString("DateButton.Text");
			this.DateButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("DateButton.TextAlign")));
			this.UsabilityDemoToolTip.SetToolTip(this.DateButton, resources.GetString("DateButton.ToolTip"));
			this.DateButton.Visible = ((bool)(resources.GetObject("DateButton.Visible")));
			this.DateButton.Click += new System.EventHandler(this.DateButton_Click);
			// 
			// CurrencyButton
			// 
			this.CurrencyButton.AccessibleDescription = ((string)(resources.GetObject("CurrencyButton.AccessibleDescription")));
			this.CurrencyButton.AccessibleName = resources.GetString("CurrencyButton.AccessibleName");
			this.CurrencyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("CurrencyButton.Anchor")));
			this.CurrencyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CurrencyButton.BackgroundImage")));
			this.CurrencyButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("CurrencyButton.Dock")));
			this.CurrencyButton.Enabled = ((bool)(resources.GetObject("CurrencyButton.Enabled")));
			this.CurrencyButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("CurrencyButton.FlatStyle")));
			this.CurrencyButton.Font = ((System.Drawing.Font)(resources.GetObject("CurrencyButton.Font")));
			this.UsabilityDemoHelpProvider.SetHelpKeyword(this.CurrencyButton, resources.GetString("CurrencyButton.HelpKeyword"));
			this.UsabilityDemoHelpProvider.SetHelpNavigator(this.CurrencyButton, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("CurrencyButton.HelpNavigator"))));
			this.UsabilityDemoHelpProvider.SetHelpString(this.CurrencyButton, resources.GetString("CurrencyButton.HelpString"));
			this.CurrencyButton.Image = ((System.Drawing.Image)(resources.GetObject("CurrencyButton.Image")));
			this.CurrencyButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("CurrencyButton.ImageAlign")));
			this.CurrencyButton.ImageIndex = ((int)(resources.GetObject("CurrencyButton.ImageIndex")));
			this.CurrencyButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("CurrencyButton.ImeMode")));
			this.CurrencyButton.Location = ((System.Drawing.Point)(resources.GetObject("CurrencyButton.Location")));
			this.CurrencyButton.Name = "CurrencyButton";
			this.CurrencyButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("CurrencyButton.RightToLeft")));
			this.UsabilityDemoHelpProvider.SetShowHelp(this.CurrencyButton, ((bool)(resources.GetObject("CurrencyButton.ShowHelp"))));
			this.CurrencyButton.Size = ((System.Drawing.Size)(resources.GetObject("CurrencyButton.Size")));
			this.CurrencyButton.TabIndex = ((int)(resources.GetObject("CurrencyButton.TabIndex")));
			this.CurrencyButton.Text = resources.GetString("CurrencyButton.Text");
			this.CurrencyButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("CurrencyButton.TextAlign")));
			this.UsabilityDemoToolTip.SetToolTip(this.CurrencyButton, resources.GetString("CurrencyButton.ToolTip"));
			this.CurrencyButton.Visible = ((bool)(resources.GetObject("CurrencyButton.Visible")));
			this.CurrencyButton.Click += new System.EventHandler(this.CurrencyButton_Click);
			// 
			// StringButton
			// 
			this.StringButton.AccessibleDescription = ((string)(resources.GetObject("StringButton.AccessibleDescription")));
			this.StringButton.AccessibleName = resources.GetString("StringButton.AccessibleName");
			this.StringButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("StringButton.Anchor")));
			this.StringButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StringButton.BackgroundImage")));
			this.StringButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("StringButton.Dock")));
			this.StringButton.Enabled = ((bool)(resources.GetObject("StringButton.Enabled")));
			this.StringButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("StringButton.FlatStyle")));
			this.StringButton.Font = ((System.Drawing.Font)(resources.GetObject("StringButton.Font")));
			this.UsabilityDemoHelpProvider.SetHelpKeyword(this.StringButton, resources.GetString("StringButton.HelpKeyword"));
			this.UsabilityDemoHelpProvider.SetHelpNavigator(this.StringButton, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("StringButton.HelpNavigator"))));
			this.UsabilityDemoHelpProvider.SetHelpString(this.StringButton, resources.GetString("StringButton.HelpString"));
			this.StringButton.Image = ((System.Drawing.Image)(resources.GetObject("StringButton.Image")));
			this.StringButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("StringButton.ImageAlign")));
			this.StringButton.ImageIndex = ((int)(resources.GetObject("StringButton.ImageIndex")));
			this.StringButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("StringButton.ImeMode")));
			this.StringButton.Location = ((System.Drawing.Point)(resources.GetObject("StringButton.Location")));
			this.StringButton.Name = "StringButton";
			this.StringButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("StringButton.RightToLeft")));
			this.UsabilityDemoHelpProvider.SetShowHelp(this.StringButton, ((bool)(resources.GetObject("StringButton.ShowHelp"))));
			this.StringButton.Size = ((System.Drawing.Size)(resources.GetObject("StringButton.Size")));
			this.StringButton.TabIndex = ((int)(resources.GetObject("StringButton.TabIndex")));
			this.StringButton.Text = resources.GetString("StringButton.Text");
			this.StringButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("StringButton.TextAlign")));
			this.UsabilityDemoToolTip.SetToolTip(this.StringButton, resources.GetString("StringButton.ToolTip"));
			this.StringButton.Visible = ((bool)(resources.GetObject("StringButton.Visible")));
			this.StringButton.Click += new System.EventHandler(this.StringButton_Click);
			// 
			// AppExitButton
			// 
			this.AppExitButton.AccessibleDescription = ((string)(resources.GetObject("AppExitButton.AccessibleDescription")));
			this.AppExitButton.AccessibleName = resources.GetString("AppExitButton.AccessibleName");
			this.AppExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("AppExitButton.Anchor")));
			this.AppExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AppExitButton.BackgroundImage")));
			this.AppExitButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("AppExitButton.Dock")));
			this.AppExitButton.Enabled = ((bool)(resources.GetObject("AppExitButton.Enabled")));
			this.AppExitButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("AppExitButton.FlatStyle")));
			this.AppExitButton.Font = ((System.Drawing.Font)(resources.GetObject("AppExitButton.Font")));
			this.UsabilityDemoHelpProvider.SetHelpKeyword(this.AppExitButton, resources.GetString("AppExitButton.HelpKeyword"));
			this.UsabilityDemoHelpProvider.SetHelpNavigator(this.AppExitButton, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("AppExitButton.HelpNavigator"))));
			this.UsabilityDemoHelpProvider.SetHelpString(this.AppExitButton, resources.GetString("AppExitButton.HelpString"));
			this.AppExitButton.Image = ((System.Drawing.Image)(resources.GetObject("AppExitButton.Image")));
			this.AppExitButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("AppExitButton.ImageAlign")));
			this.AppExitButton.ImageIndex = ((int)(resources.GetObject("AppExitButton.ImageIndex")));
			this.AppExitButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("AppExitButton.ImeMode")));
			this.AppExitButton.Location = ((System.Drawing.Point)(resources.GetObject("AppExitButton.Location")));
			this.AppExitButton.Name = "AppExitButton";
			this.AppExitButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("AppExitButton.RightToLeft")));
			this.UsabilityDemoHelpProvider.SetShowHelp(this.AppExitButton, ((bool)(resources.GetObject("AppExitButton.ShowHelp"))));
			this.AppExitButton.Size = ((System.Drawing.Size)(resources.GetObject("AppExitButton.Size")));
			this.AppExitButton.TabIndex = ((int)(resources.GetObject("AppExitButton.TabIndex")));
			this.AppExitButton.Text = resources.GetString("AppExitButton.Text");
			this.AppExitButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("AppExitButton.TextAlign")));
			this.UsabilityDemoToolTip.SetToolTip(this.AppExitButton, resources.GetString("AppExitButton.ToolTip"));
			this.AppExitButton.Visible = ((bool)(resources.GetObject("AppExitButton.Visible")));
			this.AppExitButton.Click += new System.EventHandler(this.AppExitButton_Click);
			// 
			// UsabilityDemoMenu
			// 
			this.UsabilityDemoMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							  this.HelpMenu});
			this.UsabilityDemoMenu.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("UsabilityDemoMenu.RightToLeft")));
			// 
			// HelpMenu
			// 
			this.HelpMenu.Enabled = ((bool)(resources.GetObject("HelpMenu.Enabled")));
			this.HelpMenu.Index = 0;
			this.HelpMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.HelpMenuItem});
			this.HelpMenu.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("HelpMenu.Shortcut")));
			this.HelpMenu.ShowShortcut = ((bool)(resources.GetObject("HelpMenu.ShowShortcut")));
			this.HelpMenu.Text = resources.GetString("HelpMenu.Text");
			this.HelpMenu.Visible = ((bool)(resources.GetObject("HelpMenu.Visible")));
			// 
			// HelpMenuItem
			// 
			this.HelpMenuItem.Enabled = ((bool)(resources.GetObject("HelpMenuItem.Enabled")));
			this.HelpMenuItem.Index = 0;
			this.HelpMenuItem.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("HelpMenuItem.Shortcut")));
			this.HelpMenuItem.ShowShortcut = ((bool)(resources.GetObject("HelpMenuItem.ShowShortcut")));
			this.HelpMenuItem.Text = resources.GetString("HelpMenuItem.Text");
			this.HelpMenuItem.Visible = ((bool)(resources.GetObject("HelpMenuItem.Visible")));
			this.HelpMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
			// 
			// UsabilityDemoHelpProvider
			// 
			this.UsabilityDemoHelpProvider.HelpNamespace = resources.GetString("UsabilityDemoHelpProvider.HelpNamespace");
			// 
			// CultureButton
			// 
			this.CultureButton.AccessibleDescription = ((string)(resources.GetObject("CultureButton.AccessibleDescription")));
			this.CultureButton.AccessibleName = resources.GetString("CultureButton.AccessibleName");
			this.CultureButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("CultureButton.Anchor")));
			this.CultureButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CultureButton.BackgroundImage")));
			this.CultureButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("CultureButton.Dock")));
			this.CultureButton.Enabled = ((bool)(resources.GetObject("CultureButton.Enabled")));
			this.CultureButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("CultureButton.FlatStyle")));
			this.CultureButton.Font = ((System.Drawing.Font)(resources.GetObject("CultureButton.Font")));
			this.UsabilityDemoHelpProvider.SetHelpKeyword(this.CultureButton, resources.GetString("CultureButton.HelpKeyword"));
			this.UsabilityDemoHelpProvider.SetHelpNavigator(this.CultureButton, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("CultureButton.HelpNavigator"))));
			this.UsabilityDemoHelpProvider.SetHelpString(this.CultureButton, resources.GetString("CultureButton.HelpString"));
			this.CultureButton.Image = ((System.Drawing.Image)(resources.GetObject("CultureButton.Image")));
			this.CultureButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("CultureButton.ImageAlign")));
			this.CultureButton.ImageIndex = ((int)(resources.GetObject("CultureButton.ImageIndex")));
			this.CultureButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("CultureButton.ImeMode")));
			this.CultureButton.Location = ((System.Drawing.Point)(resources.GetObject("CultureButton.Location")));
			this.CultureButton.Name = "CultureButton";
			this.CultureButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("CultureButton.RightToLeft")));
			this.UsabilityDemoHelpProvider.SetShowHelp(this.CultureButton, ((bool)(resources.GetObject("CultureButton.ShowHelp"))));
			this.CultureButton.Size = ((System.Drawing.Size)(resources.GetObject("CultureButton.Size")));
			this.CultureButton.TabIndex = ((int)(resources.GetObject("CultureButton.TabIndex")));
			this.CultureButton.Text = resources.GetString("CultureButton.Text");
			this.CultureButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("CultureButton.TextAlign")));
			this.UsabilityDemoToolTip.SetToolTip(this.CultureButton, resources.GetString("CultureButton.ToolTip"));
			this.CultureButton.Visible = ((bool)(resources.GetObject("CultureButton.Visible")));
			this.CultureButton.Click += new System.EventHandler(this.CultureButton_Click);
			// 
			// UsabilityDemo
			// 
			this.AccessibleDescription = ((string)(resources.GetObject("$this.AccessibleDescription")));
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("$this.Anchor")));
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.CultureButton,
																		  this.AppExitButton,
																		  this.StringButton,
																		  this.CurrencyButton,
																		  this.DateButton,
																		  this.OutputTextBox});
			this.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("$this.Dock")));
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.HelpButton = true;
			this.UsabilityDemoHelpProvider.SetHelpKeyword(this, resources.GetString("$this.HelpKeyword"));
			this.UsabilityDemoHelpProvider.SetHelpNavigator(this, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("$this.HelpNavigator"))));
			this.UsabilityDemoHelpProvider.SetHelpString(this, resources.GetString("$this.HelpString"));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximizeBox = false;
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.Menu = this.UsabilityDemoMenu;
			this.MinimizeBox = false;
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "UsabilityDemo";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.UsabilityDemoHelpProvider.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.UsabilityDemoToolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
			this.Visible = ((bool)(resources.GetObject("$this.Visible")));
			this.Load += new System.EventHandler(this.UsabilityDemo_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new UsabilityDemo());
		}

		private void UsabilityDemo_Load(object sender, System.EventArgs e)
		{
			if (!EnableButtons)
			{
				DateButton.Enabled = false;
				CurrencyButton.Enabled = false;
				StringButton.Enabled = false;
			}
		}

		private void CultureButton_Click(object sender, System.EventArgs e)
		{
			CultureChooser GetCultureForm = new CultureChooser();
			GetCultureForm.ShowDialog();
			ChosenCulture = GetCultureForm.UsersChoice;
			GetCultureForm.Close();

			// TODO: Set the current thread’s Culture and UICulture property values to the user requested in CultureChooser.

			UsabilityDemo DemoForm = new UsabilityDemo(ChosenCulture);

			DateButton.Enabled = true;
			CurrencyButton.Enabled = true;
			StringButton.Enabled = true;

			this.Hide();
			DemoForm.Show();
		}

		private void DateButton_Click(object sender, System.EventArgs e)
		{
			CultureInfo DesiredCulture = new CultureInfo(ChosenCulture);
			DateTime curDate = DateTime.Now;
			OutputTextBox.Text = curDate.ToString ("g", DesiredCulture);
		}

		private void CurrencyButton_Click(object sender, System.EventArgs e)
		{
			CultureInfo DesiredCulture = new CultureInfo(ChosenCulture);
			const double dollarAmount = 1982.47;
			OutputTextBox.Text = dollarAmount.ToString ("c", DesiredCulture);
		}

		private void StringButton_Click(object sender, System.EventArgs e)
		{
			// TODO: Use the resource manager to get the text string and display it in the text box.
		}

		private void AppExitButton_Click(object sender, System.EventArgs e)
		{
			this.Close();
			Application.Exit();
		}

		private void HelpMenuItem_Click(object sender, System.EventArgs e)
		{
			Help.ShowHelp (this, UsabilityDemoHelpProvider.HelpNamespace);
		}
	}
}
