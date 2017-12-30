namespace SshWrapper
{
  partial class ServerControlView
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
      this.lblServerName = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.lblCpuUsage = new System.Windows.Forms.Label();
      this.lblDiskAvailable = new System.Windows.Forms.Label();
      this.lblMemUsage = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.commandsPanel = new System.Windows.Forms.FlowLayoutPanel();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.btnClear = new System.Windows.Forms.Button();
      this.btnExit = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      //this.btnShowCommandManager = new System.Windows.Forms.PictureBox();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      //((System.ComponentModel.ISupportInitialize)(this.btnShowCommandManager)).BeginInit();
      this.SuspendLayout();
      // 
      // lblServerName
      // 
      this.lblServerName.AutoSize = true;
      this.lblServerName.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblServerName.Location = new System.Drawing.Point(114, 9);
      this.lblServerName.Name = "lblServerName";
      this.lblServerName.Size = new System.Drawing.Size(180, 40);
      this.lblServerName.TabIndex = 1;
      this.lblServerName.Text = "Server Name";
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(118, 76);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(84, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Ram Usage:";
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(118, 95);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(85, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Disk Available:";
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(119, 57);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(84, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "Cpu Usage:";
      // 
      // lblCpuUsage
      // 
      this.lblCpuUsage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCpuUsage.ForeColor = System.Drawing.Color.RoyalBlue;
      this.lblCpuUsage.Location = new System.Drawing.Point(209, 57);
      this.lblCpuUsage.Name = "lblCpuUsage";
      this.lblCpuUsage.Size = new System.Drawing.Size(113, 13);
      this.lblCpuUsage.TabIndex = 8;
      this.lblCpuUsage.Text = "0";
      // 
      // lblDiskAvailable
      // 
      this.lblDiskAvailable.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDiskAvailable.ForeColor = System.Drawing.Color.RoyalBlue;
      this.lblDiskAvailable.Location = new System.Drawing.Point(208, 95);
      this.lblDiskAvailable.Name = "lblDiskAvailable";
      this.lblDiskAvailable.Size = new System.Drawing.Size(114, 13);
      this.lblDiskAvailable.TabIndex = 7;
      this.lblDiskAvailable.Text = "0";
      // 
      // lblMemUsage
      // 
      this.lblMemUsage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblMemUsage.ForeColor = System.Drawing.Color.RoyalBlue;
      this.lblMemUsage.Location = new System.Drawing.Point(208, 76);
      this.lblMemUsage.Name = "lblMemUsage";
      this.lblMemUsage.Size = new System.Drawing.Size(113, 13);
      this.lblMemUsage.TabIndex = 6;
      this.lblMemUsage.Text = "0";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(12, 127);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(109, 25);
      this.label7.TabIndex = 9;
      this.label7.Text = "Commands";
      // 
      // label8
      // 
      this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label8.Location = new System.Drawing.Point(17, 156);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(650, 2);
      this.label8.TabIndex = 10;
      // 
      // commandsPanel
      // 
      this.commandsPanel.AutoScroll = true;
      this.commandsPanel.BackColor = System.Drawing.SystemColors.Control;
      this.commandsPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.commandsPanel.Location = new System.Drawing.Point(17, 175);
      this.commandsPanel.Name = "commandsPanel";
      this.commandsPanel.Size = new System.Drawing.Size(650, 145);
      this.commandsPanel.TabIndex = 11;
      // 
      // label9
      // 
      this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label9.Location = new System.Drawing.Point(17, 352);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(650, 2);
      this.label9.TabIndex = 13;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(12, 323);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(73, 25);
      this.label10.TabIndex = 12;
      this.label10.Text = "Output";
      // 
      // btnClear
      // 
      this.btnClear.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClear.Location = new System.Drawing.Point(511, 593);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(75, 23);
      this.btnClear.TabIndex = 15;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // btnExit
      // 
      this.btnExit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnExit.Location = new System.Drawing.Point(592, 593);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(75, 23);
      this.btnExit.TabIndex = 16;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::SshWrapper.Properties.Resources.server;
      this.pictureBox1.Location = new System.Drawing.Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(96, 96);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // btnShowCommandManager
      // 
      //this.btnShowCommandManager.Cursor = System.Windows.Forms.Cursors.Hand;
      //this.btnShowCommandManager.Image = global::SshWrapper.Properties.Resources.command;
      //this.btnShowCommandManager.Location = new System.Drawing.Point(643, 129);
      //this.btnShowCommandManager.Name = "btnShowCommandManager";
      //this.btnShowCommandManager.Size = new System.Drawing.Size(24, 24);
      //this.btnShowCommandManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      //this.btnShowCommandManager.TabIndex = 17;
      //this.btnShowCommandManager.TabStop = false;
      //this.btnShowCommandManager.Click += new System.EventHandler(this.btnShowCommandManager_Click);
      // 
      // richTextBox1
      // 
      this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(48)))));
      this.richTextBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.richTextBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.richTextBox1.Location = new System.Drawing.Point(17, 368);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(650, 219);
      this.richTextBox1.TabIndex = 18;
      this.richTextBox1.Text = "";
      // 
      // ServerControlView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(679, 623);
      this.Controls.Add(this.richTextBox1);
      //this.Controls.Add(this.btnShowCommandManager);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.commandsPanel);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.lblCpuUsage);
      this.Controls.Add(this.lblDiskAvailable);
      this.Controls.Add(this.lblMemUsage);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lblServerName);
      this.Controls.Add(this.pictureBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "ServerControlView";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Server Control";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      //((System.ComponentModel.ISupportInitialize)(this.btnShowCommandManager)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label lblServerName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblCpuUsage;
    private System.Windows.Forms.Label lblDiskAvailable;
    private System.Windows.Forms.Label lblMemUsage;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.FlowLayoutPanel commandsPanel;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnExit;
    //private System.Windows.Forms.PictureBox btnShowCommandManager;
    private System.Windows.Forms.RichTextBox richTextBox1;
  }
}