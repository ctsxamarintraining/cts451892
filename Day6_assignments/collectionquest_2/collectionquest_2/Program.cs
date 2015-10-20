using System;
using System.Collections.Generic;

namespace collectionquest_2
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			ItemList<int> itemList = new ItemList<int>();

			itemList.insertItem (1);
			itemList.insertItem (2);
			itemList.insertItem (3);
			itemList.insertItem (4);

			Console.WriteLine("After adding count {0}",itemList.Count);

			if (itemList.containsItem (3)) 
			{
				itemList.deleteitem (3);
			}

			Console.WriteLine("After Removing one item count {0}",itemList.Count);

			itemList.clearAllItems ();

			Console.WriteLine("After removing all items {0}",itemList.Count);
		}

	}



	class ItemList<T> : IList<T>
	{


		public void Add (T item)
		{
			throw new NotImplementedException ();
		}

		public void Clear ()
		{
			throw new NotImplementedException ();
		}

		public bool Contains (T item)
		{
			throw new NotImplementedException ();
		}

		public void CopyTo (T[] array, int arrayIndex)
		{
			throw new NotImplementedException ();
		}

		public bool Remove (T item)
		{
			throw new NotImplementedException ();
		}

		public int Count 
		{
			get 
			{
				return _index+1;
			}
		}

		public bool IsReadOnly 
		{
			get 
			{
				throw new NotImplementedException ();
			}
		}

		public IEnumerator<T> GetEnumerator ()
		{
			throw new NotImplementedException ();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator ()
		{
			throw new NotImplementedException ();
		}


		T[] listArray= new T[10];
		int _index;
		T itemValue;

		public T this [int index] 
		{
			get 
			{ 
				return itemValue; 
			}
			set 
			{
				itemValue = value; 
			}
		}

		public ItemList(){

			_index = -1;
		}


		public int IndexOf(T item)
		{
			for (int i = 0; i < this._index; i++) 
			{
				if (listArray [i].Equals (item)) 
				{
					return i;
				}
			}
			return -1;
		}

		public void Insert (int index, T item)
		{
			if (index < listArray.Length) 
			{
				listArray [index] = item;
			}
		}

		public void RemoveAt (int index)
		{
			for (int i = index; i < this._index; i++) 
			{
				listArray [i] = listArray [i + 1];
			}
			_index--;
		}

		public void insertItem(T item)
		{
			this._index++;
			Insert (this._index, item);
		}

		public void deleteitem(T item)
		{
			if (IndexOf (item) > -1) 
			{
				RemoveAt (IndexOf(item));
			} 
		}

		public bool containsItem(T item)
		{
			if (IndexOf (item) > -1) 
			{
				return true;
			} 
			else 
			{
				return false;
			}
		}

		public void clearAllItems()
		{
			this._index = -1;
		}
	}
}

