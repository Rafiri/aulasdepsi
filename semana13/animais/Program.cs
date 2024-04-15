using System;

namespace animais
{
    class Program
    {
        static void Main(string[] args)
        {
          animal[] animais = new animal[10];
          Random random = new Random();
          for(int i = 0; i < animais.Length; i++){
            int randomNumber = random.Next(1, 5);
            switch(randomNumber){
              case 1:
                animais[i] = new gato();
                break;
              case 2:
                animais[i] = new cao();
                break;
              case 3:
                animais[i] = new morcego();
                break;
              case 4:
                animais[i] = new abelha();
                break;
            }
            animais[i].Som();
            if(animais[i] is IMamifero)
              Cosole.WriteLine("Numero de mamilos: " + ((IMamifero)animais[i]));
                if(animais[i] is IVoador)
                  Cosole.WriteLine("Numero de asas: " + ((IVoador)animais[i]));
          }
           
        }
    }
}
