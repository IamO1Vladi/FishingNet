namespace FishingNet
{
    public class Fish
    {

//•FishType: string
//•	Length: double
//•	Weight: double

        public string FishType { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }

        public Fish(string fishType,double lenght,double weight)
        {
            this.FishType = fishType;
            this.Length = lenght;
            this.Weight = weight;
        }

        public override string ToString()
        {
            return $"There is a {FishType}, {Length} cm. long, and {Weight} gr. in weight.";
        }
    }
}
