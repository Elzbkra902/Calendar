using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Calendar
{
    public partial class Form1 : Form
    {
        // zainicjowanie zmiennych miesiac i rok do kalendarza
        int month, year;
        // zainicjowanie statycznych zmiennych publicznch, dzieki którym mozna przekazac
        // dane dot. miesiąca i roku do formularza zdarzen
        public static int static_month, static_year;


        public Form1() // główne wywołanie okna aplikacji
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // main
        {
            displayDays();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            // naglowek nazwy miesiaca 
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBdate.Text = monthname + " " + year;

            static_month = month;
            static_year = year;

            // pierwszy dzień obecnego miesiąca
            DateTime startofthemonth = new DateTime(year, month, 1);
            // licznik dni w miesiącu 
            int days = DateTime.DaysInMonth(year, month);
            int daysWeek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < daysWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);

            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }

        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month--;

            static_month = month;
            static_year = year;

            // naglowek nazwy miesiaca 
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            LBdate.Text = monthname + " " + year;


            DateTime startofthemonth = new DateTime(year, month, 1);
            // licznik dni w miesiącu 
            int days = DateTime.DaysInMonth(year, month);
            int daysWeek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < daysWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);

            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
        private void ZamknjiBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnnext_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month++;

            static_month = month;
            static_year = year;

            // Naglowek nazwy miesiaca 
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBdate.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            // licznik dni w miesiącu 
            int days = DateTime.DaysInMonth(year, month);
            int daysWeek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < daysWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);

            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }

        }
    }
}


