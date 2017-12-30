using Renci.SshNet;
using System.Threading.Tasks;

namespace SshWrapper.Extensions
{
  internal static class SshExtensions
  {
    internal static async Task<SshCommand> RunCommandAsync(this SshClient client, string strCommand)
    {
      SshCommand command = await Task.Run(() => client.RunCommand(strCommand));
      return command;
    }
  }
}
