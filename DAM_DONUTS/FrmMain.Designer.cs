namespace DAM_DONUTS
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.gbTemps = new System.Windows.Forms.GroupBox();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.lbSegons = new System.Windows.Forms.Label();
            this.nupSegons = new System.Windows.Forms.NumericUpDown();
            this.lbDonuts = new System.Windows.Forms.Label();
            this.pbCupCake = new System.Windows.Forms.PictureBox();
            this.pbWait = new System.Windows.Forms.PictureBox();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.gbTemps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSegons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCupCake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWait)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTemps
            // 
            this.gbTemps.Controls.Add(this.btStop);
            this.gbTemps.Controls.Add(this.btStart);
            this.gbTemps.Controls.Add(this.lbSegons);
            this.gbTemps.Controls.Add(this.nupSegons);
            this.gbTemps.Location = new System.Drawing.Point(13, 13);
            this.gbTemps.Name = "gbTemps";
            this.gbTemps.Size = new System.Drawing.Size(192, 137);
            this.gbTemps.TabIndex = 0;
            this.gbTemps.TabStop = false;
            this.gbTemps.Text = " ** temps de cocció **";
            // 
            // btStop
            // 
            this.btStop.BackColor = System.Drawing.Color.OrangeRed;
            this.btStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btStop.ForeColor = System.Drawing.Color.White;
            this.btStop.Location = new System.Drawing.Point(19, 81);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(150, 33);
            this.btStop.TabIndex = 5;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = false;
            this.btStop.Visible = false;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.Green;
            this.btStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btStart.ForeColor = System.Drawing.Color.White;
            this.btStart.Location = new System.Drawing.Point(19, 81);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(150, 33);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lbSegons
            // 
            this.lbSegons.AutoSize = true;
            this.lbSegons.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSegons.Location = new System.Drawing.Point(92, 35);
            this.lbSegons.Name = "lbSegons";
            this.lbSegons.Size = new System.Drawing.Size(77, 23);
            this.lbSegons.TabIndex = 1;
            this.lbSegons.Text = "segons";
            // 
            // nupSegons
            // 
            this.nupSegons.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupSegons.Location = new System.Drawing.Point(19, 33);
            this.nupSegons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupSegons.Name = "nupSegons";
            this.nupSegons.Size = new System.Drawing.Size(58, 31);
            this.nupSegons.TabIndex = 0;
            this.nupSegons.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupSegons.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbDonuts
            // 
            this.lbDonuts.AutoSize = true;
            this.lbDonuts.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonuts.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbDonuts.Location = new System.Drawing.Point(284, 394);
            this.lbDonuts.Name = "lbDonuts";
            this.lbDonuts.Size = new System.Drawing.Size(96, 23);
            this.lbDonuts.TabIndex = 4;
            this.lbDonuts.Text = "Estoc : 0";
            this.lbDonuts.Visible = false;
            // 
            // pbCupCake
            // 
            this.pbCupCake.Image = global::DAM_DONUTS.Properties.Resources.doughnut100;
            this.pbCupCake.Location = new System.Drawing.Point(238, 385);
            this.pbCupCake.Name = "pbCupCake";
            this.pbCupCake.Size = new System.Drawing.Size(40, 40);
            this.pbCupCake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCupCake.TabIndex = 3;
            this.pbCupCake.TabStop = false;
            this.pbCupCake.Visible = false;
            // 
            // pbWait
            // 
            this.pbWait.Image = global::DAM_DONUTS.Properties.Resources.wait002;
            this.pbWait.Location = new System.Drawing.Point(130, 330);
            this.pbWait.Name = "pbWait";
            this.pbWait.Size = new System.Drawing.Size(102, 170);
            this.pbWait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbWait.TabIndex = 2;
            this.pbWait.TabStop = false;
            this.pbWait.Visible = false;
            // 
            // tm
            // 
            this.tm.Interval = 1000;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 604);
            this.Controls.Add(this.lbDonuts);
            this.Controls.Add(this.pbCupCake);
            this.Controls.Add(this.gbTemps);
            this.Controls.Add(this.pbWait);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMain";
            this.Text = "Donuts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gbTemps.ResumeLayout(false);
            this.gbTemps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSegons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCupCake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTemps;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label lbSegons;
        private System.Windows.Forms.NumericUpDown nupSegons;
        private System.Windows.Forms.PictureBox pbWait;
        private System.Windows.Forms.PictureBox pbCupCake;
        public System.Windows.Forms.Label lbDonuts;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Timer tm;
    }
}

