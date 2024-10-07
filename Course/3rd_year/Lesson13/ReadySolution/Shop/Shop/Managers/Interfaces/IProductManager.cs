﻿using Shop.Models;

namespace Shop.Managers.Interfaces;

public interface IProductManager
{
    public Task<List<Product>> GetAllProductsAsync();
    public Task<Product> GetProductByIdAsync(int id);
    public Task AddProductAsync(Product product);
    public Task UpdateProductAsync(Product product);
    public Task DeleteProductAsync(int id);
}