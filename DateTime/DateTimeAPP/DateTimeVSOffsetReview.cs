using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Globalization;

namespace DateTimeAPP
{
    public  class DateTimeOffsetReview
    {

        public  void Run()
        {

            //مدیریت ناحیه زمانی

            /*
             *
             *
             *DateTime: فقط دو حالت دارد:

Kind.Local: نشان‌دهنده زمان محلی سیستم.
Kind.Utc: نشان‌دهنده زمان UTC.
Kind.Unspecified: بدون مشخص بودن ناحیه زمانی.
اما DateTime اطلاعات کامل ناحیه زمانی (مانند Offset دقیق) را ذخیره نمی‌کند. این ممکن است باعث ابهام در هنگام کار با نواحی زمانی مختلف شود.
             *
             */

            DateTime localTime1 = DateTime.Now;
            DateTime utcTime1 = DateTime.UtcNow;

            Console.WriteLine(localTime1); // خروجی: 2024-12-17 14:45:30
            Console.WriteLine(utcTime1);  // خروجی: 2024-12-17 11:15:30


            DateTimeOffset localTime = DateTimeOffset.Now;
            DateTimeOffset utcTime = DateTimeOffset.UtcNow;

            Console.WriteLine(localTime); // خروجی: 2024-12-17 14:45:30 +03:30
            Console.WriteLine(utcTime);  // خروجی: 2024-12-17 11:15:30 +00:00





            // مقایسه زمان‌ها

            DateTime time11 = DateTime.Now; // زمان محلی
            DateTime time22 = DateTime.UtcNow; // زمان UTC
            Console.WriteLine(time11 == time22); // معمولاً False


            DateTimeOffset time1 = DateTimeOffset.Now; // زمان محلی
            DateTimeOffset time2 = DateTimeOffset.UtcNow; // زمان UTC
            Console.WriteLine(time1 == time2); // True (زمان‌ها معادل در UTC هستند)



        }
    }
}
