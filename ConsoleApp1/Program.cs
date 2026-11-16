
#region Q1 
//string title = "clean code";
//string UpperTitle = title.ToUpper();
//Console.WriteLine(title);
//Console.WriteLine(UpperTitle);
#endregion
#region Q2
//string title01 = "clean code";
//string title02 = "clean code";
//Console.WriteLine(ReferenceEquals(title01, title02));
#endregion
#region Q3 , Q4
//using System.Text;
//StringBuilder sb = new StringBuilder("");
//sb.Append("Book list");
//sb.Append("-Update");
//Console.WriteLine(sb);

//Console.WriteLine("--------------");

//sb.Replace("Book list", "Library");
//Console.WriteLine(sb);
#endregion
#region  Q5,Q6,Q7
//string title = "Clean Code";
//int pages = 464;
//Console.WriteLine("Book: " + title  + ", Pages: " + pages);
//Console.WriteLine("-------------------------");     
//Console.WriteLine($"Book: {title}, Pages: {pages}");
//Console.WriteLine("-------------------------");     
//Console.WriteLine(string.Format("Book: {0}, Pages: {1}", title, pages));
#endregion
#region Q8
//int number = 464;
//if (number >300 )
//{
//    Console.WriteLine("Long book");
//}
//else
//{
//    Console.WriteLine("Short book");
//}
#endregion
#region Q9
//int pages = 50;
//bool isAvailable = true;
//if (pages>300 && isAvailable==true)

//{
//    Console.WriteLine("you can borrow thid book");

//}


#endregion
#region Q10

//string title = "Redactoring";
//switch (title)
//{
//    case "Redactoring": Console.WriteLine("Great choice!");
//        break;
//    case "Clean Code": Console.WriteLine("Nice pick!");
//        break;
//}



#endregion
#region Q11
//int pages = 464;
//string sizeLabel = "";
//switch (pages)
//{

//    case > 300:
//        sizeLabel = "Long Book";
//        Console.WriteLine(sizeLabel);
//        break;

//    default:
//        sizeLabel = "Short Book";
//        Console.WriteLine(sizeLabel);
//        break;

//}

#endregion
#region Q12~Q17

string[] Books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" }; //Q12

//for (int i = 0; i < Books.Length; i++) 
//{
//    Console.WriteLine((i + 1) + ": " + Books[i]);
//}


//int j = 0;  //Q13

//while (j < Books.Length)  
//{
//    Console.WriteLine((j + 1) + ": " + Books[j]);
//    j++;
//}





//int m = 0;   //Q14
//do
//{

//    Console.WriteLine("Checking book...");

//    m++;
//}
//while (m < Books.Length);




//int s = 0;  //Q15
//foreach (string Book in Books)
//{
//    Console.WriteLine((s + 1) + ": " + Books[s]);
//    s++;
//}





//    for (int i = 0; i < Books.Length; i++)  //Q16
//{
//    if (Books[i] == "Refactoring") break;
//    Console.WriteLine((i + 1) + ": " + Books[i]);
//}  



//for (int i = 0; i < Books.Length; i++)   //Q17
//{
//    if (Books[i] == "The Pragmatic Programmer") continue;
//    Console.WriteLine((i + 1) + ": " + Books[i]);
//}

#endregion