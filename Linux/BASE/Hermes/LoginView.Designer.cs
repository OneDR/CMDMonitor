namespace SshWrapper
{
  partial class LoginView
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
      this.txtUsername = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.cmbServers = new System.Windows.Forms.ComboBox();
      this.lblNewServer = new System.Windows.Forms.Label();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnConnect = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtUsername
      // 
      this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtUsername.Location = new System.Drawing.Point(76, 22);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new System.Drawing.Size(273, 22);
      this.txtUsername.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(58, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Username";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 53);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(56, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Password";
      // 
      // txtPassword
      // 
      this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPassword.Location = new System.Drawing.Point(76, 50);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(273, 22);
      this.txtPassword.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(30, 81);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(38, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Server";
      // 
      // cmbServers
      // 
      this.cmbServers.DisplayMember = "Name";
      this.cmbServers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbServers.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbServers.FormattingEnabled = true;
      this.cmbServers.Location = new System.Drawing.Point(76, 78);
      this.cmbServers.Name = "cmbServers";
      this.cmbServers.Size = new System.Drawing.Size(273, 21);
      this.cmbServers.TabIndex = 5;
      // 
      // lblNewServer
      // 
      this.lblNewServer.Cursor = System.Windows.Forms.Cursors.Hand;
      this.lblNewServer.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNewServer.ForeColor = System.Drawing.Color.RoyalBlue;
      this.lblNewServer.Location = new System.Drawing.Point(249, 106);
      this.lblNewServer.Name = "lblNewServer";
      this.lblNewServer.Size = new System.Drawing.Size(100, 15);
      this.lblNewServer.TabIndex = 6;
      this.lblNewServer.Text = "add new server";
      this.lblNewServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lblNewServer.Click += new System.EventHandler(this.lblNewServer_Click);
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Location = new System.Drawing.Point(274, 138);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 7;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnConnect
      // 
      this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnConnect.Location = new System.Drawing.Point(193, 138);
      this.btnConnect.Name = "btnConnect";
      this.btnConnect.Size = new System.Drawing.Size(75, 23);
      this.btnConnect.TabIndex = 8;
      this.btnConnect.Text = "Connect";
      this.btnConnect.UseVisualStyleBackColor = true;
      this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
      // 
      // LoginView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(361, 168);
      this.Controls.Add(this.btnConnect);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.lblNewServer);
      this.Controls.Add(this.cmbServers);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtUsername);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "LoginView";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Session";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cmbServers;
    private System.Windows.Forms.Label lblNewServer;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnConnect;
  }
}

