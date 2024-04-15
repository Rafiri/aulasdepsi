using System;
namespace animais
  {
  public class Gato : Animal, IMamifero
  {
    public int NumeroDeMamilos{get{ return 2;}}
  public override string Som()
  {
  return base.Som() + "Miau";
  }
  }
  }
