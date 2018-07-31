using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace HBC.ShopLib
{
    public partial class GoodsPanel : UserControl
    {
        #region внутренние переменные
        private int CurrentScreen = 0;
        private int Screens = 1; // количество экранв
        private List<Goods> _GoodsList;
        private int GoodsCount;
        private string ParentGroup = string.Empty;
        private string GrandParentGroup = string.Empty;
        private int _ColumnCount = 0;
        private int _RowCount = 0;
        #endregion

        #region События
        [Category("HBC"), Description("Нажата кнопка")]
        public event EventHandler<StringEventArgs> KeyPressed;

        [Category("HBC"), Description("Показать товар")]
        public event EventHandler<StringEventArgs> DisplayGoods;

        [Category("HBC"), Description("Открыь корзину")]
        public event EventHandler OrderBoxEvt;

        [Category("HBC"), Description("Запрос группы")]
        public event EventHandler<StringEventArgs> GetGroup;
        #endregion

        #region Параметры
        [Category("HBC"), Description("Путь к картинкам"), Browsable(false)]
        public string PicturePath { set; get; }

        [Category("HBC"), Description("Количество кнопок в строке")]
        public int ColumnCount
        {
            get => _ColumnCount;
            set
            {
                _ColumnCount = value;
                Screens = GoodsCount / _RowCount / _ColumnCount;
                MakeTableColumns();
                MakeButtons();
            }
        }

        [Category("HBC"), Description("Количество кнопок в столбце")]
        public int RowCount
        {
            get => _RowCount;
            set
            {
                _RowCount = value;
                Screens = GoodsCount / _RowCount / _ColumnCount;
                MakeTableRows();
                MakeButtons();
            }
        }
        #endregion

        public void SetGoodsList(List<Goods> V)
        {
            GoodsCount = V.Count();
            _GoodsList = (GoodsCount != 0) ? V : DebugAddGoods();

            if (_RowCount < 1)
                _RowCount = 1;
            if (_ColumnCount < 1)
                _ColumnCount = 1;
            Screens = V.Count() / _RowCount / _ColumnCount;
            //
            ParentGroup = (_GoodsList.Count() > 0) ? _GoodsList.First().Parent : string.Empty;
            GrandParentGroup = (_GoodsList.Count() > 0) ? _GoodsList.First().GrandParent : ParentGroup;
            //
            CurrentScreen = 0;
            MakeButtons();
        }

        public GoodsPanel()
        {
            InitializeComponent();

            //tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single; // Отладка

            MakeTableRows();
            MakeTableColumns();
            MakeButtons();

#if DEBUG
            #region Отладка
            if (_GoodsList == null)
                SetGoodsList(DebugAddGoods());
            #endregion  
#endif
        }

        private void MakeTableRows()
        {
            tableLayoutPanel1.RowCount = _RowCount;
            tableLayoutPanel1.RowStyles.Clear();
            for (int i = 0; i < _RowCount; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle
                {
                    SizeType = SizeType.Percent,
                    Height = 100 / _RowCount
                });
            }
        }
        private void MakeTableColumns()
        {
            tableLayoutPanel1.ColumnCount = _ColumnCount;
            tableLayoutPanel1.ColumnStyles.Clear();
            for (int j = 0; j < _ColumnCount; j++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle
                {
                    SizeType = SizeType.Percent,
                    Width = 100 / _ColumnCount
                });
            }
        }

        private void MakeButtons()
        {
            tableLayoutPanel1.Controls.Clear();
            for (int i = 0; i < _RowCount; i++)
            {
                for (int j = 0; j < _ColumnCount; j++)
                {
                    PB button = new PB() { Dock = DockStyle.Fill, Tag = $"{i * _ColumnCount + j}" };
                    button.Click += Button_Click;
                    button.KeyPressed += Button_KeyPressed;
                    tableLayoutPanel1.Controls.Add(button, j, i);
                }
            }
            RedrawScreen();
        }

        private void Button_KeyPressed(object sender, StringEventArgs e)
        {
            KeyPressed?.Invoke(sender, e);
        }

        private List<Goods> DebugAddGoods()
        {
            List<Goods> L = new List<Goods>();
            //for (int i = 0; i < 33; i++)
            //{
            //    string aaa = (i % 8 == 0) ? "Группа" : "Товар";
            //    L.Add(new Goods
            //    {
            //        Code = $"{CurrentScreen * RowCount * ColumnCount + i}",
            //        Title = $"{aaa} {CurrentScreen * RowCount * ColumnCount + i}",
            //        Grp = (i % 8 == 0),
            //        //Images = null,
            //        Parent = string.Empty
            //    });
            //}
            return L;
        }

        // при нажатиии на кнопку с товаром
        private void Button_Click(object sender, EventArgs e)
        {
            PB b = sender as PB;
            Goods G = _GoodsList.Find(x => x.Code == b.Tag.ToString());

            if (!G.Grp)
            {
                if (DisplayGoods == null)
                {
                    MessageBox.Show($"{G.Title}" + Environment.NewLine + $"{G.Code}");
                }
                else
                {
                    DisplayGoods?.Invoke(sender, new StringEventArgs(G.Code));
                }
                OrderBoxBTN.Visible = (Common.CurrentOrder != null);
            }
            else
            {
                if (GetGroup == null)
                    MessageBox.Show($"{G.Code}");
                //ParentGroup= _GoodsList.Find(x => x.Code == b.Tag.ToString())?.Parent;
                GetGroup?.Invoke(this, new StringEventArgs(G.Code));
            }
            OrderBoxBTN.Visible = (Common.CurrentOrder != null);
        }

        private void GoodsPanel_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                BorderStyle = BorderStyle.None;
                RedrawScreen();
            }
            else
                BorderStyle = BorderStyle.FixedSingle;
        }

        private void RightBTN_Click(object sender, EventArgs e)
        {
            if (CurrentScreen < Screens)
                CurrentScreen++;
            RedrawScreen();
        }

        private void LeftBTN_Click(object sender, EventArgs e)
        {
            if (0 < CurrentScreen)
                CurrentScreen--;
            RedrawScreen();
        }

        /// <summary>
        /// Установка видимости кнопок
        /// </summary>
        private void RedrawScreen()
        {
            int GoodsOnScreen = RowCount * ColumnCount;
            if (CurrentScreen == Screens)
                GoodsOnScreen = GoodsCount % GoodsOnScreen;

            // видимость управления
            RightBTN.Visible = (CurrentScreen < Screens);
            LeftBTN.Visible = (0 < CurrentScreen);
            UpBTN.Visible = ((ParentGroup != string.Empty) || (_GoodsList?.Count == 0));
            OrderBoxBTN.Visible = (Common.CurrentOrder != null);

            if (_GoodsList?.Count == 0)
            {
                tableLayoutPanel1.Controls.Clear();
                Label L = new Label
                {
                    Text = "Товары не найдены",
                    Dock = DockStyle.Fill,
                    ForeColor = Color.Red,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font(DefaultFont.FontFamily.Name, 40, FontStyle.Bold)
                };
                L.PreviewKeyDown += TableLayoutPanel1_PreviewKeyDown;
                tableLayoutPanel1.Controls.Add(L, 0, 0);

                if (tableLayoutPanel1.ColumnCount > 0)
                    tableLayoutPanel1.SetColumnSpan(L, tableLayoutPanel1.ColumnCount);
                if (tableLayoutPanel1.RowCount > 0)
                    tableLayoutPanel1.SetRowSpan(L, tableLayoutPanel1.RowCount);
            }
            else
            {
                //????
                //if (tableLayoutPanel1.Controls.Count < RowCount * ColumnCount)
                //    MakeButtons();

                for (int i = 0; i < RowCount * ColumnCount; i++)
                {
                    if (tableLayoutPanel1.Controls.Count > 0)
                    {
                        PB b = (tableLayoutPanel1.Controls[i] as PB);
                        if (i < GoodsOnScreen)
                        {
                            int ind = (CurrentScreen * RowCount * ColumnCount + i);
                            string T = (_GoodsList.Count() > 0) ? _GoodsList.ElementAt(ind).Title : string.Empty;
                            string C = (_GoodsList.Count() > 0) ? _GoodsList.ElementAt(ind).Code : string.Empty;
                            b.Grp = _GoodsList.ElementAt(ind).Grp;
                            if (!_GoodsList.ElementAt(ind).Grp)
                            {
                                string Filename = $"{PicturePath}{_GoodsList.ElementAt(ind).Code}.M.jpg";
                                if (!File.Exists(Filename))
                                {
                                    string StringImage = Common.GetImageMain(_GoodsList.ElementAt(ind).Code);
                                    Image Img = Common.PictureFromBase64(StringImage);
                                    Img?.Save(Filename,ImageFormat.Bmp);
                                }
                                if (File.Exists(Filename))
                                    b.Image = Image.FromFile(Filename);
                                else
                                    b.Image = Properties.Resources.bazby;
                                //b.Image = Common.PictureFromBase64(_GoodsList.ElementAt(ind)?.MainImage);//???
                            }

                            b.Margin = new Padding(0, 0, 0, 0);
                            b.TabIndex = i;
                            b.Title = $"{T}";
                            b.Tag = $"{C}";
                            b.Visible = true;
                        }
                        else
                            b.Visible = false;
                    }
                }
            }
        }

        private void UpBTN_Click(object sender, EventArgs e)
        {
            if (GetGroup == null)
                MessageBox.Show($"{GrandParentGroup}");
            GetGroup?.Invoke(this, new StringEventArgs((_GoodsList.Count > 0) ? GrandParentGroup : ParentGroup));
        }

        private void OrderBoxBTN_Click(object sender, EventArgs e)
        {
            OrderBoxEvt?.Invoke(this, new EventArgs());
            OrderBoxBTN.Visible = (Common.CurrentOrder != null);
        }

        private void TableLayoutPanel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            KeyPressed?.Invoke(sender, new StringEventArgs(e.KeyCode.ToString()));
        }
    }

    public class StringEventArgs : EventArgs
    {
        public string Value;

        public StringEventArgs(string value)
        {
            Value = value;
        }
    }
}
