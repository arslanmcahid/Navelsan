using System.Drawing;

namespace navelsan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_saveResults = new System.Windows.Forms.Button();
            this.btn_cancelTest = new System.Windows.Forms.Button();
            this.btn_startTest = new System.Windows.Forms.Button();
            this.btn_dataControl = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lbl_underAnalytics = new System.Windows.Forms.Label();
            this.lbl_analytics = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_details = new System.Windows.Forms.Label();
            this.lbl_graph = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_timeData = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_temperatureData = new System.Windows.Forms.Label();
            this.lbl_temperature = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_PData = new System.Windows.Forms.Label();
            this.lbl_P = new System.Windows.Forms.Label();
            this.pnl_P0 = new System.Windows.Forms.Panel();
            this.lbl_P0Data = new System.Windows.Forms.Label();
            this.lbl_P0 = new System.Windows.Forms.Label();
            this.lbl_overview = new System.Windows.Forms.Label();
            this.lbl_d = new System.Windows.Forms.Label();
            this.lbl_seriNo = new System.Windows.Forms.Label();
            this.lbl_notes = new System.Windows.Forms.Label();
            this.txtbox_d = new System.Windows.Forms.TextBox();
            this.txtbox_seriNo = new System.Windows.Forms.TextBox();
            this.txtbox_Notes = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_P0.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_saveResults);
            this.splitContainer1.Panel1.Controls.Add(this.btn_cancelTest);
            this.splitContainer1.Panel1.Controls.Add(this.btn_startTest);
            this.splitContainer1.Panel1.Controls.Add(this.btn_dataControl);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1904, 1041);
            this.splitContainer1.SplitterDistance = 330;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_saveResults
            // 
            this.btn_saveResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_saveResults.BackColor = System.Drawing.Color.Azure;
            this.btn_saveResults.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveResults.ForeColor = System.Drawing.Color.Black;
            this.btn_saveResults.Image = global::navelsan.Properties.Resources.bookmark;
            this.btn_saveResults.Location = new System.Drawing.Point(15, 456);
            this.btn_saveResults.Name = "btn_saveResults";
            this.btn_saveResults.Size = new System.Drawing.Size(300, 80);
            this.btn_saveResults.TabIndex = 4;
            this.btn_saveResults.Text = "Save Results";
            this.btn_saveResults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_saveResults.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_saveResults.UseVisualStyleBackColor = false;
            // 
            // btn_cancelTest
            // 
            this.btn_cancelTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelTest.BackColor = System.Drawing.Color.Azure;
            this.btn_cancelTest.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelTest.ForeColor = System.Drawing.Color.Black;
            this.btn_cancelTest.Image = global::navelsan.Properties.Resources.cancel;
            this.btn_cancelTest.Location = new System.Drawing.Point(15, 372);
            this.btn_cancelTest.Name = "btn_cancelTest";
            this.btn_cancelTest.Size = new System.Drawing.Size(300, 80);
            this.btn_cancelTest.TabIndex = 3;
            this.btn_cancelTest.Text = "Cancel Test";
            this.btn_cancelTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelTest.UseVisualStyleBackColor = false;
            // 
            // btn_startTest
            // 
            this.btn_startTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_startTest.BackColor = System.Drawing.Color.Azure;
            this.btn_startTest.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startTest.ForeColor = System.Drawing.Color.Black;
            this.btn_startTest.Image = global::navelsan.Properties.Resources.restart;
            this.btn_startTest.Location = new System.Drawing.Point(15, 288);
            this.btn_startTest.Name = "btn_startTest";
            this.btn_startTest.Size = new System.Drawing.Size(300, 80);
            this.btn_startTest.TabIndex = 2;
            this.btn_startTest.Text = "Start Test";
            this.btn_startTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_startTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_startTest.UseVisualStyleBackColor = false;
            // 
            // btn_dataControl
            // 
            this.btn_dataControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dataControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.btn_dataControl.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dataControl.ForeColor = System.Drawing.Color.Snow;
            this.btn_dataControl.Image = global::navelsan.Properties.Resources.monitoring;
            this.btn_dataControl.Location = new System.Drawing.Point(15, 204);
            this.btn_dataControl.Name = "btn_dataControl";
            this.btn_dataControl.Size = new System.Drawing.Size(300, 80);
            this.btn_dataControl.TabIndex = 1;
            this.btn_dataControl.Text = "Data Control";
            this.btn_dataControl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dataControl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dataControl.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 56);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lbl_underAnalytics);
            this.splitContainer2.Panel1.Controls.Add(this.lbl_analytics);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel4);
            this.splitContainer2.Panel2.Controls.Add(this.lbl_details);
            this.splitContainer2.Panel2.Controls.Add(this.lbl_graph);
            this.splitContainer2.Panel2.Controls.Add(this.panel3);
            this.splitContainer2.Panel2.Controls.Add(this.panel2);
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Panel2.Controls.Add(this.pnl_P0);
            this.splitContainer2.Panel2.Controls.Add(this.lbl_overview);
            this.splitContainer2.Size = new System.Drawing.Size(1570, 1041);
            this.splitContainer2.SplitterDistance = 119;
            this.splitContainer2.TabIndex = 0;
            // 
            // lbl_underAnalytics
            // 
            this.lbl_underAnalytics.AutoSize = true;
            this.lbl_underAnalytics.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_underAnalytics.Location = new System.Drawing.Point(72, 67);
            this.lbl_underAnalytics.Name = "lbl_underAnalytics";
            this.lbl_underAnalytics.Size = new System.Drawing.Size(254, 32);
            this.lbl_underAnalytics.TabIndex = 1;
            this.lbl_underAnalytics.Text = "Seri porttan gelen anlık veri gözlenir";
            this.lbl_underAnalytics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_analytics
            // 
            this.lbl_analytics.AutoSize = true;
            this.lbl_analytics.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_analytics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_analytics.Location = new System.Drawing.Point(72, 16);
            this.lbl_analytics.Name = "lbl_analytics";
            this.lbl_analytics.Size = new System.Drawing.Size(216, 57);
            this.lbl_analytics.TabIndex = 0;
            this.lbl_analytics.Text = "ANALYTICS";
            this.lbl_analytics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtbox_Notes);
            this.panel4.Controls.Add(this.txtbox_seriNo);
            this.panel4.Controls.Add(this.txtbox_d);
            this.panel4.Controls.Add(this.lbl_notes);
            this.panel4.Controls.Add(this.lbl_seriNo);
            this.panel4.Controls.Add(this.lbl_d);
            this.panel4.Location = new System.Drawing.Point(1083, 353);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(418, 416);
            this.panel4.TabIndex = 7;
            // 
            // lbl_details
            // 
            this.lbl_details.AutoSize = true;
            this.lbl_details.Font = new System.Drawing.Font("Microsoft Uighur", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_details.Location = new System.Drawing.Point(1072, 300);
            this.lbl_details.Name = "lbl_details";
            this.lbl_details.Size = new System.Drawing.Size(100, 53);
            this.lbl_details.TabIndex = 6;
            this.lbl_details.Text = "Details";
            this.lbl_details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_graph
            // 
            this.lbl_graph.AutoSize = true;
            this.lbl_graph.Font = new System.Drawing.Font("Microsoft Uighur", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_graph.Location = new System.Drawing.Point(46, 300);
            this.lbl_graph.Name = "lbl_graph";
            this.lbl_graph.Size = new System.Drawing.Size(96, 53);
            this.lbl_graph.TabIndex = 5;
            this.lbl_graph.Text = "Graph";
            this.lbl_graph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(151)))), ((int)(((byte)(236)))));
            this.panel3.Controls.Add(this.lbl_timeData);
            this.panel3.Controls.Add(this.lbl_time);
            this.panel3.Location = new System.Drawing.Point(1191, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 180);
            this.panel3.TabIndex = 4;
            // 
            // lbl_timeData
            // 
            this.lbl_timeData.AutoSize = true;
            this.lbl_timeData.Font = new System.Drawing.Font("Microsoft Uighur", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timeData.Location = new System.Drawing.Point(57, 52);
            this.lbl_timeData.Name = "lbl_timeData";
            this.lbl_timeData.Size = new System.Drawing.Size(254, 70);
            this.lbl_timeData.TabIndex = 1;
            this.lbl_timeData.Text = "Time DATA";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_time.Location = new System.Drawing.Point(3, 11);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(61, 35);
            this.lbl_time.TabIndex = 0;
            this.lbl_time.Text = "Time";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(151)))), ((int)(((byte)(236)))));
            this.panel2.Controls.Add(this.lbl_temperatureData);
            this.panel2.Controls.Add(this.lbl_temperature);
            this.panel2.Location = new System.Drawing.Point(805, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 180);
            this.panel2.TabIndex = 3;
            // 
            // lbl_temperatureData
            // 
            this.lbl_temperatureData.AutoSize = true;
            this.lbl_temperatureData.Font = new System.Drawing.Font("Microsoft Uighur", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temperatureData.Location = new System.Drawing.Point(49, 52);
            this.lbl_temperatureData.Name = "lbl_temperatureData";
            this.lbl_temperatureData.Size = new System.Drawing.Size(266, 70);
            this.lbl_temperatureData.TabIndex = 1;
            this.lbl_temperatureData.Text = "Temp DATA";
            // 
            // lbl_temperature
            // 
            this.lbl_temperature.AutoSize = true;
            this.lbl_temperature.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temperature.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_temperature.Location = new System.Drawing.Point(3, 11);
            this.lbl_temperature.Name = "lbl_temperature";
            this.lbl_temperature.Size = new System.Drawing.Size(129, 35);
            this.lbl_temperature.TabIndex = 0;
            this.lbl_temperature.Text = "Temperature";
            this.lbl_temperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(151)))), ((int)(((byte)(236)))));
            this.panel1.Controls.Add(this.lbl_PData);
            this.panel1.Controls.Add(this.lbl_P);
            this.panel1.Location = new System.Drawing.Point(419, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 180);
            this.panel1.TabIndex = 2;
            // 
            // lbl_PData
            // 
            this.lbl_PData.AutoSize = true;
            this.lbl_PData.Font = new System.Drawing.Font("Microsoft Uighur", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PData.Location = new System.Drawing.Point(87, 52);
            this.lbl_PData.Name = "lbl_PData";
            this.lbl_PData.Size = new System.Drawing.Size(184, 70);
            this.lbl_PData.TabIndex = 1;
            this.lbl_PData.Text = "P DATA";
            // 
            // lbl_P
            // 
            this.lbl_P.AutoSize = true;
            this.lbl_P.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_P.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_P.Location = new System.Drawing.Point(3, 11);
            this.lbl_P.Name = "lbl_P";
            this.lbl_P.Size = new System.Drawing.Size(27, 35);
            this.lbl_P.TabIndex = 0;
            this.lbl_P.Text = "P";
            this.lbl_P.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_P0
            // 
            this.pnl_P0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(151)))), ((int)(((byte)(236)))));
            this.pnl_P0.Controls.Add(this.lbl_P0Data);
            this.pnl_P0.Controls.Add(this.lbl_P0);
            this.pnl_P0.Location = new System.Drawing.Point(33, 81);
            this.pnl_P0.Name = "pnl_P0";
            this.pnl_P0.Size = new System.Drawing.Size(360, 180);
            this.pnl_P0.TabIndex = 1;
            // 
            // lbl_P0Data
            // 
            this.lbl_P0Data.AutoSize = true;
            this.lbl_P0Data.Font = new System.Drawing.Font("Microsoft Uighur", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_P0Data.Location = new System.Drawing.Point(87, 52);
            this.lbl_P0Data.Name = "lbl_P0Data";
            this.lbl_P0Data.Size = new System.Drawing.Size(206, 70);
            this.lbl_P0Data.TabIndex = 1;
            this.lbl_P0Data.Text = "P0 DATA";
            // 
            // lbl_P0
            // 
            this.lbl_P0.AutoSize = true;
            this.lbl_P0.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_P0.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_P0.Location = new System.Drawing.Point(3, 11);
            this.lbl_P0.Name = "lbl_P0";
            this.lbl_P0.Size = new System.Drawing.Size(38, 35);
            this.lbl_P0.TabIndex = 0;
            this.lbl_P0.Text = "P0";
            this.lbl_P0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_overview
            // 
            this.lbl_overview.AutoSize = true;
            this.lbl_overview.Font = new System.Drawing.Font("Microsoft Uighur", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_overview.Location = new System.Drawing.Point(46, 26);
            this.lbl_overview.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_overview.Name = "lbl_overview";
            this.lbl_overview.Size = new System.Drawing.Size(131, 53);
            this.lbl_overview.TabIndex = 0;
            this.lbl_overview.Text = "Overview";
            // 
            // lbl_d
            // 
            this.lbl_d.AutoSize = true;
            this.lbl_d.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_d.Location = new System.Drawing.Point(85, 35);
            this.lbl_d.Name = "lbl_d";
            this.lbl_d.Size = new System.Drawing.Size(41, 49);
            this.lbl_d.TabIndex = 0;
            this.lbl_d.Text = "d:";
            // 
            // lbl_seriNo
            // 
            this.lbl_seriNo.AutoSize = true;
            this.lbl_seriNo.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seriNo.Location = new System.Drawing.Point(20, 84);
            this.lbl_seriNo.Name = "lbl_seriNo";
            this.lbl_seriNo.Size = new System.Drawing.Size(106, 49);
            this.lbl_seriNo.TabIndex = 1;
            this.lbl_seriNo.Text = "Seri No:";
            // 
            // lbl_notes
            // 
            this.lbl_notes.AutoSize = true;
            this.lbl_notes.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_notes.Location = new System.Drawing.Point(37, 133);
            this.lbl_notes.Name = "lbl_notes";
            this.lbl_notes.Size = new System.Drawing.Size(89, 49);
            this.lbl_notes.TabIndex = 2;
            this.lbl_notes.Text = "Notes:";
            // 
            // txtbox_d
            // 
            this.txtbox_d.Location = new System.Drawing.Point(132, 51);
            this.txtbox_d.Name = "txtbox_d";
            this.txtbox_d.Size = new System.Drawing.Size(208, 20);
            this.txtbox_d.TabIndex = 3;
            // 
            // txtbox_seriNo
            // 
            this.txtbox_seriNo.Location = new System.Drawing.Point(132, 100);
            this.txtbox_seriNo.Name = "txtbox_seriNo";
            this.txtbox_seriNo.Size = new System.Drawing.Size(208, 20);
            this.txtbox_seriNo.TabIndex = 4;
            // 
            // txtbox_Notes
            // 
            this.txtbox_Notes.Location = new System.Drawing.Point(132, 149);
            this.txtbox_Notes.Name = "txtbox_Notes";
            this.txtbox_Notes.Size = new System.Drawing.Size(208, 228);
            this.txtbox_Notes.TabIndex = 6;
            this.txtbox_Notes.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_P0.ResumeLayout(false);
            this.pnl_P0.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_dataControl;
        private System.Windows.Forms.Button btn_saveResults;
        private System.Windows.Forms.Button btn_cancelTest;
        private System.Windows.Forms.Button btn_startTest;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lbl_analytics;
        private System.Windows.Forms.Label lbl_underAnalytics;
        private System.Windows.Forms.Label lbl_overview;
        private System.Windows.Forms.Panel pnl_P0;
        private System.Windows.Forms.Label lbl_P0;
        private System.Windows.Forms.Label lbl_P0Data;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_timeData;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_temperatureData;
        private System.Windows.Forms.Label lbl_temperature;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_PData;
        private System.Windows.Forms.Label lbl_P;
        private System.Windows.Forms.Label lbl_graph;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_details;
        private System.Windows.Forms.Label lbl_notes;
        private System.Windows.Forms.Label lbl_seriNo;
        private System.Windows.Forms.Label lbl_d;
        private System.Windows.Forms.RichTextBox txtbox_Notes;
        private System.Windows.Forms.TextBox txtbox_seriNo;
        private System.Windows.Forms.TextBox txtbox_d;
    }
}