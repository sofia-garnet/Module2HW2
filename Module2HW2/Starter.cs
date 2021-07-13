using System;
using System.Collections;
using Module2HW2.Models;
using Module2HW2.Models.FifthLevel;
using Module2HW2.Services;

namespace Module2HW2
{
    public class Starter
    {
        public static void ShowArray(ArrayList present)
        {
            for (var i = 0; i < present.Count; i++)
            {
                var sweet = (Sweets)present[i];
                Console.WriteLine($"Sweet name is: {sweet.Name}");
            }
        }

        public static void Run()
        {
            Candy chocolateCandyOne = new NaturalChocolateCandy1()
            {
                ChocolateQuantity = 5,
                CocoaCoefficient = 5.5,
                Color = "brown ",
                Filling = FillingType.CREAM,
                Name = "Lviv",
                NutsWeight = 7.7,
                Shape = ShapeType.TRIANGLE,
                Weight = 150,
                Unit = MeasurementUnit.GRAM
            };
            Candy chocolateCandyTwo = new NaturalChocolateCandy2()
            {
                ChocolateLayersQuantity = 3,
                ChocolateQuantity = 7.7,
                CocoaCoefficient = 4.4,
                Color = "mixed",
                Filling = FillingType.WITHOUT,
                Shape = ShapeType.STAR,
                Name = "Star Dream",
                Weight = 140,
                Unit = MeasurementUnit.GRAM
            };
            Candy artificialCandyOne = new ArtificialChocolateCandy1()
            {
                ChemicalCoefficient = 3.3,
                ChocolateQuantity = 5.5,
                CoatDensity = 3.3,
                Color = "magenta",
                Filling = FillingType.WITHOUT,
                Name = "Pinky Pin",
                Shape = ShapeType.CIRCLE,
                Unit = MeasurementUnit.GRAM,
                Weight = 6.7
            };
            Candy artificialCandyTwo = new ArtificialChocolateCandy2()
            {
                ChemicalCoefficient = 5.5,
                ChocolateQuantity = 8.9,
                Color = "cyan",
                Filling = FillingType.WITHOUT,
                FortunePrediction = "You will win!",
                Name = "Fortune",
                Shape = ShapeType.SQUARE,
                Unit = MeasurementUnit.GRAM,
                Weight = 11.2
            };

            var present = new ArrayList();
            present.Add(chocolateCandyOne);
            present.Add(chocolateCandyTwo);
            present.Add(artificialCandyOne);
            present.Add(artificialCandyTwo);

            var sis = new SortItemsService();
            ShowArray(present);
            Console.WriteLine();
            sis.SortItems(present);
            ShowArray(present);
            var ops = new OrganizePresentService();
            var totalWeight = ops.CountWeight(present);
            var neededSweet = present.FindFirstByName("Pinky Pin");
            Console.WriteLine($"{Environment.NewLine}{neededSweet.Name}");
            Console.WriteLine($"{Environment.NewLine}Total weight of present is: {totalWeight}");
        }
    }
}