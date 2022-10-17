using InventaryManagementProgram;

FetchInventaryDetails fetchInventaryDetails = new FetchInventaryDetails();
string filepath = "C:\\Users\\Dell\\source\\repos\\InventaryManagementProgram\\InventaryManagementProgram\\Data.json";


Rice data = fetchInventaryDetails.Read(filepath);
for (int i = 0; i < data.typeofRice.Count; i++)
{

    Console.WriteLine(data.typeofRice[i].name);
    Console.WriteLine(data.typeofRice[i].weight);
    Console.WriteLine(data.typeofRice[i].price);


    int total = data.typeofRice[i].price * data.typeofRice[i].weight;
    Console.WriteLine("The price of " + data.typeofRice[i].name + "for" + data.typeofRice[i].weight + "*" + total);
    Console.WriteLine("The Price of " + data.typeofRice[i].name + "for " + "kg * " + total);
}
Console.WriteLine("------------------------------");

for (int i = 0; i < data.typeofPulses.Count; i++)
{
    Console.WriteLine(data.typeofPulses[i].name);
    Console.WriteLine(data.typeofPulses[i].weight);
    Console.WriteLine(data.typeofPulses[i].price);

    int total = data.typeofPulses[i].price * data.typeofPulses[i].weight;
    Console.WriteLine("The Price Of " + data.typeofPulses[i].name + "for" + data.typeofPulses[i].weight + "*" + total);
    Console.WriteLine("The Price of " + data.typeofPulses[i].name + "for" + "kg * " + total);


}

for (int i = 0; i < data.typeofWheat.Count; i++)
{
    Console.WriteLine(data.typeofWheat[i].name);
    Console.WriteLine(data.typeofWheat[i].weight);
    Console.WriteLine(data.typeofWheat[i].price);

    int total = data.typeofWheat[i].price * data.typeofWheat[i].weight;
    Console.WriteLine("The Price Of " + data.typeofWheat[i].name + "for" + data.typeofWheat[i].weight + "*" + total);
    Console.WriteLine("The Price of " + data.typeofWheat[i].name + "for" + "kg * " + total);


}
        