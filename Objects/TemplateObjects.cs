using System;
using System.Collections.Generic;
using System.Linq;
namespace FindReplace.Objects

{

  //variables//

    public class FindReplacer
  {
      private string _input1;
      private string _input2;
      private string _input3;
      private static List<string> _output = new List<string> {};

//constructor//

  public FindReplacer(string input1, string input2, string input3)
   {
     _input1 = input1;
     _input2 = input2;
     _input3 = input3;
     _output.Add(this);
   }


//getters and setters for properties//

      public string GetVariable()
      {
      return _TEMPLATEVARIABLE;
      }

      public void SetVariable(string newVariable)
      {
        _TEMPLATEVARIABLE = newVariable;
      }

  }
}