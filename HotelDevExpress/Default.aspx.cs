using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelDevExpress
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebChartControl1.Series["Aylar"].Points.AddPoint("Nisan", 45);
            WebChartControl1.Series["Aylar"].Points.AddPoint("Mayıs", 60);
            WebChartControl1.Series["Aylar"].Points.AddPoint("Hziran", 75);
            WebChartControl1.Series["Aylar"].Points.AddPoint("Temmuz", 85);
            WebChartControl1.Series["Aylar"].Points.AddPoint("Agustos", 80);
            WebChartControl1.Series["Aylar"].Points.AddPoint("Eylül", 55);
            WebChartControl1.Series["Aylar"].Points.AddPoint("Ekim", 40);

            WebChartControl3.Series["Ulkeler"].Points.AddPoint("Rusya", 120);
            WebChartControl3.Series["Ulkeler"].Points.AddPoint("Ukrayna", 75);
            WebChartControl3.Series["Ulkeler"].Points.AddPoint("Almanya", 80);
            WebChartControl3.Series["Ulkeler"].Points.AddPoint("Polonya", 45);
            WebChartControl3.Series["Ulkeler"].Points.AddPoint("İsveç", 105);
            WebChartControl3.Series["Ulkeler"].Points.AddPoint("İngiltere", 72);
        }
    }
}