using Domain.Entities.User;

namespace Application.Interfaces.UserInterface
{
    public interface IUserInterface
    {
        User Add (User user);

        bool Delete (User user);
    }
}
