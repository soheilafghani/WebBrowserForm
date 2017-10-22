using System.Windows.Forms;

namespace WebBrowserForm
{
  partial class WebBrowserForm
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
      this.webBrowserControl = new System.Windows.Forms.WebBrowser();
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.httppeacekeeperfuturemarkcomrunactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.httpswwwwhatismybrowsercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.httpknockoutjscomspecrunnerhtmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.httpshtml5testcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.httpcss3testcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.httpwwweasysurfcctestjhtmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip = new System.Windows.Forms.ToolStrip();
      this.backButton = new System.Windows.Forms.ToolStripButton();
      this.forwardButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripTextBox = new WebBrowserForm.ToolStripSpringTextBox();
      this.goButton = new System.Windows.Forms.ToolStripButton();
      this.stopButton = new System.Windows.Forms.ToolStripButton();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.menuStrip.SuspendLayout();
      this.toolStrip.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // webBrowserControl
      // 
      this.webBrowserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.webBrowserControl.Location = new System.Drawing.Point(0, 47);
      this.webBrowserControl.MinimumSize = new System.Drawing.Size(20, 20);
      this.webBrowserControl.Name = "webBrowserControl";
      this.webBrowserControl.Size = new System.Drawing.Size(1044, 565);
      this.webBrowserControl.TabIndex = 0;
      this.webBrowserControl.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowserControl_Navigated);
      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(1044, 24);
      this.menuStrip.TabIndex = 3;
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.pageSetupToolStripMenuItem,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.propertiesToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // saveAsToolStripMenuItem
      // 
      this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
      this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.saveAsToolStripMenuItem.Text = "Save &As...";
      this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
      // 
      // pageSetupToolStripMenuItem
      // 
      this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
      this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.pageSetupToolStripMenuItem.Text = "Page Set&up...";
      this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.pageSetupToolStripMenuItem_Click);
      // 
      // printToolStripMenuItem
      // 
      this.printToolStripMenuItem.Name = "printToolStripMenuItem";
      this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
      this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.printToolStripMenuItem.Text = "&Print...";
      this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
      // 
      // printPreviewToolStripMenuItem
      // 
      this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
      this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.printPreviewToolStripMenuItem.Text = "Print Pre&view...";
      this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
      // 
      // propertiesToolStripMenuItem
      // 
      this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
      this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.propertiesToolStripMenuItem.Text = "Properties";
      this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // toolStripMenuItem
      // 
      this.toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.httppeacekeeperfuturemarkcomrunactionToolStripMenuItem,
            this.httpswwwwhatismybrowsercomToolStripMenuItem,
            this.httpknockoutjscomspecrunnerhtmlToolStripMenuItem,
            this.httpshtml5testcomToolStripMenuItem,
            this.httpcss3testcomToolStripMenuItem,
            this.httpwwweasysurfcctestjhtmToolStripMenuItem});
      this.toolStripMenuItem.Name = "toolStripMenuItem";
      this.toolStripMenuItem.Size = new System.Drawing.Size(66, 20);
      this.toolStripMenuItem.Text = "Websites";
      // 
      // httppeacekeeperfuturemarkcomrunactionToolStripMenuItem
      // 
      this.httppeacekeeperfuturemarkcomrunactionToolStripMenuItem.Name = "httppeacekeeperfuturemarkcomrunactionToolStripMenuItem";
      this.httppeacekeeperfuturemarkcomrunactionToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
      this.httppeacekeeperfuturemarkcomrunactionToolStripMenuItem.Text = "http://peacekeeper.futuremark.com/run.action";
      // 
      // httpswwwwhatismybrowsercomToolStripMenuItem
      // 
      this.httpswwwwhatismybrowsercomToolStripMenuItem.Name = "httpswwwwhatismybrowsercomToolStripMenuItem";
      this.httpswwwwhatismybrowsercomToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
      this.httpswwwwhatismybrowsercomToolStripMenuItem.Text = "https://www.whatismybrowser.com/";
      // 
      // httpknockoutjscomspecrunnerhtmlToolStripMenuItem
      // 
      this.httpknockoutjscomspecrunnerhtmlToolStripMenuItem.Name = "httpknockoutjscomspecrunnerhtmlToolStripMenuItem";
      this.httpknockoutjscomspecrunnerhtmlToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
      this.httpknockoutjscomspecrunnerhtmlToolStripMenuItem.Text = "http://knockoutjs.com/spec/runner.html";
      // 
      // httpshtml5testcomToolStripMenuItem
      // 
      this.httpshtml5testcomToolStripMenuItem.Name = "httpshtml5testcomToolStripMenuItem";
      this.httpshtml5testcomToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
      this.httpshtml5testcomToolStripMenuItem.Text = "https://html5test.com/";
      // 
      // httpcss3testcomToolStripMenuItem
      // 
      this.httpcss3testcomToolStripMenuItem.Name = "httpcss3testcomToolStripMenuItem";
      this.httpcss3testcomToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
      this.httpcss3testcomToolStripMenuItem.Text = "http://css3test.com/";
      // 
      // httpwwweasysurfcctestjhtmToolStripMenuItem
      // 
      this.httpwwweasysurfcctestjhtmToolStripMenuItem.Name = "httpwwweasysurfcctestjhtmToolStripMenuItem";
      this.httpwwweasysurfcctestjhtmToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
      this.httpwwweasysurfcctestjhtmToolStripMenuItem.Text = "http://www.easysurf.cc/testj.htm";
      // 
      // toolStrip
      // 
      this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backButton,
            this.forwardButton,
            this.toolStripTextBox,
            this.goButton});
      this.toolStrip.Location = new System.Drawing.Point(0, 24);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
      this.toolStrip.Size = new System.Drawing.Size(1044, 25);
      this.toolStrip.TabIndex = 2;
      // 
      // backButton
      // 
      this.backButton.Enabled = false;
      this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.backButton.Name = "backButton";
      this.backButton.Size = new System.Drawing.Size(23, 22);
      this.backButton.Text = "<--";
      this.backButton.Click += new System.EventHandler(this.backButton_Click);
      // 
      // forwardButton
      // 
      this.forwardButton.Enabled = false;
      this.forwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.forwardButton.Name = "forwardButton";
      this.forwardButton.Size = new System.Drawing.Size(23, 22);
      this.forwardButton.Text = "-->";
      this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
      // 
      // toolStripTextBox
      // 
      this.toolStripTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.toolStripTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
      this.toolStripTextBox.Name = "toolStripTextBox";
      this.toolStripTextBox.Size = new System.Drawing.Size(928, 25);
      this.toolStripTextBox.DoubleClick += new System.EventHandler(this.toolStripTextBox_DoubleClick);
      // 
      // goButton
      // 
      this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.goButton.Name = "goButton";
      this.goButton.Size = new System.Drawing.Size(27, 22);
      this.goButton.Text = "Go";
      this.goButton.Click += new System.EventHandler(this.goButton_Click);
      // 
      // stopButton
      // 
      this.stopButton.Name = "stopButton";
      this.stopButton.Size = new System.Drawing.Size(23, 23);
      // 
      // statusStrip
      // 
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
      this.statusStrip.Location = new System.Drawing.Point(0, 590);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new System.Drawing.Size(1044, 22);
      this.statusStrip.TabIndex = 4;
      // 
      // toolStripStatusLabel
      // 
      this.toolStripStatusLabel.Name = "toolStripStatusLabel";
      this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
      // 
      // WebBrowserForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1044, 612);
      this.Controls.Add(this.toolStrip);
      this.Controls.Add(this.statusStrip);
      this.Controls.Add(this.menuStrip);
      this.Controls.Add(this.webBrowserControl);
      this.Name = "WebBrowserForm";
      this.Text = "WebBrowserForm";
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion


    private System.Windows.Forms.WebBrowser webBrowserControl;

    private MenuStrip menuStrip;
    private ToolStripMenuItem fileToolStripMenuItem,
        saveAsToolStripMenuItem, printToolStripMenuItem,
        printPreviewToolStripMenuItem, exitToolStripMenuItem,
        pageSetupToolStripMenuItem, propertiesToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator1, toolStripSeparator2;

    private ToolStrip toolStrip;
    private ToolStripButton backButton, forwardButton, stopButton;

    private StatusStrip statusStrip;
    private ToolStripStatusLabel toolStripStatusLabel;
    private ToolStripButton goButton;
    private ToolStripSpringTextBox toolStripTextBox;
    private ToolStripMenuItem toolStripMenuItem;
    private ToolStripMenuItem httppeacekeeperfuturemarkcomrunactionToolStripMenuItem;
    private ToolStripMenuItem httpswwwwhatismybrowsercomToolStripMenuItem;
    private ToolStripMenuItem httpknockoutjscomspecrunnerhtmlToolStripMenuItem;
    private ToolStripMenuItem httpshtml5testcomToolStripMenuItem;
    private ToolStripMenuItem httpcss3testcomToolStripMenuItem;
    private ToolStripMenuItem httpwwweasysurfcctestjhtmToolStripMenuItem;
  }
}
