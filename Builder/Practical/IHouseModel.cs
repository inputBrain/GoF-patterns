namespace Builder.Practical
{
    public interface IHouseModel
    {
        int Id { get; }

        string Title { get; }

        string Description { get; }

        int? DoorsCount { get; }

        int? BathroomCount { get; }

        int? KitchenCount { get; }

        int? PictureCount { get; }
    }
}