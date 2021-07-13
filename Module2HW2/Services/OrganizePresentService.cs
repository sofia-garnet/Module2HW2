using System.Collections;
using Module2HW2.Models;

namespace Module2HW2.Services
{
    public class OrganizePresentService : IOrganizePresentService
    {
        public double CountWeight(ArrayList present)
        {
            var weight = 0.0;
            for (var i = 0; i < present.Count; i++)
            {
                var currentPresent = (Sweets)present[i];
                weight += currentPresent.Weight;
            }

            return weight;
        }
    }
}