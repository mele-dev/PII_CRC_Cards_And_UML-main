//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

namespace CrcCards;

/// <summary>
/// El programa principal.
/// </summary>
public static class Program
{
    private static ProductCatalog productCatalog = new ProductCatalog();

    /// <summary>
    /// El punto de entrada al programa principal.
    /// </summary>
    public static void Main()
    {
        PopulateCatalog();

        SaleCoordinator coordinator = new SaleCoordinator(productCatalog);

        coordinator.Keyboard.OnSaleStart();
        coordinator.Scanner.OnBarcodeRead(new BarcodeReading(0, 1.0));
        coordinator.Scanner.OnBarcodeRead(new BarcodeReading(1, 2.0));
        coordinator.Scanner.OnBarcodeRead(new BarcodeReading(2, 3.0));
        coordinator.Keyboard.OnSaleEnd();
    }

    private static void PopulateCatalog()
    {
        productCatalog.AddProduct(new ProductSpecification(0, "Product 1", 100.00));
        productCatalog.AddProduct(new ProductSpecification(1, "Product 2", 200.00));
        productCatalog.AddProduct(new ProductSpecification(2, "Product 3", 300.00));
    }
}