using Enterprise_E_Commerce_Management_System.Models.CartItems;
using Enterprise_E_Commerce_Management_System.Models.Carts;
using Microsoft.EntityFrameworkCore;

namespace Enterprise_E_Commerce_Management_System.Infrastructures.Carts
{
    public class CartRepository :Repository<Cart> ,ICartRepository
    {
        public CartRepository(CommerceDbContext context) : base(context) { }

        public void DeleteItemsByIds(int CartId, int[] ItemIds)
        {
            var itemArray = new CartItem[] { };
            //Prepare Primary Keys for the items to be deleted
            for (int i=0;i<ItemIds.Length;i++)
            {
                itemArray[i] = new CartItem()
                {
                    CartId = CartId, Id = ItemIds[i]
                };
            }
            foreach (var item in itemArray)
            {
                //Track the item as unchanged
                _context.Attach(item);
                //Mark as deleted
                _context.Entry(item).State = EntityState.Deleted;
            }

        }
         
        public void DeleteItemById(int CartId, int ItemId)
        {
            var item = new CartItem()
            {
                CartId = CartId,
                Id = ItemId
            };
            _context.Attach(item);
            _context.Entry(item).State = EntityState.Deleted;
        }

        public async Task<bool> IsEmpty(int CartId)
        {
            return !await _context.CartItems
                .AnyAsync(c => c.CartId == CartId);
        }

    }
}
