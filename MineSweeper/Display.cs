using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Display : Form
    {
        public int _minestext;
        public int _cols;
        public int _rows;
        public bool isFlag;
        public int minetext;
        public int _width;
        public int _height;
        public bool FirstClick;

        readonly Core Core;
        Label labelNum;
        Label[] labelMine;
        Button[] btns;

        public Display()
        {
            Core = new Core();
            InitializeComponent();
            Core.Win += Core_Win;
            Core.OnTick += Core_OnTick;
            Core.Explode += Core_Explode;
            Core.ToOpen += Core_ToOpen;
            Core.Restart += Core_Restart;
            _width = 30;
            _height = 30;
        }
        private void GameInfoInput()
        {
            Core.Columns = Convert.ToInt32(textCols.Text);
            Core.Rows = Convert.ToInt32(textRows.Text);
            Core.Mines = Convert.ToInt32(textMines.Text);
            _cols = Core.Columns;
            _rows = Core.Rows;
            _minestext = Core.Mines;
            labelMines.Text = _minestext.ToString();
        }
        private void ButtonCreate()
        {
            btns = new Button[_cols * _rows];
            for (int y = 0; y < _rows; ++y)
            {
                for (int x = 0; x < _cols; ++x)
                {
                    int i = x + y * _cols;
                    btns[i] = new Button
                    {
                        BackColor = Color.DarkGray,
                        FlatStyle = FlatStyle.Flat
                    };
                    btns[i].FlatAppearance.BorderColor = Color.LightGray;
                    btns[i].Location = new Point(_width * x, _height * y);
                    btns[i].Tag = i;
                    btns[i].Size = new Size(_width, _height);
                    btns[i].TabStop = false;
                    btns[i].MouseDown += new MouseEventHandler(ClickMode);
                }
            }
            PanelBlocks.Controls.AddRange(btns);

        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            FirstClick = true;
            GameInfoInput();
            Core.Start();
            PanelBlocks.Controls.Clear();
            ButtonCreate();
            PanelBlocks.Enabled = true;
        }
        private void ClickMode(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            int y = (int)btn.Tag / _cols;
            int x = (int)btn.Tag % _cols;

            if (e.Button == MouseButtons.Right)
            {
                if (btn.Text != "？")
                {
                    isFlag = true;
                    Core.Judgement(x, y, isFlag);
                    RightClickMode(btn, x, y);
                }
                else
                {
                    btn.Text = null;
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (FirstClick == true)
                {
                    FirstClick = false;
                    Core.CheckEmpty(x, y);
                }

                isFlag = false;
                if (Core._mapArr[y, x].isMarked == false)
                {
                    Core.Judgement(x, y, isFlag);
                }
            }
        }
        private void RightClickMode(Button btn, int x, int y)
        {
            if (Core._mapArr[y, x].isMarked == true)
            {
                btn.BackColor = Color.DarkRed;
                _minestext--;
                labelMines.Text = _minestext.ToString();
            }
            else
            {
                btn.Text = "？";
                btn.Font = new Font("微軟正黑體", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136)));
                btn.BackColor = Color.DarkGray;
                _minestext++;
                labelMines.Text = _minestext.ToString();
            }
        }
        private void ShowNum(int x, int y)
        {
            btns[x + y * _cols].Visible = false;
            labelNum = new Label
            {
                Font = new Font("微軟正黑體", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136))),
                Location = new Point(_width * x, _height * y),
                Size = new Size(_width,  _height),
                Text = Core.CountMines(x, y).ToString(),
                TextAlign = ContentAlignment.MiddleCenter,
                BorderStyle = BorderStyle.Fixed3D
            };
            PanelBlocks.Controls.Add(labelNum);
            switch (Convert.ToInt32(labelNum.Text) % 3)
            {
                case 1:
                labelNum.ForeColor = Color.DarkBlue;
                break;
                case 2:
                labelNum.ForeColor = Color.DarkGreen;
                break;
                case 0:
                labelNum.ForeColor = Color.DarkRed;
                break;
            }
            if(Convert.ToInt32(labelNum.Text) == 0)
            {
                labelNum.Text = " ";
            }
        }
        private void ShowallMines()
        {
            labelMine = new Label[Core._minesArr.Length];
            for (int i = 0; i < Core._minesArr.Length; i++)
            {
                labelMine[i] = new Label
                {
                    Font = new Font("微軟正黑體", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136))),
                    Size = new Size(_width, _height),
                    Text = "#",
                    TextAlign = ContentAlignment.MiddleCenter,
                    BorderStyle = BorderStyle.Fixed3D
                };
                labelMine[i].Location = btns[Core._minesArr[i]].Location;
                PanelBlocks.Controls.AddRange(labelMine);
                btns[Core._minesArr[i]].Visible = false;
            }
        }
        private void Core_Win(object sender, EventArgs e)
        {
            Core.Stop();
            MessageBox.Show("You Win !!!");
            PanelBlocks.Enabled = false;
        }
        private void Core_OnTick(object sender, EventArgs e)
        {
            labelTime.Text = Core.Time.ToString();
        }
        private void Core_Restart(object sender, EventArgs e)
        {
            labelNum = null;
            labelMine = null;
        }
        private void Core_ToOpen(object sender, EventArgs e)
        {
            int position = (int)sender;
            int x = position % _cols;
            int y = position / _cols;
            ShowNum(x, y);
        }
        private void Core_Explode(object sender, EventArgs e)
        {
            ShowallMines();
            Core.Stop();
            MessageBox.Show("Boom !!!");
            PanelBlocks.Enabled = false;
        }

    }
}
