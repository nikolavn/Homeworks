using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    internal abstract class HandsChecker
    {
        protected HandsChecker Successor { get; set; }

        public void SetSuccessor(HandsChecker successor)
        {
            this.Successor = successor;
        }

        public abstract void CheckHand(IHand hand);
    }
}
