
Console.WriteLine("Program do obliczania ilości cyfr w dowolnej liczbie.");

int number = 13141617;

Console.WriteLine(number);

string numberInstring = number.ToString();

char[] letters = numberInstring.ToCharArray();

int b0 = 0;
for (int a = 0; a < letters.Length; a++)
{
    if (letters[a] == '0')
    {
        b0 = b0 + 1;
    }

}

int b1 = 0;
for (int a = 0; a < letters.Length; a++) 
{
    if (letters[a] == '1')
    {
        b1 = b1 + 1;
    }
   
}


int b2 = 0;
for (int a = 0; a < letters.Length; a++)
{
    if (letters[a] == '2')
    {
        b2 = b2 + 1;
    }

}

int b3 = 0;
for (int a = 0; a < letters.Length; a++)
{
    if (letters[a] == '3')
    {
        b3 = b3 + 1;
    }

}

int b4 = 0;
for (int a = 0; a < letters.Length; a++)
{
    if (letters[a] == '4')
    {
        b4 = b4 + 1;
    }

}

int b5 = 0;
for (int a = 0; a < letters.Length; a++)
{
    if (letters[a] == '5')
    {
        b5 = b5 + 1;
    }

}

int b6 = 0;
for (int a = 0; a < letters.Length; a++)
{
    if (letters[a] == '6')
    {
        b6 = b6 + 1;
    }

}

int b7 = 0;
for (int a = 0; a < letters.Length; a++)
{
    if (letters[a] == '7')
    { 
        b7 = b7 + 1;
    }

}

int b8 = 0;
for (int a = 0; a < letters.Length; a++)
{
    if (letters[a] == '8')
    {
        b8 = b8 + 1;
    }

}

int b9 = 0;
for (int a = 0; a < letters.Length; a++)
{
    if (letters[a] == '9')
    {
        b9 = b9 + 1;
    }

}

Console.WriteLine("Cyfra 0 ==>" + b0);
Console.WriteLine("Cyfra 1 ==>" + b1);
Console.WriteLine("Cyfra 2 ==>" + b2);
Console.WriteLine("Cyfra 3 ==>" + b3);
Console.WriteLine("Cyfra 4 ==>" + b4);
Console.WriteLine("Cyfra 5 ==>" + b5);
Console.WriteLine("Cyfra 6 ==>" + b6);
Console.WriteLine("Cyfra 7 ==>" + b7);
Console.WriteLine("Cyfra 8 ==>" + b8);
Console.WriteLine("Cyfra 9 ==>" + b9);

