namespace _11.LinkedListTask.LinkedListImplementation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class LinkedList<T>:IEnumerable<T>
    {
        private ListItem<T> firstItem;

        public LinkedList()
        {
            
        }

        public ListItem<T> FirstItem { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            ListItem<T> currentNode = this.firstItem;

            while (currentNode != null)
            {
                yield return currentNode.Value;

                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
