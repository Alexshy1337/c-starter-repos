namespace TreesTwo
{
    partial class MainFormAkatosh
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.CompLabelRight = new System.Windows.Forms.Label();
            this.CompLabelLeft = new System.Windows.Forms.Label();
            this.ClrButton = new System.Windows.Forms.Button();
            this.CompButton = new System.Windows.Forms.Button();
            this.GenButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Tree1 = new System.Windows.Forms.Panel();
            this.Tree2 = new System.Windows.Forms.Panel();
            this.Tree3 = new System.Windows.Forms.Panel();
            this.Tree4 = new System.Windows.Forms.Panel();
            this.AnsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonsPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.413011F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.58699F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.AnsLabel);
            this.ButtonsPanel.Controls.Add(this.CompLabelRight);
            this.ButtonsPanel.Controls.Add(this.CompLabelLeft);
            this.ButtonsPanel.Controls.Add(this.ClrButton);
            this.ButtonsPanel.Controls.Add(this.CompButton);
            this.ButtonsPanel.Controls.Add(this.GenButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsPanel.Location = new System.Drawing.Point(3, 3);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(1178, 43);
            this.ButtonsPanel.TabIndex = 0;
            // 
            // CompLabelRight
            // 
            this.CompLabelRight.AutoSize = true;
            this.CompLabelRight.Location = new System.Drawing.Point(660, 12);
            this.CompLabelRight.Name = "CompLabelRight";
            this.CompLabelRight.Size = new System.Drawing.Size(23, 13);
            this.CompLabelRight.TabIndex = 4;
            this.CompLabelRight.Text = "null";
            // 
            // CompLabelLeft
            // 
            this.CompLabelLeft.AutoSize = true;
            this.CompLabelLeft.Location = new System.Drawing.Point(504, 12);
            this.CompLabelLeft.Name = "CompLabelLeft";
            this.CompLabelLeft.Size = new System.Drawing.Size(23, 13);
            this.CompLabelLeft.TabIndex = 3;
            this.CompLabelLeft.Text = "null";
            // 
            // ClrButton
            // 
            this.ClrButton.Location = new System.Drawing.Point(964, 3);
            this.ClrButton.Name = "ClrButton";
            this.ClrButton.Size = new System.Drawing.Size(108, 31);
            this.ClrButton.TabIndex = 2;
            this.ClrButton.Text = "Clear";
            this.ClrButton.UseVisualStyleBackColor = true;
            this.ClrButton.Click += new System.EventHandler(this.ClrButton_Click);
            // 
            // CompButton
            // 
            this.CompButton.Location = new System.Drawing.Point(559, 3);
            this.CompButton.Name = "CompButton";
            this.CompButton.Size = new System.Drawing.Size(60, 22);
            this.CompButton.TabIndex = 1;
            this.CompButton.Text = "Compare";
            this.CompButton.UseVisualStyleBackColor = true;
            this.CompButton.Click += new System.EventHandler(this.CompButton_Click);
            // 
            // GenButton
            // 
            this.GenButton.Location = new System.Drawing.Point(89, 3);
            this.GenButton.Name = "GenButton";
            this.GenButton.Size = new System.Drawing.Size(108, 31);
            this.GenButton.TabIndex = 0;
            this.GenButton.Text = "Generate";
            this.GenButton.UseVisualStyleBackColor = true;
            this.GenButton.Click += new System.EventHandler(this.GenButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Tree1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Tree2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Tree3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Tree4, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 52);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1178, 606);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Tree1
            // 
            this.Tree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tree1.Location = new System.Drawing.Point(3, 3);
            this.Tree1.Name = "Tree1";
            this.Tree1.Size = new System.Drawing.Size(583, 297);
            this.Tree1.TabIndex = 0;
            this.Tree1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tree1Check);
            // 
            // Tree2
            // 
            this.Tree2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tree2.Location = new System.Drawing.Point(592, 3);
            this.Tree2.Name = "Tree2";
            this.Tree2.Size = new System.Drawing.Size(583, 297);
            this.Tree2.TabIndex = 1;
            this.Tree2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tree2Check);
            // 
            // Tree3
            // 
            this.Tree3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tree3.Location = new System.Drawing.Point(3, 306);
            this.Tree3.Name = "Tree3";
            this.Tree3.Size = new System.Drawing.Size(583, 297);
            this.Tree3.TabIndex = 2;
            this.Tree3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tree3Check);
            // 
            // Tree4
            // 
            this.Tree4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tree4.Location = new System.Drawing.Point(592, 306);
            this.Tree4.Name = "Tree4";
            this.Tree4.Size = new System.Drawing.Size(583, 297);
            this.Tree4.TabIndex = 3;
            this.Tree4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tree4Check);
            // 
            // AnsLabel
            // 
            this.AnsLabel.AutoSize = true;
            this.AnsLabel.Location = new System.Drawing.Point(537, 25);
            this.AnsLabel.Name = "AnsLabel";
            this.AnsLabel.Size = new System.Drawing.Size(0, 13);
            this.AnsLabel.TabIndex = 5;
            // 
            // Akatosh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Akatosh";
            this.Text = "MyForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonsPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button GenButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel Tree1;
        private System.Windows.Forms.Panel Tree2;
        private System.Windows.Forms.Panel Tree3;
        private System.Windows.Forms.Panel Tree4;
        private System.Windows.Forms.Button CompButton;
        private System.Windows.Forms.Label CompLabelRight;
        private System.Windows.Forms.Label CompLabelLeft;
        private System.Windows.Forms.Button ClrButton;
        private System.Windows.Forms.Label AnsLabel;
    }
}

