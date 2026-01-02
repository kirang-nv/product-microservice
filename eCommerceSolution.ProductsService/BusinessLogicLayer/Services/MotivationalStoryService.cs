using eCommerce.BusinessLogicLayer.DTO;
using eCommerce.BusinessLogicLayer.ServiceContracts;

namespace eCommerce.BusinessLogicLayer.Services;

public class MotivationalStoryService : IMotivationalStoryService
{
  private readonly List<MotivationalStoryResponse> _stories;

  public MotivationalStoryService()
  {
    _stories = new List<MotivationalStoryResponse>
    {
      new MotivationalStoryResponse(
        "The Bamboo Tree",
        "A farmer planted bamboo seeds and watered them daily. For four years, nothing appeared above the ground. But the farmer kept watering faithfully. In the fifth year, the bamboo grew 80 feet in just six weeks! The bamboo wasn't growing for four years - it was developing a strong root system underground that would support its rapid growth.",
        "Success takes time and patience. What seems like no progress is often preparation for exponential growth."
      ),
      new MotivationalStoryResponse(
        "The Eagle and the Chicken",
        "An eagle's egg was placed in a chicken's nest. The eaglet grew up with the chickens, pecking at grain and acting like a chicken. One day, it saw eagles soaring in the sky and felt a deep longing. An old eagle told it, 'You are an eagle, not a chicken. Spread your wings and fly!' The young eagle realized its true potential and soared into the sky.",
        "Don't let your environment limit your potential. You are capable of much more than you think."
      ),
      new MotivationalStoryResponse(
        "The Stone Cutter",
        "A stone cutter worked hard every day, chipping away at a massive rock. After 100 strikes, the rock remained intact. He struck 100 more times - still nothing. People laughed and said he was wasting his time. But on the 201st strike, the rock split in half. It wasn't that final blow that did it - it was all the strikes that came before.",
        "Persistence and consistency lead to breakthrough. Every effort counts, even when results aren't immediately visible."
      ),
      new MotivationalStoryResponse(
        "The Coffee Bean Story",
        "A young woman complained about her difficult life to her father. He filled three pots with water and placed carrots in one, eggs in another, and coffee beans in the third. After boiling, the carrots became soft, the eggs became hard, but the coffee beans transformed the water itself. He asked, 'When adversity knocks, will you become soft like carrots, hardened like eggs, or transform your circumstances like coffee?'",
        "Challenges don't define you - your response to them does. Choose to transform your circumstances."
      ),
      new MotivationalStoryResponse(
        "The Starfish Story",
        "A man walking on the beach saw thousands of starfish washed ashore. A young boy was picking them up and throwing them back into the ocean. The man said, 'There are too many - you can't make a difference.' The boy picked up another starfish, threw it back, and replied, 'I made a difference to that one.'",
        "Every small action matters. Don't underestimate the impact you can make, one step at a time."
      )
    };
  }

  public Task<MotivationalStoryResponse> GetRandomStory()
  {
    Random random = new Random();
    int index = random.Next(_stories.Count);
    return Task.FromResult(_stories[index]);
  }
}
