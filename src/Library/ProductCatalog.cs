//--------------------------------------------------------------------------------
// <copyright file="ProductCatalog.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace CrcCards;

/// <summary>
/// Representa el catálogo de productos que se vende.
/// </summary>
public class ProductCatalog
{
    private List<ProductSpecification> products = new List<ProductSpecification>();

    /// <summary>
    /// Agrega un nuevo producto al catálogo.
    /// </summary>
    /// <param name="product">El producto a agregar.</param>
    public void AddProduct(ProductSpecification product)
    {
        this.products.Add(product);
    }

    /// <summary>
    /// Retorna el producto cuyo código coincide con el que se recibe como argumento, o <c>null</c> si no existe
    /// ese producto.
    /// </summary>
    /// <param name="searchCode">El código del producto buscado.</param>
    /// <returns>El producto cuyo código coincide con el que se recibe como argumento, o <c>null</c> si no existe
    /// un producto con ese código.</returns>
    public ProductSpecification FindProduct(int searchCode)
    {
        foreach (ProductSpecification product in this.products)
        {
            if (product.Code == searchCode)
            {
                return product;
            }
        }

        // El símbolo ! luego de null evita el warning del compilador avisando que este método puede retornar null
        return null!;
    }
}