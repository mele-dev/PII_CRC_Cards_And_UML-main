//----------------------------------------------------------------------------
// <copyright file="SaleTicket.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//----------------------------------------------------------------------------

using System.Collections;
using System.Globalization;
using System.Text;

namespace CrcCards;

/// <summary>
/// Representa un ticket de venta.
/// </summary>
public class SaleTicket
{
    private ArrayList lineItems = new ArrayList();

    /// <summary>
    /// Obtiene o establece la fecha de la venta.
    /// </summary>
    /// <value>La fecha de la venta.</value>
    public DateTime DateTime { get; set; }

    /// <summary>
    /// Obtiene el total del ticket que se calcula como la suma del precio del producto multiplicado por la cantidad de
    /// ese producto para todas las líneas del ticket de venta.
    /// </summary>
    /// <returns>El total del ticket.</returns>
    public double GetTotal()
    {
        double result = 0;
        foreach (TicketLineItem item in this.lineItems)
        {
            result = result + item.SubTotal;
        }

        return result;
    }

    /// <summary>
    /// Agrega al ticket la línea que se recibe como argumento.
    /// </summary>
    /// <param name="item">La línea a agregar.</param>
    public void AddLineItem(TicketLineItem item)
    {
        this.lineItems.Add(item);
    }

    /// <summary>
    /// Quita del ticket la línea que se recibe como argumento.
    /// </summary>
    /// <param name="item">La línea a remover.</param>
    public void RemoveLineItem(TicketLineItem item)
    {
        this.lineItems.Remove(item);
    }

    /// <summary>
    /// Retorna el texto del ticket a imprimir.
    /// </summary>
    /// <returns>El texto del ticket a imprimir.</returns>
    public string GetTicketText()
    {
        StringBuilder text = new StringBuilder($"Fecha: {this.DateTime}\n");
        foreach (TicketLineItem item in this.lineItems)
        {
            text.Append(item.GetLineText());
        }

        text.Append($"Total: ${this.GetTotal()}");
        return text.ToString();
    }
}