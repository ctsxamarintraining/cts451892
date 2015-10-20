using System;
using System.Collections;
using System.Collections.Generic;

namespace collectionQuest_1
{		class Person{
			public int personId;
			public string personName;
			public string personLocation;
		}

		class MainClass
		{
			public static void Main (string[] args)
			{
				MyEnumerable myEnumerable = new MyEnumerable();

				foreach (Person person in myEnumerable) 
				{
				Console.WriteLine (person.personId);
				Console.WriteLine (person.personName);
				Console.WriteLine (person.personLocation);
				}

			}
		}

		

		class MyEnumerable : IEnumerable
		{

			public IEnumerator GetEnumerator ()
			{
				return new MyEnumerator();
			}

		}

		

		class MyEnumerator : IEnumerator
		{
			public static LinkedList<Person> personLinkedList;

			public LinkedListNode<Person> currentObj;
			public object Current {
				get{
					return currentObj.Value;
				}
			}

			public bool MoveNext ()
			{
				if (personLinkedList == null) {
					personLinkedList = new LinkedList<Person>();

				personLinkedList.AddLast(new Person {personId = 1, personName = "xxx", personLocation = "chennai"} );
					personLinkedList.AddLast(new Person {personId = 2, personName = "YYY", personLocation = "chennai"} );
					personLinkedList.AddLast(new Person {personId = 3, personName = "ZZZ", personLocation = "chennai"} );
				}
				if (currentObj == null && personLinkedList.First != null) 
				{

					currentObj = personLinkedList.First;
					return true;
				} 
				if ( currentObj.Next!=null) 
				{
					currentObj = currentObj.Next;
					return true;
				} 
				else 
				{
					return false;
				}

			}

			public void Reset ()
			{
				currentObj = null;
			}
		}
}
