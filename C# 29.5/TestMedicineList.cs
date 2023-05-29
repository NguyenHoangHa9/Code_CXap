using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineList
{
    class MedicineListTest
    {
        static void Main(string[] args)
        {
            try
            {
                MedicineList objmedicines = new MedicineList();

                objmedicines.AcceptDetails();
                objmedicines.DisplayDetails();
                char input = 'Y';
                    do
                {
                    int choice;
                    Console.WriteLine("\nSelect one of the following options : ");
                    Console.WriteLine(" 1.Modify\n 2. Remove\n 3. Remove All\n 4. Search 5. Exit");
                    Console.Write("Enter your choice : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            if (objmedicines.Modify())
                            {
                                Console.WriteLine("\n-----After Modifying-----");
                                objmedicines.DisplayDetails();
                            }
                            else
                                Console.WriteLine("Medicine with this name does not exist");
                            break;
                        case 2:
                            if (objmedicines.Remove())
                            {
                                Console.Write("\n-----After Removing-----");
                                objmedicines.DisplayDetails();
                            }
                            else
                                Console.WriteLine("Medicine with this name does not exist");
                            break;
                        case 3:
                            objmedicines.objMedicineDetails.Clear();
                            Console.WriteLine("\n-----After removing all the medicines-----");
                            Console.WriteLine("Total number of supplier : " + objmedicines.objMedicineDetails.Count);
                            return;
                        case 4:
                            objmedicines.Search();
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("Invalid Data Entry!");
                            break;
                    }
                } while (input == 'Y' || input == 'y');
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error : {0} ", objEx.Message);
            }
        }
            }
        }
    