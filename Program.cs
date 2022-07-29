Console.WriteLine("Введите строку: ");    
string? origStr = Console.ReadLine();

string[] origStrMass = origStr.Split(' ');
string[] findWordsArr = new string[0];

int j = 0;                                 
for (int i = 0; i < origStrMass.Length; i++)  
{
    if (origStrMass[i].Length <= 3)           
    {
        Array.Resize(ref findWordsArr, findWordsArr.Length + 1); 
        findWordsArr[j] = origStrMass[i];                        
        j++;                                                   
    }
}   