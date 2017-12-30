namespace SshWrapper
{
  partial class ServerManagerView
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnEdit = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnRemove = new System.Windows.Forms.Button();
      this.dgServers = new System.Windows.Forms.DataGridView();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.txtServerName = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtPort = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtAddress = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnApply = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgServers)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
      this.groupBox1.Controls.Add(this.btnEdit);
      this.groupBox1.Controls.Add(this.btnAdd);
      this.groupBox1.Controls.Add(this.btnRemove);
      this.groupBox1.Controls.Add(this.dgServers);
      this.groupBox1.Controls.Add(this.txtServerName);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.txtPort);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.txtAddress);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
      this.groupBox1.Location = new System.Drawing.Point(10, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(393, 281);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Server Info";
      // 
      // btnEdit
      // 
      this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEdit.ForeColor = System.Drawing.Color.Black;
      this.btnEdit.Location = new System.Drawing.Point(222, 249);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(75, 21);
      this.btnEdit.TabIndex = 10;
      this.btnEdit.Text = "Edit";
      this.btnEdit.UseVisualStyleBackColor = true;
      this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAdd.ForeColor = System.Drawing.Color.Black;
      this.btnAdd.Location = new System.Drawing.Point(141, 249);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(75, 21);
      this.btnAdd.TabIndex = 8;
      this.btnAdd.Text = "Add";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnRemove
      // 
      this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnRemove.ForeColor = System.Drawing.Color.Black;
      this.btnRemove.Location = new System.Drawing.Point(303, 249);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(75, 21);
      this.btnRemove.TabIndex = 9;
      this.btnRemove.Text = "Remove";
      this.btnRemove.UseVisualStyleBackColor = true;
      this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // dgServers
      // 
      this.dgServers.AllowUserToAddRows = false;
      this.dgServers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgServers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
      this.dgServers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.dgServers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      this.dgServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgServers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.colAddress,
            this.colPort});
      this.dgServers.Location = new System.Drawing.Point(9, 93);
      this.dgServers.MultiSelect = false;
      this.dgServers.Name = "dgServers";
      this.dgServers.ReadOnly = true;
      this.dgServers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      this.dgServers.RowHeadersVisible = false;
      this.dgServers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgServers.Size = new System.Drawing.Size(369, 150);
      this.dgServers.TabIndex = 7;
      this.dgServers.TabStop = false;
      this.dgServers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgServers_CellContentDoubleClick);
      // 
      // Column1
      // 
      this.Column1.DataPropertyName = "Name";
      this.Column1.HeaderText = "Name";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      // 
      // colAddress
      // 
      this.colAddress.DataPropertyName = "Address";
      this.colAddress.HeaderText = "Address";
      this.colAddress.Name = "colAddress";
      this.colAddress.ReadOnly = true;
      // 
      // colPort
      // 
      this.colPort.DataPropertyName = "Port";
      this.colPort.HeaderText = "Port";
      this.colPort.Name = "colPort";
      this.colPort.ReadOnly = true;
      // 
      // txtServerName
      // 
      this.txtServerName.Location = new System.Drawing.Point(61, 33);
      this.txtServerName.Name = "txtServerName";
      this.txtServerName.Size = new System.Drawing.Size(317, 22);
      this.txtServerName.TabIndex = 0;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.Black;
      this.label3.Location = new System.Drawing.Point(250, 64);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(28, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Port";
      // 
      // txtPort
      // 
      this.txtPort.Location = new System.Drawing.Point(284, 61);
      this.txtPort.Name = "txtPort";
      this.txtPort.Size = new System.Drawing.Size(94, 22);
      this.txtPort.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.Black;
      this.label2.Location = new System.Drawing.Point(6, 64);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(48, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Address";
      // 
      // txtAddress
      // 
      this.txtAddress.Location = new System.Drawing.Point(61, 61);
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.Size = new System.Drawing.Size(170, 22);
      this.txtAddress.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Black;
      this.label1.Location = new System.Drawing.Point(18, 36);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(36, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Name";
      // 
      // btnCancel
      // 
      this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancel.Location = new System.Drawing.Point(328, 309);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 21);
      this.btnCancel.TabIndex = 8;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnApply
      // 
      this.btnApply.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnApply.Location = new System.Drawing.Point(247, 309);
      this.btnApply.Name = "btnApply";
      this.btnApply.Size = new System.Drawing.Size(75, 21);
      this.btnApply.TabIndex = 9;
      this.btnApply.Text = "Apply";
      this.btnApply.UseVisualStyleBackColor = true;
      this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
      // 
      // ServerManagerView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(415, 337);
      this.Controls.Add(this.btnApply);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ServerManagerView";
      this.Text = "Servers";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgServers)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtAddress;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtPort;
    private System.Windows.Forms.TextBox txtServerName;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnRemove;
    private System.Windows.Forms.DataGridView dgServers;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
    private System.Windows.Forms.DataGridViewTextBoxColumn colPort;
    private System.Windows.Forms.Button btnApply;
  }
}