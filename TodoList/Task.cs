using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    class Task
    {
        public string _Task { get; set; }

        public bool _IsComplect { get; set; } = false;

        public Task(string str)
        {
            _Task = str;
        }
       

    }
}
