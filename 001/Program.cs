// программа которая из имеющего массива
// строк формирует массив строк, 
//длинна которых меньше либо равна 3м символам.

string[] str = {"hello", "2", "world", ":-)"};
for (int i = 0; i < str.Length; i++)
     Console.Write ("  {1}"  , i, str[i]);
     Console.WriteLine("  =>");
     for (int i = 0; i < str.Length; i++)
    if(str[i].Length <= 3)
      Console.WriteLine (str[i]);
    