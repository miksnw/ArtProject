namespace WindowsFormsApplication1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sma1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sma2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sma3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sma4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ratioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sMAToolStripMenuItem,
            this.ratioToolStripMenuItem,
            this.lNToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(120, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // sMAToolStripMenuItem
            // 
            this.sMAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sma1ToolStripMenuItem,
            this.sma2ToolStripMenuItem,
            this.sma3ToolStripMenuItem,
            this.sma4ToolStripMenuItem});
            this.sMAToolStripMenuItem.Name = "sMAToolStripMenuItem";
            this.sMAToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.sMAToolStripMenuItem.Text = "SMA";
            // 
            // sma1ToolStripMenuItem
            // 
            this.sma1ToolStripMenuItem.Name = "sma1ToolStripMenuItem";
            this.sma1ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.sma1ToolStripMenuItem.Text = "Sma1";
            // 
            // sma2ToolStripMenuItem
            // 
            this.sma2ToolStripMenuItem.Name = "sma2ToolStripMenuItem";
            this.sma2ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.sma2ToolStripMenuItem.Text = "Sma2";
            // 
            // sma3ToolStripMenuItem
            // 
            this.sma3ToolStripMenuItem.Name = "sma3ToolStripMenuItem";
            this.sma3ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.sma3ToolStripMenuItem.Text = "Sma3";
            // 
            // sma4ToolStripMenuItem
            // 
            this.sma4ToolStripMenuItem.Name = "sma4ToolStripMenuItem";
            this.sma4ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.sma4ToolStripMenuItem.Text = "Sma4";
            // 
            // ratioToolStripMenuItem
            // 
            this.ratioToolStripMenuItem.Name = "ratioToolStripMenuItem";
            this.ratioToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ratioToolStripMenuItem.Text = "Ratio";
            // 
            // lNToolStripMenuItem
            // 
            this.lNToolStripMenuItem.Name = "lNToolStripMenuItem";
            this.lNToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
            this.lNToolStripMenuItem.Text = "LN";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 20);
            this.textBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(225, 94);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(263, 146);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 317);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sma1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sma2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sma3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sma4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ratioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

