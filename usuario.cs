using System;

class perfil{

  public static void Login(){
    string nome;
    //senha = abcd
    string senha;
    string op;
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("Digite seu nome, enfermeiro");
    Console.SetCursorPosition(0, Console.CursorTop + 1);
    Console.ResetColor();
    nome = Console.ReadLine();
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("Digite sua senha");
    Console.SetCursorPosition(0, Console.CursorTop + 1);
    Console.ResetColor();
    senha = Console.ReadLine();
    if(senha=="abcd"){
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Login bem sucedido, SEJA BEM VINDO"+" "+ nome+"!");
      Console.ResetColor();
    }
    while(senha!="abcd"){
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("SENHA INCORRETA!");     
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("Deseja colocar a senha novamente? S - N");
      Console.SetCursorPosition(0, Console.CursorTop + 1);
      op = Console.ReadLine();
      Console.Clear();
      if(op == "N"+"n"){
        break;
      }
      else{
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Digite sua senha");
        Console.SetCursorPosition(0, Console.CursorTop + 1);
        Console.ResetColor();
        senha = Console.ReadLine();
        if(senha=="abcd"){
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Login bem sucedido, SEJA BEM VINDO"+" "+ nome +"!");
      Console.ResetColor();
      Console.Clear();

        }
      }
    }
  }
}