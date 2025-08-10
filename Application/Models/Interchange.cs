namespace Murmur.Application.Models;

public class Interchange
{
  public Guid Id { get; set; }
  public string Title { get; set; }
  public List<Message> Messages { set; get; }

  public Interchange(Guid id, string title)
  {
    Id = id;
    Title = title;
    Messages = new();
  }
}
