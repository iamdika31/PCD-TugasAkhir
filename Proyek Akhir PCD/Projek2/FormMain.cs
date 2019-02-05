using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Projek2
{
    public partial class FormMain : Form
    {
        Image file;
        Bitmap bmp, bmpori;
        int width;
        int height;
        public FormMain()
        {
            InitializeComponent();
        }


        List<int> ListXw = new List<int>();
        List<int> ListYw = new List<int>();
        List<int> ListXb = new List<int>();
        List<int> ListYb = new List<int>();     


        private void BtnDetectFinal_Click(object sender, EventArgs e)
        {
            int hitungObj = 0;
            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    if ((bmp.GetPixel(x, y).ToArgb() == System.Drawing.Color.White.ToArgb()))
                    {
                        hitungObj += 1;
                    }
                }
            }
            labelObj.Text = hitungObj.ToString();
        }

        void ErosiObjHor()
        {
            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    if ((bmp.GetPixel(x, y).ToArgb() == System.Drawing.Color.White.ToArgb()) 
                       && (bmp.GetPixel(x - 1, y).ToArgb() == System.Drawing.Color.Black.ToArgb())
                       && (bmp.GetPixel(x + 1, y).ToArgb() == System.Drawing.Color.Black.ToArgb()) 
                       && (bmp.GetPixel(x, y + 1).ToArgb() == System.Drawing.Color.Black.ToArgb())
                       && (bmp.GetPixel(x, y - 1).ToArgb() == System.Drawing.Color.Black.ToArgb())
                       && (bmp.GetPixel(x + 1, y - 1).ToArgb() == System.Drawing.Color.Black.ToArgb())
                       && (bmp.GetPixel(x - 1, y - 1).ToArgb() == System.Drawing.Color.Black.ToArgb())
                       && (bmp.GetPixel(x + 1, y + 1).ToArgb() == System.Drawing.Color.Black.ToArgb())
                       && (bmp.GetPixel(x - 1, y + 1).ToArgb() == System.Drawing.Color.Black.ToArgb())
                       )
                    {
                        //Do Nothing
                    }
                    else
                    {
                        bmp.SetPixel(x, y, System.Drawing.Color.Black);

                    }
                }
            }

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    if (bmp.GetPixel(x, y).ToArgb() == System.Drawing.Color.White.ToArgb())
                    {

                        if ((bmp.GetPixel(x - 1, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||

                            (bmp.GetPixel(x - 2, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            //tambahan
                            (bmp.GetPixel(x - 1, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||

                            (bmp.GetPixel(x - 3, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            //tambahan
                            (bmp.GetPixel(x - 1, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||

                            (bmp.GetPixel(x - 4, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            //tambahan
                            (bmp.GetPixel(x - 1, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||

                            (bmp.GetPixel(x - 5, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            //tambahan
                            (bmp.GetPixel(x - 1, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||


                            (bmp.GetPixel(x - 6, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            //tambahan
                            (bmp.GetPixel(x - 1, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||

                            (bmp.GetPixel(x - 7, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            //tambahan
                            (bmp.GetPixel(x - 1, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||

                            (bmp.GetPixel(x - 8, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            //tambahan
                            (bmp.GetPixel(x - 1, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||

                            (bmp.GetPixel(x - 9, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||

                            //tambahan
                            (bmp.GetPixel(x - 1, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||

                            (bmp.GetPixel(x - 10, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            //tambahan
                            (bmp.GetPixel(x - 1, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||

                            (bmp.GetPixel(x - 11, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            //tambahan
                            (bmp.GetPixel(x - 1, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||

                            (bmp.GetPixel(x - 12, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            //tambahan
                            (bmp.GetPixel(x - 1, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||

                            (bmp.GetPixel(x - 13, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            //tambahan
                            (bmp.GetPixel(x - 1, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||

                            (bmp.GetPixel(x - 14, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            //tambahan
                            (bmp.GetPixel(x - 1, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||

                            (bmp.GetPixel(x - 15, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            //tambahan
                            (bmp.GetPixel(x - 1, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||


                            (bmp.GetPixel(x - 16, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            //tambahan
                            (bmp.GetPixel(x - 1, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||

                            (bmp.GetPixel(x - 17, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) || //baru ditambah
                            (bmp.GetPixel(x + 17, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            //tambahan
                            (bmp.GetPixel(x - 1, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||

                            (bmp.GetPixel(x - 18, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            //tambahan
                            (bmp.GetPixel(x - 1, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||

                            (bmp.GetPixel(x - 19, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            //tambahan
                            (bmp.GetPixel(x - 1, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||

                            (bmp.GetPixel(x - 20, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            //tambahan
                            (bmp.GetPixel(x - 1, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||

                            (bmp.GetPixel(x - 21, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            //tambahan
                            (bmp.GetPixel(x - 1, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||

                            (bmp.GetPixel(x - 22, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            //tambahan
                            (bmp.GetPixel(x - 1, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||

                            (bmp.GetPixel(x - 23, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            //tambahan
                            (bmp.GetPixel(x - 1, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||

                            (bmp.GetPixel(x - 24, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 23).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 22).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 21).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 20).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 19).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 18).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 17).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 16).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 15).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 14).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 13).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 12).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 11).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 10).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 9).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 8).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 7).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 6).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 5).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 4).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 3).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 2).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            //tambahan
                            (bmp.GetPixel(x - 1, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 1, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 1, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 2, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 2, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 3, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 3, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 4, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 4, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 5, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 5, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 6, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 6, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 7, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 7, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 8, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 8, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 9, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 9, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 10, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 10, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 11, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 11, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 12, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 12, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 13, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 13, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 14, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 14, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 15, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 15, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 16, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 16, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 17, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 17, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 18, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 18, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 19, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 19, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 20, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 20, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 21, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 21, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 22, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 22, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 23, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 23, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x - 24, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y + 24).ToArgb() == System.Drawing.Color.White.ToArgb()) ||
                            (bmp.GetPixel(x + 24, y - 24).ToArgb() == System.Drawing.Color.White.ToArgb())
                            )
                        {
                            bmp.SetPixel(x, y, System.Drawing.Color.Black);
                        }
                    }
                }
            }

            pictureBox2.Image = bmp;
        }

        private void btnBiner_Click(object sender, EventArgs e)
        {
            int lightest = 0;
            int darkest = 255;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //ambil nilai pixel
                    Color p = bmp.GetPixel(x, y);

                    //extract ARGB dari nilai p
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    int graylevel = (r + g + b) / 3;
                    if (graylevel > lightest)
                    {
                        lightest = graylevel;
                    }
                    if (graylevel < darkest)
                    {
                        darkest = graylevel;
                    }
                }
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //ambil nilai pixel
                    Color p = bmp.GetPixel(x, y);

                    //extract ARGB dari nilai p
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //cari nilai negative nya 
                    int graylevel = (r + g + b) / 3;

                    int nilai;
                    //if (graylevel < (lightest / 2))//Set hitam
                    int treshold;
                    treshold = lightest / 3;
                    if (graylevel < treshold)
                    {
                        nilai = 0;
                    }
                    else
                    {
                        nilai = 255;
                    }
                    //set nilai rgb yang baru ke dalam pixel
                    bmp.SetPixel(x, y, Color.FromArgb(a, nilai, nilai, nilai));
                }
                pictureBox2.Image = bmp;
            }
        }

        void Erosi()
        {
            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    //di-erosi-kan dengan FIT
                    if ((bmp.GetPixel(x, y).ToArgb() == System.Drawing.Color.White.ToArgb())
                        && (bmp.GetPixel(x - 1, y).ToArgb() == System.Drawing.Color.White.ToArgb())
                        && (bmp.GetPixel(x + 1, y).ToArgb() == System.Drawing.Color.White.ToArgb())
                        && (bmp.GetPixel(x, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb())
                        && (bmp.GetPixel(x, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb())
                        )
                    {
                        ListXw.Add(x);//Menyimpan koordinat yang perlu diwarnai putih
                        ListYw.Add(y);
                    }
                    else
                    {
                        ListXb.Add(x);//Menyimpan koordinat yang perlu diwarnai hitam
                        ListYb.Add(y);
                    }
                }
            }

            for (int z = 0; z < ListXw.Count; z++)
            {
                // MessageBox.Show(ListX[z].ToString() + ", " + ListY[z].ToString());
                bmp.SetPixel(ListXw[z], ListYw[z], System.Drawing.Color.White);
            }

            for (int z = 0; z < ListXb.Count; z++)
            {
                // MessageBox.Show(ListX[z].ToString() + ", " + ListY[z].ToString());
                bmp.SetPixel(ListXb[z], ListYb[z], System.Drawing.Color.Black);
            }
            ListXb.Clear();
            ListXw.Clear();
            ListYb.Clear();
            ListYw.Clear();
            pictureBox2.Image = bmp;
        }
        private void btnErosi_Click(object sender, EventArgs e)
        {
            Erosi();
        }

        private void btnDilasi_Click(object sender, EventArgs e)
        {
            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    //di-erosi-kan dengan FIT
                    if ((bmp.GetPixel(x, y).ToArgb() == System.Drawing.Color.White.ToArgb())
                        || (bmp.GetPixel(x - 1, y).ToArgb() == System.Drawing.Color.White.ToArgb())
                        || (bmp.GetPixel(x + 1, y).ToArgb() == System.Drawing.Color.White.ToArgb())
                        || (bmp.GetPixel(x, y + 1).ToArgb() == System.Drawing.Color.White.ToArgb())
                        || (bmp.GetPixel(x, y - 1).ToArgb() == System.Drawing.Color.White.ToArgb()))
                    {
                        ListXw.Add(x);//Menyimpan koordinat yang perlu diwarnai putih
                        ListYw.Add(y);
                    }
                    else
                    {
                        ListXb.Add(x);//Menyimpan koordinat yang perlu diwarnai hitam
                        ListYb.Add(y);
                    }
                }
            }

            for (int z = 0; z < ListXw.Count; z++)
            {
                // MessageBox.Show(ListX[z].ToString() + ", " + ListY[z].ToString());
                bmp.SetPixel(ListXw[z], ListYw[z], System.Drawing.Color.White);
            }

            for (int z = 0; z < ListXb.Count; z++)
            {
                // MessageBox.Show(ListX[z].ToString() + ", " + ListY[z].ToString());
                bmp.SetPixel(ListXb[z], ListYb[z], System.Drawing.Color.Black);
            }
            ListXb.Clear();
            ListXw.Clear();
            ListYb.Clear();
            ListYw.Clear();
            pictureBox2.Image = bmp;
        }


        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnEroHor_Click(object sender, EventArgs e)
        {           
            ErosiObjHor();
        }

        private void openGambar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files (*.*)|*.*";
            DialogResult open = openFileDialog1.ShowDialog();

            if (open == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                bmp = new Bitmap(openFileDialog1.FileName);
                bmpori = new Bitmap(openFileDialog1.FileName);
                //Load gambar ke dalam picturebox
                pictureBox1.Image = file;
                //ambil dimensi gambar 
                width = bmp.Width;
                height = bmp.Height;

            }
        }

    }
}

