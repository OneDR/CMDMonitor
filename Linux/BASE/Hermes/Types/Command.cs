namespace SshWrapper.Types
{
  class Command
  {
    public string Name { get; set; }
    public string Content { get; set; }

    /// <summary>
    /// Ctor
    /// </summary>
    public Command() : this(string.Empty, string.Empty)
    {}

    /// <summary>
    /// Ctor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="content"></param>
    public Command(string name, string content)
    {
      Name = name;
      Content = content;
    }
  }
}
