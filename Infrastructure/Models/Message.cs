using Murmur.Domain.Models;

namespace Murmur.Infrastructure.Models;

public class Message
{
  public Guid Id { get; } = Guid.NewGuid();
  public string Content { get; }

  public Message(string content)
  {
    Content = content;
  }
}
