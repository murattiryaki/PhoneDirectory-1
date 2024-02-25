﻿using PhoneDirectory.Models;
//Dermot Boyle comment
// Robin Wiman
// Aileen Donegan (again!)
// Lucas Castro
//Afua Bonsu
//Murat Tiryaki
namespace PhoneDirectory
{
    public class Program
    {
        static void Main()
        {
            PhoneBookUtils utils = new PhoneBookUtils();


            PhoneBookEntry pbe1 = new PhoneBookEntry() { Number = "042-9034999", Name = "Conchúir", Address = "Anne St", Prefix = "Mr" };
            PhoneBookEntry pbe2 = new PhoneBookEntry() { Number = "085-123456", Name = "Billy McBurty", Address = "Cottage 2", Prefix = "Prof" };
            PhoneBookEntry pbe3 = new PhoneBookEntry() { Number = "01-5558889", Name = "Nellie Nagoo", Address = "House 45", Prefix = "Ms", PostCode = "D16" };
            PhoneBookEntry pbe4 = new PhoneBookEntry() { Number = "089-5677776", Name = "Mary Maleady", Address = "Castle on hill", Prefix = "Dr.", PostCode = "BT56" };
            //            PhoneBookEntry pbe5 = new PhoneBookEntry() { Number = "086-222555888", Name = "Sheila Shine", Address = "Gatehouse" };
            //            PhoneBookEntry pbe6 = new PhoneBookEntry() { Number = "085-12121254", Name = "Joe Bloggs", Address = "Apartment 3B" };

            //Commenting the example pieces


            //utils.CreateNewPBE(pbe1);

            //utils.CreateNewPBE(pbe2);

            //utils.CreateNewPBE(pbe3);
            //utils.CreateNewPBE(pbe4);
            /*
            utils.CreateNewPBE(pbe5);
            utils.CreateNewPBE(pbe6);

            */
            utils.ReadAllPBE();
            Console.WriteLine("-------------------");

            pbe1.PostCode = "D6";
            utils.UpdatePBE(pbe1);
            pbe2.PostCode = "D9";
            utils.UpdatePBE(pbe2);

            utils.ReadAllPBE();
            Console.WriteLine("-------------------");

            /*            utils.DeletePBE(pbe6);

                        utils.ReadAllPBE();
                        Console.WriteLine("-------------------");



                        //The actual lab requirements

                        List<PhoneBookEntry> recordsByName = utils.ctx.Directory.OrderBy(p => p.Name).ToList();
                        foreach (PhoneBookEntry record in recordsByName) 
                        {
                            Console.WriteLine(record);
                        }

                        Console.WriteLine("***************************");

                        PhoneBookEntry found = utils.ctx.Directory.FirstOrDefault(p => p.Number.Equals("01-5558889"));
                        if (found != null) 
                        {
                            Console.WriteLine($"That phone number belongs to: {found.Name}");
                        }

                        Console.WriteLine("***********Number and Adress*************");
                        var records = utils.ctx.Directory.Where(p => p.Name.Equals("Jemmy Ned")).Select(p => new { p.Number, p.Address });
                        foreach (var record in records) 
                        {
                            Console.WriteLine($"Number: {record.Number} | Address: {record.Address}");
                        }

                        */


        }
    }
}
