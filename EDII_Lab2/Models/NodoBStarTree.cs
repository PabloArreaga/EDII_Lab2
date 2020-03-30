using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDII_Lab2.Models
{
	public class NodoBStarTree<T>
	{
		private int Id;
		private int Father;
		private bool IsLeaf;
		private List<int> Children = new List<int>();
		private List<T> Values = new List<T>();
		public NodoBStarTree(int id, int father, int grade)
		{
			Id = id;
			Father = father;
			if (Id == Father)
			{
				IsLeaf = false;
			}
			else
			{
				IsLeaf = true;
			}
			Children = null;
			Values = null;
			// se penso en hacerlo con listas para que al momento de crear un nodo
			// se ahorre espacio porque el nodo no tendria valores
		}
		
		// si llegas a ver esto, tengo duda de como agregar un valor a una lista tipo T, intente pero me dice que no pude hacer la conversion


	}
}
