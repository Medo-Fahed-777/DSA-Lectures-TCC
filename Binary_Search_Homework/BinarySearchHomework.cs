using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: write code for the ternary search algorithm and return the index of the element
            if (start > end)
            {
                return -1;
            }

            int mid1 = (start + end) / 3;
            int mid2 = (2 * start + end) / 3;

            if (arr[mid1] == key)
            {
                return mid1;
            }
            else if (arr[mid2] == key)
            {
                return mid2;
            }
            else if (key < arr[mid1])
            {
                return TernarySearch(arr, key, start, mid1 - 1);
            }
            else if (key > arr[mid2])
            {
                return TernarySearch(arr, key, mid2 + 1, end);
            }
            else
            {
                return TernarySearch(arr, key, mid1 + 1, mid2 - 1);
            }
            
        }

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: this methods is for getting the first accurence of the key and the last accurance
            return -1;
        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            //TODO: write code to calculate the repeat count of a spacific element
            int count = 0;
            foreach (int item in arr)
            {
                if (item == key)
                {
                    count++;
                }
            }
            return count;
            // make sure to use the previous method in this method
            
        }
    }
}
