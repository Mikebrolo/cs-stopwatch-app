namespace StopWatchApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StopBtn = new Button();
            StartBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            ResetBtn = new Button();
            LapBtn = new Button();
            LapLabel = new Label();
            LoadBtn = new Button();
            SaveBtn = new Button();
            CurrentLap = new Label();
            SuspendLayout();
            // 
            // StopBtn
            // 
            StopBtn.BackColor = Color.FromArgb(255, 128, 128);
            StopBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            StopBtn.Location = new Point(132, 281);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(178, 46);
            StopBtn.TabIndex = 0;
            StopBtn.Text = "Stop";
            StopBtn.UseVisualStyleBackColor = false;
            StopBtn.Click += button1_Click;
            // 
            // StartBtn
            // 
            StartBtn.BackColor = Color.FromArgb(192, 255, 192);
            StartBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            StartBtn.Location = new Point(500, 281);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(178, 46);
            StartBtn.TabIndex = 1;
            StartBtn.Text = "Start";
            StartBtn.UseVisualStyleBackColor = false;
            StartBtn.Click += button2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(206, 9);
            label1.Name = "label1";
            label1.Size = new Size(405, 100);
            label1.TabIndex = 2;
            label1.Text = "Stopwatch";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(67, 138);
            label2.Name = "label2";
            label2.Size = new Size(332, 97);
            label2.TabIndex = 3;
            label2.Text = "00:00:00";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.FromArgb(192, 192, 255);
            ResetBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ResetBtn.Location = new Point(132, 333);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(178, 45);
            ResetBtn.TabIndex = 4;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // LapBtn
            // 
            LapBtn.BackColor = Color.FromArgb(255, 192, 255);
            LapBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LapBtn.Location = new Point(500, 333);
            LapBtn.Name = "LapBtn";
            LapBtn.Size = new Size(178, 45);
            LapBtn.TabIndex = 5;
            LapBtn.Text = "Lap";
            LapBtn.UseVisualStyleBackColor = false;
            LapBtn.Click += LapBtn_Click;
            // 
            // LapLabel
            // 
            LapLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LapLabel.ForeColor = Color.Black;
            LapLabel.Location = new Point(459, 130);
            LapLabel.Name = "LapLabel";
            LapLabel.Size = new Size(279, 37);
            LapLabel.TabIndex = 6;
            LapLabel.Text = "Lap 1: 00:00:00";
            LapLabel.TextAlign = ContentAlignment.MiddleLeft;
            LapLabel.Click += LapLabel_Click;
            // 
            // LoadBtn
            // 
            LoadBtn.BackColor = Color.FromArgb(224, 224, 224);
            LoadBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LoadBtn.Location = new Point(221, 393);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(178, 45);
            LoadBtn.TabIndex = 7;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = false;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(224, 224, 224);
            SaveBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SaveBtn.Location = new Point(418, 393);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(178, 45);
            SaveBtn.TabIndex = 8;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CurrentLap
            // 
            CurrentLap.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentLap.ForeColor = Color.FromArgb(0, 0, 192);
            CurrentLap.Location = new Point(459, 93);
            CurrentLap.Name = "CurrentLap";
            CurrentLap.Size = new Size(279, 37);
            CurrentLap.TabIndex = 9;
            CurrentLap.Text = "00:00:00";
            CurrentLap.TextAlign = ContentAlignment.TopCenter;
            CurrentLap.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CurrentLap);
            Controls.Add(SaveBtn);
            Controls.Add(LoadBtn);
            Controls.Add(LapLabel);
            Controls.Add(LapBtn);
            Controls.Add(ResetBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(StartBtn);
            Controls.Add(StopBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button StopBtn;
        private Button StartBtn;
        private Label label1;
        private Label label2;
        private Button ResetBtn;
        private Button LapBtn;
        private Label LapLabel;
        private Button LoadBtn;
        private Button SaveBtn;
        private Label CurrentLap;
    }
}