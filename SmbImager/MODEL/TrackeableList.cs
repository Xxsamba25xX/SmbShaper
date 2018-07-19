using System;
using System.Collections.Generic;
using System.Text;

namespace SmbImager.Model
{
	public class TrackeableList<T> : List<T>
	{
		public event EventHandler<IEnumerable<T>> AddItems;
		public event EventHandler<IEnumerable<T>> AddedItems;
		public event EventHandler<IEnumerable<T>> InsertItems;
		public event EventHandler<IEnumerable<T>> InsertedItems;
		public event EventHandler<IEnumerable<T>> RemoveItems;
		public event EventHandler<IEnumerable<T>> RemovedItems;


		///<summary> Adds an object to the end of List </summary>
		///<param name="item">The object to be added to the end of the List. The value can be null for reference types.</param>
		public new void Add(T item)
		{
			if (AddItems != null) AddItems(this, new List<T>() { item });
			base.Add(item);
			if (AddedItems != null) AddedItems(this, new List<T>() { item });
		}

		///<summary> Adds the elements of the specified collection to the end of the List. </summary>
		///<param name="collection"> The collection whose elements should be added to the end of the List. The collection itself cannot be null, but it can contain elements that are null, if type T is a reference type.</param>
		///<exception cref="System.ArgumentNullException"> collection is null. </exception>
		public new void AddRange(IEnumerable<T> collection)
		{
			if (AddItems != null) AddItems(this, collection);
			base.AddRange(collection);
			if (AddedItems != null) AddedItems(this, collection);
		}

		///<summary> Inserts an element into the List at the specified index. </summary>
		///<param name="index"> The zero-based index at which item should be inserted.</param>
		///<param name="item"> The object to insert. The value can be null for reference types.</param>
		///<exception cref="System.ArgumentOutOfRangeException"> index is less than 0. -or- index is greater than List.Count.</exception>
		public new void Insert(int index, T item)
		{
			if (InsertItems != null) InsertItems(this, new List<T>() { item });
			base.Insert(index, item);
			if (InsertedItems != null) InsertedItems(this, new List<T>() { item });
		}

		///<summary> Inserts the elements of a collection into the List at the specified index. </summary>
		///<param name="index"> The zero-based index at which the new elements should be inserted.</param>
		///<param name="collection"> The collection whose elements should be inserted into the List. The collection itself cannot be null, but it can contain elements that are null, if type T is a reference type.</param>
		///<exception cref="System.ArgumentNullException"> collection is null.</exception>
		///<exception cref="System.ArgumentOutOfRangeException">index is less than 0. -or- index is greater than List.Count.</exception>
		public new void InsertRange(int index, IEnumerable<T> collection)
		{
			if (InsertItems != null) InsertItems(this, collection);
			base.InsertRange(index, collection);
			if (InsertedItems != null) InsertedItems(this, collection);
		}

		///<summary> Removes the first occurrence of a specific object from the List. </summary>
		///<param name="item">The object to remove from the List. The value can be null for reference types.</param>
		///<returns>true if item is successfully removed; otherwise, false. This method also returns false if item was not found in the List.</returns>
		public bool Remove(T item)
		{
			if (RemoveItems != null) RemoveItems(this, new List<T> { item });
			return base.Remove(item);
			if (RemovedItems != null) RemovedItems(this, new List<T> { item });
		}

		///<summary> Removes all the elements that match the conditions defined by the specified predicate. </summary>
		///<param name="match"> The System.Predicate`1 delegate that defines the conditions of the elements to remove.</param>
		///<returns> The number of elements removed from the List . </returns>
		///<exception cref="System.ArgumentNullException"> match is null.</exception>
		public int RemoveAll(Predicate<T> match)
		{
			if (RemoveItems != null || RemovedItems != null)
			{
				var enumerable = this.FindAll(match);
				if (RemoveItems != null) RemoveItems(this, enumerable);
				var result = base.RemoveAll(match);
				if (RemovedItems != null) RemovedItems(this, enumerable);
				return result;
			}
			else
			{
				return base.RemoveAll(match);
			}
		}

		///<summary> Removes the element at the specified index of the List. </summary>
		///<param name="index"> The zero-based index of the element to remove.</param>
		///<exception cref="System.ArgumentOutOfRangeException"> index is less than 0. -or- index is equal to or greater than List.Count.</exception>
		public void RemoveAt(int index)
		{
			if (RemoveItems != null) RemoveItems(this, new List<T> { this[index] });
			base.RemoveAt(index);
			if (RemovedItems != null) RemovedItems(this, new List<T> { this[index] });
		}

		///<summary> Removes a range of elements from the List. </summary>
		///<param name="index">The zero-based starting index of the range of elements to remove.</param>
		///<param name="count"> The number of elements to remove. </param>
		///<exception
		///cref="System.ArgumentOutOfRangeException"> index is less than 0. -or- count is less than 0.</exception>
		///<exception cref="System.ArgumentException"> index and count do not denote a valid range of elements in the List. </exception>
		public void RemoveRange(int index, int count)
		{
			if (RemoveItems != null || RemovedItems != null)
			{
				var enumerable = this.GetRange(index, count);
				if (RemoveItems != null) RemoveItems(this, enumerable);
				base.RemoveRange(index, count);
				if (RemovedItems != null) RemovedItems(this, enumerable);
			}
			else
			{
				base.RemoveRange(index, count);
			}
		}

		///<summary> Removes all elements from the List. </summary>
		public void Clear()
		{
			if (RemoveItems != null) RemoveItems(this, this);
			base.Clear();
			if (RemovedItems != null) RemovedItems(this, this);
		}

	}
}
