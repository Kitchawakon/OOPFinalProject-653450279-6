using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFinalProject_653450279_6
{
    //รับ data Item
    public class ClassItem
    {
        public string CharacterName { get; set; }
        public string IDGame { get; set; }
        public string Server { get; set; }
        public string ItemName { get; set; }
        public int ItemNumber { get; set; }
        public ClassItem(string nameC, string idG, string ser, string itemname, int itemnum)
        {
            CharacterName = nameC;
            IDGame = idG;
            Server = ser;
            ItemName = itemname;
            ItemNumber = itemnum;
        }
    }
}
