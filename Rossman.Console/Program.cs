
using System.Globalization;

var user = new User();

var number = ((IConvertible) "aa").ToInt32(null);
Console.WriteLine();

public interface ISoftDeletable
{
    DateTimeOffset? DeletionDate { get; set; }
    bool  IsDeleted => DeletionDate.HasValue;
    void SoftDelete();
}


public class User : ISoftDeletable// SOFT DELETE
{
    public Guid Id { get; set; }
    DateTimeOffset? ISoftDeletable.DeletionDate { get; set; }
    
    void ISoftDeletable.SoftDelete()
    {
        ((ISoftDeletable)this).DeletionDate = DateTimeOffset.Now;
    }
}

public class Product // HARD
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}


class DbConnector<TEntity>
{
    public void Delete(TEntity entity)
    {
        if (entity is ISoftDeletable softDeletable)
        {
            softDeletable.SoftDelete();
            // DB UPDATE
            return;
        }
        
        // DB DELETE
    }
}