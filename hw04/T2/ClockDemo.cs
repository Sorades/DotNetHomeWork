using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    public delegate void ClockHandler(Time time);

    class ClockDemo
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            try
            {
                clock.SetTime(1, 59, 59);
                clock.SetAlarm(2, 0, 5);//设置五秒后闹铃
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            clock.SwitchAlarm(true);//打开闹钟开关
            clock.Alarm += new ClockHandler(Alarm);
            clock.Tick += new ClockHandler(Tick);
            clock.TimeGoesOn(10);//钟走10s


        }
        /// <summary>
        /// 每秒报Tick和时间
        /// </summary>
        /// <param name="time"></param>
        static void Tick(Time time)
        {
            Console.WriteLine($"time:  {time.Hour.ToString("00")}:{time.Minute.ToString("00")}:{time.Second.ToString("00")}\nTick...");
        }
        /// <summary>
        /// 触发闹钟
        /// </summary>
        /// <param name="alarm"></param>
        static void Alarm(Time alarm)
        {
            Console.WriteLine("!!!!!Alarm!!!!!\n");
        }
    }
    /// <summary>
    /// 发布器
    /// </summary>
    public class Clock
    {
        public event ClockHandler Tick;
        public event ClockHandler Alarm;
        Time time;
        Time alarm;
        bool IsSetAlarm = false;
        public Clock()
        {
            time = new Time()
            {
                Hour = 0,
                Minute = 0,
                Second = 0
            };
            alarm = new Time();
        }
        /// <summary>
        /// 闹钟走时
        /// </summary>
        /// <param name="timeLength">走时的时间长度</param>
        public void TimeGoesOn(int timeLength)
        {
            for (int i = 0; i < timeLength; i++)
            {
                time.Second++;
                if (time.Second == 60)
                {
                    time.Second = 0;
                    time.Minute++;
                }
                if (time.Minute == 60)
                {
                    time.Minute = 0;
                    time.Hour++;
                }
                if (time.Hour == 24)
                    time.Hour = 0;
                Tick(time);
                if (IsSetAlarm && time.Equals(alarm))
                    this.Alarm(alarm);
            }
        }
        /// <summary>
        /// 设置钟的时间
        /// </summary>
        /// <param name="hour">时</param>
        /// <param name="minute">分</param>
        /// <param name="second">秒</param>
        public void SetTime(int hour, int minute, int second)
        {
            if (hour >= 24 || hour < 0 ||
                minute >= 60 || minute < 0 ||
                second >= 60 || second < 0)
                throw new ArgumentException("时间格式不对");
            time.Hour = hour;
            time.Minute = minute;
            time.Second = second;
        }
        /// <summary>
        /// 设置闹钟的时间
        /// </summary>
        /// <param name="hour">时</param>
        /// <param name="minute">分</param>
        /// <param name="second">秒</param>
        public void SetAlarm(int hour, int minute, int second)
        {
            if (hour >= 24 || hour < 0 ||
                minute >= 60 || minute < 0 ||
                second >= 60 || second < 0)
                throw new ArgumentException("时间格式不对");
            alarm.Hour = hour;
            alarm.Minute = minute;
            alarm.Second = second;
        }
        public void SwitchAlarm(bool flag) { IsSetAlarm = flag; }

    }
    /// <summary>
    /// 时间类
    /// </summary>
    public class Time
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        /// <summary>
        /// 重写父类Equals，判断两个对象的值是否相等
        /// </summary>
        /// <param name="obj">比较的对象</param>
        /// <returns>值是否相等</returns>
        public override bool Equals(object obj)
        {
            Time t = obj as Time;
            if ((this.Hour == t.Hour) &&
                (this.Minute == t.Minute) &&
                (this.Second == t.Second))
            {
                return true;
            }
            else { return false; }
        }
    }
}
