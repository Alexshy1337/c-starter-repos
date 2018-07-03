namespace Sorting1
{
    partial class SortThisForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.OptionsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SortingOptions_GroupBox = new System.Windows.Forms.GroupBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.FusionRadio = new System.Windows.Forms.RadioButton();
            this.BubbleRadio = new System.Windows.Forms.RadioButton();
            this.Actions_GroupBox = new System.Windows.Forms.GroupBox();
            this.FromSourceCheck = new System.Windows.Forms.CheckBox();
            this.MixButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.FillButton = new System.Windows.Forms.Button();
            this.ComparsionOptions_GroupBox = new System.Windows.Forms.GroupBox();
            this.CompareButton = new System.Windows.Forms.Button();
            this.CompCountRadio = new System.Windows.Forms.RadioButton();
            this.ExchangeCountRadio = new System.Windows.Forms.RadioButton();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.NumForDGV2 = new System.Windows.Forms.NumericUpDown();
            this.InputDGV2 = new System.Windows.Forms.DataGridView();
            this.NumForDGV1 = new System.Windows.Forms.NumericUpDown();
            this.InputDGV1 = new System.Windows.Forms.DataGridView();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OpenFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainTableLayout.SuspendLayout();
            this.OptionsTableLayout.SuspendLayout();
            this.SortingOptions_GroupBox.SuspendLayout();
            this.Actions_GroupBox.SuspendLayout();
            this.ComparsionOptions_GroupBox.SuspendLayout();
            this.InputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumForDGV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputDGV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumForDGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputDGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 3;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.11886F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.88114F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.MainTableLayout.Controls.Add(this.OptionsTableLayout, 0, 0);
            this.MainTableLayout.Controls.Add(this.InputPanel, 0, 0);
            this.MainTableLayout.Controls.Add(this.MainChart, 0, 0);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 1;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.Size = new System.Drawing.Size(800, 450);
            this.MainTableLayout.TabIndex = 1;
            // 
            // OptionsTableLayout
            // 
            this.OptionsTableLayout.ColumnCount = 1;
            this.OptionsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionsTableLayout.Controls.Add(this.SortingOptions_GroupBox, 0, 0);
            this.OptionsTableLayout.Controls.Add(this.Actions_GroupBox, 0, 1);
            this.OptionsTableLayout.Controls.Add(this.ComparsionOptions_GroupBox, 0, 2);
            this.OptionsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsTableLayout.Location = new System.Drawing.Point(634, 3);
            this.OptionsTableLayout.Name = "OptionsTableLayout";
            this.OptionsTableLayout.RowCount = 3;
            this.OptionsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.62541F));
            this.OptionsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.37459F));
            this.OptionsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.OptionsTableLayout.Size = new System.Drawing.Size(163, 444);
            this.OptionsTableLayout.TabIndex = 7;
            // 
            // SortingOptions_GroupBox
            // 
            this.SortingOptions_GroupBox.Controls.Add(this.SortButton);
            this.SortingOptions_GroupBox.Controls.Add(this.FusionRadio);
            this.SortingOptions_GroupBox.Controls.Add(this.BubbleRadio);
            this.SortingOptions_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortingOptions_GroupBox.Location = new System.Drawing.Point(3, 3);
            this.SortingOptions_GroupBox.Name = "SortingOptions_GroupBox";
            this.SortingOptions_GroupBox.Size = new System.Drawing.Size(157, 130);
            this.SortingOptions_GroupBox.TabIndex = 1;
            this.SortingOptions_GroupBox.TabStop = false;
            this.SortingOptions_GroupBox.Text = "Сортировка";
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(6, 79);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(145, 23);
            this.SortButton.TabIndex = 3;
            this.SortButton.Text = "Сортировать";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click_1);
            // 
            // FusionRadio
            // 
            this.FusionRadio.AutoSize = true;
            this.FusionRadio.Checked = true;
            this.FusionRadio.Location = new System.Drawing.Point(33, 49);
            this.FusionRadio.Name = "FusionRadio";
            this.FusionRadio.Size = new System.Drawing.Size(76, 17);
            this.FusionRadio.TabIndex = 2;
            this.FusionRadio.TabStop = true;
            this.FusionRadio.Text = "Слиянием";
            this.FusionRadio.UseVisualStyleBackColor = true;
            // 
            // BubbleRadio
            // 
            this.BubbleRadio.AutoSize = true;
            this.BubbleRadio.Location = new System.Drawing.Point(33, 26);
            this.BubbleRadio.Name = "BubbleRadio";
            this.BubbleRadio.Size = new System.Drawing.Size(94, 17);
            this.BubbleRadio.TabIndex = 1;
            this.BubbleRadio.Text = "Пузырьковая";
            this.BubbleRadio.UseVisualStyleBackColor = true;
            // 
            // Actions_GroupBox
            // 
            this.Actions_GroupBox.Controls.Add(this.FromSourceCheck);
            this.Actions_GroupBox.Controls.Add(this.MixButton);
            this.Actions_GroupBox.Controls.Add(this.ClearButton);
            this.Actions_GroupBox.Controls.Add(this.FillButton);
            this.Actions_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Actions_GroupBox.Location = new System.Drawing.Point(3, 139);
            this.Actions_GroupBox.Name = "Actions_GroupBox";
            this.Actions_GroupBox.Size = new System.Drawing.Size(157, 162);
            this.Actions_GroupBox.TabIndex = 0;
            this.Actions_GroupBox.TabStop = false;
            this.Actions_GroupBox.Text = "Операции";
            // 
            // FromSourceCheck
            // 
            this.FromSourceCheck.AutoSize = true;
            this.FromSourceCheck.Location = new System.Drawing.Point(33, 25);
            this.FromSourceCheck.Name = "FromSourceCheck";
            this.FromSourceCheck.Size = new System.Drawing.Size(86, 17);
            this.FromSourceCheck.TabIndex = 3;
            this.FromSourceCheck.Text = "Из таблицы";
            this.FromSourceCheck.UseVisualStyleBackColor = true;
            // 
            // MixButton
            // 
            this.MixButton.Location = new System.Drawing.Point(6, 131);
            this.MixButton.Name = "MixButton";
            this.MixButton.Size = new System.Drawing.Size(145, 27);
            this.MixButton.TabIndex = 2;
            this.MixButton.Text = "Перемешать";
            this.MixButton.UseVisualStyleBackColor = true;
            this.MixButton.Click += new System.EventHandler(this.MixButton_Click_1);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(6, 97);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(145, 28);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click_1);
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(6, 64);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(145, 27);
            this.FillButton.TabIndex = 0;
            this.FillButton.Text = "Заполнить";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click_1);
            // 
            // ComparsionOptions_GroupBox
            // 
            this.ComparsionOptions_GroupBox.Controls.Add(this.label1);
            this.ComparsionOptions_GroupBox.Controls.Add(this.SizeTextBox);
            this.ComparsionOptions_GroupBox.Controls.Add(this.CompareButton);
            this.ComparsionOptions_GroupBox.Controls.Add(this.CompCountRadio);
            this.ComparsionOptions_GroupBox.Controls.Add(this.ExchangeCountRadio);
            this.ComparsionOptions_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComparsionOptions_GroupBox.Location = new System.Drawing.Point(3, 307);
            this.ComparsionOptions_GroupBox.Name = "ComparsionOptions_GroupBox";
            this.ComparsionOptions_GroupBox.Size = new System.Drawing.Size(157, 134);
            this.ComparsionOptions_GroupBox.TabIndex = 2;
            this.ComparsionOptions_GroupBox.TabStop = false;
            this.ComparsionOptions_GroupBox.Text = "Сравнение";
            // 
            // CompareButton
            // 
            this.CompareButton.Location = new System.Drawing.Point(6, 73);
            this.CompareButton.Name = "CompareButton";
            this.CompareButton.Size = new System.Drawing.Size(145, 29);
            this.CompareButton.TabIndex = 2;
            this.CompareButton.Text = "Сравнить";
            this.CompareButton.UseVisualStyleBackColor = true;
            this.CompareButton.Click += new System.EventHandler(this.CompareButton_Click);
            // 
            // CompCountRadio
            // 
            this.CompCountRadio.AutoSize = true;
            this.CompCountRadio.Location = new System.Drawing.Point(6, 41);
            this.CompCountRadio.Name = "CompCountRadio";
            this.CompCountRadio.Size = new System.Drawing.Size(141, 17);
            this.CompCountRadio.TabIndex = 1;
            this.CompCountRadio.Text = "Количество сравнений";
            this.CompCountRadio.UseVisualStyleBackColor = true;
            // 
            // ExchangeCountRadio
            // 
            this.ExchangeCountRadio.AutoSize = true;
            this.ExchangeCountRadio.Checked = true;
            this.ExchangeCountRadio.Location = new System.Drawing.Point(6, 18);
            this.ExchangeCountRadio.Name = "ExchangeCountRadio";
            this.ExchangeCountRadio.Size = new System.Drawing.Size(131, 17);
            this.ExchangeCountRadio.TabIndex = 0;
            this.ExchangeCountRadio.TabStop = true;
            this.ExchangeCountRadio.Text = "Количество обменов";
            this.ExchangeCountRadio.UseVisualStyleBackColor = true;
            // 
            // InputPanel
            // 
            this.InputPanel.Controls.Add(this.NumForDGV2);
            this.InputPanel.Controls.Add(this.InputDGV2);
            this.InputPanel.Controls.Add(this.NumForDGV1);
            this.InputPanel.Controls.Add(this.InputDGV1);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputPanel.Location = new System.Drawing.Point(477, 3);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(151, 444);
            this.InputPanel.TabIndex = 6;
            // 
            // NumForDGV2
            // 
            this.NumForDGV2.Location = new System.Drawing.Point(76, 3);
            this.NumForDGV2.Name = "NumForDGV2";
            this.NumForDGV2.Size = new System.Drawing.Size(70, 20);
            this.NumForDGV2.TabIndex = 3;
            this.NumForDGV2.ValueChanged += new System.EventHandler(this.NumForDGV2_ValueChanged);
            // 
            // InputDGV2
            // 
            this.InputDGV2.AllowUserToAddRows = false;
            this.InputDGV2.AllowUserToDeleteRows = false;
            this.InputDGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputDGV2.Location = new System.Drawing.Point(76, 29);
            this.InputDGV2.Name = "InputDGV2";
            this.InputDGV2.Size = new System.Drawing.Size(70, 387);
            this.InputDGV2.TabIndex = 2;
            // 
            // NumForDGV1
            // 
            this.NumForDGV1.Location = new System.Drawing.Point(3, 3);
            this.NumForDGV1.Name = "NumForDGV1";
            this.NumForDGV1.Size = new System.Drawing.Size(70, 20);
            this.NumForDGV1.TabIndex = 1;
            this.NumForDGV1.ValueChanged += new System.EventHandler(this.NumForDGV1_ValueChanged);
            // 
            // InputDGV1
            // 
            this.InputDGV1.AllowUserToAddRows = false;
            this.InputDGV1.AllowUserToDeleteRows = false;
            this.InputDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputDGV1.Location = new System.Drawing.Point(3, 29);
            this.InputDGV1.Name = "InputDGV1";
            this.InputDGV1.Size = new System.Drawing.Size(70, 387);
            this.InputDGV1.TabIndex = 0;
            // 
            // MainChart
            // 
            chartArea2.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea2);
            this.MainChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.MainChart.Legends.Add(legend2);
            this.MainChart.Location = new System.Drawing.Point(3, 3);
            this.MainChart.Name = "MainChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.LegendText = "Пузырьковая";
            series3.Name = "BubbleSeries";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.LegendText = "Слияние";
            series4.Name = "FusionSeries";
            this.MainChart.Series.Add(series3);
            this.MainChart.Series.Add(series4);
            this.MainChart.Size = new System.Drawing.Size(468, 444);
            this.MainChart.TabIndex = 5;
            this.MainChart.Text = "chart1";
            // 
            // OpenFileDlg
            // 
            this.OpenFileDlg.FileName = "openFileDialog";
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Location = new System.Drawing.Point(72, 108);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(75, 20);
            this.SizeTextBox.TabIndex = 3;
            this.SizeTextBox.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Max size:";
            // 
            // SortThisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTableLayout);
            this.Name = "SortThisForm";
            this.Text = "win";
            this.Load += new System.EventHandler(this.SortThisForm_Load);
            this.MainTableLayout.ResumeLayout(false);
            this.OptionsTableLayout.ResumeLayout(false);
            this.SortingOptions_GroupBox.ResumeLayout(false);
            this.SortingOptions_GroupBox.PerformLayout();
            this.Actions_GroupBox.ResumeLayout(false);
            this.Actions_GroupBox.PerformLayout();
            this.ComparsionOptions_GroupBox.ResumeLayout(false);
            this.ComparsionOptions_GroupBox.PerformLayout();
            this.InputPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumForDGV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputDGV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumForDGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputDGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.OpenFileDialog OpenFileDlg;
        private System.Windows.Forms.TableLayoutPanel OptionsTableLayout;
        private System.Windows.Forms.GroupBox SortingOptions_GroupBox;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.RadioButton FusionRadio;
        private System.Windows.Forms.RadioButton BubbleRadio;
        private System.Windows.Forms.GroupBox Actions_GroupBox;
        private System.Windows.Forms.CheckBox FromSourceCheck;
        private System.Windows.Forms.Button MixButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.GroupBox ComparsionOptions_GroupBox;
        private System.Windows.Forms.Button CompareButton;
        private System.Windows.Forms.RadioButton CompCountRadio;
        private System.Windows.Forms.RadioButton ExchangeCountRadio;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.NumericUpDown NumForDGV2;
        private System.Windows.Forms.DataGridView InputDGV2;
        private System.Windows.Forms.NumericUpDown NumForDGV1;
        private System.Windows.Forms.DataGridView InputDGV1;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SizeTextBox;
    }
}

