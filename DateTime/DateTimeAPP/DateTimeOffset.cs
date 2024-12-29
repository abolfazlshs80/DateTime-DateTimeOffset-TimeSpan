using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Globalization;

namespace DateTimeAPP
{
    public class DateTimeVSOffsetReview
    {

        public void Run()
        {
            //ایجاد یک شیء DateTimeOffset
            DateTimeOffset dateTimeOffset = new DateTimeOffset(2024, 12, 16, 14, 30, 0, TimeSpan.FromHours(3));
            Console.WriteLine(dateTimeOffset);  // خروجی: 16/12/2024 14:30:00 +03:00


            // استفاده از DateTimeOffset.UtcNow

            DateTimeOffset utcNow = DateTimeOffset.UtcNow;
            Console.WriteLine(utcNow);  // خروجی: تاریخ و زمان جاری UTC (مثلاً: 16/12/2024 11:30:00 +00:00)



            //مقایسه DateTimeOffset
            DateTimeOffset time11 = new DateTimeOffset(2024, 12, 16, 14, 30, 0, TimeSpan.FromHours(3)); // UTC+3
            DateTimeOffset time2 = new DateTimeOffset(2024, 12, 16, 11, 30, 0, TimeSpan.FromHours(0)); // UTC

           // time2.Equals(time11);
           // time2.CompareTo(time11);
            Console.WriteLine(time11 == time2);  // خروجی: True


            //تبدیل به UTC

            DateTimeOffset time1 = new DateTimeOffset(2024, 12, 16, 14, 30, 0, TimeSpan.FromHours(3));
            DateTimeOffset utcTime = time1.ToUniversalTime();  // تبدیل به زمان UTC
            Console.WriteLine(utcTime);  // خروجی: 16/12/2024 11:30:00 +00:00


            // تبدیل به DateTime

            DateTimeOffset time = new DateTimeOffset(2024, 12, 16, 14, 30, 0, TimeSpan.FromHours(3));
            DateTime dateTime = time.DateTime;  // تبدیل به DateTime
            Console.WriteLine(dateTime);  // خروجی: 16/12/2024 14:30:00


        }
    }
}
