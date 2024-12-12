//List<string> myToDo = new List<string>();
//myToDo.Add("walk the dog");
//myToDo.Add("do the dishes");
//myToDo.Add("bake a pie");

//using System.Collections.Generic;

///------------------------------------------
///
//string folderPath = @"C:\Users\rait\Documents\data";
//string fileName = "shoppingList.txt";

//if (File.Exists(Path.Combine(folderPath, fileName)))
//{
//    Console.WriteLine($"File {fileName} exists.");

//}
//else
//{
//    Console.WriteLine($"File {fileName} does not exist.");
//}


//---------------------------------------------------------

static void DisplayDataFromFile(List<string> someList)
{
    foreach (string line in someList)
    {
        Console.WriteLine(line);
    }
}