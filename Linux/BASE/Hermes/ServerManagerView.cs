using SshWrapper.Storage;
using SshWrapper.Types;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SshWrapper
{
  public partial class ServerManagerView : Form
  {
    private BindingSource _bindingSource;
    private List<Server> _localServers;

    public ServerManagerView()
    {
      InitializeComponent();
      _bindingSource = new BindingSource();
      _localServers = new List<Server>(Repository.Servers);
      _bindingSource.DataSource = _localServers;
      dgServers.AutoGenerateColumns = false;
      dgServers.DataSource = _bindingSource;
    }

    /// <summary>
    /// Add object to the data binding
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnAdd_Click(object sender, EventArgs e)
    {
			int port = 0;
      int.TryParse(txtPort.Text, out port);
      Server server = new Server
      {
        Address = txtAddress.Text,
        Name = txtServerName.Text,
        Port = port
      };
      _bindingSource.Add(server);
      ClearFields();
    }

    /// <summary>
    /// Remove the current server object
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnRemove_Click(object sender, EventArgs e)
    {
      if (_bindingSource.Current == null) return;
      _bindingSource.RemoveCurrent();
    }

    /// <summary>
    /// Edit current Object
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnEdit_Click(object sender, EventArgs e)
    {
      if (_bindingSource.Current == null) return;
			int port = 0;
      int.TryParse(txtPort.Text, out port);
      ((Server)_bindingSource.Current).Name = txtServerName.Text;
      ((Server)_bindingSource.Current).Address = txtAddress.Text;
      ((Server)_bindingSource.Current).Port = port;
      _bindingSource.ResetCurrentItem();
      ClearFields();
    }

    /// <summary>
    /// Save servers to the file
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnApply_Click(object sender, EventArgs e)
    {
      Repository.SaveServers(_localServers);
      Repository.Servers = new List<Server>(_localServers);
      MessageBox.Show("The servers has been saved", "Save", MessageBoxButtons.OK,
        MessageBoxIcon.Information);
      Close();
    }

    private void dgServers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (_bindingSource.Current == null) return;
      txtServerName.Text = ((Server)_bindingSource.Current).Name;
      txtAddress.Text = ((Server)_bindingSource.Current).Address;
      txtPort.Text = ((Server)_bindingSource.Current).Port.ToString();
    }

    /// <summary>
    /// Close the current window
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnCancel_Click(object sender, EventArgs e)
    {
      Close();
    }

    /// <summary>
    /// Clear fields
    /// </summary>
    private void ClearFields()
    {
      txtAddress.Text = string.Empty;
      txtServerName.Text = string.Empty;
      txtPort.Text = string.Empty;
    }
  }
}
