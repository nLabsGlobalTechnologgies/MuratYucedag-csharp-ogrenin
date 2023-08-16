namespace EmployeeUI
{
    partial class frmGraphics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cCities = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cJobs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.cCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // cCities
            // 
            chartArea5.Name = "ChartArea1";
            this.cCities.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.cCities.Legends.Add(legend5);
            this.cCities.Location = new System.Drawing.Point(12, 12);
            this.cCities.Name = "cCities";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.LimeGreen;
            series5.Legend = "Legend1";
            series5.Name = "Sehirler";
            series5.ShadowColor = System.Drawing.Color.White;
            this.cCities.Series.Add(series5);
            this.cCities.Size = new System.Drawing.Size(382, 300);
            this.cCities.TabIndex = 0;
            this.cCities.Text = "cCities";
            // 
            // cJobs
            // 
            chartArea6.Name = "ChartArea1";
            this.cJobs.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.cJobs.Legends.Add(legend6);
            this.cJobs.Location = new System.Drawing.Point(400, 12);
            this.cJobs.Name = "cJobs";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Meslek-Maas";
            this.cJobs.Series.Add(series6);
            this.cJobs.Size = new System.Drawing.Size(382, 300);
            this.cJobs.TabIndex = 0;
            this.cJobs.Text = "cJobs";
            // 
            // frmGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 331);
            this.Controls.Add(this.cJobs);
            this.Controls.Add(this.cCities);
            this.Name = "frmGraphics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafiksel İstatistikler";
            this.Load += new System.EventHandler(this.frmGraphics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJobs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cCities;
        private System.Windows.Forms.DataVisualization.Charting.Chart cJobs;
    }
}