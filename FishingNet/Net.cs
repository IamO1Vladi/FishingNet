using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {

//        •	Material: string
//•	Capacity: int

        public string Material { get; set; }
        public int Capacity { get; set; }
        public List<Fish> Fish { get; set; }

        public Net(string material,int capacity)
        {
            this.Material = material;
            this.Capacity = capacity;
            Fish = new List<Fish>();
                
        }

        public int Count => Fish.Count;

        public string AddFish(Fish fish)
        {
            if(fish.FishType==null || fish.FishType==" ")
            {
                return "Invalid fish.";
            }
            else if(fish.Weight<=0 || fish.Length <= 0)
            {
                return "Invalid fish.";
            }
            else if (Count == Capacity)
            {
                return "Fishing net is full.";
            }
            else
            {
                Fish.Add(fish);
                return $"Successfully added {fish.FishType} to the fishing net.";
            }
        }


        public bool ReleaseFish(double weight)
        {
            if (Fish.Any(x => x.Weight == weight))
            {
                Fish fistToRemove = Fish.First(x => x.Weight == weight);
                Fish.Remove(fistToRemove);
                return true;
            }
            else
            {
                return false;
            }
        }


        public Fish GetFish(string fishType)
        {
            return Fish.FirstOrDefault(x => x.FishType == fishType);
        }

        public Fish GetBiggestFish()
        {
            double biggestFish = Fish.Max(x => x.Length);

            return Fish.First(x => x.Length == biggestFish);
        }

        public string Report()
        {
            Fish = Fish.OrderByDescending(x => x.Length).ToList();

            StringBuilder output = new StringBuilder();

            output.AppendLine($"Into the {Material}:");

            foreach (var fishes in Fish)
            {
                output.AppendLine(fishes.ToString().TrimEnd());
            }

            return output.ToString().TrimEnd();
        }
    }
}
