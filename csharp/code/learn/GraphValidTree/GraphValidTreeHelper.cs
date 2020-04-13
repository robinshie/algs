using System;
using System.Collections.Generic;
using System.Collections;
namespace GraphValidTree
{
    public static class GraphValidTreeHelper
    {   
        public static bool ValidTree(int n, int[][] eages)
        {
            bool result = false;
            Dictionary<int,HashSet<int>> adjectacelist = BuildAdjectaceList(eages);

            Queue<int> queue  = new Queue<int>();
            HashSet<int> set =new HashSet<int>();

            queue.Enqueue(0);
            set.Add(0);
            while (queue.Count!=0)
            {
                var currentkey = queue.Dequeue();
                if(!adjectacelist.ContainsKey(currentkey))
                {
                    continue;
                }
                foreach (var endpoint in adjectacelist[currentkey])
                {
                    if(set.Contains(endpoint))
                    {
                        continue;
                    }
                    set.Add(endpoint);
                    queue.Enqueue(endpoint);
                }
                
            }
            result = set.Count==n;
            return result;
        }

        private static Dictionary<int, HashSet<int>> BuildAdjectaceList(int[][] eages)
        {
            Dictionary<int, HashSet<int>> result = new Dictionary<int, HashSet<int>>();
            
            int d1= eages.Length;
            for (int i = 0; i < d1; i++)
            {
                var start = eages[i][0];
                if(!result.ContainsKey(start))
                {
                    result.Add(start,new HashSet<int>());
                }
                var end = eages[i][1];
                if(result.ContainsKey(end))
                {
                    continue;
                }
                result[start].Add(end);
            }
            return result;
        }
    }

        
}
