using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Module2HW2.Models;

namespace Module2HW2.Services
{
    public static class SearchItemService
    {
        public static Sweets FindFirstByName(this ArrayList present, string name)
        {
            for (var i = 0; i < present.Count; i++)
            {
                var currentPresent = (Sweets)present[i];
                if (currentPresent.Name == name)
                {
                    return currentPresent;
                }
            }

            throw new Exception("There is no needed value");
        }
    }
}