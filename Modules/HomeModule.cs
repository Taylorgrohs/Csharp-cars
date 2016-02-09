using Nancy;
using Carlist.Objects;
using System.Collections.Generic;

namespace CarDealer
{
  public class HomeModule : NancyModule
{
    public HomeModule()
    {
      Get["/"] = _ => View["/add_new_car.cshtml"];
      Get["/view_all_cars"] = _ =>
      {
        List<Cars> car = Cars.ViewCars();
        return View["view_all_cars.cshtml", car];
      };
      Post["/car_added"] = _ =>
      {
        int carYear;
         int.TryParse(Request.Form["new-year"], out carYear);
        string carMake = Request.Form["new-make"];
        string carModel = Request.Form["new-model"];
        int carPrice;
          int.TryParse(Request.Form["new-price"], out carPrice);
        int carMiles;
          int.TryParse(Request.Form["new-miles"], out carMiles);

          Cars newCar = new Cars(carYear, carMake, carModel, carPrice, carMiles);
          newCar.AddCars();
          return View["/car_added.cshtml", newCar];
      };
      Post["/cars_cleared"] = _ => {
        Cars.DeleteAll();
        return View["cars_cleared.cshtml"];
      };
    }
  }
}
