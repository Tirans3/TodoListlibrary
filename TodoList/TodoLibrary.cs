namespace TodoList
{
    class TodoLibrary
    {
        public MyList<Task> mylist = new MyList<Task>();

        public int ItemLeft
        {
            get
            {
                int count = 0; int i = 0;
                while (i != mylist.Count)
                {
                  count=mylist[i]._IsComplect==true ? count++ : ++i;
                }
                return count;
            }
        }

       

        public void Add(string str)
        {
            mylist.Add(new Task(str));
        }

    }
}
