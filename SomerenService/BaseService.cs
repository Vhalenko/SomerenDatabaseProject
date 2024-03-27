using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Reflection;

namespace SomerenService
{
    public abstract class BaseService<T>
    {
        /*Update student*/

        protected T CheckForUpdates<T>(T newItem, T item)
        {
            PropertyInfo[] objectProperties = typeof(T).GetProperties();

            foreach (PropertyInfo property in objectProperties)
            {
                object newValue = property.GetValue(newItem);

                if (newValue != null)
                {
                    property.SetValue(item, newValue);
                }
            }

            return item;
        }
    }
}
