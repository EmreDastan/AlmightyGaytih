using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;
namespace LordGaytih
{
    public partial class Form1 : Form
    {
        int count = 0;
        Random random = new Random();
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            player.URL = "music.mp3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(count == 0)
            {
                count++;
                int randomnumber = random.Next(2);
                switch (randomnumber)
                {
                    case 0:
                        Result.ForeColor = System.Drawing.Color.White;
                        Result.Text = "YES !";
                        break;
                    case 1:
                        Result.ForeColor = System.Drawing.Color.Red;
                        Result.Text = "NO !";
                        break;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }
    }
}
