using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MCCL7
{
    class DBItem<T> : IDBItem<T> where T : IID
    {
        int counter = 1;    
        public List<T> Items { get; set; }
        public DBItem()
        {
            Items = new List<T>();
        }
        public void AddItem(T item)
        {
            item.Id = counter++;
            Items.Add(item);
        }
        public T FindById(int id)
        {
            T result = default(T);
            foreach (T item in Items)
            {
                if (item.Id == id)
                {
                    result = item;
                    break;
                }
            }
            return result;
        }
        public bool Delete(T item)
        {
            bool result = false;
            result = Items.Remove(item);
            return result;
        }
    }
}