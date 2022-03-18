namespace TomasosPizzeria.Repositories
{
    public interface IFoodRepo
    {
        string GetFoodName(int id);

        Food GetFood(int id);

        List<FoodType> GetFoodTypeList();

        List<Product> GetProductList();

        List<Food> GetFoodComboList();

        List<Food> GetFoodComboList(string category);

        List<Order> GetOrderList(int id);          
    }
}
