namespace Assign6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.afibRB = new System.Windows.Forms.RadioButton();
            this.dvtRB = new System.Windows.Forms.RadioButton();
            this.hypertentionRB = new System.Windows.Forms.RadioButton();
            this.insulinRB = new System.Windows.Forms.RadioButton();
            this.stimLaxRB = new System.Windows.Forms.RadioButton();
            this.antiCoRB = new System.Windows.Forms.RadioButton();
            this.ReactionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GenderChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.afibGRB = new System.Windows.Forms.RadioButton();
            this.dvtGRB = new System.Windows.Forms.RadioButton();
            this.hypertentionGRB = new System.Windows.Forms.RadioButton();
            this.insulinGRB = new System.Windows.Forms.RadioButton();
            this.stimLaxGRB = new System.Windows.Forms.RadioButton();
            this.antiCoGRB = new System.Windows.Forms.RadioButton();
            this.changeChartBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.limitSearchCB = new System.Windows.Forms.ComboBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReactionChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderChart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.afibRB);
            this.groupBox1.Controls.Add(this.dvtRB);
            this.groupBox1.Controls.Add(this.hypertentionRB);
            this.groupBox1.Location = new System.Drawing.Point(31, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Indication for Drug Use";
            // 
            // afibRB
            // 
            this.afibRB.AutoSize = true;
            this.afibRB.Location = new System.Drawing.Point(32, 68);
            this.afibRB.Name = "afibRB";
            this.afibRB.Size = new System.Drawing.Size(97, 17);
            this.afibRB.TabIndex = 2;
            this.afibRB.TabStop = true;
            this.afibRB.Text = "Atrial Fibrillation";
            this.afibRB.UseVisualStyleBackColor = true;
            this.afibRB.Click += new System.EventHandler(this.ReactionRadioButtons_CheckedChanged);
            // 
            // dvtRB
            // 
            this.dvtRB.AutoSize = true;
            this.dvtRB.Location = new System.Drawing.Point(32, 44);
            this.dvtRB.Name = "dvtRB";
            this.dvtRB.Size = new System.Drawing.Size(132, 17);
            this.dvtRB.TabIndex = 1;
            this.dvtRB.TabStop = true;
            this.dvtRB.Text = "Deep Vein Thrombosis";
            this.dvtRB.UseVisualStyleBackColor = true;
            this.dvtRB.Click += new System.EventHandler(this.ReactionRadioButtons_CheckedChanged);
            // 
            // hypertentionRB
            // 
            this.hypertentionRB.AutoSize = true;
            this.hypertentionRB.Location = new System.Drawing.Point(32, 20);
            this.hypertentionRB.Name = "hypertentionRB";
            this.hypertentionRB.Size = new System.Drawing.Size(85, 17);
            this.hypertentionRB.TabIndex = 0;
            this.hypertentionRB.TabStop = true;
            this.hypertentionRB.Text = "Hypertention";
            this.hypertentionRB.UseVisualStyleBackColor = true;
            this.hypertentionRB.Click += new System.EventHandler(this.ReactionRadioButtons_CheckedChanged);
            // 
            // insulinRB
            // 
            this.insulinRB.AutoSize = true;
            this.insulinRB.Location = new System.Drawing.Point(36, 68);
            this.insulinRB.Name = "insulinRB";
            this.insulinRB.Size = new System.Drawing.Size(55, 17);
            this.insulinRB.TabIndex = 5;
            this.insulinRB.TabStop = true;
            this.insulinRB.Text = "Insulin";
            this.insulinRB.UseVisualStyleBackColor = true;
            this.insulinRB.Click += new System.EventHandler(this.ReactionRadioButtons_CheckedChanged);
            // 
            // stimLaxRB
            // 
            this.stimLaxRB.AutoSize = true;
            this.stimLaxRB.Location = new System.Drawing.Point(36, 46);
            this.stimLaxRB.Name = "stimLaxRB";
            this.stimLaxRB.Size = new System.Drawing.Size(111, 17);
            this.stimLaxRB.TabIndex = 4;
            this.stimLaxRB.TabStop = true;
            this.stimLaxRB.Text = "Stimulant Laxative";
            this.stimLaxRB.UseVisualStyleBackColor = true;
            this.stimLaxRB.Click += new System.EventHandler(this.ReactionRadioButtons_CheckedChanged);
            // 
            // antiCoRB
            // 
            this.antiCoRB.AutoSize = true;
            this.antiCoRB.Location = new System.Drawing.Point(36, 22);
            this.antiCoRB.Name = "antiCoRB";
            this.antiCoRB.Size = new System.Drawing.Size(93, 17);
            this.antiCoRB.TabIndex = 3;
            this.antiCoRB.TabStop = true;
            this.antiCoRB.Text = "Anti-coagulant";
            this.antiCoRB.UseVisualStyleBackColor = true;
            this.antiCoRB.Click += new System.EventHandler(this.ReactionRadioButtons_CheckedChanged);
            // 
            // ReactionChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ReactionChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ReactionChart.Legends.Add(legend1);
            this.ReactionChart.Location = new System.Drawing.Point(11, 134);
            this.ReactionChart.Name = "ReactionChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "ReactionSeries";
            this.ReactionChart.Series.Add(series1);
            this.ReactionChart.Size = new System.Drawing.Size(652, 336);
            this.ReactionChart.TabIndex = 4;
            this.ReactionChart.Text = "ReactionChart";
            // 
            // GenderChart
            // 
            chartArea2.Name = "ChartArea1";
            this.GenderChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.GenderChart.Legends.Add(legend2);
            this.GenderChart.Location = new System.Drawing.Point(17, 155);
            this.GenderChart.Name = "GenderChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "GenderSeries";
            this.GenderChart.Series.Add(series2);
            this.GenderChart.Size = new System.Drawing.Size(295, 315);
            this.GenderChart.TabIndex = 5;
            this.GenderChart.Text = "GenderChart";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.afibGRB);
            this.groupBox2.Controls.Add(this.dvtGRB);
            this.groupBox2.Controls.Add(this.hypertentionGRB);
            this.groupBox2.Location = new System.Drawing.Point(17, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 93);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Indication for Drug Use";
            // 
            // afibGRB
            // 
            this.afibGRB.AutoSize = true;
            this.afibGRB.Location = new System.Drawing.Point(7, 67);
            this.afibGRB.Name = "afibGRB";
            this.afibGRB.Size = new System.Drawing.Size(97, 17);
            this.afibGRB.TabIndex = 2;
            this.afibGRB.TabStop = true;
            this.afibGRB.Text = "Atrial Fibrillation";
            this.afibGRB.UseVisualStyleBackColor = true;
            this.afibGRB.Click += new System.EventHandler(this.GenderRadioButtons_CheckedChanged);
            // 
            // dvtGRB
            // 
            this.dvtGRB.AutoSize = true;
            this.dvtGRB.Location = new System.Drawing.Point(7, 44);
            this.dvtGRB.Name = "dvtGRB";
            this.dvtGRB.Size = new System.Drawing.Size(132, 17);
            this.dvtGRB.TabIndex = 1;
            this.dvtGRB.TabStop = true;
            this.dvtGRB.Text = "Deep Vein Thrombosis";
            this.dvtGRB.UseVisualStyleBackColor = true;
            this.dvtGRB.Click += new System.EventHandler(this.GenderRadioButtons_CheckedChanged);
            // 
            // hypertentionGRB
            // 
            this.hypertentionGRB.AutoSize = true;
            this.hypertentionGRB.Location = new System.Drawing.Point(7, 20);
            this.hypertentionGRB.Name = "hypertentionGRB";
            this.hypertentionGRB.Size = new System.Drawing.Size(85, 17);
            this.hypertentionGRB.TabIndex = 0;
            this.hypertentionGRB.TabStop = true;
            this.hypertentionGRB.Text = "Hypertention";
            this.hypertentionGRB.UseVisualStyleBackColor = true;
            this.hypertentionGRB.Click += new System.EventHandler(this.GenderRadioButtons_CheckedChanged);
            // 
            // insulinGRB
            // 
            this.insulinGRB.AutoSize = true;
            this.insulinGRB.Location = new System.Drawing.Point(6, 64);
            this.insulinGRB.Name = "insulinGRB";
            this.insulinGRB.Size = new System.Drawing.Size(55, 17);
            this.insulinGRB.TabIndex = 5;
            this.insulinGRB.TabStop = true;
            this.insulinGRB.Text = "Insulin";
            this.insulinGRB.UseVisualStyleBackColor = true;
            this.insulinGRB.Click += new System.EventHandler(this.GenderRadioButtons_CheckedChanged);
            // 
            // stimLaxGRB
            // 
            this.stimLaxGRB.AutoSize = true;
            this.stimLaxGRB.Location = new System.Drawing.Point(6, 41);
            this.stimLaxGRB.Name = "stimLaxGRB";
            this.stimLaxGRB.Size = new System.Drawing.Size(111, 17);
            this.stimLaxGRB.TabIndex = 4;
            this.stimLaxGRB.TabStop = true;
            this.stimLaxGRB.Text = "Stimulant Laxative";
            this.stimLaxGRB.UseVisualStyleBackColor = true;
            this.stimLaxGRB.Click += new System.EventHandler(this.GenderRadioButtons_CheckedChanged);
            // 
            // antiCoGRB
            // 
            this.antiCoGRB.AutoSize = true;
            this.antiCoGRB.Location = new System.Drawing.Point(6, 17);
            this.antiCoGRB.Name = "antiCoGRB";
            this.antiCoGRB.Size = new System.Drawing.Size(93, 17);
            this.antiCoGRB.TabIndex = 3;
            this.antiCoGRB.TabStop = true;
            this.antiCoGRB.Text = "Anti-coagulant";
            this.antiCoGRB.UseVisualStyleBackColor = true;
            this.antiCoGRB.Click += new System.EventHandler(this.GenderRadioButtons_CheckedChanged);
            // 
            // changeChartBtn
            // 
            this.changeChartBtn.Location = new System.Drawing.Point(84, 126);
            this.changeChartBtn.Name = "changeChartBtn";
            this.changeChartBtn.Size = new System.Drawing.Size(161, 23);
            this.changeChartBtn.TabIndex = 7;
            this.changeChartBtn.Text = "Change Chart Type";
            this.changeChartBtn.UseVisualStyleBackColor = true;
            this.changeChartBtn.Click += new System.EventHandler(this.changeChartBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.limitSearchCB);
            this.groupBox3.Controls.Add(this.exitBtn);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.ReactionChart);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(671, 481);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Frequently Reported Adverse Reactions ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Change Limit Returned";
            // 
            // limitSearchCB
            // 
            this.limitSearchCB.FormattingEnabled = true;
            this.limitSearchCB.Items.AddRange(new object[] {
            "Limit 5",
            "Limit 10"});
            this.limitSearchCB.Location = new System.Drawing.Point(450, 64);
            this.limitSearchCB.Name = "limitSearchCB";
            this.limitSearchCB.Size = new System.Drawing.Size(121, 21);
            this.limitSearchCB.TabIndex = 8;
            this.limitSearchCB.SelectedIndexChanged += new System.EventHandler(this.limitSearchCB_SelectedIndexChanged);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(588, 19);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit Program";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.insulinRB);
            this.groupBox5.Controls.Add(this.stimLaxRB);
            this.groupBox5.Controls.Add(this.antiCoRB);
            this.groupBox5.Location = new System.Drawing.Point(240, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(193, 93);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Established Pharmacologic Class";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.GenderChart);
            this.groupBox4.Controls.Add(this.changeChartBtn);
            this.groupBox4.Location = new System.Drawing.Point(702, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 481);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Adverse Reactions Totals by Gender";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.insulinGRB);
            this.groupBox6.Controls.Add(this.stimLaxGRB);
            this.groupBox6.Controls.Add(this.antiCoGRB);
            this.groupBox6.Location = new System.Drawing.Point(166, 27);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(146, 93);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Est. Pharmacologic Class";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1038, 519);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReactionChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderChart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton dvtRB;
        private System.Windows.Forms.RadioButton hypertentionRB;
        private System.Windows.Forms.DataVisualization.Charting.Chart ReactionChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart GenderChart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton dvtGRB;
        private System.Windows.Forms.RadioButton hypertentionGRB;
        private System.Windows.Forms.RadioButton insulinRB;
        private System.Windows.Forms.RadioButton stimLaxRB;
        private System.Windows.Forms.RadioButton antiCoRB;
        private System.Windows.Forms.RadioButton afibRB;
        private System.Windows.Forms.RadioButton insulinGRB;
        private System.Windows.Forms.RadioButton stimLaxGRB;
        private System.Windows.Forms.RadioButton antiCoGRB;
        private System.Windows.Forms.RadioButton afibGRB;
        private System.Windows.Forms.Button changeChartBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ComboBox limitSearchCB;
        private System.Windows.Forms.Label label1;
    }
}

