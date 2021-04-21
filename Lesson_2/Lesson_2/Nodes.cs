using System;

namespace Lesson_2
{
    public sealed class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }
    }
    
}
