namespace ComMgr.Data;

using LiteDB;

public static class DatabaseHelper
{
    static ILiteCollection<ITransaction> GetCollection(ITransaction transaction, string collection)
    {
        using var db = new LiteDatabase($"{Environment.CurrentDirectory}/commngr.db");

        return db.GetCollection<ITransaction>(collection);
    }

    public static IEnumerable<ITransaction> GetDatabase(ITransaction transaction, string collection)
    {
        var column = GetCollection(transaction, collection);

        return column.FindAll();
    }
    public static IEnumerable<ITransaction> InsertColumn(ITransaction transaction, string file, string collection)
    {
        var column = GetCollection(transaction, collection);

        column.Insert(transaction);

        return column.FindAll();
    }

}