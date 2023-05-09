using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeArraylist
{
    public class ArrayClass
    {
        public void ArrayListPracticeDemo()
        {
            ArrayList arrayList = new ArrayList();
            //Add
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add(5);
            arrayList.Add("Mansi");
            //Insert
            arrayList.Insert(0, 58);
            arrayList.Insert(1, "Mohan");
            //Remove
            arrayList.Remove(1);
            //RemoveAt
            arrayList.RemoveAt(1);
            //RemoveRange
            arrayList.RemoveRange(0, 2);
            int count = arrayList.Count;
            //Foreach loop
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
            //For Loop
            for (var i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
        }
    }
}
