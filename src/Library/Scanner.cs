//--------------------------------------------------------------------------------
// <copyright file="Scanner.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace CrcCards;

/// <summary>
/// Representa un escáner de códigos de barras.
/// </summary>
public class Scanner
{
    private SaleCoordinator coordinator;

    /// <summary>
    /// Inicializa una nueva instancia de la clase Scanner con el coordinador de venta que se recibe como argumento. El
    /// escáner enviará eventos a este coordinador de venta cuando se lean códigos de barras.
    /// </summary>
    /// <param name="coordinator">El coordinador de venta.</param>
    public Scanner(SaleCoordinator coordinator)
    {
        this.coordinator = coordinator;
    }

    /// <summary>
    /// Este evento representa la lectura del código de barras que se recibe como argumento. El evento se procesa
    /// enviándolo al controlador de la venta.
    /// </summary>
    /// <param name="reading">El código de barras leído.</param>
    public void OnBarcodeRead(BarcodeReading reading)
    {
        this.coordinator.BarcodeRead(reading);
    }
}