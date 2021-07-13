using System;
using System.Collections;
using System.Collections.Generic;
using Module2HW2.Models;

namespace Module2HW2.Services
{
    public class SortItemsService : IComparer
    {
        public void SortItems(ArrayList present)
        {
            present.Sort(this);
        }

        public int Compare(object x, object y)
        {
            var sweetOne = (Sweets)x;
            var sweetTwo = (Sweets)y;
            return sweetOne.Name.CompareTo(sweetTwo.Name);
        }
    }
}