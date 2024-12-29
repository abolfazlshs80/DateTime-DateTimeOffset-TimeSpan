using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAPP
{
    public class TimeSpanPreview
    {
        public void run()
        {
            TimeSpan timeSpan1 = new TimeSpan(1, 2, 30, 45);  // 1 روز، 2 ساعت، 30 دقیقه، 45 ثانیه
            TimeSpan timeSpan2 = new TimeSpan(5, 0, 0);  // 5 ساعت


            //مقایسه TimeSpan ها:
            TimeSpan time111 = new TimeSpan(1, 0, 0);  // 1 ساعت
            TimeSpan time211 = new TimeSpan(2, 0, 0);  // 2 ساعت
            Console.WriteLine(time111 < time211);  // True


            //جمع و تفریق TimeSpan ها

            TimeSpan time1 = new TimeSpan(1, 0, 0);  // 1 ساعت
            TimeSpan time2 = new TimeSpan(2, 0, 0);  // 2 ساعت
            TimeSpan sum = time1 + time2;  // جمع دو TimeSpan
            Console.WriteLine(sum);  // خروجی: 03:00:00

            TimeSpan diff = time2 - time1;  // تفریق دو TimeSpan
            Console.WriteLine(diff);  // خروجی: 01:00:00



            //دسترسی به مقادیر اجزای مختلف TimeSpan


            TimeSpan time4 = new TimeSpan(5, 10, 20, 30);
            Console.WriteLine(time4.Days);    // 5
            Console.WriteLine(time4.Hours);   // 10
            Console.WriteLine(time4.Minutes); // 20
            Console.WriteLine(time4.Seconds); // 30


            //تبدیل به فرمت‌های مختلف
            TimeSpan time3 = new TimeSpan(2, 14, 35, 50);  // 2 روز، 14 ساعت، 35 دقیقه، 50 ثانیه
            Console.WriteLine(time3.ToString());
            // خروجی: 2.14:35:50

            //fffffff: میلی‌ثانیه‌ها یا کسری از ثانیه
            //  d: روزها
            //  hh: ساعت‌ها
            //  mm: دقیقه‌ها
            //  ss: ثانیه‌ها
            //  fffffff: میلی‌ثانیه‌ها یا کسری از ثانیه






            //تبدیل به تعداد ثانیه یا میلی‌ثانیه

            TimeSpan time = new TimeSpan(1, 0, 0);  // 1 ساعت
            Console.WriteLine(time.TotalSeconds);  // 3600
            Console.WriteLine(time.TotalMilliseconds);  // 3600000




            //محاسبه تفاوت زمانی بین دو تاریخ


            DateTime startTime = new DateTime(2024, 12, 16, 8, 0, 0);  // شروع زمان
            DateTime endTime = new DateTime(2024, 12, 16, 10, 30, 0);  // زمان پایان

            TimeSpan difference = endTime - startTime;  // تفاوت بین دو تاریخ
            Console.WriteLine(difference);  // خروجی: 02:30:00

            //استفاده از TimeSpan برای تاخیر (Delay)


            TimeSpan delay = new TimeSpan(0, 0, 5);  // 5 ثانیه
            Console.WriteLine("Before delay");
            System.Threading.Thread.Sleep(delay);  // توقف به مدت 5 ثانیه
            Console.WriteLine("After delay");


            //محاسبه مدت زمان بین دو زمان خاص


            DateTime startDate = DateTime.Now;
            DateTime endDate = startDate.AddHours(5).AddMinutes(30);  // 5 ساعت و 30 دقیقه بعد

            TimeSpan duration = endDate - startDate;
            Console.WriteLine($"Duration: {duration.TotalHours} hours");  // خروجی: 5.5 hours


            //   تبدیل TimeSpan به فرمت قابل نمایش
            TimeSpan timeSpan = new TimeSpan(2, 14, 35, 50);
            Console.WriteLine(timeSpan.ToString(@"d\:hh\:mm\:ss"));  // خروجی: 2:14:35:50



            // استفاده از TimeSpan برای انجام عملیات با تاریخ‌ها
            DateTime now = DateTime.Now;
            DateTime futureDate = now + new TimeSpan(5, 0, 0);  // 5 ساعت بعد
            Console.WriteLine(futureDate);  // خروجی: تاریخ و زمان 5 ساعت بعد








        }
    }
}
