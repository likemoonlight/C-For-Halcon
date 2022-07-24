using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;

namespace ForHalcon
{
    internal static class Program
    {
        public static HTuple hv_Path = null;
        public static HTuple hv_Class2_Number = null;     //瑕疵數量
        public static HTuple hv_Class2_Ratio = null; //寬高比
        public static HTuple hv_Class2_area = null; //面積
        public static HTuple hv_Class2_centerX = null;
        public static HTuple hv_Class2_centerY = null; //中心座標  
        public static HTuple hv_Class2_height = null;  //高
        public static HTuple hv_Class2_width = null;  //寬
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
    }
    }
}
