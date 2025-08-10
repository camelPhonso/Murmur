namespace Murmur.Domain.Models;

public interface IInterchange
{
  public Guid Id { set; get; }
  public string Title { set; get; }
  public List<IMessage> Messages { get; set; }
}
