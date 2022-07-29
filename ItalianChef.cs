using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
  class ItalianChef : Chef
  {
    public void MakeSpaghetti()
    {
      Console.WriteLine("The Chef makes Spaghetti");
    }

    public override void MakeSpecialDish()
    {
      Console.WriteLine("The Chef makes Pizza!!!");
    }
  }
}