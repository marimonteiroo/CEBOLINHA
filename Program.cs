string fraseDigitada, fraseComDislalia;
 
Console.Write("escreva uma frase: ");
fraseDigitada = Console.ReadLine()! 
.Replace("r", "l")
    .Replace("R", "L");
fraseComDislalia = fraseDigitada;
   
 Console.WriteLine("\n");
Console.WriteLine(fraseComDislalia);