using System;

namespace conversortemperatura
{
    
class Program {
  public static int Menu(){
    int op;

        Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n\n\n");
    Console.WriteLine("\t\t\tMenu:\n");
    Console.WriteLine("Escolha a Escala de temperatura para começar");
    Console.WriteLine("1- Celsius para Fahrenheit");
    Console.WriteLine("2- Celsius para Kelvin");
    Console.WriteLine("3- Fahrenheit para Celsius");
    Console.WriteLine("4- Kelvin para Celsius");
    Console.WriteLine("5- Fechar Programa");

    op = Convert.ToInt32(Console.ReadLine());

    return op;
  }
  public static float PerguntaTemperatura(string NomedaEscala){
    
    float temp;

    Console.WriteLine($"Digite a temperatura em {NomedaEscala}");
    temp = float.Parse(Console.ReadLine());
    Console.WriteLine("\n");

    return temp;
  }
  public static float conversionCelsiusToFahrenheit(float TemperaturaCelsius){

    return TemperaturaCelsius * 1.8f + 32;
  }
  public static float conversionCelsiusToKelvin(float TemperaturaCelsius){

    return TemperaturaCelsius +  273.15f;
  }
  public static float conversionFahrenheitToCelsius(float TemperaturaFahrenheit){

    return (TemperaturaFahrenheit - 32)/1.8f;
  }
  public static float conversionKelvinToCelsius(float TemperaturaKelvin){

    return TemperaturaKelvin - 273.15f;
  }

  public static void Main (string[] args) {
    int op;
    float tempC, tempF, tempK;

    

    do{
      
      op = Menu();

      switch(op)
      {
      case 1:
        //C -> F
        
      tempC = PerguntaTemperatura("Celsius");
      tempF = conversionCelsiusToFahrenheit(tempC);
      Console.WriteLine($"{tempC} Celsius = {tempF} Fahrenheit");

       break;

      case 2:
        //C -> K

      tempC = PerguntaTemperatura("Celsius");
      tempK = conversionCelsiusToKelvin(tempC);
      Console.WriteLine($"{tempC} Celsius = {tempK} Kelvin");

        break;

        case 3:
        //F -> C

      tempF = PerguntaTemperatura("Fahrenheit");
      tempC = conversionFahrenheitToCelsius(tempF);
      Console.WriteLine($"{tempF} Fahrenheit = {tempC} Celsius");

        break;

        case 4:
        //K -> C
        
      tempK = PerguntaTemperatura("Kelvin");
      tempC = conversionKelvinToCelsius(tempK);
      Console.WriteLine($"{tempK} Kelvin = {tempC} Celsius");

        break;

        case 5:
        //Fechar o programa
        Console.WriteLine("Programa Finalizado");
        break;

        default:
        Console.WriteLine("Entrada invalida, insira um valor valido");
        break;
      }

    }while(op != 5);
  }
}
}
