using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    public class TwoLinkedList : ILinkeList
    {
        public int Size { get; set; }
        public Node FirstNode { get; set; }
        public Node LostNode { get; set; }

        public int GetCount()
        {
            return Size;
        }

        public void AddNode(int value)
        {
            Node node = new Node { Value = value };

            if (node == null)
            {
                node = FirstNode;
            }
            else
            {
                LostNode.NextNode = node;
                node.PrevNode = LostNode;
            }
            LostNode = node;
            Size++;
        }

        public void AddNodeAfter(Node node, int value)
        {
            
            if (node == FirstNode)
            {
                Node newNode = new Node { Value = value };
                var currentNode = newNode;

                newNode.NextNode = LostNode;
                LostNode.PrevNode = newNode;
                newNode.PrevNode = FirstNode;
                FirstNode.NextNode = node;
                currentNode.PrevNode = FirstNode;
                currentNode.NextNode = LostNode;
                Size++;
            }
            else if (node == LostNode)
            {
                AddNode(value);
            }
            
        }

        public void RemoveNode(int index)
        {

        }

        public void RemoveNode(Node node)
        {
            if (node == FirstNode)
            {
                FirstNode = node.NextNode;
                node.NextNode = null;
                FirstNode.PrevNode = null;
            }
            else if (node == LostNode)
            {
                LostNode = node.PrevNode;
                node.PrevNode = null;
                LostNode.NextNode = null;
            }
            else
            {
                node.NextNode.PrevNode = node.PrevNode;
                node.PrevNode.NextNode = node.NextNode;
            }
            Size--;
        }

        public Node FindNode(int searchNode)
        {
            return null;
        }
    }
}
