// See https://aka.ms/new-console-template for more information
using lab5._1way2;

Conntroller controller = new Conntroller();
int ch;
do
{
    Console.WriteLine("====Action====");
    Console.WriteLine("1. Add Product");
    Console.WriteLine("2. Edit Product");
    Console.WriteLine("3. Delete Product");
    Console.WriteLine("4. View all Product");
    Console.WriteLine("5. Search product by Id ");
    Console.WriteLine("6. Search product by Name ");
    Console.WriteLine("7. End ");
    Console.WriteLine("Please enter your selection");
    ch = int.Parse(Console.ReadLine());
    switch (ch)
    {
        case 1:
            controller.CreatePr();
            break;
        case 2:
            controller.EditProduct();
            break;
        case 3:
            controller.DeleteProduct();
            break;
        case 4:
            controller.RealAllPr();
            break;
        case 5:
            controller.SearchById();
            break;
        case 6:
            controller.SearchByName();
            break;
        case 7:
        default:
            Console.WriteLine("====================");
            Console.WriteLine("Exit");
            break;
    }

} while (ch != 7);

