namespace _12.StackTask.StackImplementation
{
    using System;

    public class CustomStack<T>
    {
        private const int InitialSize = 4;

        private T[] stack;
        private int currentIndex;

        public CustomStack()
        {
            this.stack = new T[InitialSize];
            this.currentIndex = 0;
        }

        public T Peek()
        {
            if (this.currentIndex == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            return this.stack[currentIndex - 1];
        }

        public void Push(T item)
        {
            if (this.currentIndex == this.stack.Length)
            {
                Array.Resize(ref this.stack, this.stack.Length * 2);
            }

            this.stack[this.currentIndex] = item;
            this.currentIndex++;
        }

        public T Pop()
        {
            if (this.currentIndex ==0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            T item = this.stack[this.currentIndex - 1];
            this.currentIndex--;

            return item;
        }
    }
}
