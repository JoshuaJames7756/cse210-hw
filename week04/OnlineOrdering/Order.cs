using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalProductsCost = 0;
        foreach (Product product in _products)
        {
            totalProductsCost += product.GetTotalCost();
        }

        // $5 for USA customers, $35 for international
        double shippingCost = _customer.IsInUSA() ? 5.0 : 35.0;
        return totalProductsCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "PACKING LABEL:\n";
        foreach (Product product in _products)
        {
            label += $" - Product: {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"SHIPPING LABEL:\nCustomer: {_customer.GetName()}\nAddress:\n{_customer.GetAddress().GetFullAddress()}\n";
    }
}