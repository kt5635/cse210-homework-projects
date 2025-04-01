using System;
using System.Collections.Generic;

public class Product {
   private string _productName;
   private int _productID;
   private int _productPrice;
   private int _quantity;
   
   public Product(string name, int id, int price, int quantity)
   {
        _productName = name;
        _productID = id;
        _productPrice = price;
        _quantity = quantity;
   }

   public double TotalProductCost()
   {
     return _productPrice * _quantity;
   }

   public string GetPackingLabel()
   {
    return $"{_productName} (ID: {_productID})";
   }
}