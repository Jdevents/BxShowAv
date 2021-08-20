using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using SpotifyAPI.Web;
using System.Threading;

namespace BxshowAV_Spotify
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new Form1());
        //}


        static async Task Main()
        {
            var aoth = new Auth();
            //var spotify = new SpotifyClient("BQDCm3OsojOkBVjMmAUrqSScXZOjZ8q-7ek0ClsD6ARNh9sx52Bkjx_H_b-n8x_5T0hmWsj8h_vfZu6WHU4O81O-i7lFTTJg-lgjgxk2Xmgy2wrdwDciylBsqLbEWVnuXGCSfcZ7PEexFy2z8WykJ9ZbFU_gE2Dihn5GdQTKCU9XqpMKpQIB2L8FN9ZP4s73eXL5gd0EBljXgMhisdbIcvK-GDuO6yEvgwfk_tu1T9nM-cmhHHYx3aofuW7EJcvz");
            var config = SpotifyClientConfig
              .CreateDefault()
             // .WithToken("BQD4VBMb-4yW_hFaSfYs46tJiJ8QSrh4faL8Y00Fo8u0J0De8yWh2ct0ul3qR1lZeW2URsI64GsrmM8kAhuyhEODXl0ObcFlSITFKv1CJzx9fD-XCiDjsANs880xb8QNnYDXVjlNbt4Q5-xYkH_j1OPDsFm2KhL7KLzZnkNe563iuayvlaBZ9Ts4jd3Jqd8g6elSaAEAY4i9E5UcTHsoGonyx1WFUm1yaubS8Vq84bSm0nI6MxvYWLJLaTH932FbDVtFoWhKNlxY74iv");
              .WithAuthenticator(new ClientCredentialsAuthenticator("b9a5afca12024ed1b91503b67f8dcbd9", "f1062b2ac10c49c1aca3150a28cc6536"));
            var l = config.APIConnector;
            var spot = new SpotifyClient(config);
            var track = await spot.Tracks.Get("2NcstvY8H9PVQ0DMNGHckh");
            //var playing = await spot.Player.GetCurrentPlayback();
            var test = await spot.Tracks.GetAudioAnalysis("2NcstvY8H9PVQ0DMNGHckh");
            
            Console.WriteLine(track.Name);
            Console.WriteLine(track.Id);
            Console.WriteLine(track.Album.Name);
            Console.WriteLine(l);
            //Console.WriteLine("---------------");
            //Console.WriteLine();
            //Console.WriteLine("---------------");
            //Console.WriteLine("is playing: ");
            //Console.WriteLine(playing.IsPlaying);
            //Console.WriteLine("---------------");
            //Console.WriteLine("Progress: ");
            //Console.WriteLine(playing.ProgressMs / 60000);
            //Console.WriteLine("---------------");
            //Console.WriteLine("Is repeat on: ");
            //Console.WriteLine(playing.RepeatState);
            //Console.WriteLine("---------------");
            //Console.WriteLine("Is shuffle on: ");
            //Console.WriteLine(playing.ShuffleState);
            //Console.WriteLine("---------------");
            //Console.WriteLine("Playing type: ");
            //Console.WriteLine(playing.CurrentlyPlayingType);
            //Console.WriteLine("---------------");
            //Console.WriteLine("PLayback on current Device: ");
            //Console.WriteLine(playing.Device.Name);
            Console.ReadKey(true);
        }


    }
}
