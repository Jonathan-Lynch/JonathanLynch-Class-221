using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp2
{
	class ItemRepo
	{
		private ItemContext db;

		public ItemRepo()
		{
			db = new ItemContext();
			db.Database.EnsuredCreated();
		}

		public void Created(ToDoItem )
		{

		}

	}
}
