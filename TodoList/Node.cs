using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    public class Node<T>
    {

        public Node(T t)
        {
            Data = t;
        }
        public T Data { get; set; } 
        public Node<T> Next { get; set; } 
    }
}
