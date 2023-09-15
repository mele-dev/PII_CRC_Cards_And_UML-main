//--------------------------------------------------------------------------------
// <copyright file="TicketLineItem.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------

using System;

namespace CrcCards
{
    /// <summary>
    /// Representa una línea de un ticket de venta.
    /// </summary>
    public class TicketLineItem
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase TicketLineItem con la cantidad y el producto que se reciben como
        /// argumento.
        /// </summary>
        /// <param name="quantity">La cantidad del producto.</param>
        /// <param name="product">El producto.</param>
        public TicketLineItem(double quantity, ProductSpecification product)
        {
            this.Quantity = quantity;
            this.Product = product;
        }

        /// <summary>
        /// Obtiene o establece la cantidad del producto.
        /// </summary>
        /// <value>La cantidad del producto.</value>
        public double Quantity { get; set; }

        /// <summary>
        /// Obtiene o establece el producto.
        /// </summary>
        /// <value>El producto.</value>
        public ProductSpecification Product { get; set; }

        /// <summary>
        /// Obtiene el subtotal de la línea multiplicando la cantidad por el precio del producto.
        /// </summary>
        /// <value>El subtotal de la línea.</value>
        public double SubTotal
        {
            get
            {
                return this.Quantity * this.Product.Price;
            }
        }

        /// <summary>
        /// Obtiene el texto de la linea para imprimir.
        /// </summary>
        /// <returns>El texto de la línea.</returns>
        public string GetLineText()
        {
            return $"{this.Quantity} de '{this.Product.Description}' a ${this.Product.Price}\n";
        }
    }
}