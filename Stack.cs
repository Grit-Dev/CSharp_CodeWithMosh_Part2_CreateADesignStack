using System;
using System.Collections;

namespace ConsoleApp5
{
    public class Stack : object
    {
        private object object1;

        private readonly ArrayList list = new ArrayList();

        public void Push(Object obj)
        {
            if (obj == null)
            {
                Console.WriteLine("You cannot put nothing in the stack \n");

            }
            else
            {
                list.Add(obj);
            }

        }

        public object Pop()
        {
            if (list.Count != 0)
            {
                object1 = list[list.Count - 1];
                list.Remove(object1);

                //Note:
                //
                //To understand this: 123 is stored in the List
                //The list looks in to see what is in the length of the array list which would
                //be position [4] -1. Which is 3.
                //3 is moved from the array list and then
                // returned to be displayed

                //Once the method is called again
                //it will find the length - 2. which is 2 and so on
            }
            else
            {
                throw new InvalidOperationException("Stack is already empty. Nothing to remove. ");
            }
            return object1;
        }

        public void Clear()
        {
            if (list.Count != 0)
            {
                list.Clear();
            }
            else
            {
                throw new InvalidOperationException("Stack is already cleared");
            }

        }
    }
    
}
