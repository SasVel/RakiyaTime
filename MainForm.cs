﻿using System.Text;
using RakiyaTime.Data;

namespace RakiyaTime
{
    public partial class MainForm : Form
    {
        


        public MainForm()
        {
            InitializeComponent();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            var universalTime = DateTime.Now.ToUniversalTime();
            DateTime rakiyaTime = universalTime;
            int utcNum = 0; 
            while (true)
            {
                if (rakiyaTime.Hour >= 16 && rakiyaTime.Hour < 17)
                {
                    break;
                }
                else
                {
                    rakiyaTime = rakiyaTime.AddHours(1);
                    if (utcNum == 12)
                    {
                        utcNum = -11;
                    }
                    else if (utcNum > 12)
                    {
                        utcNum--;
                    }
                    else
                    {
                        utcNum++;
                    }
                }
            }

            affirmationLabel.Visible = true;
            var citiesToDisplay = CitiesInfo.GetCitiesByUTC(utcNum);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"В момента е {rakiyaTime:HH:mm} в:");
            for (int i = 0; i < citiesToDisplay.Count; i++)
            {
                sb.AppendLine($"{i + 1}. {citiesToDisplay[i]}");
            }
            
            MainText.Text = sb.ToString();
        }
    }
}