//--------------------------------------------------------------------------------
// <copyright file="BarcodeReading.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace CrcCards;

/// <summary>
/// Representa la lectura del escáner compuesta por el código del producto leído y la cantidad de ese producto.
/// </summary>
public class BarcodeReading
{
    /// <summary>
    /// Inicializa una nueva instancia de la clase BarcodeReading.
    /// </summary>
    /// <param name="productCode">El valor inicial del código del producto leído.</param>
    /// <param name="quantity">La cantidad inicial del producto leída.</param>
    public BarcodeReading(int productCode, double quantity)
    {
        this.ProductCode = productCode;
        this.Quantity = quantity;
    }

    /// <summary>
    /// Obtiene o establece el código del producto leído.
    /// </summary>
    /// <value>El código del producto leído.</value>
    public int ProductCode { get; set; }

    /// <summary>
    /// Obtiene o establece la cantidad del producto leída.
    /// </summary>
    /// <value>La cantidad del producto leída.</value>
    public double Quantity { get; set; }
}