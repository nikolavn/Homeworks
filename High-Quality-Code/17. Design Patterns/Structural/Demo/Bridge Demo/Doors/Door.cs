namespace Bridge_Demo.Doors
{
    internal abstract class Door
    {
        protected readonly ILockable Locker;

        protected Door(ILockable locker)
        {
            this.Locker = locker;
        }

        public virtual string SecurityRating { get; }
        public virtual int NumberOfLocks { get; }
    }
}
