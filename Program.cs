void PrintArray(string[]array)            
{
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write($"{array[i]} ");  
    }
    Console.WriteLine();
}
Console.WriteLine("Введите строку: ");    
string? origStr = Console.ReadLine();

string[] origStrMass = origStr.Split(' ');
string[] newWordsMass = new string[0];

int j = 0;                                 
for (int i = 0; i < origStrMass.Length; i++)  
{
    if (origStrMass[i].Length <= 3)           
    {
        Array.Resize(ref newWordsMass, newWordsMass.Length + 1); 
        newWordsMass[j] = origStrMass[i];                        
        j++;                                                   
    }
}   
PrintArray(newWordsMass);