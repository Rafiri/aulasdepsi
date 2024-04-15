using System;
namespace animais
  {
  public class cao : Animal, IMamifero
  {
    public int NumeroDeMamilos{get{ return 4;}}
  public override string Som()
  {
  return base.Som() + "ão ão";
  }
  }
  }