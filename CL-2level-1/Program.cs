
//level 1 checkpoint2
List<ProdClass> prodlist = new List<ProdClass>();

while (true)
{
    ProdClass prodobj = new ProdClass();
    string p;

    Console.Write("Enter the category of the product:");
    prodobj.category = Console.ReadLine();
    Console.Write("Enter the productname of the product:");
    prodobj.productname = Console.ReadLine();
    Console.Write("Enter the price of the product:");
    p = Console.ReadLine();
    bool isInt = int.TryParse(p, out int value);
    if (isInt)
    { prodobj.price = p; }
    else { Console.WriteLine("Please enter int value"); }


    prodlist.Add(prodobj);
    Console.Write("Press q to quit or any:");// quit "q" to exit
    string q = Console.ReadLine();
    if (q == "q") { break; }
    Console.WriteLine("------------------------");

}
Console.WriteLine("------------------------");
Console.WriteLine("The items u entered are:");
foreach (ProdClass prod in prodlist)//Displaying list

    Console.WriteLine($" category:{prod.category}\n productname:{prod.productname}\n price:{prod.price}");


class ProdClass
{
    public string category;
    public string productname;
    public string price;


}