using System;
using System.Collections.Generic;
using Codecool.CodecoolShop.Models;

namespace Codecool.CodecoolShop.Models;

public class User
{
  private Guid _id;
  private string _name;
  private HashSet<Product> _userCart;
  private string _email;
  private string _password;
  private HashSet<Product> _bougthProducts;

  public void AddProduct(Product product)
  {
    _userCart.Add(product);
  }

  public void RemoveProduct(Product product)
  {
    _userCart.Remove(product);
  }
}