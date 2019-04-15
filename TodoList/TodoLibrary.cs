using System;
namespace TodoList
{
    class TodoLibrary
    {
        public MyList<Task> mylist = new MyList<Task>();

        public int Count{ get => mylist.Count; }

        public Task this[int i]
        {
            get
            {
                return mylist[i];
            }
        }

        public int ItemLeft
        {
            get
            {
                int count = 0; int i = 0;
                while (i != mylist.Count)
                {
                    count = mylist[i]._IsComplect ? count++ : ++i;
                }
                return count;
            }
        }

        public void Complect(int i)
        {
            this[i]._IsComplect = true;
        }

        public void Remove(int i)
        {
            mylist.Remove(mylist[i]);
        }

        public void ClearCompleted()
        {
            mylist.Action(T => T._IsComplect);
        }

        public void Add(string str)
        {
            mylist.Add(new Task(str));
        }

        public TodoLibrary All()
        {
            return new TodoLibrary() { mylist=mylist};
        }

        public TodoLibrary Active()
        {
            MyList<Task> temp = new MyList<Task>();
            foreach (Task item in mylist)
            {
                if (!item._IsComplect)
                {
                    temp.Add(item);
                }
            }
            return new TodoLibrary() { mylist=temp};
        }

        public TodoLibrary Complected()
        {
            MyList<Task> temp = new MyList<Task>();

            foreach (Task item in mylist)
            {
                if (item._IsComplect)
                {
                    temp.Add(item);
                }
            }
            return new TodoLibrary() { mylist = temp };
        }

       
    }
}
