using CommonLib.Database;

namespace KabulTalk.Repositories
{
  public abstract class RepositoryBase
  {
    protected MySqlDb AccountDb => new(Properties.Settings.Default.CONNSTRING_ACCOUNT);
  }
}
