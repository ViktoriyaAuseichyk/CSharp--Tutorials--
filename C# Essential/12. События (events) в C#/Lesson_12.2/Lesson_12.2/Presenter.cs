using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_12._2
{
    public class Presenter
    {
        private readonly Form1 form1;
        private readonly Model model;

        public Presenter(Form1 form1)
        {
            this.model = new Model();
            this.form1 = form1;
            form1.Start += ViewStart;
            form1.Stop += ViewStop;
            form1.Reset += ViewReset;
            form1.timer.Elapsed += TimerTick;
            form1.timer.Start();
            form1.timer.Enabled = false;
        }

        private void ViewReset(object sender, EventArgs e)
        {
            form1.timer.Stop();
            this.form1.DayTextBox.Text = "00";
            this.form1.HourTextBox.Text = "00";
            this.form1.MinTextBox.Text = "00";
            this.form1.SekTextBox.Text = "00";
            this.form1.MSekTextBox.Text = "00";
            model.Reset();
        }
        private void ViewStart(object sender, EventArgs e)
        {
            form1.timer.Enabled = true;
        }
        private void ViewStop(object sender, EventArgs e)
        {
            form1.timer.Enabled = false;
        }
        private void TimerTick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.form1.MSekTextBox.Text) != 59)
            {
                this.form1.MSekTextBox.Text = this.model.Tick(this.form1.MSekTextBox.Text.ToString());
            }
            else if (Convert.ToInt32(this.form1.SekTextBox.Text) != 59)
            {
                this.form1.MSekTextBox.Text = "00";
                this.form1.SekTextBox.Text = this.model.Tick(this.form1.SekTextBox.Text.ToString());
            }
            else if (Convert.ToInt32(this.form1.MinTextBox.Text) != 59)
            {
                this.form1.MSekTextBox.Text = "00";
                this.form1.SekTextBox.Text = "00";
                this.form1.MinTextBox.Text = this.model.Tick(this.form1.MinTextBox.Text.ToString());
            }
            else if (Convert.ToInt32(this.form1.HourTextBox.Text) != 59)
            {
                this.form1.MSekTextBox.Text = "00";
                this.form1.SekTextBox.Text = "00";
                this.form1.MinTextBox.Text = "00";
                this.form1.HourTextBox.Text = this.model.Tick(this.form1.HourTextBox.Text.ToString());
            }
            else
            {
                this.form1.MSekTextBox.Text = "00";
                this.form1.SekTextBox.Text = "00";
                this.form1.MinTextBox.Text = "00";
                this.form1.HourTextBox.Text = "00";
                this.form1.DayTextBox.Text = this.model.Tick(this.form1.HourTextBox.Text.ToString());
            }
        }
    }
}
