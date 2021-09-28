using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public static class Sort
    {
        public static void Bubble(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                for (var k = 0; k < arr.Length - 1; k++)
                {
                    if (arr[k] > arr[k + 1])
                    {
                        var temp = arr[k];
                        arr[k] = arr[k + 1];
                        arr[k + 1] = temp;
                    }
                }
            }
            //throw new NotImplementedException();
        }

    //    public static void Selection(int[] arr)
    //    {
    //        for (var i = 0; i < arr.Length - 1; i++)//5
    //        {
    //            int tempMin = i;
    //            for (int k = i + 1; k < arr.Length; k++)
    //            {
    //                if (arr[k] < arr[tempMin])
    //                {
    //                    tempMin = k;
    //                }
    //                var temp = arr[i];
    //                arr[i] = arr[tempMin];
    //                arr[tempMin] = temp;
    //            }
    //        }

    //    }
    //    //throw new NotImplementedException();
    //}

    public static void Insertion(int[] arr)//INSERTION
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int k = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > k)//elements >k to +1 position
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = k;
            }

            throw new NotImplementedException();
        }

        //public static int[] Selection(int[] arr)//changed void to int MERGEPOINT
        //{
        //    if (arr.Length <= 1) return arr;
        //    decimal midpoint = arr.Length / 2;
        //    var mid = Convert.ToInt32(Math.Ceiling(midpoint));

        //    var bot = arr.Take(mid).ToArray();
        //    var top = arr.Skip(mid).ToArray();

        //    var botOut = Selection(bot);//cahnge to MergeSort
        //    var topOut = Selection(top);

        //    var combined = Combine(botOut, topOut);
        //    return combined;      

        //}
        //private static int[] Combine(int[] bottom, int[] top)
        //{
        //    var i = 0;
        //    var j = 0;
        //    var k = 0;
        //    var arr = new int[bottom.Length + top.Length];

        //    while(i<bottom.Length && j < top.Length)
        //    {
        //        if(bottom[i] < top[j])
        //        {
        //            arr[k] = bottom[i];
        //            i++;
        //        }
        //        else
        //        {
        //            arr[k] = top[j];
        //            j++;
        //        }
        //        k++;
        //    }
        //    while(i < bottom.Length)
        //    {
        //        arr[k] = bottom[i];
        //        i++;
        //        k++;
        //    }
        //    while(j < top.Length)
        //    {
        //        arr[k] = top[j];
        //        j++;
        //        k++;
        //    }

        //    return arr;
        //}
    }
}












