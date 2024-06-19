namespace Lesson_12._2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResetButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.SekTextBox = new System.Windows.Forms.TextBox();
            this.MSekTextBox = new System.Windows.Forms.TextBox();
            this.HourTextBox = new System.Windows.Forms.TextBox();
            this.DayText = new System.Windows.Forms.Label();
            this.HourText = new System.Windows.Forms.Label();
            this.MinText = new System.Windows.Forms.Label();
            this.SekText = new System.Windows.Forms.Label();
            this.MSekText = new System.Windows.Forms.Label();
            this.DayTextBox = new System.Windows.Forms.TextBox();
            this.timer = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.timer)).BeginInit();
            this.SuspendLayout();
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.SystemColors.Menu;
            this.ResetButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ResetButton.Location = new System.Drawing.Point(75, 175);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(100, 40);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "RESET";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.SystemColors.Menu;
            this.StopButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StopButton.Location = new System.Drawing.Point(325, 175);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(100, 40);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "STOP";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.Menu;
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StartButton.Location = new System.Drawing.Point(200, 175);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(100, 40);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MinTextBox
            // 
            this.MinTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.MinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MinTextBox.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinTextBox.Location = new System.Drawing.Point(215, 65);
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.Size = new System.Drawing.Size(70, 52);
            this.MinTextBox.TabIndex = 4;
            this.MinTextBox.Text = "00";
            this.MinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SekTextBox
            // 
            this.SekTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.SekTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SekTextBox.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SekTextBox.Location = new System.Drawing.Point(291, 65);
            this.SekTextBox.Name = "SekTextBox";
            this.SekTextBox.Size = new System.Drawing.Size(70, 52);
            this.SekTextBox.TabIndex = 5;
            this.SekTextBox.Text = "00";
            this.SekTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MSekTextBox
            // 
            this.MSekTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.MSekTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MSekTextBox.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSekTextBox.Location = new System.Drawing.Point(367, 65);
            this.MSekTextBox.Name = "MSekTextBox";
            this.MSekTextBox.Size = new System.Drawing.Size(70, 52);
            this.MSekTextBox.TabIndex = 6;
            this.MSekTextBox.Text = "00";
            this.MSekTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HourTextBox
            // 
            this.HourTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.HourTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HourTextBox.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourTextBox.Location = new System.Drawing.Point(139, 65);
            this.HourTextBox.Name = "HourTextBox";
            this.HourTextBox.Size = new System.Drawing.Size(70, 52);
            this.HourTextBox.TabIndex = 7;
            this.HourTextBox.Text = "00";
            this.HourTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DayText
            // 
            this.DayText.AutoSize = true;
            this.DayText.Font = new System.Drawing.Font("Elephant", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayText.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DayText.Location = new System.Drawing.Point(80, 131);
            this.DayText.Name = "DayText";
            this.DayText.Size = new System.Drawing.Size(36, 16);
            this.DayText.TabIndex = 9;
            this.DayText.Text = "DAY";
            // 
            // HourText
            // 
            this.HourText.AutoSize = true;
            this.HourText.Font = new System.Drawing.Font("Elephant", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourText.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.HourText.Location = new System.Drawing.Point(149, 131);
            this.HourText.Name = "HourText";
            this.HourText.Size = new System.Drawing.Size(51, 16);
            this.HourText.TabIndex = 11;
            this.HourText.Text = "HOUR";
            // 
            // MinText
            // 
            this.MinText.AutoSize = true;
            this.MinText.Font = new System.Drawing.Font("Elephant", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinText.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MinText.Location = new System.Drawing.Point(232, 131);
            this.MinText.Name = "MinText";
            this.MinText.Size = new System.Drawing.Size(40, 16);
            this.MinText.TabIndex = 12;
            this.MinText.Text = "MIN.";
            // 
            // SekText
            // 
            this.SekText.AutoSize = true;
            this.SekText.Font = new System.Drawing.Font("Elephant", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SekText.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.SekText.Location = new System.Drawing.Point(307, 131);
            this.SekText.Name = "SekText";
            this.SekText.Size = new System.Drawing.Size(40, 16);
            this.SekText.TabIndex = 13;
            this.SekText.Text = "SEK.";
            // 
            // MSekText
            // 
            this.MSekText.AutoSize = true;
            this.MSekText.Font = new System.Drawing.Font("Elephant", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSekText.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MSekText.Location = new System.Drawing.Point(377, 131);
            this.MSekText.Name = "MSekText";
            this.MSekText.Size = new System.Drawing.Size(56, 16);
            this.MSekText.TabIndex = 14;
            this.MSekText.Text = "M.SEK.";
            // 
            // DayTextBox
            // 
            this.DayTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.DayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DayTextBox.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayTextBox.Location = new System.Drawing.Point(63, 65);
            this.DayTextBox.Name = "DayTextBox";
            this.DayTextBox.Size = new System.Drawing.Size(70, 52);
            this.DayTextBox.TabIndex = 15;
            this.DayTextBox.Text = "00";
            this.DayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10D;
            this.timer.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.DayTextBox);
            this.Controls.Add(this.MSekText);
            this.Controls.Add(this.SekText);
            this.Controls.Add(this.MinText);
            this.Controls.Add(this.HourText);
            this.Controls.Add(this.DayText);
            this.Controls.Add(this.HourTextBox);
            this.Controls.Add(this.MSekTextBox);
            this.Controls.Add(this.SekTextBox);
            this.Controls.Add(this.MinTextBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.ResetButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.timer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label MSekText;
        private System.Windows.Forms.Label SekText;
        private System.Windows.Forms.Label MinText;
        private System.Windows.Forms.Label HourText;
        private System.Windows.Forms.Label DayText;
        public System.Windows.Forms.TextBox HourTextBox;
        public System.Windows.Forms.TextBox MSekTextBox;
        public System.Windows.Forms.TextBox SekTextBox;
        public System.Windows.Forms.TextBox MinTextBox;
        public System.Windows.Forms.TextBox DayTextBox;
        public System.Timers.Timer timer;
    }
}

