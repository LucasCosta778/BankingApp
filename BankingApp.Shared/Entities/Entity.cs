using Flunt.Notifications;

namespace BankingApp.Shared.Entities
{
    public abstract class Entity: Notifiable<Notification>
    {
        protected Entity()
        {
            Guid = Guid.NewGuid();
        }

        public Guid Guid { get; set; }
    }
}