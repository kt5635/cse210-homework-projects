using System;
public class Product {
   private string _productName;
   private int _productID;
   private int _productPrice;
   private int _quantity;

   public Product(string name, int id, int price, int quantity)
   {
    name = _productName;
    id = _productID;
    price = _productPrice;
    quantity = _quantity;
   }

   public double TotalProductCost()
   {
     return _productPrice * _quantity;
   }
}