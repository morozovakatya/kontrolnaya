// программа которая из имеющего массива
// строк формирует массив строк, 
//длинна которых меньше либо равна 3м символам.

string[] str = {"hello", "2", "world", ":-)"};
for (int i = 0; i < str.Length; i++)
     Console.WriteLine("AS[{0}] = {1}", i, str[i]);
     for (int i = 0; i < str.Length; i++)
    {if(str[i].Length <= 3)
      Console.WriteLine (str[i]);
    }
