namespace ComManager.Models;

using LiteDB;

public class DatabaseHelper
{
  public DatabaseHelper() { }

  ILiteCollection<ITransaction> GetCollection(ITransaction transaction, string collection)
  {
	using var db = new LiteDatabase($"{Environment.CurrentDirectory}/commngr.db");

	return db.GetCollection<ITransaction>(collection);
  }

  public IEnumerable<ITransaction> GetDatabase(ITransaction transaction, string collection)
  {
	var column = GetCollection(transaction, collection);

	return column.FindAll();
  }
  public IEnumerable<ITransaction> InsertColumn(ITransaction transaction, string file, string collection)
  {
	var column = GetCollection(transaction, collection);

	column.Insert(transaction);

	return column.FindAll();
  }

}