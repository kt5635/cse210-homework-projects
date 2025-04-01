using System;
using System.Collections.Generic;

public class Order 
{
    private List<Product> _productOrder = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _productOrder.Add(product);
    }

    public string ShippingLabel()
    {
        return _customer.GetShippingLabel();

    }
    public string PackingLabel()
    {

        string packingDetails = "Packing List:\n";
        foreach (var product in _productOrder)
        {
            packingDetails += $"- {product.GetPackingLabel()}\n";
        }
        return packingDetails;
    }
    public int ShippingCost()
    {
        return _customer.IsBasedInUSA() ? 15 : 35;

    }
    public double TotalPrice()
    {
        double totalCost = 0;
        foreach (var product in _productOrder)
        {
            totalCost += product.TotalProductCost();
        }
        return totalCost + ShippingCost();
    }

}