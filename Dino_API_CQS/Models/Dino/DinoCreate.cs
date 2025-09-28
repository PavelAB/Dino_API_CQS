namespace Dino_API_CQS.Models.Dino
{
    public class DinoCreate
    {
        public DinoCreate(string spece, double weight, double size)
        {
            Spece = spece;
            Weight = weight;
            Size = size;
        }

        public string Spece { get; set; }
        public double Weight { get; set; }
        public double Size { get; set; }
    }
}
