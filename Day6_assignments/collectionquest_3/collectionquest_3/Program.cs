using System;

namespace collectionquest_3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			StackClass stack = new StackClass();

			stack.push (1);
			stack.push (2);
			stack.pop();
			stack.push (4);

			QueueClass queue = new QueueClass();

			queue.enqueue (1);
			queue.enqueue (2);
			queue.enqueue (4);
			queue.dequeue();
			queue.enqueue (3);

		}
	}


	class StackClass
	{
		int[] stackArray = new int[10];

		int top = -1;

		public void push(int item)
		{
			top ++;

			if (top < stackArray.Length) 
			{
				stackArray [top] = item;
			}
		}

		public int pop()
		{
			top --;

			if (top >= 0) 
			{
				return stackArray [top];
			} 
			else 
			{
				return -1;
			}
		}
	}


	class QueueClass
	{
		int[] queueArray = new int[10];

		int front = -1;
		int rear = -1;

		public void enqueue(int item)
		{
			rear ++;
			if (rear < queueArray.Length) 
			{
				queueArray [rear] = item;
			} 
		}

		public int dequeue()
		{
			front ++;

			if (front < queueArray.Length) 
			{
				return queueArray [front];
			} 
			else 
			{
				return -1;
			}
		}

	}
}
