using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Problems.Common.DataStructures.LinkedList
{
    public class DoublyLinkedList
    {
        private class ListNode
        {
            public int Value { get; set; }

            public ListNode PreviousNode { get; set; }
            public ListNode NextNode { get; set; }

            public ListNode(int value)
            {
                this.Value = value;

            }
        }
        private ListNode Head { get; set; }
        private ListNode Tail { get; set; }

        public int Count { get; private set; }

        public void AddFirst(int element)
        {
            if (this.Count == 0)
            {
                this.Head = this.Tail = new ListNode(element);
            }
            else
            {
                var newHead = new ListNode(element);
                newHead.NextNode = this.Head;
                this.Head.PreviousNode = newHead;
                this.Head = newHead;
            }
            this.Count++;
        }
        public void AddLast(int element)
        {
            if (this.Count == 0)
            {
                this.Head = this.Tail = new ListNode(element);
            }
            else
            {
                var newHead = new ListNode(element);
                newHead.PreviousNode = this.Tail;
                this.Tail.NextNode = newHead;
                this.Tail = newHead;
            }
            this.Count++;
        }
        public int RemoveFirst(int element)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("This list is empty");
            }

            var firstElement = this.Head.Value;
            this.Head = this.Head.NextNode;
            if (this.Head != null)
            {
                this.Head.PreviousNode = null;
            }
            else
            {
                this.Tail = null;
            }
            this.Count--;
            return firstElement;
        }
        public int RemoveLast(int element)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("This list is empty");
            }

            var lastElement = this.Tail.Value;
            this.Tail = this.Tail.PreviousNode;
            if (this.Tail != null)
            {
                this.Tail.NextNode = null;
            }
            else
            {
                this.Head = null;
            }
            this.Count--;
            return lastElement;
        }
        public void ForEach(Action<int> action)
        {
            var currentNode = this.Head;
            while (currentNode !=null)
            {
                // Console.WriteLine(currentNode.Value);
                action(currentNode.Value);
                currentNode = currentNode.PreviousNode;
            }
        }
        public int[] ToArray()
        {
            int[] array = new int[this.Count];
            int index = 0;

            var currentNode = this.Head;
            while (currentNode != null)
            {
                array[index] = currentNode.Value;
                currentNode = currentNode.PreviousNode;
                index++;
            }
            return array;
        }
        public void Clear()
        {
            this.Head = null;
        }
        public bool Contains(int element)
        {
            var currentNode = this.Head;
            while (currentNode != null)
            {
                if (currentNode.Value == element)
                {
                    return true;
                }
                currentNode = currentNode.PreviousNode;
            }
            return false;
        }
        /// <summary>
        /// Reverse LinedList
        /// </summary>
        /// <returns>return Head</returns>
        public void Reverse()
        {
            if (this.Head == null)
                return;

            ListNode prev = null;
            ListNode current = this.Head;
            ListNode next = null;

            while (current != null)
            {
                next = current.NextNode;
                current.NextNode = prev;
                prev = current;
                current = next;
            }
            this.Head = prev;
        }
        // TODO : BinarySearch(T)
    }
}
