using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    class Core
    {
        #region <<<變數>>>
        //遊戲規格
        public int _cols;
        public int _rows;
        public int _mines;

        //遊戲輸入座標
        public int _x = 0;
        public int _y = 0;

        //地雷陣列
        public int[] _minesArr;
        public MapArr[,] _mapArr;
        public struct MapArr
        {
            public bool isMarked;
            public bool isOpen;
            public bool isMine;
            public int toCount;
        };
        readonly Timer _timer;

        //計分變數
        int _flags;
        int _blocks;
        #endregion

        #region<<<屬性>>>
        public int Columns
        {
            get
            {
                return _cols;
            }
            set
            {
                _cols = value;
            }
        }
        public int Rows
        {
            get
            {
                return _rows;
            }
            set
            {
                _rows = value;
            }
        }
        public int Mines
        {
            get
            {
                return _mines;
            }
            set
            {
                _mines = value;
            }
        }
        public int Time { get; set; }
        #endregion

        #region<<<事件>>>
        public EventHandler OnTick;
        public EventHandler Win;
        public EventHandler ToOpen;
        public EventHandler Explode;
        public EventHandler Restart;
        #endregion

        public Core()
        {
            _timer = new Timer
            {
                Interval = 1000
            };
            _timer.Tick += TickTimer;
        }
        public void Start()
        {
            Time = 0;
            _timer.Start();
            _blocks = 0;
            _flags = 0;
            CreateMines();
            PlaceMines();
            GetResult();
            Cheating();
        }
        private void TickTimer(object sender, EventArgs e)
        {
            OnTick(sender, e);
            Time++;
        }
        public void CheckEmpty(int _x, int _y)
        {
            while (_mapArr[_y, _x].toCount !=0 || _mapArr[_y, _x].isMine == true)
            {
                _blocks = 0;
                _flags = 0;
                CreateMines();
                PlaceMines();
                GetResult();
                Cheating();
                Restart(null, null);
            }
        }
        public void CreateMines()
        {
            _minesArr = new int[_mines];
            Random random = new Random();
            bool used;
            for (int i = 0; i<_mines; i++)
            {
                do
                {
                    _minesArr[i] = random.Next() % (_cols * _rows);
                    used = false;

                    for (int k = 0; k < i; k++)
                    {
                        if (_minesArr[k] == _minesArr[i])
                        {
                            used = true;
                            break;
                        }
                    }
                } while (used);
            }
        }
        public void PlaceMines()
        {
            _mapArr = new MapArr[_rows,_cols];
           
            for (int i = 0; i < _mines; i++)
            {
                int iy = _minesArr[i] / _cols;
                int ix = _minesArr[i] % _cols;
                _mapArr[iy, ix].isMine = true;
            }
        }
        public int CountMines(int _x, int _y)
        {
            int _rst = 0;
            for(int iy =0; iy<3; iy++)
            {
                for(int ix = 0; ix<3; ix++)
                {
                    int trans_rows = _y - 1 + iy;
                    int trans_cols = _x - 1 + ix;

                    if (trans_cols == _x & trans_rows == _y) continue;
                    if (trans_cols < 0 || trans_rows < 0) continue;
                    if (trans_cols >= _cols || trans_rows >= _rows) continue;

                    if (_mapArr[trans_rows, trans_cols].isMine == true)
                        _rst++;
                }
            }
            return _rst;
        }
        public void Cheating()
        {
            for (int i =0; i<_rows; i++)
            {
                for(int j = 0; j < _cols; j++)
                {
                    if (_mapArr[i, j].isMine == true)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void GetResult()
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    _mapArr[i, j].toCount = CountMines(j, i);
                }
            }
        }
        public void Judgement(int _x, int _y, bool _isFlag)
        {
            if (_isFlag == true)
            {
                FlagMode(_x, _y);
            }
            else
            {
                ButtonRevealed(_x, _y);
            }
            WinCondition();
            Winning();
        }
        public void FlagMode(int _x, int _y)
        {
                if (_mapArr[_y, _x].isMarked == true)
                {
                    if (_mapArr[_y, _x].isMine == true)
                    {
                        _flags--;
                    }
                    _mapArr[_y, _x].isMarked = false;
                }
                else
                {
                    if (_mapArr[_y, _x].isMine == true)
                    {
                        _flags++;
                    }
                    _mapArr[_y, _x].isMarked = true;
                }
        }
        public void ButtonRevealed(int _x, int _y)
        {
            if (_mapArr[_y, _x].isMine == true)
            {
                Explode(null, null);
            }
            else
            {
                OpenBlocks(_x, _y);
            }
        }
        public void OpenBlocks(int _x, int _y)
        {
            if (_mapArr[_y, _x].isOpen == false)
            {
                _mapArr[_y, _x].isOpen = true;
                ToOpen((Object)(_x + _y * _cols), null);
                if (_mapArr[_y, _x].toCount == 0)
                {
                    Spread(_x - 1, _y - 1);
                    Spread(_x - 0, _y - 1);
                    Spread(_x + 1, _y - 1);
                    Spread(_x - 1, _y - 0);
                    Spread(_x + 1, _y - 0);
                    Spread(_x - 1, _y + 1);
                    Spread(_x - 0, _y + 1);
                    Spread(_x + 1, _y + 1);
                }
            }
        }
        public void Spread(int _x, int _y)
        {
            if (_x >= 0 && _y >= 0)
            {
                if (_x < (_mapArr.GetLength(1)) && _y < _mapArr.GetLength(0))
                {
                    if(_mapArr[_y, _x].isMine == false)
                    {
                        OpenBlocks(_x, _y);
                    }
                }
            }
        }
        public void WinCondition()
        {
            _blocks = 0;
            for (int iy = 0; iy < _rows; ++iy)
            {
                for (int ix = 0; ix < _cols; ++ix)
                {
                    if (_mapArr[iy, ix].isOpen == true)
                    {
                        _blocks++;
                    }
                }
            }
        }
        public void Winning()
        {
            if ((_blocks + _flags == (_cols*_rows))||(_blocks == (_cols * _rows - _mines)))
            {
                Win(null, null);
                _blocks = 0;
                _flags = 0;
            }
        }
        public void Stop()
        {
            _timer.Stop();
        }
    }
}
