using System;
namespace animais
  {
  public class abelha : Animal, IVoador
  {
    public int NumeroDeAsas{get{ return 6;}}
  public override string Som()
  {
  return base.Som() + "zzzzzzzzzzzzz";
  }
  }
  }