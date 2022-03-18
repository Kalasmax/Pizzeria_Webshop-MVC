namespace TomasosPizzeria.ViewModels
{
    public class OrderViewModel
    {
        public string FoodName { get; set; } = null!;

        public int FoodId { get; set; } 

        public int OrderId { get; set; } 

        public int Amount { get; set; } 

        public int Price {  get; set; } 
    }
}
