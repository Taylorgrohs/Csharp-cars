using System;
using System.Collections.Generic;

namespace Carlist.Objects
{
  public class Cars
  {
    private int Year{ get; set; }
    private string Make{ get; set; }
    private string Model{ get; set; }
    private int Price{ get; set; }
    private int Miles{ get; set; }
    public static List<Cars> CarsList = new List<Cars>{};

    public Cars (int year, string make, string model, int price, int miles)
    {
      Year = year;
      Make= make;
      Model = model;
      Price = price;
      Miles = miles;
    }

    public int getYear()
    {
      return Year;
    }
    public string getMake()
    {
      return Make;
    }
    public string getModel()
    {
      return Model;
    }
    public int getPrice()
    {
      return Price;
    }
    public int getMiles()
    {
      return Miles;
    }

    public void AddCars(Cars newCar)
    {
      CarsList.Add(newCar);
    }

    public static List<Cars> ViewCars()
    {
      return CarsList;
    }
  }
}
