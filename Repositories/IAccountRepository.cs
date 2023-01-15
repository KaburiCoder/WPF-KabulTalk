using KabulTalk.Models;

namespace KabulTalk.Repositories
{
  public interface IAccountRepository
  {
    bool ExistEmail(string email);
    long Save(Account account);
  }
}