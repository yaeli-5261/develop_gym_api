

using Gym.Core.Entities;

namespace Gym.Core.Interface
{
    public interface IDataContext
    {
        List<Trainer> ListTrainer { get; set; }
        List<Client> ListClient { get; set; }
        List<Lesson> ListLesson { get; set; }

    }
}
