using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01
{
    internal class Reverse<T> where T : IComparable<T>, IEquatable<T>
    {

        public void ReverseArray(ArrayList arrayList)
        {
            if (arrayList is null || arrayList.Count <= 1) return;

            int leftElement = 0;
            int rightElement = arrayList.Count - 1;

            while (leftElement < rightElement)
            {
                if (arrayList[leftElement] is T && arrayList[rightElement] is T)
                {
                    T temp = (T)arrayList[leftElement]!;
                    arrayList[leftElement] = arrayList[rightElement];
                    arrayList[rightElement] = temp;


                    leftElement++;
                    rightElement--;
                }
                else
                {
                    throw new InvalidOperationException("ArrayList contains incompatible types.");
                }
            }
        }
    }
}
