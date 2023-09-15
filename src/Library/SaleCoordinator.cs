//--------------------------------------------------------------------------------
// <copyright file="SaleCoordinator.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace CrcCards;

/// <summary>
/// Representa el coordinador de una venta. El coordinador recibe eventos desde el teclado o el escáner y los envía a la
/// caja registradora.
/// </summary>
public class SaleCoordinator
{
    private CashRegister cashRegister;

    /// <summary>
    /// Inicializa una nueva instancia de la clase CashRegister creando su teclado y su escáner.
    /// </summary>
    /// <param name="productCatalog">El catálogo de productos.</param>
    public SaleCoordinator(ProductCatalog productCatalog)
    {
        this.Keyboard = new Keyboard(this);
        this.Scanner = new Scanner(this);
        this.cashRegister = new CashRegister(productCatalog);
    }

    /// <summary>
    /// Obtiene el teclado. El teclado puede ser usado para iniciar o terminar una venta.
    /// </summary>
    /// <value>El teclado.</value>
    public Keyboard Keyboard { get; }

    /// <summary>
    /// Obtiene el escáner de códigos de barra. El escáner puede ser usado para agregar productos al ticket de venta.
    /// </summary>
    /// <value>El escáner.</value>
    public Scanner Scanner { get; }

    /// <summary>
    /// Inicia una venta.
    /// </summary>
    public void StartSale()
    {
        this.cashRegister.StartSale();
    }

    /// <summary>
    /// Termina una venta.
    /// </summary>
    public void EndSale()
    {
        this.cashRegister.EndSale();
    }

    /// <summary>
    /// Responde al evento de una nueva lectura de un código de barras.
    /// </summary>
    /// <param name="reading">El código de barras leído.</param>
    public void BarcodeRead(BarcodeReading reading)
    {
        this.cashRegister.BarcodeRead(reading);
    }
}