using IOrange.Data;

namespace IOrange.Services
{
    public class ItemService
    {
        private readonly IorangedatabaseContext _context;

        public ItemService(IorangedatabaseContext context)
        {
            _context = context;
        }
        int[] importantDrinks = [1, 2, 3, 4, 12, 13, 14, 21, 22, 
            23, 25, 26, 28, 29, 37, 38, 40, 41, 42, 44, 52, 
            53, 54, 55, 56, 57, 66, 67, 68, 69, 70, 71, 
            84, 85, 86, 87, 90, 91, 92, 93, 109, 110, 
            111, 112, 113, 114, 115, 116, 122];
        public List<Item> GetItems()
        {
            List<Item> items = new List<Item>();
            foreach (var item in _context.Items)
            {
                if(importantDrinks.Contains(item.Iid))
                {
                    items.Add(item);
                }
            }
            return items;
        }
    }
}
