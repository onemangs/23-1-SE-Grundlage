Console.WriteLine("Schleifen-Demo");
int itercount = 10;
while(itercount > 0)
{
  Console.WriteLine("MEEP");
  itercount = itercount - 1;
  //itercount--;
  //--itercount; !! Achtung: Nicht das gleiche 
}
itercount = 10;
do
{
  Console.WriteLine("DO - WHILE");
  itercount--;

  
} while (itercount > 0);

Console.WriteLine("FOR LOOP");
for (int i = 0; i < 10; i++)
{
  Console.WriteLine("FOR") ;
}