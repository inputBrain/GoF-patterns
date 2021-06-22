namespace Builder.Practical
{
    public interface IHouseBuilder
    {
        void SetDoorsCount(int count);

        void SetBathroomCount(int count);

        void SetKitchenCount(int count);

        void SetPictureCount(int count);
    }
}