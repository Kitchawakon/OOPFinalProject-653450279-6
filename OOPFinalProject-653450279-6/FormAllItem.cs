using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOPFinalProject_653450279_6
{
    public partial class FormAllItem : Form
    {
        
        //make a new list to show dataGridView
        private List<ClassItem> listItem = new List<ClassItem>();
        
        ClassItem selectedItem;
        public FormAllItem()
        {
            InitializeComponent();
        }


        //open FromAddInfo to add Item and Show data at dataGridView
        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddInfo formInfo = new FormAddInfo();
            formInfo.ShowDialog();

            if (formInfo.DialogResult == DialogResult.OK)
            {
                ClassItem newItem = formInfo.GetClassItem();
                listItem.Add(newItem);
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = listItem;
                formInfo.Close();
            }
        }

        
        //open file to get data
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV|*.csv|TEXT|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] line = reader.ReadLine().Split(',');
                        if (line.Length >= 5) // เช็กว่าไฟล์นั้นมีพื้นที่พอที่จะรับมา
                        {
                            ClassItem items = new ClassItem(
                                line[0],
                                line[1],
                                line[2],
                                line[3],
                                Int32.Parse(line[4])
                            );
                            listItem.Add(items);
                        }
                    }

                }
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = listItem;
            }
        }

        //save file
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "CSV|*.csv|TEXT|*.txt";
            saveFile.ShowDialog();
            if (saveFile.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFile.FileName))
                {
                    foreach (ClassItem item in listItem)
                    {
                        writer.WriteLine(String.Format("{0},{1},{2},{3},{4}",
                            item.CharacterName,
                            item.IDGame,
                            item.Server,
                            item.ItemName,
                            item.ItemNumber
                            ));
                    }
                }
            }
        }
        public ClassItem GetselectedPlayer() { return selectedItem; }

        //ค้นหาชื่อตัวละคร
        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxFName.Text;
            textBoxFName.Text = "";

            // วนไปตามข้อมูลใน DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // วนให้พอกับ cells ในแถว
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // เช็กใน cell ว่าตรงกับค่าที่หามั้ย
                    if (cell.Value != null && cell.Value.ToString().Equals(searchValue, StringComparison.OrdinalIgnoreCase))
                    {
                        // เลือก แถว และ scroll เข้าไปในมุมมอง
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index;

                        // หยุดลูบ
                        return;
                    }
                }
            }

            // ถัาหาข้อฒุลไม่เจอให้ขึ้นข้อความข้างล่าง
            MessageBox.Show("ไม่พบชื่อ ตัวละคร ดังกล่าว");
        }

        //ค้นหา ID เกม
        private void button2_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxFID.Text;
            textBoxFID.Text = "";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Equals(searchValue, StringComparison.OrdinalIgnoreCase))
                    {
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index;
                        return;
                    }
                }
            }
            MessageBox.Show("ไม่พบ ID ดังกล่าว");
        }

        //ค้นหา Server
        private void button3_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxFser.Text;
            textBoxFser.Text = "";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Equals(searchValue, StringComparison.OrdinalIgnoreCase))
                    {
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index;
                        return;
                    }
                }
            }
            MessageBox.Show("ไม่พบชื่อ Srever ดังกล่าว");
        }

        // ค้นหาชื้อไอเท็ม
        private void button4_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxFIName.Text;
            textBoxFIName.Text = "";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Equals(searchValue, StringComparison.OrdinalIgnoreCase))
                    {
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index;
                        return;
                    }
                }
            }
            MessageBox.Show("ไม่พบชื่อ ไอเท็ม ดังกล่าว");
        }

        //close FromAllItem
        private void closeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }
    }
}
