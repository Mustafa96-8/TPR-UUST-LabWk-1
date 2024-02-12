using System.Security.Cryptography;
using System.Windows.Forms;
using System;

namespace tpr_1_Maybe
{
    public partial class Form1 : Form
    {
        int statesCount;
        int strategiesCount;
        int stagesCount;
        Model globalMOdel;

        public Form1()
        {
            InitializeComponent();

            statesCount = Convert.ToInt32(numericUpDownN.Value);
            strategiesCount = Convert.ToInt32(numericUpDownS.Value);
            stagesCount = Convert.ToInt32(numericUpDownStages.Value);
            RecreateTable(statesCount, strategiesCount);
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void RecreateTable(int N, int S)
        {
            statesCount = N;
            strategiesCount = S;
            

            // столбцы (стратегии)
            grid.Columns.Clear();
            
            for (int i = 1; i <= S; i++)
            {
                grid.Columns.Add($"P{i}", $"P{i}");
                grid.Columns.Add($"R{i}", $"R{i}");
            }
            grid.RowHeadersWidth = 50;
            // строки (стратегии)
            grid.Rows.Clear();
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    var idx = grid.Rows.Add();
                    grid.Rows[idx].HeaderCell.Value = $"{i}->{j}";
                }
            }

            //автозаполнение нулями
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                for (int j = 0; j < grid.Columns.Count; j++)
                {
                    grid.Rows[i].Cells[j].Value = "0";
                }
            }
        }

        private void buttonRecreateTable_Click(object sender, EventArgs e)
        {
            statesCount = Convert.ToInt32(numericUpDownN.Value);
            strategiesCount = Convert.ToInt32(numericUpDownS.Value);
            stagesCount = Convert.ToInt32(numericUpDownStages.Value);

            RecreateTable(statesCount, strategiesCount);
        }

        private Model createModel()
        {
            stagesCount = Convert.ToInt32(numericUpDownStages.Value);

            var strategies = new List<Strategy>();
            for (int str = 0; str < strategiesCount; str++)
            {
                var P = new double[statesCount, statesCount];
                var R = new double[statesCount, statesCount];
                for (int i = 0; i < statesCount; i++)
                {
                    for (int j = 0; j < statesCount; j++)
                    {
                        try
                        {
                            P[i, j] = Convert.ToDouble(grid.Rows[i * statesCount + j].Cells[str * 2].Value);
                            R[i, j] = Convert.ToDouble(grid.Rows[i * statesCount + j].Cells[str * 2 + 1].Value);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show($"Error in {i}->{j}, Num of Strategy - {str + 1}");
                            return null;
                        }
                    }
                }

                strategies.Add(new Strategy(R, P, statesCount));
            }

            var model = new Model() { stages = stagesCount, strategies = strategies };
            model.calculate();
            globalMOdel = model;
            return model;
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {

            legend.Items.Clear();
            comboBox.Items.Clear();

            Model model = globalMOdel;
            if (grid.Rows.Count != 0)
            {
                model = createModel();
                if (model != null)
                {
                    int N = model.strategies[0].N;
                    int S = model.strategies.Count;
                    for (int i = 0; i < model.stages; i++)
                    {
                        comboBox.Items.Add($"{i}->{i + 1}");
                    }
                    for (int i = 0; i < S; i++)
                    {
                        var item = new Legend()
                        {
                            ItemColor = colors[i],
                            Message = $"Strategy №{i + 1}"
                        };
                        legend.Items.Add(item);
                    }
                    comboBox.SelectedIndex = 0;

                    RecreateTableQ(N, S,model);
                    RecreateTableF(N, S,model);

                    legend.Invalidate();
                }

            }
        }

        // открыть
        private void button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (var sr = new StreamReader(ofd.FileName))
                {
                    var N = Convert.ToInt32(sr.ReadLine());
                    var S = Convert.ToInt32(sr.ReadLine());
                    numericUpDownN.Value = N;
                    numericUpDownS.Value = S;

                    RecreateTable(N, S);

                    List<double> numbers;
                    for (int s = 0; s < S; s++)
                    {
                        for (int i = 0; i < N; i++)
                        {
                            numbers = readNums(sr.ReadLine());
                            for (int j = 0; j < N; j++)
                            {
                                grid.Rows[i * N + j].Cells[s * 2].Value = numbers[j];
                            }
                        }

                        for (int i = 0; i < N; i++)
                        {
                            numbers = readNums(sr.ReadLine());
                            for (int j = 0; j < N; j++)
                            {
                                grid.Rows[i * N + j].Cells[s * 2 + 1].Value = numbers[j];
                            }
                        }
                    }
                }
            }
        }

        List<double> readNums(string str)
        {
            return str.Trim().Split(' ').Select((s) => Convert.ToDouble(s)).ToList();
        }

        // сохранить
        private void button2_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var sw = new StreamWriter(sfd.FileName))
                {
                    sw.WriteLine(statesCount);
                    sw.WriteLine(strategiesCount);
                    for (int s = 0; s < strategiesCount; s++)
                    {
                        for (int i = 0; i < statesCount; i++)
                        {
                            for (int j = 0; j < statesCount; j++)
                            {
                                sw.Write(grid.Rows[i * statesCount + j].Cells[s * 2].Value);
                                sw.Write(' ');
                            }
                            sw.Write('\n');
                        }

                        for (int i = 0; i < statesCount; i++)
                        {
                            for (int j = 0; j < statesCount; j++)
                            {
                                sw.Write(grid.Rows[i * statesCount + j].Cells[s * 2 + 1].Value);
                                sw.Write(' ');
                            }
                            sw.Write('\n');
                        }
                    }
                }
            }
        }

        private void RecreateTableQ(int N, int S, Model model)
        {
            gridQ.Columns.Clear();

            // столбцы
            gridQ.Columns.Add("N", "Состояния");
            gridQ.Columns.Add("S", "Strategy");
            gridQ.Columns.Add("D", "Ожидаемые доходности");

            // строки
            gridQ.Rows.Clear();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < model.strategies.Count; j++)
                {
                    var idx = gridQ.Rows.Add();
                    gridQ.Rows[idx].Cells[0].Value = i + 1;
                    gridQ.Rows[idx].Cells[1].Value = j + 1;
                    gridQ.Rows[idx].Cells[2].Value = string.Format("{0:0.00}", model.Q[j, i]);
                }
            }
        }
        private void RecreateTableF(int N, int S,Model model)
        {
            gridF.Columns.Clear();
            // столбцы
            for (int i = 0; i <= model.stages; i++)
            {
                gridF.Columns.Add($"n{i}", $"{i}");
            }

            gridF.RowHeadersWidth = 80;
            // строки
            gridF.Rows.Clear();
            for (int i = 0; i < N; i++)
            {
                var idV = gridF.Rows.Add();
                gridF.Rows[idV].HeaderCell.Value = $"V{i + 1}(n)";
                for (int j = 0; j <= model.stages; j++)
                {
                    gridF.Rows[idV].Cells[j].Value = string.Format("{0:0.00}", model.V[i, j]);
                }
            }
            for (int i = 0; i < N; i++)
            {
                var idD = gridF.Rows.Add();
                gridF.Rows[idD].HeaderCell.Value = $"d{i + 1}(n)";
                for (int j = 0; j <= model.stages; j++)
                {
                    if (model.D[i, j] == -1)
                    {
                        gridF.Rows[idD].Cells[j].Value = "-";
                    }
                    else
                    {
                        gridF.Rows[idD].Cells[j].Value = model.D[i, j] + 1;
                    }
                }
            }
        }

        static Color[] colors = new Color[] {
        Color.Olive, Color.LimeGreen, Color.Orange,
        Color.Red, Color.Blue, Color.DarkGoldenrod,
        Color.DarkCyan, Color.Yellow, Color.Black
        };

        static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private void panel_Paint(object sender, EventArgs e)
        {
            Model model = globalMOdel;
            // размеры
            float offset = 14;
            float width = 350;
            float height = 30;
            float size = 25;

            // набор для рисования
            var g = panel.CreateGraphics();
            var penBlack = new Pen(Brushes.Black, 2);
            Pen pen;
            Font font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);

            var stage = comboBox.SelectedIndex + 1; // этап -> этап+1
            
            var N = model.strategies[0].N;

            // линии
            for (int i = 0; i < N; i++)
            {
                var optimal = model.D[i, stage];
                var strategy = model.strategies[optimal];

                for (int j = 0; j < N; j++)
                {
                    var p = strategy.P[i, j];

                    if (true)
                    {
                        // цвет линии согласно стратегии
                        pen = new Pen(colors[optimal % colors.Length], 2);

                        float x1 = offset + (size / 2);
                        float y1 = offset + (i + 1) * (height + size) - (size / 2);
                        float x2 = offset + width + (size / 2);
                        float y2 = offset + (j + 1) * (height + size) - (size / 2);

                        //float centerX = x1 - ((x1 - x2) / 3);
                        //float centerY = y1 - ((y1 - y2) / 3);

                        g.DrawLine(pen, x1, y1, x2, y2);

                        //g.DrawString(
                        //    $"{strategy.P[i, j]} ({strategy.R[i, j]})",
                        //    font,
                        //    Brushes.Black,
                        //    new PointF(centerX - 14, centerY - 8)
                        //    );
                    }
                }
            }

            // элементы
            for (int state = 0; state < N; state++)
            {
                // левый
                float x1 = offset;
                float y1 = offset + (state + 1) * (height + size) - size;

                // правый
                float x2 = offset + width;
                float y2 = offset + (state + 1) * (height + size) - size;

                g.FillEllipse(Brushes.White, x1, y1, size, size);
                g.DrawEllipse(penBlack, x1, y1, size, size);
                g.DrawString($"{alphabet[state]}", font, Brushes.Black,
                    x1 + (size / 2) - 8, y1 + (size / 2) - 8);

                g.FillEllipse(Brushes.White, x2, y2, size, size);
                g.DrawEllipse(penBlack, x2, y2, size, size);
                g.DrawString($"{alphabet[state]}", font, Brushes.Black,
                    x2 + (size / 2) - 8, y2 + (size / 2) - 8);
            }
        }

        private void StrNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            panel.Invalidate();
        }

        private void legend_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            var item = legend.Items[e.Index] as Legend; // Get the current item and cast it to MyListBoxItem
            if (item != null)
            {
                e.Graphics.DrawString( // Draw the appropriate text in the ListBox
                    item.Message, // The message linked to the item
                    legend.Font, // Take the font from the listbox
                    new SolidBrush(item.ItemColor), // Set the color 
                    0, // X pixel coordinate
                    e.Index * legend.ItemHeight // Y pixel coordinate.  Multiply the index by the ItemHeight defined in the listbox.
                );
            }
            else
            {
                // The item isn't a MyListBoxItem, do something about it
            }
        }
    }
}