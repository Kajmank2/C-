using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAdvancedTWODATASET
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Item_mast> itemList = new List<Item_mast>
            {
                new Item_mast{ ItemId=1 , ItemDes="Ciastka" },
                new Item_mast{ItemId = 2 , ItemDes="Chocolate"},
                new Item_mast { ItemId = 3 , ItemDes="Baton"},
                new Item_mast { ItemId=4,ItemDes = "Brade"},
                new Item_mast {ItemId=5 , ItemDes="Honey"}
            };
            List<Purchase> purchaseList = new List<Purchase>
            {
           new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 },
           new Purchase { InvNo=101, ItemId = 2,  PurQty = 650 },
           new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },
           new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
           new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },
           new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },
           new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }
            };
            Console.WriteLine("Item LIST  ++++++++++++++=++=");
            foreach (var item in itemList)
            {
                Console.WriteLine("Item Id {0}  ,  Description {1}",
                    item.ItemId,
                    item.ItemDes);
            };
            Console.WriteLine("Purchase List ============");
            foreach (var item in purchaseList)
            {
                {
                    Console.WriteLine(
                    "Invoice No: {0}, Item Id : {1},  Quantity : {2}",
                    item.InvNo,
                    item.ItemId,
                    item.PurQty);
                }
            }

            var innerJoin = from e in itemList join d in purchaseList on e.ItemId equals d.ItemId 
                            select new
                            {
                                itid = e.ItemId,
                                itdes = e.ItemDes,
                                prqty = d.PurQty
        };
            var leftOuterJoin = from itm in itemList
                                join prch in purchaseList
                                on itm.ItemId equals prch.ItemId
                                into a
                                from b in a.DefaultIfEmpty(new Purchase())
                                select new
                                {
                                    itid = itm.ItemId,
                                    itdes = itm.ItemDes,
                                    prqty = b.PurQty
                                };
            var rightOuterJoin = from p in purchaseList
                                 join i in itemList
                                 on p.ItemId equals i.ItemId
                                 into a
                                 from b in a.DefaultIfEmpty()
                                 select new
                                 {
                                     itid = b.ItemId,
                                     itdes = b.ItemDes,
                                     prqty = p.PurQty

                                 };
            foreach (var item in innerJoin) //podmieniamu lef OurJoin
            {
                Console.WriteLine(item
                    );
            }
            Console.ReadKey();
        }
        public class Item_mast
        {
            public int ItemId { get; set; }
            public string ItemDes { get; set; }
        }
        public class Purchase
        {
            public int InvNo { get; set; }
            public int ItemId { get; set; }
            public int PurQty { get; set; }
        }
    }
}
