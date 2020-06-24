
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GantChart.Models;
using GantChart.Controllers;
namespace GantChart.controll
{
    //public delegate void LabelClick(object sender, EventArgs e);
    class MyPanel : Panel
    {
        private List<MyLabel> listLabelDate;
        private List<MyLabel> listLabelYear;
        private List<MyLabel> listLabelMonth;
        public List<MyLabel> listLabelTask;
        private int level;
        private int WidthLabel;
        private int HegthTitle;
        public Action<object, EventArgs> Label_Click;
        private int paintWidth;
        private int paintHegth;
        public DateTime minFromDate { get; set; }
        public DateTime maxToDate { get; set; }
        public TimeSpan timeSpan { get; set; }
        public List<TaskWork> ListTask
        {
            get => listTask;
            set
            {
                if (value != null)
                {
                    listTask = value;
                    this.Controls.Clear();
                    this.Invalidate();
                }
            }
        }
        public int PaintWidth
        {
            get => paintWidth;
            set
            {
                paintWidth = value - 200;
                this.Controls.Clear();
                this.Invalidate();
            }
        }

        public int PaintHegth
        {
            get => paintHegth;
            set
            {
                paintHegth = value;
                this.Controls.Clear();
                this.Invalidate();
            }
        }

        private List<TaskWork> listTask;
        public MyPanel(List<TaskWork> tasks, Action<object, EventArgs> label_Click, int PaintWidth)
        {
            listLabelDate = new List<MyLabel>();
            listLabelMonth = new List<MyLabel>();
            listLabelYear = new List<MyLabel>();
            listLabelTask = new List<MyLabel>();
            ListTask = tasks;
            this.PaintWidth = PaintWidth;
            this.paintHegth = 550;
            this.Label_Click = label_Click;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //this.Controls.Clear();
            if (listTask.Count != 0)
            {
                PaintChart(e.Graphics);
            }
            else
            {
                e.Graphics.Clear(BackColor);
                return;
            }
        }
        private void PaintChart(Graphics gfs)
        {
            listLabelDate.Clear();
            listLabelMonth.Clear();
            listLabelYear.Clear();
            listLabelTask.Clear();
            this.minFromDate = ListController.MinFromDate(ListTask);
            this.maxToDate = ListController.MaxToDate(ListTask);
            timeSpan = maxToDate - minFromDate;
            if (timeSpan.TotalDays > 365*2)
            {
                if (minFromDate.Month > maxToDate.Month || (minFromDate.Month == maxToDate.Month && minFromDate.Day > maxToDate.Day))
                    maxToDate = maxToDate.AddYears(1);
                WidthLabel = PaintWidth * 365 / (Convert.ToInt32(timeSpan.TotalDays) + 365);
                level = 3;
            }
            else
            {
                if (timeSpan.TotalDays > 61)
                {
                    if (minFromDate.Day > maxToDate.Day)
                        maxToDate = maxToDate.AddMonths(1);

                    WidthLabel = PaintWidth * 30 / (Convert.ToInt32(timeSpan.TotalDays) + 31);


                    level = 2;
                }
                else
                {
                    WidthLabel = PaintWidth / (Convert.ToInt32(timeSpan.TotalDays) + 1);
                    level = 1;
                }
            }
            HegthTitle = paintHegth / ListTask.Count;
            //HetgthTitle = WidthLabel;

            gfs.Clear(BackColor);
            DrawNetVertical(gfs);
            DrawNetHorizontal(gfs);

        }
        public void DrawNetHorizontal(Graphics grfx)//ve cac duong ngan va label ten cong viec
        {
            int x;
            int WidthTemp = 0;
            double detalTo = 0, detalfr = 0;
            if (level == 3)
            {
                x = 20 - HegthTitle;

            }
            else
            {
                x = 40 - HegthTitle;
                
            }
            Point oldPoint = new Point(0, x);
            Point statPoint = new Point(0, 0);
            Point EndPoint = new Point(0, 0);
            for (int i = 0; i < ListTask.Count; i++)
            {
                MyLabel label = new MyLabel()
                {
                    Text = ListTask[i].Title,
                    Size = new Size(150, HegthTitle - 1),
                    BackColor = Color.LightBlue,
                    Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular),
                    //BackColor = ColorController.RandomColor(),
                    Location = new Point(0, oldPoint.Y + HegthTitle + 1),
                    TextAlign = ContentAlignment.MiddleCenter
                    
                };
                //listLabelTitle.Add(label);
                if (level == 1)
                {
                    foreach (MyLabel item in listLabelDate)
                    {
                        if (item.DateTime.Date == ListTask[i].FromDate.Date)
                        {
                            statPoint = item.Location;
                            break;

                        }
                    }
                    foreach (MyLabel item in listLabelDate)
                    {
                        if (item.DateTime.Date == ListTask[i].ToDate.Date)
                        {
                            EndPoint = item.Location;
                            break;

                        }
                    }
                    WidthTemp = listLabelDate[listLabelDate.Count - 1].Location.X + listLabelDate[listLabelDate.Count - 1].Size.Width;
                    detalTo = Convert.ToDouble(ListTask[i].FromDate.Hour) / 24;
                    detalfr = Convert.ToDouble(ListTask[i].ToDate.Hour) / 24;
                }
                else
                {
                    if (level == 2)
                    {
                        foreach (MyLabel item in listLabelMonth)
                        {
                            if (item.DateTime.Month == ListTask[i].FromDate.Month && item.DateTime.Year == ListTask[i].FromDate.Year)
                            {
                                statPoint = item.Location;
                                break;

                            }
                        }
                        foreach (MyLabel item in listLabelMonth)
                        {
                            if (item.DateTime.Month == ListTask[i].ToDate.Month && item.DateTime.Year == ListTask[i].ToDate.Year)
                            {
                                EndPoint = item.Location;
                                break;

                            }
                        }
                        WidthTemp = listLabelMonth[listLabelMonth.Count - 1].Location.X + listLabelMonth[listLabelMonth.Count - 1].Size.Width;
                        detalTo = Convert.ToDouble(ListTask[i].FromDate.Day) / 31;
                        detalfr = Convert.ToDouble(ListTask[i].ToDate.Day) / 31;
                    }
                    else
                    {
                        if (level == 3)
                        {
                            foreach (MyLabel item in listLabelYear)
                            {
                                if (item.DateTime.Year == ListTask[i].FromDate.Year)
                                {
                                    statPoint = item.Location;
                                    break;

                                }
                            }
                            foreach (MyLabel item in listLabelYear)
                            {
                                if (item.DateTime.Year == ListTask[i].ToDate.Year)
                                {
                                    EndPoint = item.Location;
                                    break;

                                }
                            }
                            WidthTemp = listLabelYear[listLabelYear.Count - 1].Location.X + listLabelYear[listLabelYear.Count - 1].Size.Width;

                            detalTo = Convert.ToDouble(ListTask[i].FromDate.Month) / 12;
                            detalfr = Convert.ToDouble(ListTask[i].ToDate.Month) / 12;
                        }
                    }
                }
                //int halfWidthLabel = Convert.ToInt32(WidthLabel * 0.5);
                //int halfHetgthTitle = Convert.ToInt32(HetgthTitle * 0.5);
                int HetgthTitle1_3 = Convert.ToInt32(HegthTitle * 1 / 3);
                int tempTo = Convert.ToInt32(detalTo * WidthLabel);
                int tempfr = Convert.ToInt32(detalfr * WidthLabel);
                MyLabel label1 = new MyLabel()
                {
                    Text = ListTask[i].PercentCompleted.ToString() + "%",

                    //BackColor = Color.PowderBlue,
                    Location = new Point(statPoint.X + tempTo, label.Location.Y + HetgthTitle1_3),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(EndPoint.X - statPoint.X + tempfr - tempTo, HetgthTitle1_3)
                };
                if (ListTask[i].Priority.ToString() == "LOW")
                {
                    label1.BackColor = Color.FromArgb(128, 255, 128);
                }
                else
                {
                    if (ListTask[i].Priority.ToString() == "NORMAL")
                    {
                        label1.BackColor = Color.FromArgb(255, 192, 128);
                    }
                    else
                    {
                        label1.BackColor = Color.FromArgb(255, 128, 128);
                    }
                }
                label1.Click += new EventHandler(Label_Click);
                label1.Task = ListTask[i];
                listLabelTask.Add(label1);
                this.Controls.Add(label);
                this.Controls.Add(label1);
                //grfx.DrawLine(Pens.LightSeaGreen, 0, oldPoint.Y + HegthTitle, WidthTemp, oldPoint.Y + HegthTitle);
                grfx.DrawLine(Pens.Silver, 0, oldPoint.Y + HegthTitle, WidthTemp, oldPoint.Y + HegthTitle);

                oldPoint.Y += HegthTitle;
            }
            grfx.DrawLine(Pens.Silver, 0, oldPoint.Y + HegthTitle, WidthTemp, oldPoint.Y + HegthTitle);
            if (level == 3)
            {
                grfx.DrawLine(Pens.LightSeaGreen, 0, 0, 150, 20);
                grfx.DrawLine(Pens.LightSeaGreen, 0, 20, 150, 0);

            }
            else
            {

                grfx.DrawLine(Pens.LightSeaGreen, 0, 0, 150, 40);
                grfx.DrawLine(Pens.LightSeaGreen, 0, 40, 150, 0);


            }
        }
        public void DrawNetVertical(Graphics grfx)//ve cac duong doc va label ngay thang nam
        {
            int HegthTemp;
            if (level == 3)
            {
                HegthTemp = HegthTitle * (listTask.Count) + 20;

            }
            else
            {
                HegthTemp = HegthTitle * (listTask.Count) + 40;

            }
            if (level == 1)
            {
                int oldX = 150 - WidthLabel;
                //maxToDate = maxToDate.AddDays(1);
                for (DateTime date = minFromDate; date.Date <= maxToDate.Date; date = date.AddDays(1))
                {
                    string str = date.ToString("dd");
                    MyLabel lb = new MyLabel()
                    {
                        Text = str,
                        Font = new Font(FontFamily.GenericSansSerif, 5f),
                        Location = new Point(oldX + WidthLabel + 1, 20),
                        Size = new Size(WidthLabel - 1, 20),
                        TextAlign = ContentAlignment.MiddleCenter,
                        //BackColor = ColorController.RandomColor()
                        BackColor = Color.SkyBlue
                    };
                    lb.DateTime = date;

                    listLabelDate.Add(lb);
                    this.Controls.Add(lb);
                    grfx.DrawLine(Pens.Silver, oldX + WidthLabel, 0, oldX + WidthLabel, HegthTemp);

                    oldX += WidthLabel;
                }

                Point SPoint = listLabelDate[0].Location;
                Point GPoint;
                DateTime date1 = minFromDate;
                for (int i = 0; i < listLabelDate.Count; i++)
                {

                    if (i == listLabelDate.Count - 1)
                    {
                        GPoint = new Point(listLabelDate[i].Location.X + WidthLabel, 0);
                        Label label = new Label()
                        {
                            Text = date1.ToString("MMMM-yyyy"),
                            Location = new Point(SPoint.X, 0),
                            Size = new Size(GPoint.X - SPoint.X - 1, 20),
                            TextAlign = ContentAlignment.MiddleCenter,
                            BackColor = Color.LightBlue
                        };
                        this.Controls.Add(label);
                    }
                    else
                    if (Convert.ToInt32(listLabelDate[i].Text) > Convert.ToInt32(listLabelDate[i + 1].Text))
                    {
                        GPoint = listLabelDate[i + 1].Location;
                        Label label = new Label()
                        {
                            Text = date1.ToString("MMMM-yyyy"),
                            Location = new Point(SPoint.X, 0),
                            Size = new Size(GPoint.X - SPoint.X - 1, 20),
                            TextAlign = ContentAlignment.MiddleCenter,
                            BackColor = Color.LightBlue
                        };
                        SPoint = GPoint;
                        date1 = date1.AddMonths(1);
                        this.Controls.Add(label);
                    }
                }
                foreach (MyLabel lb in listLabelDate)
                {
                    if (lb.DateTime.Date == DateTime.Now.Date)
                    {

                        //int temp = Convert.ToInt32(1.5 * WidthLabel);
                        double detal = Convert.ToDouble(DateTime.Now.Hour) / 24;
                        int temp = Convert.ToInt32(detal * WidthLabel);

                        grfx.DrawLine(Pens.Red, lb.Location.X + temp, 0, lb.Location.X + temp, HegthTemp);

                    }
                }
                grfx.DrawLine(Pens.Silver, oldX + WidthLabel, 0, oldX + WidthLabel, HegthTemp);
            }
            else
            if (level == 2)
            {
                int oldX = 150 - WidthLabel;

                for (DateTime date = minFromDate; date.Date <= maxToDate.Date; date = date.AddMonths(1))
                {
                    string str = date.ToString("MMMM");
                    MyLabel lb = new MyLabel()
                    {
                        Text = str,
                        Font = new Font(FontFamily.GenericSansSerif, 8f),
                        Location = new Point(oldX + WidthLabel + 1, 20),
                        Size = new Size(WidthLabel - 1, 20),
                        TextAlign = ContentAlignment.MiddleCenter,
                        BackColor = Color.PaleTurquoise
                    };
                    lb.DateTime = date;

                    listLabelMonth.Add(lb);
                    this.Controls.Add(lb);
                    grfx.DrawLine(Pens.Silver, oldX + WidthLabel, 0, oldX + WidthLabel, HegthTemp);
                    oldX += WidthLabel;
                }

                Point SPoint = listLabelMonth[0].Location;
                Point GPoint;
                DateTime date1 = minFromDate;
                for (int i = 0; i < listLabelMonth.Count; i++)
                {

                    if (i == listLabelMonth.Count - 1)
                    {
                        GPoint = new Point(listLabelMonth[i].Location.X + WidthLabel, 0);
                        Label label = new Label()
                        {
                            Text = date1.ToString("yyyy"),
                            Location = new Point(SPoint.X, 0),
                            Size = new Size(GPoint.X - SPoint.X - 1, 20),
                            TextAlign = ContentAlignment.MiddleCenter,
                            BackColor = Color.LightBlue
                        };
                        this.Controls.Add(label);
                    }
                    else
                    if (Convert.ToInt32(listLabelMonth[i].DateTime.Month) > Convert.ToInt32(listLabelMonth[i + 1].DateTime.Month))
                    {
                        GPoint = listLabelMonth[i + 1].Location;
                        Label label = new Label()
                        {
                            Text = date1.ToString("yyyy"),
                            Location = new Point(SPoint.X, 0),
                            Size = new Size(GPoint.X - SPoint.X - 1, 20),
                            TextAlign = ContentAlignment.MiddleCenter,
                            BackColor = Color.LightBlue
                        };
                        SPoint = GPoint;
                        date1 = date1.AddYears(1);
                        this.Controls.Add(label);
                    }
                }
                foreach (MyLabel lb in listLabelMonth)
                {
                    if (lb.DateTime.Month == DateTime.Now.Month && lb.DateTime.Year == DateTime.Now.Year)
                    {

                        //int temp = Convert.ToInt32(1.5 * WidthLabel);
                        double detal = Convert.ToDouble(DateTime.Now.Day) / 31;
                        int temp = Convert.ToInt32(detal * WidthLabel);

                        grfx.DrawLine(Pens.Red, lb.Location.X + temp, 0, lb.Location.X + temp, HegthTemp);

                    }
                }
                grfx.DrawLine(Pens.Silver, oldX + WidthLabel, 0, oldX + WidthLabel, HegthTemp);
            }
            else
            if (level == 3)
            {
                int oldX = 150 - WidthLabel;
                for (DateTime date = minFromDate; date.Date <= maxToDate.Date; date = date.AddYears(1))
                {
                    string str = date.ToString("yyyy");
                    MyLabel lb = new MyLabel()
                    {
                        Text = str,
                        Font = new Font(FontFamily.GenericSansSerif, 8f),
                        Location = new Point(oldX + WidthLabel + 1, 0),
                        Size = new Size(WidthLabel - 1, 20),
                        TextAlign = ContentAlignment.MiddleCenter,
                        BackColor = Color.PaleTurquoise
                    };

                    lb.DateTime = date;
                    listLabelYear.Add(lb);
                    this.Controls.Add(lb);
                    grfx.DrawLine(Pens.Silver, oldX + WidthLabel, 0, oldX + WidthLabel, HegthTemp);
                    oldX += WidthLabel;
                }
                foreach (MyLabel lb in listLabelYear)
                {
                    if (lb.DateTime.Year == DateTime.Now.Year)
                    {

                        //int temp = Convert.ToInt32(1.5 * WidthLabel);
                        double detal = Convert.ToDouble(DateTime.Now.Month) / 12;
                        int temp = Convert.ToInt32(detal * WidthLabel);

                        grfx.DrawLine(Pens.Red, lb.Location.X + temp, 0, lb.Location.X + temp, HegthTemp);

                    }
                }
                grfx.DrawLine(Pens.Silver, oldX + WidthLabel, 0, oldX + WidthLabel, HegthTemp);

            }

        }

    }
}