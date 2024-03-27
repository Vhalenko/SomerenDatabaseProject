using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;
using System;
using System.Linq;

namespace SomerenService
{
    public abstract class BaseService<T>
    {
        protected const int ObjectIdBeforeDb = 0;

        /*Add item*/

        public void AddDrink(List<string> list)
        {
            if (list.Any(x => x == ""))
            {
                throw new Exception("Enter all values!");
            }
            else
            {
                FillItemToAdd(list);
            }
        }

        protected abstract void FillItemToAdd(List<string> list);
    }
}
