using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LongestArray.CleanUp
{
  public class AmazonItem
    {
        public string Name;
        public string Category;
    }
    public static class AmazonWorker 
    {
        public static List<AmazonItem> LeaveOnlyMainCategoryItems(List<AmazonItem> items)
        {

            return items.GroupBy(x => x.Category).Select(x => new { x.Key, Count = x.Count(), Items = x }).OrderByDescending(x => x.Count).First().Items.ToList();
        }
        
    }
    public class AmazonWorkerComparer
    {
       public int Compare(string x, string y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    // If x is null and y is null, they're
                    // equal. 
                    return 0;
                }
                else
                {
                    // If x is null and y is not null, y
                    // is greater. 
                    return -1;
                }
            }
            else
            {
                // If x is not null...
                //
                if (y == null)
                // ...and y is null, x is greater.
                {
                    return 1;
                }
                else
                {
                    // ...and y is not null, compare the 
                    // lengths of the two strings.
                    //
                    int retval = x.Length.CompareTo(y.Length);

                    if (retval != 0)
                    {
                        // If the strings are not of equal length,
                        // the longer string is greater.
                        //
                        return retval;
                    }
                    else
                    {
                        // If the strings are of equal length,
                        // sort them with ordinary string comparison.
                        //
                        return x.CompareTo(y);
                    }
                }
            }
        }
    }
}
