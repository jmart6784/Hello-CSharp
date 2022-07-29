using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
  class Moive
  {
    public string title;
    public string director;
    private string rating;

    public Moive(string aTitle, string aDirector, string aRating)
    {
      title = aTitle;
      director = aDirector;
      Rating = aRating;
    }

    public string Rating
    {
      get { return rating; }
      set
      {
        if (value == "PG" || value == "PG-13" || value == "R")
        {
          rating = value;
        }
        else
        {
          rating = "NR";
        }
      }
    }

    public string Director
    {
      get { return director; }
      set { director = value; }
    }
  }
}