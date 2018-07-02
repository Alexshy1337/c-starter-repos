using System.Windows.Forms;

namespace Graph1
{
    partial class GForm
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.MoveModeRadio = new System.Windows.Forms.RadioButton();
            this.DelEdgeRadio = new System.Windows.Forms.RadioButton();
            this.DelVertRadio = new System.Windows.Forms.RadioButton();
            this.AddEdgeRadio = new System.Windows.Forms.RadioButton();
            this.AddVertRadio = new System.Windows.Forms.RadioButton();
            this.SolutionButton = new System.Windows.Forms.Button();
            this.DPanel = new System.Windows.Forms.Panel();
            this.OpenFD = new System.Windows.Forms.OpenFileDialog();
            this.SaveFD = new System.Windows.Forms.SaveFileDialog();
            this.MenuStrip.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.ControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel.Controls.Add(this.ControlsPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.DPanel, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 426);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.Controls.Add(this.ClearButton);
            this.ControlsPanel.Controls.Add(this.InfoLabel);
            this.ControlsPanel.Controls.Add(this.MoveModeRadio);
            this.ControlsPanel.Controls.Add(this.DelEdgeRadio);
            this.ControlsPanel.Controls.Add(this.DelVertRadio);
            this.ControlsPanel.Controls.Add(this.AddEdgeRadio);
            this.ControlsPanel.Controls.Add(this.AddVertRadio);
            this.ControlsPanel.Controls.Add(this.SolutionButton);
            this.ControlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsPanel.Location = new System.Drawing.Point(3, 3);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(106, 420);
            this.ControlsPanel.TabIndex = 0;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(16, 362);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(73, 24);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(3, 322);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 13);
            this.InfoLabel.TabIndex = 6;
            // 
            // MoveModeRadio
            // 
            this.MoveModeRadio.AutoSize = true;
            this.MoveModeRadio.Location = new System.Drawing.Point(10, 129);
            this.MoveModeRadio.Name = "MoveModeRadio";
            this.MoveModeRadio.Size = new System.Drawing.Size(79, 17);
            this.MoveModeRadio.TabIndex = 5;
            this.MoveModeRadio.TabStop = true;
            this.MoveModeRadio.Text = "MoveMode";
            this.MoveModeRadio.UseVisualStyleBackColor = true;
            // 
            // DelEdgeRadio
            // 
            this.DelEdgeRadio.AutoSize = true;
            this.DelEdgeRadio.Location = new System.Drawing.Point(10, 106);
            this.DelEdgeRadio.Name = "DelEdgeRadio";
            this.DelEdgeRadio.Size = new System.Drawing.Size(66, 17);
            this.DelEdgeRadio.TabIndex = 4;
            this.DelEdgeRadio.TabStop = true;
            this.DelEdgeRadio.Text = "DelEdge";
            this.DelEdgeRadio.UseVisualStyleBackColor = true;
            // 
            // DelVertRadio
            // 
            this.DelVertRadio.AutoSize = true;
            this.DelVertRadio.Location = new System.Drawing.Point(10, 83);
            this.DelVertRadio.Name = "DelVertRadio";
            this.DelVertRadio.Size = new System.Drawing.Size(60, 17);
            this.DelVertRadio.TabIndex = 3;
            this.DelVertRadio.TabStop = true;
            this.DelVertRadio.Text = "DelVert";
            this.DelVertRadio.UseVisualStyleBackColor = true;
            // 
            // AddEdgeRadio
            // 
            this.AddEdgeRadio.AutoSize = true;
            this.AddEdgeRadio.Location = new System.Drawing.Point(10, 60);
            this.AddEdgeRadio.Name = "AddEdgeRadio";
            this.AddEdgeRadio.Size = new System.Drawing.Size(69, 17);
            this.AddEdgeRadio.TabIndex = 2;
            this.AddEdgeRadio.TabStop = true;
            this.AddEdgeRadio.Text = "AddEdge";
            this.AddEdgeRadio.UseVisualStyleBackColor = true;
            // 
            // AddVertRadio
            // 
            this.AddVertRadio.AutoSize = true;
            this.AddVertRadio.Checked = true;
            this.AddVertRadio.Location = new System.Drawing.Point(10, 37);
            this.AddVertRadio.Name = "AddVertRadio";
            this.AddVertRadio.Size = new System.Drawing.Size(63, 17);
            this.AddVertRadio.TabIndex = 1;
            this.AddVertRadio.TabStop = true;
            this.AddVertRadio.Text = "AddVert";
            this.AddVertRadio.UseVisualStyleBackColor = true;
            // 
            // SolutionButton
            // 
            this.SolutionButton.Location = new System.Drawing.Point(3, 194);
            this.SolutionButton.Name = "SolutionButton";
            this.SolutionButton.Size = new System.Drawing.Size(100, 38);
            this.SolutionButton.TabIndex = 0;
            this.SolutionButton.Text = "Paint the Graph";
            this.SolutionButton.UseVisualStyleBackColor = true;
            this.SolutionButton.Click += new System.EventHandler(this.SolutionButton_Click);
            // 
            // DPanel
            // 
            this.DPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DPanel.Location = new System.Drawing.Point(115, 3);
            this.DPanel.Name = "DPanel";
            this.DPanel.Size = new System.Drawing.Size(682, 420);
            this.DPanel.TabIndex = 1;
            this.DPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MagicClick);
            // 
            // OpenFD
            // 
            this.OpenFD.FileName = "openFileDialog1";
            // 
            // GForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "GForm";
            this.Text = "just regular window";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.ControlsPanel.ResumeLayout(false);
            this.ControlsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel ControlsPanel;
        private System.Windows.Forms.RadioButton MoveModeRadio;
        private System.Windows.Forms.RadioButton DelEdgeRadio;
        private System.Windows.Forms.RadioButton DelVertRadio;
        private System.Windows.Forms.RadioButton AddEdgeRadio;
        private System.Windows.Forms.RadioButton AddVertRadio;
        private System.Windows.Forms.Button SolutionButton;
        private System.Windows.Forms.Panel DPanel;
        private System.Windows.Forms.OpenFileDialog OpenFD;
        private System.Windows.Forms.SaveFileDialog SaveFD;
        private Label InfoLabel;
        private Button ClearButton;
    }
}

