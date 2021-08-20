using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using SpotifyAPI.Web;

namespace BxshowAV_Spotify
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }




        private void button1_Click(object sender, EventArgs e)
        {
          //  string[] playing = Spotify.GetFavArtist();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }
    }
}
