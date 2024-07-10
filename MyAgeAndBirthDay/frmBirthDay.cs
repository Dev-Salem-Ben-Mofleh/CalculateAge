using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAgeAndBirthDay
{
    public partial class frmBirthDay : Form
    {
        public frmBirthDay()
        {
            InitializeComponent();
        }
        DateTime time = DateTime.Now;

        void ClacultDays()
        {


            DateTime Time2 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);

            TimeSpan Ressult = time.Subtract(Time2);
            lblDays2.Text = Convert.ToString((int)Ressult.TotalDays);
            lblHours.Text = Convert.ToString((int)Ressult.TotalHours);
            lblMuntes.Text = Convert.ToString((int)Ressult.TotalMinutes);
            lblSecond.Text = Convert.ToString((int)Ressult.TotalSeconds);
            lblWeeks.Text = Convert.ToString(((int)Ressult.TotalDays / 7));
            //lblWeeks.Text = Convert.ToString(CalcultWeeks((int)Ressult.TotalDays));
        }


        void CalculatAge()
        {
            if (dateTimePicker1.Value.Year >= time.Year)
            {
                return;
            }


            lblAge.Text = "Your Age " + Convert.ToString(time.Year - dateTimePicker1.Value.Year) + " Year ";

            if (dateTimePicker1.Value.Month > time.Month)
                lblMonthes.Text = "and " + Convert.ToString(dateTimePicker1.Value.Month - time.Month) + " Months";
            else
                lblMonthes.Text = "and " + Convert.ToString(time.Month - dateTimePicker1.Value.Month) + " Months";

            if (dateTimePicker1.Value.Day > time.Day)
                lblDays.Text = "and " + Convert.ToString(dateTimePicker1.Value.Day - time.Day) + " Days";
            else
                lblDays.Text = "and " + Convert.ToString(time.Day - dateTimePicker1.Value.Day) + " Days";

            ClacultDays();
        }

        private void btnAge_Click(object sender, EventArgs e)
        {
            CalculatAge();

        }
    }
}
