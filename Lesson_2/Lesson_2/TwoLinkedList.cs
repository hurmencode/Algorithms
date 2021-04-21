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
            Node newNode = new Node { Value = value };
            if (node == FirstNode)
            {
                
            }
        }

        public void RemoveNode(int index)
        {

        }

        public void RemoveNode(Node node)
        {

        }

        public Node FindNode(int searchNode)
        {
            return null;
        }
    }
}
