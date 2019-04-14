namespace TodoList
{
    class TodoLibrary
    {
        public MyList<Task> mylist = new MyList<Task>();

        public int Count{ get => mylist.Count; }

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
        public string this[int i]
        {
            get
            {
                return mylist[i]._Task;
            }
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

        public MyList<Task> All()
        {
            return mylist;
        }

        public MyList<Task> Active()
        {
            MyList<Task> temp = new MyList<Task>();
            foreach (Task item in mylist)
            {
                if (!item._IsComplect)
                {
                    temp.Add(item);
                }
            }
            return temp;
        }
        public MyList<Task> Complected()
        {
            MyList<Task> temp = new MyList<Task>();
            foreach (Task item in mylist)
            {
                if (item._IsComplect)
                {
                    temp.Add(item);
                }
            }
            return temp;
        }
    }
}
