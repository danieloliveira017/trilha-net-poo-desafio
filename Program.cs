
using DesafioPOO.Models;
Iphone iphone = new("qwe", "IPhone 18", "qsdr", 135);
Nokia nokia = new("asdf", "Noki 2345", "xcvdfg", 100);

// TODO: Realizar os testes com as classes Nokia e Iphone

var appIphome = new List<string> { "facebook", "instagram", "watsap" };
appIphome.Add("fotoIPhone");
appIphome.Add("MusicaIPhpne");
Console.WriteLine(iphone.Modelo);
iphone.InstalarAplicativo(appIphome);
Console.WriteLine("--------------");

var appNokia = new List<string> { "facebook", "instagram", "watsap" };
appNokia.Add("fotoNokia");
appNokia.Add("MusicNokia");
Console.WriteLine(nokia.Modelo);
nokia.InstalarAplicativo(appNokia);
Console.WriteLine("--------------");