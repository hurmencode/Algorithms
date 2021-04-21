using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    interface ILinkeList
    {
        int GetCount();  // Возвращает количество элемнентов в списке
        void AddNode(int value); // добавляет новый элемнт списка
        void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определенного элемента
        void RemoveNode(int index); // удаляет элемент по порядковому номеру 
        void RemoveNode(Node node); // удаляет указанный элемент
        Node FindNode(int searchValue); // ищет элемнт по его значению

    }
}
