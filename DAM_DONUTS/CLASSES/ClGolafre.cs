using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace DAM_DONUTS.CLASSES
{
    class ClGolafre
    {
        private Mutex exclusioMutua = new Mutex();          // declarem aquesta variable per a poder accedir de manera única a un recurs

        private FrmMain fpare;
        //private System.Windows.Forms.Timer tmMenjant = new System.Windows.Forms.Timer();
        private System.Timers.Timer tmMenjant = new System.Timers.Timer();
        private Panel pnl = new Panel();
        private PictureBox pbox = new PictureBox();

        private Label etqTempsAcabarMenjarDonut=new Label();
        private Label etqQuantsDonutsMenjats=new Label();

        private int nDonutsMenjats = 0;
        private int quantsSegons = 0;
        private int segonsTranscorreguts = 0;
        private Boolean tincDonut = false;
        
        private delegate void delegat();
        Image[] noinoia = { Properties.Resources.noi100, Properties.Resources.noia100 };

        public ClGolafre(FrmMain xpare, Point xpos)
        {
            fpare = xpare;

            iniPanell(xpos);
            iniTimer();
        }

        private void iniPanell(Point xpos)
        {
            Random R = new Random();

            System.Threading.Thread.Sleep(5);
            pbox.Location = new Point(0, 0);
            pbox.Image = noinoia[R.Next(0, 2)];
            pbox.Size = noinoia[0].Size;

            pnl.Location = xpos;
            pnl.BorderStyle = BorderStyle.FixedSingle;

            
            etqQuantsDonutsMenjats.Location = new Point(pbox.Right, 0);
            etqQuantsDonutsMenjats.Font = new Font(fpare.Font.FontFamily, 14);
            etqQuantsDonutsMenjats.Size = pbox.Size;
            etqQuantsDonutsMenjats.MinimumSize = pbox.Size;
            etqQuantsDonutsMenjats.TextAlign = ContentAlignment.MiddleCenter;
            etqQuantsDonutsMenjats.Text = "menjats" + Environment.NewLine + nDonutsMenjats.ToString(); ;
            etqQuantsDonutsMenjats.BringToFront();

            etqTempsAcabarMenjarDonut.Location = new Point(pnl.Left, pnl.Bottom+10);
            etqTempsAcabarMenjarDonut.Font = new Font(fpare.Font.FontFamily, 14);
            etqTempsAcabarMenjarDonut.Margin=new Padding(10);
            etqTempsAcabarMenjarDonut.TextAlign = ContentAlignment.MiddleCenter;
            etqTempsAcabarMenjarDonut.Text = "";
            etqTempsAcabarMenjarDonut.AutoSize = true;
            etqTempsAcabarMenjarDonut.BringToFront();

            pnl.Controls.Add(pbox);
            pnl.Controls.Add(etqQuantsDonutsMenjats);
            fpare.Controls.Add(pnl);
            fpare.Controls.Add(etqTempsAcabarMenjarDonut);
        }

        private void iniTimer()
        {
            Random R = new Random();

            System.Threading.Thread.Sleep(5);
            quantsSegons = R.Next(5, 16);

            tmMenjant.Interval = 1000;                  // fem el timer de 1 segon perquè si no hi ha cupcakes esperarem 1 segon a tornar-ho a mirar
            tmMenjant.Elapsed += tmMenjantTick;
        }

        private void tmMenjantTick(Object source, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                fpare.Invoke(new delegat(modificaretiqueta3));
                if (tincDonut)
                {
                    segonsTranscorreguts++;
                    fpare.Invoke(new delegat(modificaretiqueta1));
                    fpare.Invoke(new delegat(modificaretiqueta2));
                    if (segonsTranscorreguts == quantsSegons)
                    {
                        nDonutsMenjats++;
                        //fpare.Invoke(new delegat(modificaretiqueta2));

                        segonsTranscorreguts = 0;
                        //tincDonut = agafarDonut();
                        fpare.Invoke(new delegat(agafarDonut));
                    }
                }
                else
                {
                    //tincDonut = agafarDonut();
                    fpare.Invoke(new delegat(agafarDonut));
                }
            }
            catch (Exception)
            {

                
            }

        }

        private void modificaretiqueta1()
        {
            etqQuantsDonutsMenjats.Text = "menjats" + Environment.NewLine + nDonutsMenjats.ToString();
            etqQuantsDonutsMenjats.Refresh();
        }

        private void modificaretiqueta2()
        {
            etqTempsAcabarMenjarDonut.Text = "menjant : " + (quantsSegons - segonsTranscorreguts).ToString();
            etqTempsAcabarMenjarDonut.Refresh();
        }        
        
        private void modificaretiqueta3()
        {
            if(nDonutsMenjats!=0)etqQuantsDonutsMenjats.Text = "menjats" + Environment.NewLine + nDonutsMenjats.ToString();
        }

        public void Menjar()
        {
            tmMenjant.Start();
        }

        private void agafarDonut()
        {

            segonsTranscorreguts = 0;

            exclusioMutua.WaitOne();                        // activem l'exclusió mútua, el procés s'espera aquí fins que és l'únic dels subprocessos que s'està executant
            
            if (fpare.quantsDonuts > 0) {
                fpare.quantsDonuts--;
                fpare.lbDonuts.Text = "Estoc : " + fpare.quantsDonuts.ToString();
                tincDonut = true;
                Console.WriteLine("Cuantos donuts quedan: " + fpare.quantsDonuts);
            } else
            {
                tincDonut = false;
                etqTempsAcabarMenjarDonut.Text = "";
                etqTempsAcabarMenjarDonut.Refresh();
            }
            exclusioMutua.ReleaseMutex();            // alliberem l'exclusió mútua
            
            
        }
    }
}
