using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DAM_DONUTS.CLASSES;

namespace DAM_DONUTS
{
    public partial class FrmMain : Form
    {
        private const int NGOLAFRES = 5;
        private const int NForns = 3;
        private Mutex exclusioMutua = new Mutex();

        public int quantsDonuts = 0;

        private List<ClGolafre> llGolafres = new List<ClGolafre>();
        private List<ClForn> llForns = new List<ClForn>();
        List<Thread> llThreadsG = new List<Thread>();
        List<Thread> llThreadsF = new List<Thread>();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            int w = (this.Width - 600) / 6;
            int posy = 170;

            for (int i = 0; i < NGOLAFRES; i++)
            {
                llGolafres.Add(new ClGolafre(this, new Point(w + (w + 100) * i, this.Height - 300)));
                llThreadsG.Add(new Thread(llGolafres[llGolafres.Count - 1].Menjar));
                llThreadsG[llThreadsG.Count - 1].Start();
                /*llGolafres.Add(new ClGolafre(this, new Point(w + (w + 100) * i, this.Height - 300)));
                llGolafres[llGolafres.Count - 1].Menjar();*/
            }
            Console.WriteLine("threads golafres: "+llThreadsG.Count);
            for (int i = 0; i < NForns; i++)
            {

                llForns.Add(new ClForn(this, new Point(10, posy)));
                llForns[llForns.Count - 1].definirInterval((int)nupSegons.Value);
                //llThreadsF.Add(new Thread(llForns[llForns.Count - 1].EncenderHorno));

                //llThreadsF[llThreadsF.Count - 1].Start();

                /*llForns.Add(new ClForn(this, new Point(10, posy)));
                llGolafres[llGolafres.Count - 1].Menjar();*/
                posy = posy + 200;
            }
            Console.WriteLine("threads forns: " + llThreadsF.Count);
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            pbWait.Visible = true;
            pbCupCake.Visible = true;
            lbDonuts.Visible = true;
            lbDonuts.Text = 0.ToString();

            btStart.Visible = false;
            btStop.Visible = true;
            int i = 0;
            foreach (ClForn Forn in llForns)
            {
                llThreadsF.Add(new Thread(Forn.EncenderHorno));
                llThreadsF[llThreadsF.Count - 1].Start();
            }

            //tm.Interval = (int) nupSegons.Value * 1000;
            //tm.Start();
        }


        private void btStop_Click(object sender, EventArgs e)
        {
            //tm.Stop();
            foreach (ClForn Forn in llForns)
            {
                Forn.ApagarHorno();
            }
            pbWait.Visible = false;
            btStart.Visible = true;
            btStop.Visible = false;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Thread th in llThreadsG)
            {
                if (th.IsAlive)
                {
                    th.Abort();
                }
            }

            foreach (Thread th in llThreadsF)
            {
                if (th.IsAlive)
                {
                    th.Abort();
                }
            }
        }


        /*private void tm_Tick(object sender, EventArgs e)
        {
            exclusioMutua.WaitOne();
            quantsDonuts++;
            lbDonuts.Text = "Estoc : "+quantsDonuts.ToString();
            exclusioMutua.ReleaseMutex();
        }*/
    }
}
