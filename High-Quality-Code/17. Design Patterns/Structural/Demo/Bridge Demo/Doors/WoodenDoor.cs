using System.Text;

namespace Bridge_Demo.Doors
{
    internal class WoodenDoor : Door
    {
        private const string WoodenDoorSecurityRating = "Low";
        private const int WoodenDoorNumberOfLocks = 1;

        public WoodenDoor(ILockable locker)
            : base(locker)
        {

        }

        public override string SecurityRating
        {
            get
            {
                return WoodenDoorSecurityRating;
            }
        }
        public override int NumberOfLocks
        {
            get
            {
                return WoodenDoorNumberOfLocks;
            }
        }

        public void Lock()
        {
            this.Locker.Lock();
        }

        public void UnLock()
        {
           this.Locker.UnLock();
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(string.Format("Door type: {0}", this.GetType().Name));
            builder.AppendLine(string.Format("Security rating: {0}", this.SecurityRating));
            builder.AppendLine(string.Format("Number of locks: {0}", this.NumberOfLocks));
            builder.AppendLine(string.Format("Locks type: {0}", this.Locker.GetType().Name));

            return builder.ToString();
        }
    }
}
