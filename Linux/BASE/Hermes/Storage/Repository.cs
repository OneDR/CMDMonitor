using SshWrapper.Types;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace SshWrapper.Storage
{
  internal class Repository
  {
    private const string SERVER_FILENAME = "servers.json";
    private const string COMMANDS_FILENAME = "commands.json";

    private static List<Server> _servers;
    private static List<Command> _commands;
    public static List<Server> Servers
    {
      get
      {
        if (_servers == null) _servers = LoadServers();
        return _servers;
      }
      set { _servers = value; }
    }

    public static List<Command> Commands
    {
      get
      {
        if (_commands == null) _commands = LoadCommands();
        return _commands;
      }
      set { _commands = value; }
    }

    /// <summary>
    /// Load the servers file
    /// </summary>
    /// <returns></returns>
    private static List<Server> LoadServers()
    {
      if (File.Exists(SERVER_FILENAME) == false) return new List<Server>();
      string json = File.ReadAllText(SERVER_FILENAME);
      return JsonConvert.DeserializeObject<List<Server>>(json);
    }

    /// <summary>
    /// Load the commands file
    /// </summary>
    /// <returns></returns>
    private static List<Command> LoadCommands()
    {
      if (File.Exists(COMMANDS_FILENAME) == false) return new List<Command>();
      string json = File.ReadAllText(COMMANDS_FILENAME);
      return JsonConvert.DeserializeObject<List<Command>>(json);
    }

    /// <summary>
    /// Save the servers
    /// </summary>
    /// <param name="servers"></param>
    public static void SaveServers(List<Server> servers)
    {
      string json = JsonConvert.SerializeObject(servers);
      File.WriteAllText(SERVER_FILENAME, json);
    }

    /// <summary>
    /// Save the commands
    /// </summary>
    /// <param name="servers"></param>
    public static void SaveCommands(List<Command> commands)
    {
      string json = JsonConvert.SerializeObject(commands);
      File.WriteAllText(COMMANDS_FILENAME, json);
    }
  }
}
