using SshWrapper.Storage;
using System;
using System.Windows.Forms;
using Renci.SshNet;
using SshWrapper.Types;
using Renci.SshNet.Common;

namespace SshWrapper
{
  public partial class LoginView : Form
  {
    public LoginView()
    {
      InitializeComponent();
      cmbServers.DataSource = Repository.Servers;
    }

    /// <summary>
    /// Shows the new server form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void lblNewServer_Click(object sender, EventArgs e)
    {
      new ServerManagerView().ShowDialog();
    }

    /// <summary>
    /// Closes the current form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnClose_Click(object sender, EventArgs e)
    {
			Close();
    }

    private void btnConnect_Click(object sender, EventArgs e)
    {
      if (cmbServers.SelectedItem == null) return;
      btnConnect.Enabled = false;
      Server server = (Server)cmbServers.SelectedItem;
      SshClient sshClient = new SshClient(server.Address, txtUsername.Text, txtPassword.Text);
      try
      {
        sshClient.Connect();
        Hide();
        new ServerControlView(sshClient).ShowDialog();
        sshClient.Disconnect();
        Close();
      }
      catch (SshAuthenticationException)
      {
        MessageBox.Show("Invalid Credentials", "Authentication", MessageBoxButtons.OK, 
          MessageBoxIcon.Error);
      }
      catch (Exception ex)
      {
        MessageBox.Show($"A problem occurred: {ex.Message}", "Exception", MessageBoxButtons.OK,
          MessageBoxIcon.Error);
      }
			Show();
      btnConnect.Enabled = true;
    }
  }
}
