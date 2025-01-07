namespace ColorMixer2025
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
            numericUpDownRed = new NumericUpDown();
            pictureBoxRed = new PictureBox();
            pictureBoxGreen = new PictureBox();
            numericUpDownGreen = new NumericUpDown();
            pictureBoxBlue = new PictureBox();
            numericUpDownBlue = new NumericUpDown();
            trackBarRed = new TrackBar();
            trackBarGreen = new TrackBar();
            trackBarBlue = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownRed
            // 
            numericUpDownRed.BackColor = Color.WhiteSmoke;
            numericUpDownRed.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownRed.Location = new Point(47, 41);
            numericUpDownRed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownRed.Name = "numericUpDownRed";
            numericUpDownRed.Size = new Size(150, 61);
            numericUpDownRed.TabIndex = 0;
            numericUpDownRed.ValueChanged += numericUpDownRed_ValueChanged;
            // 
            // pictureBoxRed
            // 
            pictureBoxRed.BackColor = Color.WhiteSmoke;
            pictureBoxRed.Location = new Point(47, 121);
            pictureBoxRed.Name = "pictureBoxRed";
            pictureBoxRed.Size = new Size(150, 150);
            pictureBoxRed.TabIndex = 1;
            pictureBoxRed.TabStop = false;
            pictureBoxRed.Click += pictureBoxRed_Click;
            // 
            // pictureBoxGreen
            // 
            pictureBoxGreen.BackColor = Color.WhiteSmoke;
            pictureBoxGreen.Location = new Point(248, 121);
            pictureBoxGreen.Name = "pictureBoxGreen";
            pictureBoxGreen.Size = new Size(150, 150);
            pictureBoxGreen.TabIndex = 3;
            pictureBoxGreen.TabStop = false;
            pictureBoxGreen.Click += pictureBoxGreen_Click;
            // 
            // numericUpDownGreen
            // 
            numericUpDownGreen.BackColor = Color.WhiteSmoke;
            numericUpDownGreen.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownGreen.Location = new Point(248, 41);
            numericUpDownGreen.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownGreen.Name = "numericUpDownGreen";
            numericUpDownGreen.Size = new Size(150, 61);
            numericUpDownGreen.TabIndex = 2;
            numericUpDownGreen.ValueChanged += numericUpDownGreen_ValueChanged;
            // 
            // pictureBoxBlue
            // 
            pictureBoxBlue.BackColor = Color.WhiteSmoke;
            pictureBoxBlue.Location = new Point(446, 121);
            pictureBoxBlue.Name = "pictureBoxBlue";
            pictureBoxBlue.Size = new Size(150, 150);
            pictureBoxBlue.TabIndex = 5;
            pictureBoxBlue.TabStop = false;
            // 
            // numericUpDownBlue
            // 
            numericUpDownBlue.BackColor = Color.WhiteSmoke;
            numericUpDownBlue.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownBlue.Location = new Point(446, 41);
            numericUpDownBlue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownBlue.Name = "numericUpDownBlue";
            numericUpDownBlue.Size = new Size(150, 61);
            numericUpDownBlue.TabIndex = 4;
            numericUpDownBlue.ValueChanged += numericUpDownBlue_ValueChanged;
            // 
            // trackBarRed
            // 
            trackBarRed.Location = new Point(47, 296);
            trackBarRed.Maximum = 255;
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Size = new Size(150, 56);
            trackBarRed.TabIndex = 6;
            trackBarRed.TickStyle = TickStyle.None;
            trackBarRed.Scroll += trackBarRed_Scroll;
            // 
            // trackBarGreen
            // 
            trackBarGreen.Location = new Point(248, 296);
            trackBarGreen.Maximum = 255;
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Size = new Size(150, 56);
            trackBarGreen.TabIndex = 7;
            trackBarGreen.TickStyle = TickStyle.None;
            trackBarGreen.Scroll += trackBarGreen_Scroll;
            // 
            // trackBarBlue
            // 
            trackBarBlue.Location = new Point(446, 296);
            trackBarBlue.Maximum = 255;
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Size = new Size(150, 56);
            trackBarBlue.TabIndex = 8;
            trackBarBlue.TickStyle = TickStyle.None;
            trackBarBlue.Scroll += trackBarBlue_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(trackBarBlue);
            Controls.Add(trackBarGreen);
            Controls.Add(trackBarRed);
            Controls.Add(pictureBoxBlue);
            Controls.Add(numericUpDownBlue);
            Controls.Add(pictureBoxGreen);
            Controls.Add(numericUpDownGreen);
            Controls.Add(pictureBoxRed);
            Controls.Add(numericUpDownRed);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownRed;
        private PictureBox pictureBoxRed;
        private PictureBox pictureBoxGreen;
        private NumericUpDown numericUpDownGreen;
        private PictureBox pictureBoxBlue;
        private NumericUpDown numericUpDownBlue;
        private TrackBar trackBarRed;
        private TrackBar trackBarGreen;
        private TrackBar trackBarBlue;
    }
}