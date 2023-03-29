
namespace IzradaWebPreglednika
{
    partial class Form1
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.bntSearch = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.bntBack = new System.Windows.Forms.Button();
            this.bntForward = new System.Windows.Forms.Button();
            this.bntHome = new System.Windows.Forms.Button();
            this.bntRefresh = new System.Windows.Forms.Button();
            this.bntTabs = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bntBookmark = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bntClear = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(642, 362);
            this.webBrowser1.TabIndex = 0;
            // 
            // bntSearch
            // 
            this.bntSearch.Location = new System.Drawing.Point(713, 12);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(75, 23);
            this.bntSearch.TabIndex = 1;
            this.bntSearch.Text = "Traži";
            this.bntSearch.UseVisualStyleBackColor = true;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(12, 12);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(695, 20);
            this.txtBoxSearch.TabIndex = 2;
            // 
            // bntBack
            // 
            this.bntBack.Location = new System.Drawing.Point(93, 38);
            this.bntBack.Name = "bntBack";
            this.bntBack.Size = new System.Drawing.Size(75, 23);
            this.bntBack.TabIndex = 3;
            this.bntBack.Text = "Nazad";
            this.bntBack.UseVisualStyleBackColor = true;
            this.bntBack.Click += new System.EventHandler(this.bntBack_Click);
            // 
            // bntForward
            // 
            this.bntForward.Location = new System.Drawing.Point(174, 38);
            this.bntForward.Name = "bntForward";
            this.bntForward.Size = new System.Drawing.Size(75, 23);
            this.bntForward.TabIndex = 4;
            this.bntForward.Text = "Naprijed";
            this.bntForward.UseVisualStyleBackColor = true;
            this.bntForward.Click += new System.EventHandler(this.bntForward_Click);
            // 
            // bntHome
            // 
            this.bntHome.Location = new System.Drawing.Point(12, 38);
            this.bntHome.Name = "bntHome";
            this.bntHome.Size = new System.Drawing.Size(75, 23);
            this.bntHome.TabIndex = 5;
            this.bntHome.Text = "Home";
            this.bntHome.UseVisualStyleBackColor = true;
            this.bntHome.Click += new System.EventHandler(this.bntHome_Click);
            // 
            // bntRefresh
            // 
            this.bntRefresh.Location = new System.Drawing.Point(714, 38);
            this.bntRefresh.Name = "bntRefresh";
            this.bntRefresh.Size = new System.Drawing.Size(75, 23);
            this.bntRefresh.TabIndex = 6;
            this.bntRefresh.Text = "Osvježiti";
            this.bntRefresh.UseVisualStyleBackColor = true;
            this.bntRefresh.Click += new System.EventHandler(this.bntRefresh_Click);
            // 
            // bntTabs
            // 
            this.bntTabs.Location = new System.Drawing.Point(632, 38);
            this.bntTabs.Name = "bntTabs";
            this.bntTabs.Size = new System.Drawing.Size(75, 23);
            this.bntTabs.TabIndex = 7;
            this.bntTabs.Text = "Novi Tab";
            this.bntTabs.UseVisualStyleBackColor = true;
            this.bntTabs.Click += new System.EventHandler(this.bntTabs_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(650, 386);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(642, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Tab";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bntBookmark
            // 
            this.bntBookmark.Location = new System.Drawing.Point(668, 397);
            this.bntBookmark.Name = "bntBookmark";
            this.bntBookmark.Size = new System.Drawing.Size(121, 23);
            this.bntBookmark.TabIndex = 10;
            this.bntBookmark.Text = "Dodaj Bookmark";
            this.bntBookmark.UseVisualStyleBackColor = true;
            this.bntBookmark.Click += new System.EventHandler(this.bntBookmark_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(668, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 303);
            this.listBox1.TabIndex = 11;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_Click);
            // 
            // bntClear
            // 
            this.bntClear.Location = new System.Drawing.Point(669, 426);
            this.bntClear.Name = "bntClear";
            this.bntClear.Size = new System.Drawing.Size(120, 23);
            this.bntClear.TabIndex = 12;
            this.bntClear.Text = "Clear";
            this.bntClear.UseVisualStyleBackColor = true;
            this.bntClear.Click += new System.EventHandler(this.bntClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.bntClear);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bntBookmark);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bntTabs);
            this.Controls.Add(this.bntRefresh);
            this.Controls.Add(this.bntHome);
            this.Controls.Add(this.bntForward);
            this.Controls.Add(this.bntBack);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.bntSearch);
            this.Name = "Form1";
            this.Text = "Web Preglednika";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button bntSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button bntBack;
        private System.Windows.Forms.Button bntForward;
        private System.Windows.Forms.Button bntHome;
        private System.Windows.Forms.Button bntRefresh;
        private System.Windows.Forms.Button bntTabs;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bntBookmark;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bntClear;
    }
}

