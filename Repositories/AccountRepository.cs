using CommonLib.Database;
using KabulTalk.Models;

namespace KabulTalk.Repositories
{
  public class AccountRepository : RepositoryBase, IAccountRepository
  {
    public long Save(Account account)
    {
      string query = "" +
        "INSERT account SET\n" +
        "  id = @id\n" +
        ", pwd = @pwd\n" +
        ", email = @email\n" +
        ", nickname = @nickname\n" +
        ", cell_phone = @cell_phone";

      using (MySqlDb db = AccountDb)
      {
        return db.Execute(query, new SqlParameter[]
         {
          new SqlParameter("@id", account.Id),
          new SqlParameter("@pwd", account.Pwd),
          new SqlParameter("@email", account.Email),
          new SqlParameter("@nickname", account.Nickname),
          new SqlParameter("@cell_phone", account.CellPhone),
         });
      }
    }

    public bool ExistEmail(string email)
    {
      string query =
        "SELECT 1 FROM account\n" +
        "WHERE email = @email";
      using MySqlDb db = AccountDb;
      using System.Data.IDataReader? dr = db.GetReader(query, new SqlParameter[] { new SqlParameter("@email", email) });
      return dr.Read();
    }
  }
}
