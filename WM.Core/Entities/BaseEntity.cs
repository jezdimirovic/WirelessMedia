namespace WM.Core.Entities
{
    public abstract class BaseEntity
    {
        // set should be protected but seeding db
        // from configuration as recommended by MS
        // needs to set Id
        public virtual int Id { get; set; }
    }
}
