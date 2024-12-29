using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Globalization;

namespace DateTimeAPP
{
    public  class DateTimeReview
    {

        public  void Run()
        {

            //مقداردهی به تاریخ و زمان:
            //ایجاد یک شیء از نوع DateTime
           DateTime date = new System.DateTime(2024, 12, 16); // سال، ماه، روز
            System.DateTime dateTime = new System.DateTime(2024, 12, 16, 14, 30, 0); // سال، ماه، روز، ساعت، دقیقه، ثانیه


            var dat1 = new DateTime();

            //1/1/0001 12:00:00 AM

            //گرفتن زمان و تاریخ فعلی:


            System.DateTime now = System.DateTime.Now;  // زمان و تاریخ کنونی
           System.DateTime today = System.DateTime.Today;  // فقط تاریخ امروز، زمان برابر 00:00:00
           DateTime date111 = DateTime.UtcNow;//زمان جهانی
            //خصوصیات اصلی
            int year = now.Year;
            int month = now.Month;
            int dayOfWeek = (int)now.DayOfWeek; // روز هفته به صورت اعداد

            //فرمت‌دهی تاریخ و زمان
            string formattedDate = now.ToString("yyyy-MM-dd HH:mm:ss");
            string customFormat = now.ToString("dddd, dd MMMM yyyy");
            //       d: 6/15/2008
            //       D: Sunday, June 15, 2008
            //       f: Sunday, June 15, 2008 9:15 PM
            //       F: Sunday, June 15, 2008 9:15:07 PM
            //       g: 6/15/2008 9:15 PM
            //       G: 6/15/2008 9:15:07 PM
            //       m: June 15
            //       o: 2008-06-15T21:15:07.0000000
            //       R: Sun, 15 Jun 2008 21:15:07 GMT
            //       s: 2008-06-15T21:15:07
            //       t: 9:15 PM
            //       T: 9:15:07 PM
            //       u: 2008-06-15 21:15:07Z
            //       U: Monday, June 16, 2008 4:15:07 AM
            //       y: June, 2008
            //
            //       'h:mm:ss.ff t': 9:15:07.00 P
            //       'd MMM yyyy': 15 Jun 2008
            //       'HH:mm:ss.f': 21:15:07.0
            //       'dd MMM HH:mm:ss': 15 Jun 21:15:07
            //       '\Mon\t\h\: M': Month: 6
            //       'HH:mm:ss.ffffzzz': 21:15:07.0000-07:00
            //فرمت‌های پیش‌فرض:
            string shortDate = now.ToShortDateString(); // تاریخ کوتاه 12/17/2024
            string longDate = now.ToLongDateString();   // Tuesday, December 17, 2024 تاریخ طولانی
            string shortTime = now.ToShortTimeString(); // زمان کوتاه : PM 2:45  
            string longTime = now.ToLongTimeString();   // زمان طولانیخروجی نمونه: PM 2:45:30

            //محاسبات روی تاریخ و زمان
            System.DateTime future = now.AddDays(10);   // 10 روز بعد
            System.DateTime past = now.AddHours(-5);   // 5 ساعت قبل
            //محاسبه فاصله بین دو تاریخ
            System.DateTime startDate = new System.DateTime(2024, 1, 1);
            TimeSpan difference = now - startDate;
            int daysDifference = difference.Days; // تعداد روزها


            //تبدیل رشته به DateTime
            string dateStr = "2024-12-16 14:30:00";
            System.DateTime parsedDate = System.DateTime.Parse(dateStr);

            //استفاده از TryParse برای جلوگیری از خطا
            if (System.DateTime.TryParse(dateStr, out System.DateTime result))
            {
                Console.WriteLine(result);
            }



            // تاریخ میلادی
            DateTime gregorianDate = new DateTime(2017, 8, 19);

            PersianCalendar persianCalendar = new PersianCalendar();

            // تبدیل تاریخ میلادی به شمسی
            int yearShamsi = persianCalendar.GetYear(gregorianDate);
            int monthShamsi = persianCalendar.GetMonth(gregorianDate);
            int dayShamsi = persianCalendar.GetDayOfMonth(gregorianDate);





            // تاریخ شمسی (هجری شمسی)
            PersianCalendar persianCalendar1 = new PersianCalendar();
            // تبدیل تاریخ شمسی به میلادی
            DateTime gregorianDate1 = persianCalendar.ToDateTime(yearShamsi, monthShamsi, dayShamsi, 0, 0, 0, 0);





            //مقایسه با عملگرها
            var date1 = new System.DateTime(2024, 2, 2);
            var date2 = new System.DateTime(2024, 2, 3);
            if (date1 > date2) { Console.WriteLine("date1 is later than date2"); }

            //توابع مخصوص
            int comparison = System.DateTime.Compare(date1, date2); // -1، 0، یا 1



            System.DateTime utcTime = System.DateTime.UtcNow;
            System.DateTime localTime = utcTime.ToLocalTime();
        }
    }
}
