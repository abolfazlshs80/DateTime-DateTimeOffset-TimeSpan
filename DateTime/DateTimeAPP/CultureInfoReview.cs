using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAPP
{
   

    public class CultureInfoReview
    {
        public void run()
        {
            //https://agent-docs.emplifi.io/home/Training/culture-name


            //فرمت‌دهی تاریخ و زمان:
            var faIR1 = new CultureInfo("fa-IR");
            Console.WriteLine(DateTime.Now.ToString("D", faIR1)); // 26 آذر 1402



            //فرمت‌دهی اعداد و ارز
            var usCulture = new CultureInfo("en-US");
            var deCulture = new CultureInfo("de-DE");
            Console.WriteLine(12345.67.ToString("C", usCulture)); // $12,345.67
            Console.WriteLine(12345.67.ToString("C", deCulture)); // 12.345,67 €



            //نام فرهنک

            var faIR = new CultureInfo("fa-IR");
            Console.WriteLine(faIR.DateTimeFormat.Calendar); // PersianCalendar

            //مقایسه رشته‌ها:
            var culture = new CultureInfo("tr-TR");
            Console.WriteLine(string.Compare("i", "I", false, culture)); // نتایج بر اساس زبان ترکی


            //فرهنک پیش فرض
            CultureInfo.CurrentCulture = new CultureInfo("fa-IR");
            Console.WriteLine(DateTime.Now);//1403/9/27 22:47:41

        }
    }
}
