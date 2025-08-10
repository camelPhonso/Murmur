namespace Murmur.Domain.Models;

public interface IMessage
{
  public Guid Id { set; get; }
  public string Content { set; get; }
}
