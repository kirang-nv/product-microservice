using eCommerce.BusinessLogicLayer.DTO;
using eCommerce.BusinessLogicLayer.ServiceContracts;

namespace eCommerce.ProductsMicroService.API.APIEndpoints;

public static class MotivationalStoryAPIEndpoints
{
  public static IEndpointRouteBuilder MapMotivationalStoryAPIEndpoints(this IEndpointRouteBuilder app)
  {
    //GET /api/motivational-story
    app.MapGet("/api/motivational-story", async (IMotivationalStoryService motivationalStoryService) =>
    {
      MotivationalStoryResponse story = await motivationalStoryService.GetRandomStory();
      return Results.Ok(story);
    });

    return app;
  }
}
