using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }


  }
}