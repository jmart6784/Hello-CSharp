using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
  class Student
  {
    public string name;
    public string major;
    public double gpa;

    public Student(string aName, string aMajor, double aGpa)
    {
      name = aName;
      major = aMajor;
      gpa = aGpa;
    }

    public bool HasHonors()
    {
      return gpa >= 3.5 ? true : false;
    }
  }
}