using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MCCL7
{
    interface IDBItem<T> where T : IID
    {
        List<T> Items { get; set; }
        void AddItem(T item);
        T FindById(int id);
        bool Delete(T item);
    }
}