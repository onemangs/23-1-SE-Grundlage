int GetNumber()
{
  int num = 0;
  bool checkParse = false;
  do
  {
    Console.WriteLine("Gebe eine Zahl ein");
    string input = Console.ReadLine();
    checkParse = int.TryParse(input, out num);

    if (checkParse == false)
    {
      Console.WriteLine("Ungültiger Eingabe: Nur Ganzzahlen sind erlaubt");
    }
  } while (checkParse == false);
  return num;
}


Console.WriteLine("Willkommen beim Tascherechner 3000");
var num1 = GetNumber();
var num2 = GetNumber();

var result = num1 + num2;
Console.WriteLine($"{num1} + {num2} = {result}");






//entweder (var), oder (datentyp eg. string, int, float, decimal...) 
//string test1= "buxtehude"; 
//int test2 = 69;
//var test3 = "Buxtehude";
//test3 = 69;
//var int x =420; //"Var" ist nicht kombinierbar mit Datentypenangaben
