namespace Builder.Practical
{
    public class HouseBuilder : IHouseBuilder
    {
        private IHouseBuilder _house = new HouseModel();


        private void ResetModel()
        {
            _house = new HouseModel();
        }


        public HouseBuilder()
        {
            ResetModel();
        }


        public void SetDoorsCount(int count)
        {
            _house.SetDoorsCount(count);
        }


        public void SetBathroomCount(int count)
        {
            _house.SetBathroomCount(count);
        }


        public void SetKitchenCount(int count)
        {
            _house.SetKitchenCount(count);
        }


        public void SetPictureCount(int count)
        {
            _house.SetPictureCount(count);
        }


        public HouseModel GetHouse()
        {
            var result = _house;
            ResetModel();

            return (HouseModel) result;
        }
    }
}