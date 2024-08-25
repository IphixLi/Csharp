using System.Runtime.CompilerServices;

String[] items=["B123","C234","A345","C15","B177","G3003","C235","B179"];

foreach(String Item in items){
if (Item.StartsWith("B")){
    Console.WriteLine(Item);
}
}
