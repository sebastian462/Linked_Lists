using SingleList;

var singleList = new SinglyLinkedList<string>();
var opc = "0";

do
{
    opc = Menu();
    switch (opc)
    {
        case "1":
            Console.Write("Enter the data to insert at beginning: ");
            var dataAtBeginning = Console.ReadLine();
            if (dataAtBeginning != null)
            {
                singleList.InsertAtBeginning(dataAtBeginning);
            }
            break;
        case "2":
            Console.WriteLine("Enter the data to insert at end: ");
            var dataAtEnd = Console.ReadLine();
            if (dataAtEnd != null)
            {
                singleList.InsertAtEnd(dataAtEnd);
            }
            break;
        case "3":
            Console.WriteLine(singleList.ToString());
            break;
        case "4":
            Console.Write("Enter the data to validate if exists: ");
            var data = Console.ReadLine();
            if (data != null)
            {
                var exists = singleList.Contains(data) ? "exists" : " does not exist";
                Console.WriteLine($"The data: {data} {exists}");
            }
            break;

        case "5":
            Console.Write("Enter the data to delete: ");
            var remove = Console.ReadLine();
            if (remove != null)
            {
                if (singleList.Contains(remove))
                {
                    singleList.Remove(remove);
                    Console.WriteLine("Item remove.");
                }
                else
                {
                    Console.WriteLine("Item does exists. ");
                }
            }
            break;


        case "6":
            singleList.Clear();
            Console.Write("Lis cleaned. ");
            break;

    }
} while (opc != "0");

string Menu ()

{
    Console.WriteLine("1. Insert at beginning");
    Console.WriteLine("2. Insert at end");
    Console.WriteLine("3. Show list");
    Console.WriteLine("4. Exists");
    Console.WriteLine("5. Remove Item");
    Console.WriteLine("6. Clear all List");
    Console.WriteLine("0. Exit");
    Console.Write("Choose an option: ");
    return Console.ReadLine() ?? "0";

}
 

  