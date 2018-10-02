namespace SmbImager.MODEL
{
   public class Progress
   {
      public double Total { get; set; }
      public double Partial { get; set; }
      public double Percentage => Rate * 100;
      public double Rate => Partial / Total;

      public Progress()
      {

      }
      public Progress(double total, double partial)
      {
         Total = total;
         Partial = partial;
      }
   }
}
