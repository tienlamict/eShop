using eShop.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Application.Catalog.Products
{
    public interface IProductServices
    {
        int Create(ProductRequest product);

        int Update(ProductRequest product);

        int Delete(int productId);
    }
}
