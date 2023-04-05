using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPFinalProject_653450279_6
{
    public partial class FormAddInfo : Form
    {
        private ClassItem _newItem;
        public FormAddInfo()
        {
            InitializeComponent();
        }

        //ADD INFO ITEM
        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            string nameC = textBoxNC.Text;
            string idG = textBoxIDG.Text;
            string ser = textBoxSer.Text;
            string itemname = textBoxIN.Text;
            int iitemnum = 0;
            try
            {
                string itemnum = textBoxInum.Text;
                iitemnum = Int32.Parse(itemnum);
            }
            catch (FormatException ex)
            {
                // ให้ขึ้นว่าต้องใส่เลขเท่านั้น
                MessageBox.Show("โปรดใส่ตัวเลข ในช่อง 'Number of Item'");
                return;
            }
            _newItem = new ClassItem(nameC, idG, ser, itemname, iitemnum);

            this.DialogResult = DialogResult.OK;
        }
        
        public ClassItem GetClassItem() { return _newItem; }

    }
}
