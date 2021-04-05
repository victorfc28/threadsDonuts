using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace DAM_DONUTS.CLASSES
{
    class ClForn
    {
        private PictureBox pbox = new PictureBox();
        private Mutex exclusioMutua = new Mutex();
        System.Timers.Timer tm = new System.Timers.Timer();
        private Point pos;
        private FrmMain fpare;
        private delegate void delegat();
        public ClForn(FrmMain xpare, Point xpos)
        {
            fpare = xpare;
            pos = xpos;
            fpare.Invoke(new delegat(posicionarHorno));
            tm.Enabled = false;
            tm.Elapsed += tmTick;
            tm.Interval = 1000;
        }



        private void posicionarHorno()
        {
            pbox.Image = Properties.Resources.forn100;
            pbox.Location = pos;
            pbox.Width = 100;
            pbox.Height = 100;
            fpare.Controls.Add(pbox);

        }


        private void tmTick(Object source, System.Timers.ElapsedEventArgs e)
        {
            exclusioMutua.WaitOne();
            fpare.Invoke(new delegat(inserirStock));
            exclusioMutua.ReleaseMutex();
        }

        private void inserirStock()
        {
            Console.WriteLine(fpare.quantsDonuts.ToString());
            fpare.quantsDonuts++;
            fpare.lbDonuts.Text = "Estoc : " + fpare.quantsDonuts.ToString();
        }

        public void EncenderHorno()
        {
            tm.Start();
        }

        public void ApagarHorno()
        {
            tm.Stop();
        }

        public void definirInterval(int seg)
        {
            tm.Interval = seg * 1000;
        }

    }
}
