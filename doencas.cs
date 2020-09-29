using System;

public class doencas{
  
  private int NumCasosCancer;
  private int NumCasosAids; 
  private int NumCasosCoronaVirus;
  private int NumCasosDiabetes;
  

  public void cancer(){
    //Perguntando ao Usuario, os dados do dia sobre a respectiva doenca.
    Console.WriteLine("Digite a Quantidade de casos de cancer atendido no dia de hoje");
    NumCasosCancer = int.Parse(Console.ReadLine());
    Console.SetCursorPosition(0, Console.CursorTop - 1);
    //Utilizar os dados passado pelo Usuario e agragar a variavel cancer! 
    if(NumCasosCancer > 0){
      //Mostrar ao Usuario a Quantidade de casos!
      Console.WriteLine("Quantidade de casos"+" "+ NumCasosCancer +" "+"de Cancer.");
    }
    else{
      Console.WriteLine("Não foi atendido ninguem com cancer no dia de hoje!");
    } 
  } 
  public void aids(){     
    //Perguntando ao Usuario, os dados do dia sobre a respectiva doenca.
    Console.WriteLine("Digite a Quantidade de casos de aids atendido no dia de hoje ");
    NumCasosAids = int.Parse(Console.ReadLine());
    Console.SetCursorPosition(0, Console.CursorTop - 1);
    //Utilizar os dados passado pelo Usuario e agragar a variavel cancer! 
    if(NumCasosAids > 0){
    //Mostrar ao Usuario a Quantidade de casos!
    Console.WriteLine("Quantidade de casos"+" "+ NumCasosAids +" "+"de Aids."); 
    }
    else{
      Console.WriteLine("Não foi atendido ninguem com aids no dia de hoje!");
    } 
  }  
  public void coronavirus(){
    //Perguntando ao Usuario, os dados do dia sobre a respectiva doenca.
    Console.WriteLine("Digite a Quantidade de casos de Corona virus atendido no dia de hoje ");
    NumCasosCoronaVirus = int.Parse(Console.ReadLine());
    Console.SetCursorPosition(0, Console.CursorTop - 1);
    //Utilizar os dados passado pelo Usuario e agragar a variavel cancer! 
    if(NumCasosCoronaVirus > 0){
      //Mostrar ao Usuario a Quantidade de casos!
      Console.WriteLine("Quantidade de casos"+" "+ NumCasosCoronaVirus +" "+"de Corona Virus.");  
    }
    else{
      Console.WriteLine("Não foi atendido ninguem com Corona virus no dia de hoje!");
    }    
  }
  public void diabetes(){
    //Perguntando ao Usuario, os dados do dia sobre a respectiva doenca.
    Console.WriteLine("Digite a Quantidade de casos de diabetes atendido no dia de hoje");
    NumCasosDiabetes = int.Parse(Console.ReadLine());
    Console.SetCursorPosition(0, Console.CursorTop - 1);
    //Utilizar os dados passado pelo Usuario e agragar a variavel cancer! 
    if(NumCasosDiabetes > 0){
      //Mostrar ao Usuario a Quantidade de casos!
      Console.WriteLine("Quantidade de casos"+" "+ NumCasosDiabetes +" "+"de Diabetes."); 
    }
    else{
      Console.WriteLine("Não foi atendido ninguem com diabetes no dia de hoje!");
    }
  } 
}