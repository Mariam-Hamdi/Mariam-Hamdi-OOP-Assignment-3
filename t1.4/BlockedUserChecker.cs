using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
namespace Task1_ass_oop3.t1._4
{
    public static class BlockedUserChecker
    {
        public static int CountBlocked(HashSet<int> blockedIds, int[] requestIds)
        {
            var blocked = 0;
            foreach (var id in requestIds)
            {
                if (blockedIds.Contains(id))
                    blocked++;
            }
            return blocked;
        }

        public static HashSet<int> BuildBlockedIds(int count)
        {
            var list = new HashSet<int>(count);
            for (var i = 0; i < count; i++)
                list.Add(i);
            return list;
        }

        public static int[] BuildRequestIds(int count, int maxId, int seed = 42)
        {
            var rnd = new Random(seed);
            var ids = new int[count];
            for (var i = 0; i < count; i++)
                ids[i] = rnd.Next(maxId);
            return ids;
        }

        public static long MeasureMs(HashSet<int> blockedIds, int[] requestIds, out int found)
        {
            var sw = Stopwatch.StartNew();
            found = CountBlocked(blockedIds, requestIds);
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }
    }
}
