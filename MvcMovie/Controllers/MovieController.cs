using System.Diagnostics;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class MovieController : Controller
{

// public string Index()
// {
//   return "Book my show page";
// }

//[ActionName("bk")]
[NonAction]
public string Booking()
{
    return "Booking confirmed for Avatar";
}

[ActionName("confirm")]
//http://localhost:5270/movie/confirm?username=jeni&tickets=5
public string Userconfirm(string username,int tickets=1)
{
    return HtmlEncoder.Default.Encode($"{username} has booked {tickets} tickets for Avatar Movie");
}

public IActionResult Index()
{
    var movielist=from e in GetMovieList()
                  select e;
    ViewBag.movies=movielist;
    return View();
}

public List<Movie> GetMovieList()
{

  return new List<Movie>{

   new Movie{
    MovieId=101,
    MovieName="Avatar",
    NumberOfTickets=5
   },
   new Movie{
    MovieId=102,
    MovieName="Tunivu",
    NumberOfTickets=15
   },
   new Movie{
    MovieId=103,
    MovieName="Varisu",
    NumberOfTickets=10
   },
   new Movie{
    MovieId=104,
    MovieName="Veera simha reddy",
    NumberOfTickets=15
   },


  };

    
}





}