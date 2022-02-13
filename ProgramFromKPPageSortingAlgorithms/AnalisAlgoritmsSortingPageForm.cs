using System;
using System.Windows.Forms;

namespace ProgramFromKPPageSortingAlgorithms
{
    public partial class AnalisAlgoritmsSortingPageForm : Form
    {
        bool flag = false;
        public AnalisAlgoritmsSortingPageForm()
        {
            InitializeComponent();
        }
        public void ClearTable() { dataGridView1.Rows.Clear();}
        public void SetTitleChart(int numberofpagesblocks)
        {
            string titlech = "График алгоритмов сортировки страниц для " + numberofpagesblocks+" страничных блоков";
            pictureChart.Titles[0].Text = titlech;
        }
        public void AddColumnTable(string nameColumn)
        {
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = nameColumn, Width = 65 });
        }
        public void AddRowTable()
        {
            dataGridView1.Rows.Add();
        }
        public void AddValueTable(int i, int j, string value)
        {
            dataGridView1.Rows[i].Cells[j].Value = value;
        }
        public string GetRowName(int i)
        {
            return dataGridView1.Columns[i].Name;
        }
        public int GetCountRow()
        {
            return dataGridView1.Rows.Count;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                for(int i = 1; i < dataGridView1.Columns.Count; i++)
                {
                    this.pictureChart.Series[i-1].Points.Clear();
                    if (dataGridView1.Rows[0].Cells[i].Value != null)
                    {
                        for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
                        {
                            pictureChart.Series[i-1].Points.AddXY(Int32.Parse(dataGridView1.Rows[j].Cells[0].Value.ToString()), Int32.Parse(dataGridView1.Rows[j].Cells[i].Value.ToString())-(i*(Int32.Parse(dataGridView1.Rows[j].Cells[0].Value.ToString())*2/100)));
                        }
                    }
                    else
                        continue;
                }
                dataGridView1.Visible = false;
                pictureChart.Visible = true;
                flag = true;
                button1.Text = "Посмотреть талбицу построения";
            }
            else
            {
                dataGridView1.Visible = true;
                pictureChart.Visible = false;
                flag = false;
                button1.Text = "Построить график";
            }
        }
    }
}
