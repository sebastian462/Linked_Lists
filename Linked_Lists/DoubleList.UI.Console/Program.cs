
using DoubleList;

var doubleList = new DoublyLinkedList<string>();
var opc = "0";

do
{
    opc = Menu();
    switch (opc)
    {
        case "1":
            Console.Write("Enter the data to insert: ");
            var dataAtBeginning = Console.ReadLine();
            if (dataAtBeginning != null)
            {
                doubleList.Insert(dataAtBeginning);
            }
            break;

        case "2":
            Console.WriteLine("list forwatd:");
            Console.WriteLine(doubleList.GetForward());
            break;

        case "3":
            Console.WriteLine("List backward:");
            Console.WriteLine(doubleList.GetBackward());
            break;

        case "4":
            Console.WriteLine("List descending:");
            doubleList.sortDescending();
            Console.WriteLine(doubleList.GetForward());
            break;

        case "5":
            Console.WriteLine("View fads");
            var fads = doubleList.Fads();
            if (fads.Count == 0)
            {
                Console.WriteLine("No have fads");
            }
            else
            {
                Console.WriteLine("Fad(s): " + string.Join(",", fads));
            }
            break;

        case "6":
            Console.WriteLine("View the graphic.");
            Console.WriteLine();
            doubleList.Graphic();
            break;


        case "7":
            Console.Write("Enter the data to validate if exists: ");
            var data = Console.ReadLine();
            if (data != null)
            {
                var exists = doubleList.Contains(data) ? "exists" : " does not exist";
                Console.WriteLine($"The data: {data} {exists}");
            }
            break;

        case "8":
            Console.WriteLine("Enter the data to delete: ");
            var remove = Console.ReadLine();
            if (remove != null)
            {
                if (doubleList.Contains(remove))
                {
                    doubleList.Remove(remove);
                    Console.WriteLine("Item remove.");
                }
                else
                {
                    Console.WriteLine("Item does exists. ");
                }
            }
            break;

        case "9":
            doubleList.Clear();
            Console.Write("List cleaned. ");
            break;

    }



}
while (opc != "0");

string Menu()

{
    Console.WriteLine("1. Add new item.");
    Console.WriteLine("2. Show list forward.");
    Console.WriteLine("3. Show list backward.");
    Console.WriteLine("4. Show list Descending.");
    Console.WriteLine("5. Show at fads.");
    Console.WriteLine("6. Show at Graphics.");
    Console.WriteLine("7. Exists.");
    Console.WriteLine("8. Remove Item.");
    Console.WriteLine("9. Clear Items.");
    Console.WriteLine("0. Exit");
    Console.Write("Choose an option: ");
    return Console.ReadLine() ?? "0";

}



