const double kelvinOffset = 273.15;
double celsius = 23.5;
double fahrenheit = celsius * 9 / 5 + 32;
double kelvin = celsius + kelvinOffset;
Console.WriteLine($"{celsius} °C = {fahrenheit} °F = {kelvin} K");