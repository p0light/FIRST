namespace Storage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("Lighthouse");
            int result = Basestatic.EnterChoosens();

            while (result != 0)
            {

                switch(result)
                {
                    case 1:
                        Storage storage = Basestatic.EnterStoragedetails();
                        company.Addstorage(storage);
                        result = Basestatic.EnterChoosens();
                        break;
                    case 2:
                        company.GetStorage();
                        int id = Basestatic.EnterStorageid();
                        storage = company.getStoragebyId(id);
                        while (storage == null)
                        {
                            Console.WriteLine("404 not found");
                            id = Basestatic.EnterStorageid();
                            storage = company.getStoragebyId(id);
                        }
                        Customer customer = Basestatic.EnterCustomerdetails();
                        storage.addcustomer(customer);
                        result = Basestatic.EnterChoosens();
                        break;
                    case 3:
                        company.Getallstorage();

                        Console.WriteLine("Enter storage Id");
                        int storageid = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Customer Id");
                        int customerid = int.Parse(Console.ReadLine());
                        Console.WriteLine("Choose the hire area");
                        int Hirefield = int.Parse(Console.ReadLine());
                        Hire hireinfo = Company.Gethire(storageid,customerid,Hirefield);
                        if (hireinfo == null)
                        {
                            Console.WriteLine("area is hired");
                        }
                        else
                        {
                            Console.WriteLine("404 not found");

                        }
                        result = Basestatic.EnterChoosens();
                        break;
                        case 4:
                        company.Getallstorage();
                        break;
                        default:
                        result = Basestatic.EnterChoosens();
                        break;

                }     
            }
        }
    }
}
