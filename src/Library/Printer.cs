//--------------------------------------------------------------------------------
// <copyright file="Printer.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace CrcCards
{
    /// <summary>
    /// Representa una impresora de tickets.
    /// </summary>
    public class Printer
    {
        /// <summary>
        /// Imprime por console el ticket que se recibe como argumento.
        /// </summary>
        /// <param name="ticket">El ticket a imprimir.</param>
        public void PrintTicket(SaleTicket ticket)
        {
            if (ticket != null)
            {
                Console.WriteLine(ticket.GetTicketText());
            }
        }
    }
}