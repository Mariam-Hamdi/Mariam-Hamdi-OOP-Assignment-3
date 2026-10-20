using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ass_oop3.t3
{
    public interface IHasId
    {
        int Id { get; set; }
    }
    internal class Store<T> where T : class, IHasId
    {
        Dictionary<int, T> Dict = new Dictionary<int, T>();
        public void  Add(T item)
        {
            if(Dict.ContainsKey(item.Id))
            {
                throw new Exception("Course with this ID already exists.");
            }
            Dict.Add(item.Id, item);
        }
        public T GetById(int id)   
        {
            if(Dict.ContainsKey(id))
            {
                return Dict[id];
            }
            return null;
        }
        public IReadOnlyCollection<T> GetAll()
        {
            return Dict.Values;
        }
        public void Remove(int id)
        {
            Dict.Remove(id);
        }
    }
}
