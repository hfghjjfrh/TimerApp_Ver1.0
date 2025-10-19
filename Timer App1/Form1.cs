/*
アプリ名： タイマーVer.1
　作成者： 外田良平
作成日時： 2024/8/4(Sun)
作成言語： C#コンソールアプリケーション
備　　考： 特にありません
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_App1
{
    public partial class Form1 : Form
    {
        int h;
        int m;
        int s;
        int time;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            Init();
            status.Text = ("Standby");
            Start.Enabled = false;
            Stop.Enabled = false;
            timeup.Visible = false;

        }

        public void Init()
        {
            h = 0;
            m = 0;
            s = 0;
            time = 0;
            WriteTimeText();
           
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void WriteTimeText()
        {
            display.Text = String.Format("{0:00}:{1:00}:{2:00}",h, m, s);//00:00:00
        }
        private void Form1_Load(object sender, EventArgs e) {} //枠の近くの設定をします
        private void Title_Click(object sender, EventArgs e) {}
        private void display_Click(object sender, EventArgs e) {} //初期値  XX:XX:XXとしてください
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            time = time - 1000;
            m = time / 60000;
            h = time / (360 * 100*100);
            s = (time % 60000) / 1000;
            


            WriteTimeText();
            if (time == 0)
            {
              
                timer1.Stop();
              
                status.Text = ("Time Up");
                status2.Minimum = 0;
                status2.Maximum = 0;
                status2.Value = 0;

                try
                {
                    SoundPlayer simpleSound = new SoundPlayer(@"..\..\sound\Alarm.wav");
                    simpleSound.Play();
                }
                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("サウンドファイルが見つかりません。\nファイルが指定の場所にあるか確認してください。\n", "エラー");
                }
                
                timeup.Visible = true;
                status2.Visible = false;

                Init();
                status.Text = ("Standby");
                min1.Enabled = true;
                min10.Enabled = true;
                min30.Enabled = true;
                sec1.Enabled = true;
                sec10.Enabled = true;
                sec30.Enabled = true;
                Start.Enabled = false;
                Stop.Enabled = false;
             

                return;
                
            }

        }
        private void reset_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer simpleSound = new SoundPlayer(@"..\..\sound\chimes.wav");
                simpleSound.Play();
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("サウンドファイルが見つかりません。\nファイルが指定の場所にあるか確認してください。\n", "エラー");
            }
            timer1.Stop();
            Start.Enabled = false;
            h = 0;
            m = 0;
            s = 0;
            time = 0;
            display.Text = String.Format("00:00:00");
            status.Text = ("Reset");
            Start.Enabled = false;
            status2.Minimum = 0;
            status2.Maximum = 0;
            status2.Value = 0;
            min1.Enabled = true;
            min10.Enabled = true;
            min30.Enabled = true;
            sec1.Enabled = true;
            sec10.Enabled = true;
            sec30.Enabled = true;
            Start.Enabled = false;
            Stop.Enabled = false;
        }

        
        
        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer simpleSound = new SoundPlayer(@"..\..\sound\notify.wav");
                simpleSound.Play();
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("サウンドファイルが見つかりません。\nファイルが指定の場所にあるか確認してください。\n", "エラー");
            }
            
            time = (h * 60 * 60 + m * 60 + s) * 1000;　//{(時×60)+(分×60)+ 秒}*1000＝全体の秒　（例）1:30 → 90と計算します
            timer1.Start();
            status.Text = ("Start");//　　　　↑ミリ秒を秒に直すためにつけます
            status2.Style = ProgressBarStyle.Marquee;
            status2.Maximum = 10;
            status2.MarqueeAnimationSpeed = 30;
            min1.Enabled = false;
            min10.Enabled = false;
            min30.Enabled = false;
            sec1.Enabled = false;
            sec10.Enabled = false;
            sec30.Enabled = false;
            Start.Enabled = false;
            Stop.Enabled = true;
        }

        private void Button_SMH1(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer simpleSound = new SoundPlayer(@"..\..\sound\chimes.wav");
                simpleSound.Play();
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("サウンドファイルが見つかりません。\nファイルが指定の場所にあるか確認してください。\n", "エラー");
            }
            
            Start.Enabled = true;
            Button btn = (Button)sender;

            if (btn == min1)
            {
                m++;
                if (m >= 60)
                {
                    m = 0;
                }

            }
            else if (btn == sec1)
            {
                s++;
                if (s >= 60)
                {
                    s = 0;
                }
            }

            /*
            else if (btn == hour1)
            {
                h++;
                if (h >= 2)
                {
                    h = 0;
                }
            }
            */

            WriteTimeText();

            
        } //1ずつ増える

        private void Button_SMH10(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer simpleSound = new SoundPlayer(@"..\..\sound\chimes.wav");
                simpleSound.Play();
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("サウンドファイルが見つかりません。\nファイルが指定の場所にあるか確認してください。\n", "エラー");
            }
            Start.Enabled = true;
            Button btn = (Button)sender;
            if (btn == min10)
            {
                m = m + 10;
                if (m >= 60)
                {
                    m = 0;
                }

            }
            else if (btn == sec10)
            {
                s = s + 10;
                if (s >= 60)
                {
                    s = 0;
                }
            }

            WriteTimeText();
        }//10ずつ増える

        private void Button_SMH30(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer simpleSound = new SoundPlayer(@"..\..\sound\chimes.wav");
                simpleSound.Play();
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("サウンドファイルが見つかりません。\nファイルが指定の場所にあるか確認してください。\n", "エラー");
            }
            Start.Enabled = true;
            Button btn = (Button)sender;
            if (btn == min30)
            {
                m = m + 30;
                if (m >= 60)
                {
                    m = 0;
                }

            }
            else if (btn == sec30)
            {
                s = s + 30;
                if (s >= 60)
                {
                    s = 0;
                }
            }
        

            WriteTimeText();
        }//30ずつ増える

        private void Stop_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer simpleSound = new SoundPlayer(@"..\..\sound\chimes.wav");
                simpleSound.Play();
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("サウンドファイルが見つかりません。\nファイルが指定の場所にあるか確認してください。\n", "エラー");
            }

            timer1.Stop();
            WriteTimeText();
            status.Text = ("Stop");
            status2.Style = ProgressBarStyle.Marquee;
            status2.MarqueeAnimationSpeed = 0;
            
            min1.Enabled = true;
            min10.Enabled = true;
            min30.Enabled = true;
            sec1.Enabled = true;
            sec10.Enabled = true;
            sec30.Enabled = true;
            Start.Enabled = true;
            Stop.Enabled = false;
        }

        private void status_Click(object sender, EventArgs e){}

        private void status2_Click(object sender, EventArgs e)
        {

        }

        private void timeup_Click(object sender, EventArgs e)
        {
            try {
                SoundPlayer simpleSound = new SoundPlayer();
                simpleSound.Stop();
                SoundPlayer simpleSound2 = new SoundPlayer(@"..\..\sound\chimes.wav");
                simpleSound2.Play();
            } catch (System.IO.FileNotFoundException) {
                MessageBox.Show("サウンドファイルが見つかりません。\nファイルが指定の場所にあるか確認してください。\n", "エラー");
            }
            timeup.Visible = false;
            status2.Visible = true;
            
           
        }
    }
}
