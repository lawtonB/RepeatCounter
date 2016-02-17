using Xunit;
using FindReplace.Objects;
using System;
using System.Collections.Generic;
namespace  FindReplaceTest
{
  public class FindReplaceTester
  {
    [Fact]
    public void IsFindReplace_ForWholeWord_true()
    {
      string input1 = "world";
      string input2 = "world";
      string input3 = "universe";
      FindReplacer newFindReplacer = new FindReplacer(input1, input2, input3);
      Assert.Equal(input3, newFindReplacer.Replace());
    }
  }
}