using InventaryDataManagementProgram;

FetchInventaryDetails fetchInventaryDetails = new FetchInventaryDetails();

string filepath = "C:\\Users\\Dell\\source\\repos\\InventaryDataManagementProgram\\InventaryDataManagementProgram\\Data.json";

Rice data = fetchInventaryDetails.Read(filepath);

for (int i = 0; i < data.typeofRice.Count; i++)
{

    Console.WriteLine(data.typeofRice[i].name);
    Console.WriteLine(data.typeofRice[i].weight);
    Console.WriteLine(data.typeofRice[i].price);
}
Console.WriteLine("---------------");

for (int i = 0; i < data.typeofPulses.Count; i++)
{
    Console.WriteLine(data.typeofPulses[i].name);
    Console.WriteLine(data.typeofPulses[i].weight);
    Console.WriteLine(data.typeofPulses[i].price);
}
Console.WriteLine("---------------");

for (int i = 0; i < data.typeofWheat.Count; i++)
{
    Console.WriteLine(data.typeofWheat[i].name);
    Console.WriteLine(data.typeofWheat[i].weight);
    Console.WriteLine(data.typeofWheat[i].price);
}
Console.WriteLine("---------------");