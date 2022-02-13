using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProgramFromKPPageSortingAlgorithms
{
    public partial class MainForm : Form
    {
        private int[] temparrLRU, temparrNRU;
        private bool[] temparrSA, temparrClock;
        private int indesclockwise;
        private string sequenceofpagenumbers;
        AnalisAlgoritmsSortingPageForm analis = new AnalisAlgoritmsSortingPageForm();
        public MainForm()
        {
            InitializeComponent();
            timerNRY.Enabled = false;
            checkboxhandNRU.Visible = false;
            checkboxrandomNRU.Visible = false;
            NumberofPageBlocks.Maximum = numericUpDownmaxpagesblock.Value;
            numericUpDownNumNewPage.Maximum = numericUpDowndifferentpages.Value;
            sequenceofpagenumbers = "";
            MainTable.Columns.Clear();
            MainTable.Columns.Add(new DataGridViewTextBoxColumn() { Name = "№ страничного блока", Width = 100 });
            for (int i = 0; i < NumberofPageBlocks.Value; i++)
            {
                MainTable.Columns.Add(new DataGridViewTextBoxColumn() { Name = (i + 1).ToString(), Width = 25 });
            }
            MainTable.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Количество прерываний", Width = 100 });
        }
        private void FIFONewPage(int numrow)
        {
            for (int i = 0; i < NumberofPageBlocks.Value; i++)
            {
                if (MainTable.Rows[numrow].Cells[i + 1].Value == null)
                {
                    MainTable.Rows[numrow].Cells[i + 1].Value = numericUpDownNumNewPage.Value;
                    MainTable.Rows[numrow].Cells[Int32.Parse( NumberofPageBlocks.Value.ToString()) +1].Value = (Int32.Parse(MainTable.Rows[numrow].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value.ToString()) + 1).ToString();
                    return;
                } 
                if(Int32.Parse(MainTable.Rows[numrow].Cells[i+1].Value.ToString()) == Int32.Parse( numericUpDownNumNewPage.Value.ToString()))
                {
                    return;
                }
            }
            for (int i = 0; i < NumberofPageBlocks.Value; i++)
            {
                MainTable.Rows[numrow].Cells[i + 1].Value = MainTable.Rows[numrow].Cells[i + 2].Value;
            }
            MainTable.Rows[numrow].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString())].Value = numericUpDownNumNewPage.Value;
            MainTable.Rows[numrow].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value = (Int32.Parse(MainTable.Rows[numrow].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value.ToString()) + 1).ToString();
        }
        private void LRUNewPage(int numrow)
        {
            int indmaxLRU = 0, indminLRU = 0;
            for (int i = 0; i < NumberofPageBlocks.Value; i++)
            {
                if (temparrLRU[indmaxLRU] < temparrLRU[i])
                    indmaxLRU = i;
                if (temparrLRU[indminLRU] > temparrLRU[i])
                    indminLRU = i;
            }
            for (int i = 0; i < NumberofPageBlocks.Value; i++)
            {
                if (MainTable.Rows[numrow].Cells[i + 1].Value == null)
                {
                    MainTable.Rows[numrow].Cells[i + 1].Value = numericUpDownNumNewPage.Value;
                    MainTable.Rows[numrow].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value = (Int32.Parse(MainTable.Rows[numrow].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value.ToString()) + 1).ToString();
                    temparrLRU[i] = temparrLRU[indmaxLRU]+1;
                    return;
                }
                if (Int32.Parse(MainTable.Rows[numrow].Cells[i + 1].Value.ToString()) == Int32.Parse(numericUpDownNumNewPage.Value.ToString()))
                {
                    temparrLRU[i] = temparrLRU[indmaxLRU] + 1;
                    return;
                }
            }
            MainTable.Rows[numrow].Cells[indminLRU+1].Value = numericUpDownNumNewPage.Value;
            MainTable.Rows[numrow].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value = (Int32.Parse(MainTable.Rows[numrow].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value.ToString()) + 1).ToString();
            temparrLRU[indminLRU] = temparrLRU[indmaxLRU] + 1;
        }
        private void NRUNewPage(int numrow)
        {
            int quantityminNRU = 0, minNRU = 5, randomidx=-1;
            var rand = new Random();
            for (int i = 0; i < NumberofPageBlocks.Value; i++)
            {
                if (minNRU > temparrNRU[i])
                {
                    minNRU = temparrNRU[i];
                    quantityminNRU = 0;
                }
                if (minNRU == temparrNRU[i])
                    quantityminNRU++;
            }
            for (int i = 0; i < NumberofPageBlocks.Value; i++)
            {
                if (MainTable.Rows[numrow].Cells[i + 1].Value == null)
                {
                    MainTable.Rows[numrow].Cells[i + 1].Value = numericUpDownNumNewPage.Value;
                    MainTable.Rows[numrow].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value = (Int32.Parse(MainTable.Rows[numrow].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value.ToString()) + 1).ToString();
                    if (checkboxrandomNRU.Checked == true)
                        temparrNRU[i] = 2+1+(rand.Next()%2);
                    else if (checkboxhandNRU.Checked == true)
                        temparrNRU[i] = 4;
                    else
                        temparrNRU[i] = 3;
                    return;
                }
                if (Int32.Parse(MainTable.Rows[numrow].Cells[i + 1].Value.ToString()) == Int32.Parse(numericUpDownNumNewPage.Value.ToString()))
                {
                    if (checkboxrandomNRU.Checked == true)
                        temparrNRU[i] = 2 + 1 + (rand.Next() % 2);
                    else if (checkboxhandNRU.Checked == true)
                        temparrNRU[i] = 4;
                    else
                        temparrNRU[i] = 3;
                    return;
                }
            }
            randomidx = rand.Next() % quantityminNRU;
            for (int i = 0; i < NumberofPageBlocks.Value; i++)
            {
                if (temparrNRU[i] == minNRU && randomidx == 0)
                {
                    MainTable.Rows[numrow].Cells[i + 1].Value = numericUpDownNumNewPage.Value;
                    if (checkboxrandomNRU.Checked == true)
                        temparrNRU[i] = 2 + 1 + (rand.Next() % 2);
                    else if (checkboxhandNRU.Checked == true)
                        temparrNRU[i] = 4;
                    else
                        temparrNRU[i] = 3;
                    MainTable.Rows[numrow].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value = (Int32.Parse(MainTable.Rows[numrow].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value.ToString()) + 1).ToString();
                    return;
                }
                if (temparrNRU[i] == minNRU)
                    randomidx--;
            }
        }
        private void SecondAttemptNewPage(int numrow)
        {
            for (int i = 0; i < NumberofPageBlocks.Value; i++)
            {
                if (MainTable.Rows[numrow].Cells[i + 1].Value == null)
                {
                    MainTable.Rows[numrow].Cells[i + 1].Value = numericUpDownNumNewPage.Value;
                    MainTable.Rows[numrow].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value = (Int32.Parse(MainTable.Rows[numrow].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value.ToString()) + 1).ToString();
                    temparrSA[i] = false;
                    return;
                }
                if (Int32.Parse(MainTable.Rows[numrow].Cells[i + 1].Value.ToString()) == Int32.Parse(numericUpDownNumNewPage.Value.ToString()))
                {
                    temparrSA[i] = true;
                    return;
                }
            }
            string tempstr = MainTable.Rows[numrow].Cells[1].Value.ToString();
            if (temparrSA[0] == true)
            {
                for (int i = 0; i < NumberofPageBlocks.Value-1; i++)
                {
                    MainTable.Rows[numrow].Cells[i + 1].Value = MainTable.Rows[numrow].Cells[i + 2].Value;
                    temparrSA[i] = temparrSA[i + 1];
                }
                MainTable.Rows[numrow].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString())].Value = tempstr;
                temparrSA[Int32.Parse(NumberofPageBlocks.Value.ToString()) - 1] = false;
                SecondAttemptNewPage(numrow);
            }
            else
            {
                for (int i = 0; i < NumberofPageBlocks.Value-1; i++)
                {
                    MainTable.Rows[numrow].Cells[i + 1].Value = MainTable.Rows[numrow].Cells[i + 2].Value;
                    temparrSA[i] = temparrSA[i + 1];
                }
                MainTable.Rows[numrow].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString())].Value = numericUpDownNumNewPage.Value;
                MainTable.Rows[numrow].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value = (Int32.Parse(MainTable.Rows[numrow].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value.ToString()) + 1).ToString();
                temparrSA[Int32.Parse(NumberofPageBlocks.Value.ToString())-1] = false;
                return;
            }
        }
        private void ClockNewPage(int numrow)
        {
            for (int i = 0; i < NumberofPageBlocks.Value; i++)
            {
                if (MainTable.Rows[numrow].Cells[i + 1].Value == null)
                {
                    MainTable.Rows[numrow].Cells[i + 1].Value = numericUpDownNumNewPage.Value;
                    MainTable.Rows[numrow].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value = (Int32.Parse(MainTable.Rows[numrow].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value.ToString()) + 1).ToString();
                    temparrClock[i] = false;
                    return;
                }
                if (Int32.Parse(MainTable.Rows[numrow].Cells[i + 1].Value.ToString()) == Int32.Parse(numericUpDownNumNewPage.Value.ToString()))
                {
                    temparrClock[i] = true;
                    return;
                }
            }
            if(temparrClock[indesclockwise] == true)
            {
                temparrClock[indesclockwise] = false;
                if (indesclockwise == (Int32.Parse(NumberofPageBlocks.Value.ToString()) - 1))
                    indesclockwise = 0;
                else
                    indesclockwise++;
                ClockNewPage(numrow);
            }
            else
            {
                MainTable.Rows[numrow].Cells[indesclockwise + 1].Value = numericUpDownNumNewPage.Value;
                MainTable.Rows[numrow].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value = (Int32.Parse(MainTable.Rows[numrow].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value.ToString()) + 1).ToString();
                if (indesclockwise == (Int32.Parse(NumberofPageBlocks.Value.ToString()) - 1))
                    indesclockwise = 0;
                else
                    indesclockwise++;
                return;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            analis.Close();
            analis = new AnalisAlgoritmsSortingPageForm();
            analis.Visible = false;
            checkboxhandNRU.Visible = false;
            checkboxrandomNRU.Visible = false;
            sequenceofpagenumbers = "";
            temparrSA = new bool[Int32.Parse(NumberofPageBlocks.Value.ToString())];
            analis.SetTitleChart(Int32.Parse(NumberofPageBlocks.Value.ToString()));
            for (int i = 0; i < NumberofPageBlocks.Value; i++)
                temparrSA[i] = false;
            temparrClock = new bool[Int32.Parse(NumberofPageBlocks.Value.ToString())];
            for (int i = 0; i < NumberofPageBlocks.Value; i++)
                temparrClock[i] = false;
            indesclockwise = 0;
            temparrLRU = new int[Int32.Parse(NumberofPageBlocks.Value.ToString())];
            for (int i = 0; i < NumberofPageBlocks.Value; i++)
                temparrLRU[i] = 0;
            temparrNRU = new int[Int32.Parse(NumberofPageBlocks.Maximum.ToString())];
            for (int i = 0; i < NumberofPageBlocks.Maximum; i++)
                temparrNRU[i] = 0;
            MainTable.Columns.Clear();
            MainTable.Columns.Add(new DataGridViewTextBoxColumn() { Name = "№ страничного блока", Width = 100 }) ;
            for (int i = 0; i < NumberofPageBlocks.Value; i++)
            {
                MainTable.Columns.Add(new DataGridViewTextBoxColumn() { Name = (i + 1).ToString(), Width = 25 });
            }
            MainTable.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Количество прерываний", Width = 100 });
            bool flagTimerNRU = false;
            if (checkedListBoxAlgoritmsSortingPage.CheckedItems.Count > 0)
            {
                analis.ClearTable();
                for (int i = 0; i < checkedListBoxAlgoritmsSortingPage.CheckedItems.Count; i++)
                {
                    MainTable.Rows.Add();
                    MainTable.Rows[i].Cells[0].Value = checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString();
                    MainTable.Rows[i].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value = "0";
                    if (checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString() == "NRU")
                    {
                        checkboxhandNRU.Visible = true;
                        flagTimerNRU = true;
                        checkboxrandomNRU.Visible = true;
                        timerNRY.Enabled = true;
                    }
                    else if (!flagTimerNRU)
                        timerNRY.Enabled = false;
                }
            }
        }

        private void checkedListBoxAlgoritmsSortingPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            analis.Close();
            analis = new AnalisAlgoritmsSortingPageForm();
            analis.Visible = false;
            sequenceofpagenumbers = "";
            checkboxhandNRU.Visible = false;
            checkboxrandomNRU.Visible = false;
            temparrSA = new bool[Int32.Parse(NumberofPageBlocks.Value.ToString())];
            analis.SetTitleChart(Int32.Parse(NumberofPageBlocks.Value.ToString()));
            for (int i = 0; i < NumberofPageBlocks.Value; i++)
                temparrSA[i] = false;
            temparrLRU = new int[Int32.Parse(NumberofPageBlocks.Value.ToString())];
            for (int i = 0; i < NumberofPageBlocks.Value; i++)
                temparrLRU[i] = 0;
            temparrNRU = new int[Int32.Parse(NumberofPageBlocks.Maximum.ToString())];
            for (int i = 0; i < NumberofPageBlocks.Maximum; i++)
                temparrNRU[i] = 0;
            temparrClock = new bool[Int32.Parse(NumberofPageBlocks.Value.ToString())];
            for (int i = 0; i < NumberofPageBlocks.Value; i++)
                temparrClock[i] = false;
            MainTable.Rows.Clear();
            bool flagTimerNRU = false;
            if (checkedListBoxAlgoritmsSortingPage.CheckedItems.Count > 0)
            {
                analis.ClearTable();
                for (int i = 0; i < checkedListBoxAlgoritmsSortingPage.CheckedItems.Count; i++)
                {
                    MainTable.Rows.Add();
                    MainTable.Rows[i].Cells[0].Value = checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString();
                    MainTable.Rows[i].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) +1].Value = "0";
                    if (checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString() == "NRU")
                    {
                        checkboxhandNRU.Visible = true;
                        flagTimerNRU = true;
                        checkboxrandomNRU.Visible = true;
                        timerNRY.Enabled = true;
                    }
                    else if (!flagTimerNRU)
                        timerNRY.Enabled = false;
                }
            }
        }

        private void timerNRY_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxAlgoritmsSortingPage.CheckedItems.Count; i++)
            {
                if (checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString() == "NRU")
                {
                    for (int timei = 0; timei < NumberofPageBlocks.Maximum; timei++)
                    {
                        if(temparrNRU[timei] ==3)
                            temparrNRU[timei] = 0;
                        if (temparrNRU[timei] == 4)
                            temparrNRU[timei] = 1;
                    }
                    break;
                }
            }
        }

        private void графикСравненияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            analis.Show();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            analis.Close();
            analis = new AnalisAlgoritmsSortingPageForm();
            analis.Visible = false;
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            List<string> lines = File.ReadAllLines(filename).ToList();
            int tempi;
            foreach (string line in lines)
            {
                if (!Int32.TryParse(line, out tempi)) {
                    if (оПрограммеToolStripMenuItem.Text == "Отключить оповещения")
                        MessageBox.Show("Файл содержит некорректные данные!", "Ошибка!");
                    return;
                }
                if (tempi >= numericUpDowndifferentpages.Value)
                {
                    if (оПрограммеToolStripMenuItem.Text == "Отключить оповещения")
                        MessageBox.Show("Страницы в файле не подходят под заданные уславия!", "Ошибка!");
                    return;
                }
            }
            foreach (string line in lines)
            {
                numericUpDownNumNewPage.Value = decimal.Parse(line);
                if ((checkedListBoxAlgoritmsSortingPage.CheckedItems.Count > 0))
                {
                    if(!(checkedListBoxAlgoritmsSortingPage.CheckedItems.Count == MainTable.Rows.Count - 1))
                    {
                        analis.ClearTable();
                        MainTable.Rows.Clear();
                        for (int i = 0; i < checkedListBoxAlgoritmsSortingPage.CheckedItems.Count; i++)
                        {
                            MainTable.Rows.Add();
                            MainTable.Rows[i].Cells[0].Value = checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString();
                            MainTable.Rows[i].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value = "0";
                        }
                    }
                    analis.AddRowTable();
                    analis.AddValueTable(analis.GetCountRow() - 2, 0, (analis.GetCountRow() - 1).ToString());
                    for (int i = 0; i < checkedListBoxAlgoritmsSortingPage.CheckedItems.Count; i++)
                    {
                        if (checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString() == "FIFO")
                            FIFONewPage(i);
                        if (checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString() == "LRU")
                            LRUNewPage(i);
                        if (checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString() == "NRU")
                            NRUNewPage(i);
                        if (checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString() == "Вторая попытка")
                            SecondAttemptNewPage(i);
                        if (checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString() == "Часы")
                            ClockNewPage(i);
                        for (int j = 0; j < 5; j++)
                        {
                            if ((analis.GetRowName(j + 1) == checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString()) || ((analis.GetRowName(j + 1) == "Clock" && checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString() == "Часы") || (checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString() == "Вторая попытка" && analis.GetRowName(j + 1) == "SA")))
                                analis.AddValueTable(analis.GetCountRow() - 2, j + 1, MainTable.Rows[i].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value.ToString());
                        }
                    }
                    sequenceofpagenumbers += numericUpDownNumNewPage.Value + "\n";
                }
                else
                {
                    if (оПрограммеToolStripMenuItem.Text == "Отключить оповещения")
                        MessageBox.Show("Выберете проверямый алгоритм замещения страниц!", "Ошибка!");
                    return;
                }
            }
            analis.SetTitleChart((int)NumberofPageBlocks.Value);
            if (оПрограммеToolStripMenuItem.Text == "Отключить оповещения")
                MessageBox.Show("Данные считаны из файла!", "Отчет о завершении");
        }

        private void numericUpDownmaxpagesblock_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownmaxpagesblock.Value < numericUpDowndifferentpages.Value)
                NumberofPageBlocks.Maximum = numericUpDownmaxpagesblock.Value;
            else
            {
                if (оПрограммеToolStripMenuItem.Text == "Отключить оповещения")
                    MessageBox.Show("Максимальное количество\nстраничных блоков должно\nбыть меньше разнаобразия страниц!\nИначе подсчет эффективности\nне имеет смысла.", "Ошибка!");
                numericUpDownmaxpagesblock.Value = numericUpDowndifferentpages.Value - 1;
            }
        }

        private void numericUpDowndifferentpages_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownmaxpagesblock.Value < numericUpDowndifferentpages.Value)
                numericUpDownNumNewPage.Maximum = numericUpDowndifferentpages.Value-1;
            else
            {
                if (оПрограммеToolStripMenuItem.Text == "Отключить оповещения")
                    MessageBox.Show("Максимальное количество\nстраничных блоков должно\nбыть меньше разнаобразия страниц!\nИначе подсчет эффективности\nне имеет смысла.", "Ошибка!");
                numericUpDowndifferentpages.Value=numericUpDownmaxpagesblock.Value + 1;
            }
        }

        private void checkboxrandomNRU_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxrandomNRU.Checked == true)
            {
                checkboxhandNRU.Checked = false;
                checkboxhandNRU.Enabled = false;
            }
            else
                checkboxhandNRU.Enabled = true;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            analis.Close();
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string tempstr = "Программный комплекс для проверки\nэффективности различных алгоритмов\nсортировки страниц и сравнения оных.\nОрганизация: СПбгТИ(ТУ)\nГруппа: 494\nАвтор: Казанцев Александр Михайлович\nСанкт-Петербург, 2022 г.";
            MessageBox.Show(tempstr, "О программе");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (оПрограммеToolStripMenuItem.Text == "Отключить оповещения")
                оПрограммеToolStripMenuItem.Text = "Включить оповещения";
            else
                оПрограммеToolStripMenuItem.Text = "Отключить оповещения";
        }

        private void обновитьToolStripMenuItem_Click_1(object sender, EventArgs e)

        {
            analis.Close();
            analis = new AnalisAlgoritmsSortingPageForm();
            analis.Visible = false;
            checkboxhandNRU.Visible = false;
            checkboxrandomNRU.Visible = false;
            sequenceofpagenumbers = "";
            temparrSA = new bool[Int32.Parse(NumberofPageBlocks.Value.ToString())];
            analis.SetTitleChart(Int32.Parse(NumberofPageBlocks.Value.ToString()));
            for (int i = 0; i < NumberofPageBlocks.Value; i++)
                temparrSA[i] = false;
            temparrClock = new bool[Int32.Parse(NumberofPageBlocks.Value.ToString())];
            for (int i = 0; i < NumberofPageBlocks.Value; i++)
                temparrClock[i] = false;
            indesclockwise = 0;
            temparrLRU = new int[Int32.Parse(NumberofPageBlocks.Value.ToString())];
            for (int i = 0; i < NumberofPageBlocks.Value; i++)
                temparrLRU[i] = 0;
            temparrNRU = new int[Int32.Parse(NumberofPageBlocks.Maximum.ToString())];
            for (int i = 0; i < NumberofPageBlocks.Maximum; i++)
                temparrNRU[i] = 0;
            MainTable.Columns.Clear();
            MainTable.Columns.Add(new DataGridViewTextBoxColumn() { Name = "№ страничного блока", Width = 100 });
            for (int i = 0; i < NumberofPageBlocks.Value; i++)
            {
                MainTable.Columns.Add(new DataGridViewTextBoxColumn() { Name = (i + 1).ToString(), Width = 25 });
            }
            MainTable.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Количество прерываний", Width = 100 });
            bool flagTimerNRU = false;
            if (checkedListBoxAlgoritmsSortingPage.CheckedItems.Count > 0)
            {
                analis.ClearTable();
                for (int i = 0; i < checkedListBoxAlgoritmsSortingPage.CheckedItems.Count; i++)
                {
                    MainTable.Rows.Add();
                    MainTable.Rows[i].Cells[0].Value = checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString();
                    MainTable.Rows[i].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value = "0";
                    if (checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString() == "NRU")
                    {
                        checkboxhandNRU.Visible = true;
                        flagTimerNRU = true;
                        checkboxrandomNRU.Visible = true;
                        timerNRY.Enabled = true;
                    }
                    else if (!flagTimerNRU)
                        timerNRY.Enabled = false;
                }
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "HelpOS.chm");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sequenceofpagenumbers != "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = saveFileDialog1.FileName + ".txt";
                System.IO.File.WriteAllText(filename, sequenceofpagenumbers);
                if (оПрограммеToolStripMenuItem.Text == "Отключить оповещения")
                    MessageBox.Show("Файл сохранен", "Отчет о завершении");
            }
            else
                if (оПрограммеToolStripMenuItem.Text == "Отключить оповещения")
                    MessageBox.Show("Нечего сохранять!", "Ошибка!");
        }

        private void buttonnewPage_Click(object sender, EventArgs e)
        {
            if ((checkedListBoxAlgoritmsSortingPage.CheckedItems.Count > 0) && (checkedListBoxAlgoritmsSortingPage.CheckedItems.Count == MainTable.Rows.Count-1))
            {
                analis.AddRowTable();
                analis.AddValueTable(analis.GetCountRow() - 2, 0, (analis.GetCountRow()-1).ToString());
                for (int i = 0; i < checkedListBoxAlgoritmsSortingPage.CheckedItems.Count; i++)
                {
                    if (checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString() == "FIFO")
                        FIFONewPage(i);
                    if (checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString() == "LRU")
                        LRUNewPage(i);
                    if (checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString() == "NRU")
                        NRUNewPage(i);
                    if (checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString() == "Вторая попытка")
                        SecondAttemptNewPage(i);
                    if (checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString() == "Часы")
                        ClockNewPage(i);
                    for (int j = 0; j < 5; j++)
                    {
                        if ((analis.GetRowName(j + 1) == checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString())|| ((analis.GetRowName(j + 1) == "Clock" && checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString() == "Часы") || (checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString() == "Вторая попытка" && analis.GetRowName(j + 1) == "SA")))
                            analis.AddValueTable(analis.GetCountRow() - 2, j + 1, MainTable.Rows[i].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value.ToString());
                    }
                }
                
                sequenceofpagenumbers += numericUpDownNumNewPage.Value+"\n";
            }
            else if(checkedListBoxAlgoritmsSortingPage.CheckedItems.Count > MainTable.Rows.Count - 1)
            {
                analis.ClearTable();
                MainTable.Rows.Clear();
                for (int i = 0; i < checkedListBoxAlgoritmsSortingPage.CheckedItems.Count; i++)
                {
                    MainTable.Rows.Add();
                    MainTable.Rows[i].Cells[0].Value = checkedListBoxAlgoritmsSortingPage.CheckedItems[i].ToString();
                    MainTable.Rows[i].Cells[Int32.Parse(NumberofPageBlocks.Value.ToString()) + 1].Value = "0";
                }
            }
            else
            {
                if (оПрограммеToolStripMenuItem.Text == "Отключить оповещения")
                    MessageBox.Show("Выберете проверямый алгоритм сортировки!", "Ошибка!");
            }
        }
    }
}
