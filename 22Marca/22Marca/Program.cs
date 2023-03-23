List<string> daysOfWeek = new List<string>();
daysOfWeek.Add("poniedzialek");
daysOfWeek.Add("wtorek");
daysOfWeek.Add("sroda");
daysOfWeek.Add("czwartek");
daysOfWeek.Add("piatek");
daysOfWeek.Add("sobota");
daysOfWeek.Add("niedziela");

Console.WriteLine(daysOfWeek[2]);
Console.WriteLine(daysOfWeek[3]);
Console.WriteLine("-----------");


for (int i = 0; i < daysOfWeek.Count; i++)
{
    Console.WriteLine(daysOfWeek[i]);
}

   