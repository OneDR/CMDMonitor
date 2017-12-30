using Renci.SshNet;
using SshWrapper.Storage;
using SshWrapper.Types;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using SshWrapper.Extensions;

namespace SshWrapper
{
  public partial class ServerControlView : Form
  {
    private SshClient _client;
    private Timer _timer;

    /// <summary>
    /// Ctor
    /// </summary>
    public ServerControlView()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Ctor
    /// </summary>
    /// <param name="sshClient"></param>
    internal ServerControlView(SshClient sshClient)
    {
      InitializeComponent();
      _client = sshClient;
      _timer = new Timer();
      _timer.Interval = 8000;
      _timer.Tick += _timer_Tick;
      BuildCommandButtons();
			LoadServerStatus().ConfigureAwait(false);
      _timer.Start();
    }

    /// <summary>
    /// Execute when the timer reach the interval
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void _timer_Tick(object sender, EventArgs e)
    {
			LoadServerStatus().ConfigureAwait(false);
    }

    /// <summary>
    /// Build a button per command
    /// </summary>
    private void BuildCommandButtons()
    {
      commandsPanel.Controls.Clear();
      foreach (Command command in Repository.Commands)
      {
        Button button = new Button();
        button.Text = command.Name;
        button.Tag = command;
        button.Click += btnExecuteCommand;
        commandsPanel.Controls.Add(button);
      }
    }

    /// <summary>
    /// Load the server status
    /// </summary>
    private async Task LoadServerStatus()
		{
			const string cpu = @"top -bn 2 -d 0.5 | grep ""Cpu(s)"" | tail -n 1 | awk '{print ($2+$4$6)"" %""}'";
			const string mem = @"free -m | grep ""Mem: "" | awk '{print $3 "" MB""}'";
			const string hd = @"df -k | grep ""/dev/"" | awk '{print $4 "" KB""}'";
			if (_client.IsConnected == false) return;
			SshCommand statCommand = await _client.RunCommandAsync(cpu);
			string cpuUsage = statCommand.Result;
			statCommand = await _client.RunCommandAsync(mem);
			string memUsage = statCommand.Result;
			statCommand = await _client.RunCommandAsync(hd);
			string diskAvailable = statCommand.Result;
			lblCpuUsage.Text = cpuUsage;
			lblMemUsage.Text = memUsage;
			lblDiskAvailable.Text = diskAvailable;
		}

    /// <summary>
    /// Executes commands
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnExecuteCommand(object sender, EventArgs e)
    {
      Button button = (Button)sender;
      Command command = (Command)button.Tag;
      var cmd = _client.CreateCommand(command.Content);
      string result = cmd.Execute();
      richTextBox1.AppendText(result);
    }

    /// <summary>
    /// Clears the output
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnClear_Click(object sender, EventArgs e)
    {
      richTextBox1.Text = string.Empty;
    }


    /// <summary>
    /// Shows the command manager view
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnShowCommandManager_Click(object sender, EventArgs e)
    {
      if (new CommandManagerView().ShowDialog() == DialogResult.Yes)
        BuildCommandButtons();
    }

    /// <summary>
    /// CLose the current form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnExit_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
