using System;

namespace Builder.Practical
{
    public class HouseModel : IHouseModel, IHouseBuilder
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int? DoorsCount { get; set; }

        public int? BathroomCount { get; set; }

        public int? KitchenCount { get; set; }

        public int? PictureCount { get; set; }


        public void SetDoorsCount(int count)
        {
            DoorsCount = count;
            Console.WriteLine($"The house contains {DoorsCount} doors.");
        }
        public void SetBathroomCount(int count)
        {
            BathroomCount = count;
            Console.WriteLine($"The house contains {BathroomCount} bathrooms.");
        }
        public void SetKitchenCount(int count)
        {
            KitchenCount = count;
            Console.WriteLine($"The house contains {KitchenCount} kitchens.");
        }
        public void SetPictureCount(int count)
        {
            PictureCount = count;
            Console.WriteLine($"The house contains {PictureCount} pictures.");
        }
    }
}