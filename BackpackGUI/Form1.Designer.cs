namespace BackpackGUI
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
            ItemsBox = new TextBox();
            SeedBox = new TextBox();
            label2 = new Label();
            CapacityBox = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            ResultsBox = new TextBox();
            InstanceBox = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 17);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Number of items:";
            label1.Click += label1_Click;
            // 
            // ItemsBox
            // 
            ItemsBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ItemsBox.Location = new Point(37, 43);
            ItemsBox.Name = "ItemsBox";
            ItemsBox.Size = new Size(100, 23);
            ItemsBox.TabIndex = 1;
            // 
            // SeedBox
            // 
            SeedBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            SeedBox.Location = new Point(37, 109);
            SeedBox.Name = "SeedBox";
            SeedBox.Size = new Size(100, 23);
            SeedBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 83);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "Seed:";
            label2.Click += label2_Click;
            // 
            // CapacityBox
            // 
            CapacityBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            CapacityBox.Location = new Point(38, 176);
            CapacityBox.Name = "CapacityBox";
            CapacityBox.Size = new Size(100, 23);
            CapacityBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 150);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Capacity:";
            // 
            // button1
            // 
            button1.Location = new Point(202, 108);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 227);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 7;
            label4.Text = "Results:";
            label4.Click += label4_Click;
            // 
            // ResultsBox
            // 
            ResultsBox.Location = new Point(37, 258);
            ResultsBox.Multiline = true;
            ResultsBox.Name = "ResultsBox";
            ResultsBox.ReadOnly = true;
            ResultsBox.Size = new Size(240, 180);
            ResultsBox.TabIndex = 8;
            // 
            // InstanceBox
            // 
            InstanceBox.Location = new Point(311, 43);
            InstanceBox.Multiline = true;
            InstanceBox.Name = "InstanceBox";
            InstanceBox.ReadOnly = true;
            InstanceBox.ScrollBars = ScrollBars.Vertical;
            InstanceBox.Size = new Size(477, 395);
            InstanceBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(311, 17);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 10;
            label5.Text = "Instance:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(InstanceBox);
            Controls.Add(ResultsBox);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(CapacityBox);
            Controls.Add(label3);
            Controls.Add(SeedBox);
            Controls.Add(label2);
            Controls.Add(ItemsBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ItemsBox;
        private TextBox SeedBox;
        private Label label2;
        private TextBox CapacityBox;
        private Label label3;
        private Button button1;
        private Label label4;
        private TextBox ResultsBox;
        private TextBox InstanceBox;
        private Label label5;
    }
}
