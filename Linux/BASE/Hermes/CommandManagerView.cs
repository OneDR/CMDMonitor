using SshWrapper.Storage;
using SshWrapper.Types;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SshWrapper
{
	public partial class CommandManagerView : Form
	{
		private BindingSource _bindingSource;
		private List<Command> _localCommands;

		public CommandManagerView()
		{
			InitializeComponent();
			_bindingSource = new BindingSource();
			_localCommands = new List<Command>(Repository.Commands);
			_bindingSource.DataSource = _localCommands;
			dgCommands.AutoGenerateColumns = false;
			dgCommands.DataSource = _bindingSource;
		}

		/// <summary>
		/// Add object to the data binding
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAdd_Click(object sender, EventArgs e)
		{
			Command command = new Command
			{
				Name = txtName.Text,
				Content = txtCommand.Text
			};
			_bindingSource.Add(command);
			ClearFields();
		}

		/// <summary>
		/// Remove the current command object
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
			((Command)_bindingSource.Current).Name = txtName.Text;
			((Command)_bindingSource.Current).Content = txtCommand.Text;
			_bindingSource.ResetCurrentItem();
			ClearFields();
		}

		/// <summary>
		/// Save commands to the file
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnApply_Click(object sender, EventArgs e)
		{
			Repository.SaveCommands(_localCommands);
			Repository.Commands = new List<Command>(_localCommands);
			MessageBox.Show("Commands has been saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
			DialogResult = DialogResult.Yes;
			Close();
		}

		/// <summary>
		/// Fill the fields with the command info
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgCommands_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (_bindingSource.Current == null) return;
			txtName.Text = ((Command)_bindingSource.Current).Name;
			txtCommand.Text = ((Command)_bindingSource.Current).Content;
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
		/// Clear the fields
		/// </summary>
		private void ClearFields()
		{
			txtName.Text = string.Empty;
			txtCommand.Text = string.Empty;
		}
	}
}