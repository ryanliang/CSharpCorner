using System;

namespace HelloWorld
{
  public class Bar
  {
    private string _name;

    public Bar(string name)
    {
      _name = name;
    }
    
    public string ToString()
    {
        return $"My bar name is {_name}";
    }
  }
}
