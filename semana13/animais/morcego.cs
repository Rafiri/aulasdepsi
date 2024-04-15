using System;
namespace animais
  {
  public class morcego : Animal, IVoador, IMamifero
  {
    public int NumeroDeAsas{get{ return 2;}}
    public int NumeroDeMamilos{get{ return 2;}}
  public override string Som()
  {
  return base.Som() + 	"ti ti ti ti ti";
  }
  }
  }