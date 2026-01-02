using eCommerce.BusinessLogicLayer.DTO;

namespace eCommerce.BusinessLogicLayer.ServiceContracts;

public interface IMotivationalStoryService
{
  /// <summary>
  /// Retrieves a random motivational story
  /// </summary>
  /// <returns>Returns a MotivationalStoryResponse object</returns>
  Task<MotivationalStoryResponse> GetRandomStory();
}
