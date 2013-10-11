namespace A1Calculator
{
   partial class Main
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
         this.menuStrip = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.txtOutput = new System.Windows.Forms.TextBox();
         this.txtInput = new System.Windows.Forms.TextBox();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.btnConvert = new System.Windows.Forms.Button();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.txtListing = new System.Windows.Forms.TextBox();
         this.menuStrip.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStrip
         // 
         this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.helpToolStripMenuItem1});
         this.menuStrip.Location = new System.Drawing.Point(0, 0);
         this.menuStrip.Name = "menuStrip";
         this.menuStrip.Size = new System.Drawing.Size(358, 24);
         this.menuStrip.TabIndex = 0;
         this.menuStrip.Text = "menuStrip\\";
         // 
         // fileToolStripMenuItem1
         // 
         this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
         this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
         this.fileToolStripMenuItem1.Size = new System.Drawing.Size(40, 20);
         this.fileToolStripMenuItem1.Text = "&File";
         // 
         // exitToolStripMenuItem1
         // 
         this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
         this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
         this.exitToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
         this.exitToolStripMenuItem1.Text = "E&xit";
         this.exitToolStripMenuItem1.Click += new System.EventHandler(this.OnExit);
         // 
         // helpToolStripMenuItem1
         // 
         this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
         this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
         this.helpToolStripMenuItem1.Size = new System.Drawing.Size(45, 20);
         this.helpToolStripMenuItem1.Text = "&Help";
         // 
         // aboutToolStripMenuItem1
         // 
         this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
         this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
         this.aboutToolStripMenuItem1.Text = "&About";
         this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.OnMenuHelpAbout);
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
         this.fileToolStripMenuItem.Text = "&File";
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
         this.exitToolStripMenuItem.Text = "E&xit";
         this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExit);
         // 
         // helpToolStripMenuItem
         // 
         this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
         this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
         this.helpToolStripMenuItem.Text = "&Help";
         // 
         // aboutToolStripMenuItem
         // 
         this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
         this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.aboutToolStripMenuItem.Text = "&About";
         this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnMenuHelpAbout);
         // 
         // txtOutput
         // 
         this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.84615F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtOutput.Location = new System.Drawing.Point(218, 19);
         this.txtOutput.Name = "txtOutput";
         this.txtOutput.ReadOnly = true;
         this.txtOutput.Size = new System.Drawing.Size(100, 30);
         this.txtOutput.TabIndex = 3;
         // 
         // txtInput
         // 
         this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.84615F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtInput.Location = new System.Drawing.Point(15, 19);
         this.txtInput.Name = "txtInput";
         this.txtInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
         this.txtInput.Size = new System.Drawing.Size(98, 30);
         this.txtInput.TabIndex = 1;
         this.txtInput.TextChanged += new System.EventHandler(this.OnInputTextChanged);
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.btnConvert);
         this.groupBox1.Controls.Add(this.txtInput);
         this.groupBox1.Controls.Add(this.txtOutput);
         this.groupBox1.Location = new System.Drawing.Point(13, 27);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(333, 57);
         this.groupBox1.TabIndex = 3;
         this.groupBox1.TabStop = false;
         // 
         // btnConvert
         // 
         this.btnConvert.Enabled = false;
         this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.84615F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnConvert.Image = global::A1Calculator.Properties.Resources.b;
         this.btnConvert.Location = new System.Drawing.Point(119, 19);
         this.btnConvert.Name = "btnConvert";
         this.btnConvert.Size = new System.Drawing.Size(93, 30);
         this.btnConvert.TabIndex = 2;
         this.btnConvert.UseVisualStyleBackColor = true;
         this.btnConvert.Click += new System.EventHandler(this.OnConvert);
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.txtListing);
         this.groupBox2.Location = new System.Drawing.Point(13, 90);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(333, 180);
         this.groupBox2.TabIndex = 4;
         this.groupBox2.TabStop = false;
         // 
         // txtListing
         // 
         this.txtListing.Font = new System.Drawing.Font("Courier New", 8.307693F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtListing.Location = new System.Drawing.Point(15, 19);
         this.txtListing.Multiline = true;
         this.txtListing.Name = "txtListing";
         this.txtListing.ReadOnly = true;
         this.txtListing.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.txtListing.Size = new System.Drawing.Size(303, 145);
         this.txtListing.TabIndex = 4;
         // 
         // Main
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(358, 282);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.menuStrip);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MainMenuStrip = this.menuStrip;
         this.MaximizeBox = false;
         this.Name = "Main";
         this.Text = "A1 Calculator";
         this.menuStrip.ResumeLayout(false);
         this.menuStrip.PerformLayout();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
      private System.Windows.Forms.TextBox txtOutput;
      private System.Windows.Forms.TextBox txtInput;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.TextBox txtListing;
      private System.Windows.Forms.Button btnConvert;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
   }
}

