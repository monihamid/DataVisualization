namespace MS_Chart
{
    partial class MSChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.buttLoadDB = new System.Windows.Forms.Button();
            this.buttExit = new System.Windows.Forms.Button();
            this.comboBoxPClass = new System.Windows.Forms.ComboBox();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.CoulmChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttProductClass = new System.Windows.Forms.Button();
            this.buttProduct = new System.Windows.Forms.Button();
            this.buttCity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CoulmChart)).BeginInit();
            this.SuspendLayout();
            // 
            // buttLoadDB
            // 
            this.buttLoadDB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttLoadDB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buttLoadDB.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttLoadDB.Location = new System.Drawing.Point(746, 406);
            this.buttLoadDB.Name = "buttLoadDB";
            this.buttLoadDB.Size = new System.Drawing.Size(89, 33);
            this.buttLoadDB.TabIndex = 1;
            this.buttLoadDB.Text = "DBLoad";
            this.buttLoadDB.UseVisualStyleBackColor = false;
            this.buttLoadDB.Click += new System.EventHandler(this.buttLoadDB_Click);
            // 
            // buttExit
            // 
            this.buttExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttExit.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttExit.Location = new System.Drawing.Point(768, 476);
            this.buttExit.Name = "buttExit";
            this.buttExit.Size = new System.Drawing.Size(89, 32);
            this.buttExit.TabIndex = 2;
            this.buttExit.Text = "EXIT";
            this.buttExit.UseVisualStyleBackColor = false;
            this.buttExit.Click += new System.EventHandler(this.buttExit_Click);
            // 
            // comboBoxPClass
            // 
            this.comboBoxPClass.FormattingEnabled = true;
            this.comboBoxPClass.Items.AddRange(new object[] {
            "ALL"});
            this.comboBoxPClass.Location = new System.Drawing.Point(714, 46);
            this.comboBoxPClass.Name = "comboBoxPClass";
            this.comboBoxPClass.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPClass.TabIndex = 5;
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(714, 156);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProduct.TabIndex = 6;
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Items.AddRange(new object[] {
            "All",
            "Everett",
            "Marysville",
            "Edmonds",
            "Tacoma",
            "Olympia",
            "Puyallup",
            "Spokane",
            "Walla Walla",
            "Yakima",
            "Richmond",
            "Westminster",
            "Burnaby",
            "Haney",
            "Langley",
            "Newton",
            "Ladner",
            "N. Vancouver",
            "Port Hammond",
            "Oak Bay",
            "Royal Oak",
            "Sooke",
            "Langford",
            "Cliffside",
            "Metchosin",
            "Shawnee",
            "San Andres",
            "Tixapan",
            "Santa Anita",
            "Santa Fe"});
            this.comboBoxCity.Location = new System.Drawing.Point(714, 273);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCity.TabIndex = 8;
            // 
            // CoulmChart
            // 
            chartArea7.AxisX.Interval = 1D;
            chartArea7.AxisX.Title = "Month";
            chartArea7.AxisX.TitleFont = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea7.AxisY.Title = "Total Sales";
            chartArea7.AxisY.TitleFont = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea7.Name = "ChartArea1";
            chartArea7.ShadowColor = System.Drawing.Color.Blue;
            this.CoulmChart.ChartAreas.Add(chartArea7);
            this.CoulmChart.Location = new System.Drawing.Point(12, 3);
            this.CoulmChart.Name = "CoulmChart";
            series7.ChartArea = "ChartArea1";
            series7.Name = "Series1";
            this.CoulmChart.Series.Add(series7);
            this.CoulmChart.Size = new System.Drawing.Size(660, 465);
            this.CoulmChart.TabIndex = 10;
            this.CoulmChart.Text = "chart1";
            title7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title7.Name = "Title1";
            title7.Text = "Foodmart Monthly Sales 1998";
            this.CoulmChart.Titles.Add(title7);
            // 
            // buttProductClass
            // 
            this.buttProductClass.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttProductClass.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttProductClass.Location = new System.Drawing.Point(699, 97);
            this.buttProductClass.Name = "buttProductClass";
            this.buttProductClass.Size = new System.Drawing.Size(173, 29);
            this.buttProductClass.TabIndex = 11;
            this.buttProductClass.Text = "Select Product Class";
            this.buttProductClass.UseVisualStyleBackColor = false;
            this.buttProductClass.Click += new System.EventHandler(this.buttProductClass_Click);
            // 
            // buttProduct
            // 
            this.buttProduct.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttProduct.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttProduct.Location = new System.Drawing.Point(699, 207);
            this.buttProduct.Name = "buttProduct";
            this.buttProduct.Size = new System.Drawing.Size(173, 35);
            this.buttProduct.TabIndex = 12;
            this.buttProduct.Text = "Select Product";
            this.buttProduct.UseVisualStyleBackColor = false;
            this.buttProduct.Click += new System.EventHandler(this.buttProduct_Click);
            // 
            // buttCity
            // 
            this.buttCity.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttCity.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttCity.Location = new System.Drawing.Point(699, 329);
            this.buttCity.Name = "buttCity";
            this.buttCity.Size = new System.Drawing.Size(173, 35);
            this.buttCity.TabIndex = 13;
            this.buttCity.Text = "Select City";
            this.buttCity.UseVisualStyleBackColor = false;
            this.buttCity.Click += new System.EventHandler(this.buttCity_Click);
            // 
            // MSChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttCity);
            this.Controls.Add(this.buttProduct);
            this.Controls.Add(this.buttProductClass);
            this.Controls.Add(this.CoulmChart);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.comboBoxPClass);
            this.Controls.Add(this.buttExit);
            this.Controls.Add(this.buttLoadDB);
            this.Name = "MSChart";
            this.Text = "MS Chart ";
            this.Load += new System.EventHandler(this.MSChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CoulmChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttLoadDB;
        private System.Windows.Forms.Button buttExit;
        private System.Windows.Forms.ComboBox comboBoxPClass;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.DataVisualization.Charting.Chart CoulmChart;
        private System.Windows.Forms.Button buttProductClass;
        private System.Windows.Forms.Button buttProduct;
        private System.Windows.Forms.Button buttCity;
    }
}

