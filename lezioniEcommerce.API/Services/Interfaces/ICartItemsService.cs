﻿using lezioniEcommerce.API.DTO;

namespace lezioniEcommerce.API.Services.Interfaces
{
    public interface ICartItemsService
    {
        Task<List<READ_CART_ITEM_DTO>> GetAllCartItems();
        Task<READ_CART_ITEM_DTO> GetCartItemById(int id);
        Task AddCartItem(int cartId, int productId, int quantity);
        Task UpdateCartItem(WRITE_CART_ITEM_DTO updatedCartItem);
        Task DeleteCartItem(int id);
        Task<READ_CART_ITEM_DTO> GetCartItemByCartIdAndProductId(int cartId, int productId);

    }
}
