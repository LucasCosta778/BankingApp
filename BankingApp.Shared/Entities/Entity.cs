namespace BankingApp.Shared.Entities
{
    public abstract class Entity 
    {
        protected Entity()
        {
            Guid = Guid.NewGuid();
        }

        public Guid Guid { get; set; }
    }
}