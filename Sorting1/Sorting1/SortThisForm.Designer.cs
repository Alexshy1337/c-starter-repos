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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.File_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.___ = new System.Windows.Forms.ToolStripSeparator();
            this.Exit_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.OptionsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SortingOptions_GroupBox = new System.Windows.Forms.GroupBox();
            this.DemoButton = new System.Windows.Forms.Button();
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
            this.DemoTabs = new System.Windows.Forms.TabControl();
            this.Tab_Chart = new System.Windows.Forms.TabPage();
            this.ChartPanel = new System.Windows.Forms.Panel();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Tab_Demo = new System.Windows.Forms.TabPage();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.InputDGV2 = new System.Windows.Forms.DataGridView();
            this.NumForDGV1 = new System.Windows.Forms.NumericUpDown();
            this.InputDGV1 = new System.Windows.Forms.DataGridView();
            this.OpenFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.NumForDGV2 = new System.Windows.Forms.NumericUpDown();
            this.Menu.SuspendLayout();
            this.MainTableLayout.SuspendLayout();
            this.OptionsTableLayout.SuspendLayout();
            this.SortingOptions_GroupBox.SuspendLayout();
            this.Actions_GroupBox.SuspendLayout();
            this.ComparsionOptions_GroupBox.SuspendLayout();
            this.DemoTabs.SuspendLayout();
            this.Tab_Chart.SuspendLayout();
            this.ChartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.InputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputDGV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumForDGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputDGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumForDGV2)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_MenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // File_MenuItem
            // 
            this.File_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open_MenuItem,
            this.___,
            this.Exit_MenuItem});
            this.File_MenuItem.Name = "File_MenuItem";
            this.File_MenuItem.Size = new System.Drawing.Size(48, 20);
            this.File_MenuItem.Text = "Файл";
            // 
            // Open_MenuItem
            // 
            this.Open_MenuItem.Name = "Open_MenuItem";
            this.Open_MenuItem.Size = new System.Drawing.Size(180, 22);
            this.Open_MenuItem.Text = "Открыть";
            this.Open_MenuItem.Click += new System.EventHandler(this.Open_MenuItem_Click);
            // 
            // ___
            // 
            this.___.Name = "___";
            this.___.Size = new System.Drawing.Size(177, 6);
            // 
            // Exit_MenuItem
            // 
            this.Exit_MenuItem.Name = "Exit_MenuItem";
            this.Exit_MenuItem.Size = new System.Drawing.Size(180, 22);
            this.Exit_MenuItem.Text = "Выход";
            this.Exit_MenuItem.Click += new System.EventHandler(this.Exit_MenuItem_Click);
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 3;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.80236F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.19764F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 465F));
            this.MainTableLayout.Controls.Add(this.OptionsTableLayout, 0, 0);
            this.MainTableLayout.Controls.Add(this.DemoTabs, 2, 0);
            this.MainTableLayout.Controls.Add(this.InputPanel, 1, 0);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 24);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 1;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.Size = new System.Drawing.Size(800, 426);
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
            this.OptionsTableLayout.Location = new System.Drawing.Point(3, 3);
            this.OptionsTableLayout.Name = "OptionsTableLayout";
            this.OptionsTableLayout.RowCount = 3;
            this.OptionsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.62541F));
            this.OptionsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.37459F));
            this.OptionsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.OptionsTableLayout.Size = new System.Drawing.Size(170, 420);
            this.OptionsTableLayout.TabIndex = 1;
            // 
            // SortingOptions_GroupBox
            // 
            this.SortingOptions_GroupBox.Controls.Add(this.DemoButton);
            this.SortingOptions_GroupBox.Controls.Add(this.SortButton);
            this.SortingOptions_GroupBox.Controls.Add(this.FusionRadio);
            this.SortingOptions_GroupBox.Controls.Add(this.BubbleRadio);
            this.SortingOptions_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortingOptions_GroupBox.Location = new System.Drawing.Point(3, 3);
            this.SortingOptions_GroupBox.Name = "SortingOptions_GroupBox";
            this.SortingOptions_GroupBox.Size = new System.Drawing.Size(164, 131);
            this.SortingOptions_GroupBox.TabIndex = 1;
            this.SortingOptions_GroupBox.TabStop = false;
            this.SortingOptions_GroupBox.Text = "Сортировка";
            // 
            // DemoButton
            // 
            this.DemoButton.Location = new System.Drawing.Point(7, 95);
            this.DemoButton.Name = "DemoButton";
            this.DemoButton.Size = new System.Drawing.Size(144, 23);
            this.DemoButton.TabIndex = 4;
            this.DemoButton.Text = "Демонстрация";
            this.DemoButton.UseVisualStyleBackColor = true;
            this.DemoButton.Click += new System.EventHandler(this.DemoButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(6, 65);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(145, 23);
            this.SortButton.TabIndex = 3;
            this.SortButton.Text = "Сортировать";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // FusionRadio
            // 
            this.FusionRadio.AutoSize = true;
            this.FusionRadio.Checked = true;
            this.FusionRadio.Location = new System.Drawing.Point(33, 42);
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
            this.BubbleRadio.Location = new System.Drawing.Point(33, 19);
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
            this.Actions_GroupBox.Location = new System.Drawing.Point(3, 140);
            this.Actions_GroupBox.Name = "Actions_GroupBox";
            this.Actions_GroupBox.Size = new System.Drawing.Size(164, 164);
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
            this.MixButton.Click += new System.EventHandler(this.MixButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(6, 97);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(145, 28);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(6, 64);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(145, 27);
            this.FillButton.TabIndex = 0;
            this.FillButton.Text = "Заполнить";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // ComparsionOptions_GroupBox
            // 
            this.ComparsionOptions_GroupBox.Controls.Add(this.CompareButton);
            this.ComparsionOptions_GroupBox.Controls.Add(this.CompCountRadio);
            this.ComparsionOptions_GroupBox.Controls.Add(this.ExchangeCountRadio);
            this.ComparsionOptions_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComparsionOptions_GroupBox.Location = new System.Drawing.Point(3, 310);
            this.ComparsionOptions_GroupBox.Name = "ComparsionOptions_GroupBox";
            this.ComparsionOptions_GroupBox.Size = new System.Drawing.Size(164, 107);
            this.ComparsionOptions_GroupBox.TabIndex = 2;
            this.ComparsionOptions_GroupBox.TabStop = false;
            this.ComparsionOptions_GroupBox.Text = "Сравнение";
            // 
            // CompareButton
            // 
            this.CompareButton.Location = new System.Drawing.Point(6, 75);
            this.CompareButton.Name = "CompareButton";
            this.CompareButton.Size = new System.Drawing.Size(145, 29);
            this.CompareButton.TabIndex = 2;
            this.CompareButton.Text = "Сравнить";
            this.CompareButton.UseVisualStyleBackColor = true;
            // 
            // CompCountRadio
            // 
            this.CompCountRadio.AutoSize = true;
            this.CompCountRadio.Location = new System.Drawing.Point(10, 52);
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
            this.ExchangeCountRadio.Location = new System.Drawing.Point(10, 29);
            this.ExchangeCountRadio.Name = "ExchangeCountRadio";
            this.ExchangeCountRadio.Size = new System.Drawing.Size(131, 17);
            this.ExchangeCountRadio.TabIndex = 0;
            this.ExchangeCountRadio.TabStop = true;
            this.ExchangeCountRadio.Text = "Количество обменов";
            this.ExchangeCountRadio.UseVisualStyleBackColor = true;
            // 
            // DemoTabs
            // 
            this.DemoTabs.Controls.Add(this.Tab_Chart);
            this.DemoTabs.Controls.Add(this.Tab_Demo);
            this.DemoTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DemoTabs.Location = new System.Drawing.Point(337, 3);
            this.DemoTabs.Name = "DemoTabs";
            this.DemoTabs.SelectedIndex = 0;
            this.DemoTabs.Size = new System.Drawing.Size(460, 420);
            this.DemoTabs.TabIndex = 2;
            // 
            // Tab_Chart
            // 
            this.Tab_Chart.Controls.Add(this.ChartPanel);
            this.Tab_Chart.Location = new System.Drawing.Point(4, 22);
            this.Tab_Chart.Name = "Tab_Chart";
            this.Tab_Chart.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Chart.Size = new System.Drawing.Size(452, 394);
            this.Tab_Chart.TabIndex = 0;
            this.Tab_Chart.Text = "График";
            this.Tab_Chart.UseVisualStyleBackColor = true;
            // 
            // ChartPanel
            // 
            this.ChartPanel.Controls.Add(this.MainChart);
            this.ChartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartPanel.Location = new System.Drawing.Point(3, 3);
            this.ChartPanel.Name = "ChartPanel";
            this.ChartPanel.Size = new System.Drawing.Size(446, 388);
            this.ChartPanel.TabIndex = 0;
            // 
            // MainChart
            // 
            chartArea2.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea2);
            this.MainChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.MainChart.Legends.Add(legend2);
            this.MainChart.Location = new System.Drawing.Point(0, 0);
            this.MainChart.Name = "MainChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.LegendText = "Пузырьковая";
            series3.Name = "BubbleSeries";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.LegendText = "Слияние";
            series4.Name = "FusionSeries";
            this.MainChart.Series.Add(series3);
            this.MainChart.Series.Add(series4);
            this.MainChart.Size = new System.Drawing.Size(446, 388);
            this.MainChart.TabIndex = 0;
            this.MainChart.Text = "chart1";
            // 
            // Tab_Demo
            // 
            this.Tab_Demo.Location = new System.Drawing.Point(4, 22);
            this.Tab_Demo.Name = "Tab_Demo";
            this.Tab_Demo.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Demo.Size = new System.Drawing.Size(452, 394);
            this.Tab_Demo.TabIndex = 1;
            this.Tab_Demo.Text = "Демонстрация";
            this.Tab_Demo.UseVisualStyleBackColor = true;
            // 
            // InputPanel
            // 
            this.InputPanel.Controls.Add(this.NumForDGV2);
            this.InputPanel.Controls.Add(this.InputDGV2);
            this.InputPanel.Controls.Add(this.NumForDGV1);
            this.InputPanel.Controls.Add(this.InputDGV1);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputPanel.Location = new System.Drawing.Point(179, 3);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(152, 420);
            this.InputPanel.TabIndex = 3;
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
            this.NumForDGV1.ValueChanged += new System.EventHandler(this.UpDownForDGV_ValueChanged);
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
            // OpenFileDlg
            // 
            this.OpenFileDlg.FileName = "openFileDialog";
            // 
            // NumForDGV2
            // 
            this.NumForDGV2.Location = new System.Drawing.Point(76, 3);
            this.NumForDGV2.Name = "NumForDGV2";
            this.NumForDGV2.Size = new System.Drawing.Size(70, 20);
            this.NumForDGV2.TabIndex = 3;
            this.NumForDGV2.ValueChanged += new System.EventHandler(this.NumForDGV2_ValueChanged);
            // 
            // SortThisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTableLayout);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "SortThisForm";
            this.Text = "win";
            this.Load += new System.EventHandler(this.SortThisForm_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.MainTableLayout.ResumeLayout(false);
            this.OptionsTableLayout.ResumeLayout(false);
            this.SortingOptions_GroupBox.ResumeLayout(false);
            this.SortingOptions_GroupBox.PerformLayout();
            this.Actions_GroupBox.ResumeLayout(false);
            this.Actions_GroupBox.PerformLayout();
            this.ComparsionOptions_GroupBox.ResumeLayout(false);
            this.ComparsionOptions_GroupBox.PerformLayout();
            this.DemoTabs.ResumeLayout(false);
            this.Tab_Chart.ResumeLayout(false);
            this.ChartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.InputPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InputDGV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumForDGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputDGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumForDGV2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem File_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Open_MenuItem;
        private System.Windows.Forms.ToolStripSeparator ___;
        private System.Windows.Forms.ToolStripMenuItem Exit_MenuItem;
        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.DataGridView InputDGV1;
        private System.Windows.Forms.TableLayoutPanel OptionsTableLayout;
        private System.Windows.Forms.GroupBox SortingOptions_GroupBox;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.RadioButton FusionRadio;
        private System.Windows.Forms.RadioButton BubbleRadio;
        private System.Windows.Forms.GroupBox Actions_GroupBox;
        private System.Windows.Forms.Button MixButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.GroupBox ComparsionOptions_GroupBox;
        private System.Windows.Forms.Button CompareButton;
        private System.Windows.Forms.RadioButton CompCountRadio;
        private System.Windows.Forms.RadioButton ExchangeCountRadio;
        private System.Windows.Forms.TabControl DemoTabs;
        private System.Windows.Forms.TabPage Tab_Chart;
        private System.Windows.Forms.TabPage Tab_Demo;
        private System.Windows.Forms.Panel ChartPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.NumericUpDown NumForDGV1;
        private System.Windows.Forms.CheckBox FromSourceCheck;
        private System.Windows.Forms.OpenFileDialog OpenFileDlg;
        private System.Windows.Forms.Button DemoButton;
        private System.Windows.Forms.DataGridView InputDGV2;
        private System.Windows.Forms.NumericUpDown NumForDGV2;
    }
}

