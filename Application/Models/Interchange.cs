using Murmur.Domain.Models;

namespace Murmur.Application.Models;

public class Interchange : IInterchange
{
  public Guid Id { set; get; } = Guid.NewGuid();
  public string Title { set; get; }
  public List<IMessage> Messages { set; get; } = new();

  public Interchange(string title)
  {
    Title = title;
  }
}

