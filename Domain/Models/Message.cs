namespace Murmur.Domain.Models;

public class Message
{
  public Guid Id { get; set; }
  public string Content { get; set; }

  public Message(Guid id, string content)
  {
    Id = id;
    Content = content;
  }
}
