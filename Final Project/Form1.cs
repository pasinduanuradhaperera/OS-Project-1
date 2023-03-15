using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        private Button currentButton;        

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();

        }

        //all gloabal variables
        public static class Gvar
        {
            
            public static float[] fcpu = new float[60];
            public static float[] fram = new float[60];
            public static float[] fdiskR = new float[60];
            public static float[] fdiskW = new float[60];
            public static int W = 1;

        }

        //tiemr tick 1s tick
        private void Timer_Tick(object sender, EventArgs e)
        
        {
            //take realtime updates.
            Gvar.fcpu[59] = pCpu.NextValue();//cpu%
            Gvar.fram[59] = pRam.NextValue();//ram%
            float framB = pRamAval.NextValue();
            Gvar.fdiskR[59] = pDiskR.NextValue();//disk read
            Gvar.fdiskW[59] = pDiskW.NextValue(); // disk write

            //convert B to MB
            float framBMB = framB / 1024 / 1024;

            //update chart coloumn data
            for (int i = 0; i < 59; i++)
            {
                Gvar.fcpu[i] = Gvar.fcpu[i + 1];
                Gvar.fram[i] = Gvar.fram[i + 1];
                Gvar.fdiskR[i] = Gvar.fdiskR[i + 1]; 
                Gvar.fdiskW[i] = Gvar.fdiskW[i + 1];

            }

            // panel update

            lb_cpu1.Text = string.Format("{0:0}%", Gvar.fcpu[59]); //cpu

            lb_ram.Text = string.Format("{0:0}%", Gvar.fram[59]); //ram 
            lb_ramB.Text = string.Format("{0:0} MB", framBMB); //ram available memory

            lb_diskRead.Text = string.Format("{0:0} MB/s", Gvar.fdiskR[59]);//disk read
            lb_diskWrite.Text = string.Format("{0:0} MB/s", Gvar.fdiskW[59]);//disk write

           

            //cpu status update
            if (Gvar.W == 1)
            {
                label1.Text = "CPU"; //label name
                //update charts             
                UpdateChart(Gvar.fcpu);

            }
            else if (Gvar.W == 2)
            {
                label1.Text = "RAM";//label name
                //update charts             
                UpdateChart(Gvar.fram);
                
                
                

            }
            else if (Gvar.W == 3)
            {
                label1.Text = "DISK";//label name
                //update charts             
                UpdateChart(Gvar.fdiskR);


            }
            else if (Gvar.W == 4)
            {
                label1.Text = "NETWORK";
               

            }

        }
        private void UpdateChart(float[] A)
        {
            if (Gvar.W != 3)
            {
                //circular chart 
                cCPU.Value = (int)A[59];
                cCPU.Text = string.Format("{0:0}", A[59]);

                //update chart 
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }

                for (int i = 0; i < 60; i++)
                {
                    chart1.Series["CPU"].Points.Add(A[i]);

                }
            }
            else
            {
                //circular chart 
                cCPU.Value = (int)100;
                cCPU.Text = string.Format("---", 0);

                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }

                for (int i = 0; i < 60; i++)
                {
                    chart1.Series["CPU"].Points.Add(A[i]);
                    chart1.Series["disk"].Points.Add(Gvar.fdiskW[i]);
                }
            }

        }
        //change color when button active
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(56,56,56);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;                   
                }
            }
        }
        //set colour to default when disable 
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(31,31,31);
                }
            }
        }

        private void IsWBActive(int i)
        {
            Gvar.W = i;
        }

        private void btn_cpu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            IsWBActive(1);

        }

        private void btn_ram_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            IsWBActive(2);
        }

        private void btn_disk_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            IsWBActive(3);
        }

        private void btn_network_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            IsWBActive(4);
        }
    }
}

