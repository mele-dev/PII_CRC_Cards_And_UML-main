//--------------------------------------------------------------------------------
// <copyright file="CashRegister.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace CrcCards;

/// <summary>
/// Representa una caja registradora.
/// </summary>
public class CashRegister
{
    private Printer printer = new Printer();

    private ProductCatalog productCatalog;

    // El símbolo ? luego del tipo SaleTicket indica que este tipo puede tener valores nulos; es necesario comprobar que
    // la variable de instancia ticket no es null antes de usarla.
    private SaleTicket? ticket;

    /// <summary>
    /// Inicializa una nueva instancia de la clase CashRegister con el catálogo de producto que se recibe como argumento.
    /// </summary>
    /// <param name="productCatalog">El catálogo de productos a usar.</param>
    public CashRegister(ProductCatalog productCatalog)
    {
        this.productCatalog = productCatalog;
    }

    /// <summary>
    /// Comienza una venta.
    /// </summary>
    public void StartSale()
    {
        this.ticket = new SaleTicket();
        this.ticket.DateTime = DateTime.Now;
    }

    /// <summary>
    /// Termina la venta en curso.
    /// </summary>
    public void EndSale()
    {
        this.PrintTicket();
    }

    /// <summary>
    /// Imprime el ticket de la venta en curso.
    /// </summary>
    public void PrintTicket()
    {
        if (this.ticket != null)
        {
            this.printer.PrintTicket(this.ticket);
        }
    }

    /// <summary>
    /// Procesa la lectura de un código de barras.
    /// </summary>
    /// <param name="reading">El código de barras leído.</param>
    public void BarcodeRead(BarcodeReading reading)
    {
        if (reading != null)
        {
            ProductSpecification product = this.productCatalog.FindProduct(reading.ProductCode);
            if (this.ticket != null && product != null)
            {
                TicketLineItem lineItem = new TicketLineItem(reading.Quantity, product);
                this.ticket.AddLineItem(lineItem);
            }
        }
    }
}