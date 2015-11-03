namespace _13.LinkedQueueTask.LinkedQueueImplementation
{
    using System.Collections.Generic;

    public class CustomLinkedQueue<T>
    {
        private LinkedList<T> list;

        public CustomLinkedQueue()
        {
            this.list = new LinkedList<T>();
        }

        public void Enqueue(T item)
        {
            this.list.AddFirst(item);
        }

        public T Dequeue()
        {
            var lastItem = this.list.Last;

            this.list.RemoveLast();

            return lastItem.Value;
        }
    }
}
