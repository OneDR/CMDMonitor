namespace SshWrapper.Types
{
  internal class Server
  {
    public string Address { get; set; }
    public string Name { get; set; }
    public int Port { get; set; }

    public Server() : this(string.Empty, string.Empty, 0)
    {}

    /// <summary>
    /// Builds a server object that encapsulate a server information
    /// </summary>
    /// <param name="name"></param>
    /// <param name="address"></param>
    /// <param name="port"></param>
    public Server(string name, string address, int port)
    {
      Name = name;
      Address = address;
      Port = port;
    }
  }
}
