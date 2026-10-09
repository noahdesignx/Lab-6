namespace Lab_6
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
            label1 = new Label();
            day = new TextBox();
            night = new TextBox();
            label2 = new Label();
            regular = new RadioButton();
            output = new Label();
            premium = new RadioButton();
            calculate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 110);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter day minutes";
            // 
            // day
            // 
            day.Location = new Point(404, 110);
            day.Name = "day";
            day.Size = new Size(125, 27);
            day.TabIndex = 1;
            day.TextChanged += day_TextChanged;
            // 
            // night
            // 
            night.Location = new Point(404, 185);
            night.Name = "night";
            night.Size = new Size(125, 27);
            night.TabIndex = 3;
            night.TextChanged += night_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 185);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 2;
            label2.Text = "Enter night minutes";
            // 
            // regular
            // 
            regular.AutoSize = true;
            regular.Location = new Point(225, 264);
            regular.Name = "regular";
            regular.Size = new Size(81, 24);
            regular.TabIndex = 4;
            regular.TabStop = true;
            regular.Text = "Regular";
            regular.UseVisualStyleBackColor = true;
            regular.CheckedChanged += regular_CheckedChanged;
            // 
            // output
            // 
            output.AutoSize = true;
            output.Location = new Point(613, 113);
            output.Name = "output";
            output.Size = new Size(55, 20);
            output.TabIndex = 7;
            output.Text = "Output";
            // 
            // premium
            // 
            premium.AutoSize = true;
            premium.BackColor = SystemColors.Control;
            premium.Location = new Point(345, 264);
            premium.Name = "premium";
            premium.Size = new Size(89, 24);
            premium.TabIndex = 8;
            premium.TabStop = true;
            premium.Text = "Premium";
            premium.UseVisualStyleBackColor = false;
            premium.CheckedChanged += premium_CheckedChanged;
            // 
            // calculate
            // 
            calculate.BackColor = Color.FromArgb(255, 128, 0);
            calculate.Location = new Point(225, 326);
            calculate.Name = "calculate";
            calculate.Size = new Size(304, 58);
            calculate.TabIndex = 9;
            calculate.Text = "Calculate";
            calculate.UseVisualStyleBackColor = false;
            calculate.Click += calculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calculate);
            Controls.Add(premium);
            Controls.Add(output);
            Controls.Add(regular);
            Controls.Add(night);
            Controls.Add(label2);
            Controls.Add(day);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox day;
        private TextBox night;
        private Label label2;
        private RadioButton regular;
        private RadioButton radioButton2;
        private Button button1;
        private Label output;
        private RadioButton premium;
        private Button calculate;
    }
}
