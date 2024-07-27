//Converting to Celcius

int fahrenheit =94;
decimal temperature = ((fahrenheit - 32) * 5m/9);
Console.WriteLine( "The temperature is " + temperature + " degree celcius");

int fahrenheit =94;
decimal temperature = ((fahrenheit - 32m) * 5m/9m);
Console.WriteLine( "The temperature is " + Math.Round(temperature
 ) + " degree celcius");