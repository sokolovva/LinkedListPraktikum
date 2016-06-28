
namespace LinkedList
{
    using System;


    public class LinkedList<T>
    {

        private Node Head { get; set; }
        private int size;

        public LinkedList<T> Add(T value)
        {
            size++;
            if (this.Head.Equals(null))
            {
                this.Head = new Node(value, null);
                return this;
            }

            Node next = this.Head;
            while (!next.Next.Equals(null))
            {
                next = next.Next;
            }

            return this;
        }


        public LinkedList<T> InsertAfter(T key, T value)
        {
            Node insert = this.Head;
            insert.Value = value;
            while (!insert.Equals(null) && !insert.Value.Equals(key))
            {
                insert = insert.Next;
            }

            insert.Next = new Node(value, insert.Next);
            return this;
        }


        public LinkedList<T> InsertBefore(T key, T value)
        {
            if (this.Head.Equals(null))
            {
                this.Head = new Node(value, null);
            }

            Node prev = null;
            Node curr = this.Head;
            while (curr != null && !curr.Value.Equals(key))
            {
                prev = curr;
                curr = curr.Next;
            }

            if (curr == null)
            {
                return this;
            }

            if (prev != null)
            {
                prev.Next = new Node(value, curr);
            }

            return this;
        }





        public LinkedList<T> Remove(T value)
        {
            if (this.Head.Equals(null))
            {
                throw new ArgumentException("Head is null");
            }

            Node curr = this.Head;
            Node prev = null;
            while (curr != null && !curr.Value.Equals(value))
            {
                prev = curr;
                curr = curr.Next;
            }

            if (curr != null && curr.Equals(null))
            {
                throw new ArgumentException("Cannot delete");
            }

            if (prev == null)
            {
                return this;
            }

            if (curr != null)
            {
                prev.Next = curr.Next;
            }

            return this;
        }



        public LinkedList<T> Clear()
        {
            if (this.Head.Equals(null))
            {
                return this;
            }

            Node curr = this.Head;
            while (curr != null && !curr.Value.Equals(null))
            {
                Node prev = curr;
                curr = curr.Next;
                prev.Next = null;
            }

            return this;
        }

        
        public int Count
        {
            get
            {
                return size;
            }
        }

        private class Node
        {
           
            public Node(T value, Node next)
            {
                this.Value = value;
                this.Next = next;
            }

        
            public T Value { get; set; }

          
            public Node Next { get; set; }
        }
        public void PrintList()
        {
            Node temp = Head;
            while(temp!=null)
            {
                Console.Write(" " +temp.Value+ " ");
                temp = temp.Next;
            }
        }
    }
}

