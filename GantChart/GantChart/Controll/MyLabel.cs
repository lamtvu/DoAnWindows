using System;
using System.Windows.Forms;
using GantChart.Models;
namespace GantChart.controll
{
    class MyLabel : Label
    {
        public DateTime DateTime { get; set; }
        public TaskWork Task { get; set; }
    }
}