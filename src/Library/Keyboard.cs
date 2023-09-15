//--------------------------------------------------------------------------------
// <copyright file="Keyboard.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace CrcCards;

/// <summary>
/// Representa el teclado de la caja registradora.
/// </summary>
public class Keyboard
{
    private SaleCoordinator coordinator;

    /// <summary>
    /// Inicializa una nueva instancia de la clase Keyboard con el coordinador de venta que se recibe como argumento. El
    /// teclado enviará eventos a este coordinador de venta cuando se opriman sus teclas.
    /// </summary>
    /// <param name="coordinator">El coordinador de venta.</param>
    public Keyboard(SaleCoordinator coordinator)
    {
        this.coordinator = coordinator;
    }

    /// <summary>
    /// Este evento representa el inicio de una venta que ocurre al oprimir la tecla correspondiente. El evento se
    /// procesa enviándolo al coordinador de la venta.
    /// </summary>
    public void OnSaleStart()
    {
        this.coordinator.StartSale();
    }

    /// <summary>
    /// Este evento representa el final de una venta que ocurre al oprimir la tecla correspondiente. El evento se
    /// procesa enviándolo al coordinador de la venta.
    /// </summary>
    public void OnSaleEnd()
    {
        this.coordinator.EndSale();
    }
}