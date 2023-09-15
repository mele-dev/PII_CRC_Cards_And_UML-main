//--------------------------------------------------------------------------------------
// <copyright file="ProductSpecification.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------

using System;
using System.Collections;

namespace CrcCards;

/// <summary>
/// Representa un producto.
/// </summary>
public class ProductSpecification
{
    /// <summary>
    /// Crea una nueva instancia de la clase ProductoSpecification con los valores que se reciben como argumento.
    /// </summary>
    /// <param name="code">El código del producto.</param>
    /// <param name="description">La descripción del producto.</param>
    /// <param name="price">El precio del producto.</param>
    public ProductSpecification(int code, string description, double price)
    {
        this.Code = code;
        this.Description = description;
        this.Price = price;
    }

    /// <summary>
    /// Obtiene o establece el código del producto.
    /// </summary>
    /// <value>El código del producto.</value>
    public int Code { get; set; }

    /// <summary>
    /// Obtiene o establece la descripción del producto.
    /// </summary>
    /// <value>La descripción del producto.</value>
    public string Description { get; set; }

    /// <summary>
    /// Obtiene o establece el precio del producto.
    /// </summary>
    /// <value>El precio del producto.</value>
    public double Price { get; set; }
}