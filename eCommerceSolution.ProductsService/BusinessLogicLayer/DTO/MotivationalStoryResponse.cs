namespace eCommerce.BusinessLogicLayer.DTO;

public record MotivationalStoryResponse(string Title, string Story, string Moral)
{
  public MotivationalStoryResponse() : this(default, default, default)
  {
  }
}
