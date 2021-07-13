namespace Module2HW2.Models
{
     public abstract class Sweets
     {
         public double Weight { get; set; }
         public string Name { get; set; }
         public string Color { get; set; }
         public ShapeType Shape { get; set; }

         public MeasurementUnit Unit { get; set; }
     }
}