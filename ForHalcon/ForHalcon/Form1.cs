using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using HalconDotNet;
using ForHalcon;

namespace ForHalcon
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForHalcon.Program.hv_Path= "C://Users//Jason//Desktop//ForHalcon";
           
            string Path = "C://Users//Jason//Desktop//ForHalcon//1.jpg";
            Bitmap imge = new Bitmap(@Path);
            pictureBox1.Image = imge;
            Thread.Sleep(30);
            new HDevelopExport();
            ShowData.Items.Clear();
            ShowData.Items.Add("Class2_Number:");
            ShowData.Items.Add(ForHalcon.Program.hv_Class2_Number);
            ShowData.Items.Add("Class2_Ratio:");
            ShowData.Items.Add(ForHalcon.Program.hv_Class2_Ratio);
            ShowData.Items.Add("Class2_area:");
            ShowData.Items.Add( ForHalcon.Program.hv_Class2_area);
            ShowData.Items.Add("Class2_centerX:");
            ShowData.Items.Add(ForHalcon.Program.hv_Class2_centerX);
            ShowData.Items.Add("Class2_centerY:");
            ShowData.Items.Add( ForHalcon.Program.hv_Class2_centerY);
            ShowData.Items.Add("Class2_height:");
            ShowData.Items.Add(ForHalcon.Program.hv_Class2_height);
            ShowData.Items.Add("Class2_width:");
            ShowData.Items.Add( ForHalcon.Program.hv_Class2_width);

            HImage img = new HImage(@Path);
            HRegion region = img.Threshold(0d, 122d);
            int numRegions = region.Connection().CountObj();
            Console.WriteLine("Number of Regions: " + numRegions);

            HObject obj = new HObject();
            HOperatorSet.ReadImage(out obj, Path);
        }
    }
}
