using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Demo.Doors
{
    internal class EnforcedMetalDoor : Door
    {
        private const string EnforcedDoorSecurityRating = "High";
        private const int EnforcedMetalDoorNumberOfLocks = 2;

        public EnforcedMetalDoor(ILockable locker)
            : base(locker)
        {

        }

        public override string SecurityRating
        {
            get
            {
                return EnforcedDoorSecurityRating;
            }
        }

        public override int NumberOfLocks
        {
            get
            {
                return EnforcedMetalDoorNumberOfLocks;
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
