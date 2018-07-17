using SmbShaper.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			TrackeableList<int> sh = new TrackeableList<int>();
			sh.Add(2);
			sh.AddRange(new int[] { 1, 2, 3 });
			sh.Insert(1, 2);
			sh.InsertRange(1, new int[] { 1, 2, 3 });
			sh.Clear();
			sh.Add(2);
			sh.AddRange(new int[] { 1, 2, 3 });
			sh.Insert(1, 2);
			sh.InsertRange(1, new int[] { 1, 2, 3 });
			sh.Remove(1);
			sh.RemoveAll((x) => x == 2);
			sh.Add(2);
			sh.AddRange(new int[] { 1, 2, 3 });
			sh.Insert(1, 2);
			sh.InsertRange(1, new int[] { 1, 2, 3 });
			sh.RemoveAt(1);
			sh.RemoveRange(1, 2);

		}

		public static string IEnumerableToString<T>(IEnumerable<T> lista)
		{
			StringBuilder sb = new StringBuilder();
			foreach (var item in lista)
			{
				sb.AppendLine(item.ToString());
			}
			return sb.ToString();
		}
	}
}
