using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ass_oop3.t3
{
    public static class EnumerableExtensions
    {
        //R1
        public static IEnumerable<T> Page <T>(this IEnumerable<T> source, int pageNumber, int pageSize)
        {
            if (pageNumber < 1) throw new ArgumentOutOfRangeException(nameof(pageNumber), "Page number must be 1 or greater.");
            if (pageSize < 1) throw new ArgumentOutOfRangeException(nameof(pageSize), "Page size must be 1 or greater.");

            int skipCount = (pageNumber - 1) * pageSize;
            int currentIndex = 0;
            int returnedCount = 0;

            foreach (var item in source)
            {
                if (currentIndex >= skipCount)
                {
                    yield return item;
                    returnedCount++;
                    if (returnedCount >= pageSize)
                    {
                        yield break; 
                    }
                }
                currentIndex++;
            }
        }
        //R2
        public static T? FindById<T>(this IEnumerable<T> source, int id) where T : IHasId
        {
            foreach (var item in source)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return default;
        }

        //R3
        public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(this IEnumerable<T> source) where T : IHasId
        {
            var dictionary = new Dictionary<int, T>();
            foreach (var item in source)
            {
                if (!dictionary.ContainsKey(item.Id))
                {
                    dictionary.Add(item.Id, item);
                }
            }
            return dictionary;
        }
    }
}
