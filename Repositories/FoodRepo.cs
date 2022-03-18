namespace TomasosPizzeria.Repositories
{
	public class FoodRepo : IFoodRepo
	{
		// readonly gör att man bara kan sätta ett värde på variabeln via konstruktorn
		private readonly TomasosDBContext _context;

		public FoodRepo(TomasosDBContext context)
		{
			_context = context;
		}

		public Food GetFood(int id)
		{
			Food food = _context.Foods.SingleOrDefault(p => p.FoodId == id);
									
			return food;
		}

		public string GetFoodName(int id)
		{
			string food = _context.Foods
							.Where(p => p.FoodId == id)
							.Select(n => n.FoodName)
							.SingleOrDefault();

			return food;
		}

        public List<FoodType> GetFoodTypeList()
        {
            List<FoodType> types = _context.FoodTypes.ToList();

            return types;
        }

        public List<Product> GetProductList()
		{
			List<Product> products = _context.Products.ToList();

			return products;
		}

		// Tar fram alla maträtter
		public List<Food> GetFoodComboList()
		{
			List<Food> foodTypeProducts = _context.Foods
										.Include(c => c.FoodTypeNavigation)
										.Include(i => i.Products).ToList();

			return foodTypeProducts;
		}

		// Tar fram maträtter av angiven kategori
		public List<Food> GetFoodComboList(string type)
		{
			List<Food> foodTypeProducts = _context.Foods
										.Include(c => c.FoodTypeNavigation)
										.Include(i => i.Products)
										.Select(sublist => sublist)
										.Where(item => item.FoodTypeNavigation.Description
										.Contains(type)).ToList();

			return foodTypeProducts;
		}

		// Tar fram ordrar lagda av inloggad kund
		public List<Order> GetOrderList(int id)
		{
			
			List<Order> orders = _context.Orders
								.Include(of => of.OrderFoods)
								.Where(c => c.CustomerId == id).ToList();

			return orders;
		} 
    }
}