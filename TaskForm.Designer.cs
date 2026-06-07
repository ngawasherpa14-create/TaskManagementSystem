namespace TaskManagementSystem
{
    partial class TaskForm
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
            textBox1 = new TextBox();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            taskTitle = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            priority = new DataGridViewTextBoxColumn();
            dueDate = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            textBoxSearch = new TextBox();
            button5 = new Button();
            comboBox2 = new ComboBox();
            label5 = new Label();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 33);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Task Title:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(236, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 62);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(236, 62);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(617, 135);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 217);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 4;
            label3.Text = "Priority:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Low", "Medium", "High" });
            comboBox1.Location = new Point(235, 209);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 287);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 6;
            label4.Text = "Due Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(236, 280);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(93, 310);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(105, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Completed";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(93, 340);
            button1.Name = "button1";
            button1.Size = new Size(126, 29);
            button1.TabIndex = 9;
            button1.Text = "Add Task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 375);
            button2.Name = "button2";
            button2.Size = new Size(126, 32);
            button2.TabIndex = 10;
            button2.Text = "Update Task";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(93, 413);
            button3.Name = "button3";
            button3.Size = new Size(126, 29);
            button3.TabIndex = 11;
            button3.Text = "Delete Task";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(93, 448);
            button4.Name = "button4";
            button4.Size = new Size(126, 29);
            button4.TabIndex = 12;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { taskTitle, description, priority, dueDate, status, Category });
            dataGridView1.Location = new Point(225, 400);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(805, 102);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // taskTitle
            // 
            taskTitle.HeaderText = "Task Title";
            taskTitle.MinimumWidth = 6;
            taskTitle.Name = "taskTitle";
            taskTitle.Width = 125;
            // 
            // description
            // 
            description.HeaderText = "Description";
            description.MinimumWidth = 6;
            description.Name = "description";
            description.Width = 125;
            // 
            // priority
            // 
            priority.HeaderText = "Priority";
            priority.MinimumWidth = 6;
            priority.Name = "priority";
            priority.Width = 125;
            // 
            // dueDate
            // 
            dueDate.HeaderText = "Due Date";
            dueDate.MinimumWidth = 6;
            dueDate.Name = "dueDate";
            dueDate.Width = 125;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.Width = 125;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.Width = 125;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(225, 367);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(278, 27);
            textBoxSearch.TabIndex = 14;
            textBoxSearch.Text = "textBoxSearch";
            // 
            // button5
            // 
            button5.Location = new Point(536, 365);
            button5.Name = "button5";
            button5.Size = new Size(334, 29);
            button5.TabIndex = 15;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Personal", "Work", "Study" });
            comboBox2.Location = new Point(93, 247);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(126, 28);
            comboBox2.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(235, 247);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 17;
            label5.Text = "Category:";
            label5.Click += label5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(94, 487);
            button6.Name = "button6";
            button6.Size = new Size(125, 29);
            button6.TabIndex = 18;
            button6.Text = "About";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 553);
            Controls.Add(button6);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(button5);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "TaskForm";
            Text = "Task Management System";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private TextBox textBoxSearch;
        private Button button5;
        private ComboBox comboBox2;
        private Label label5;
        private DataGridViewTextBoxColumn taskTitle;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn priority;
        private DataGridViewTextBoxColumn dueDate;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn Category;
        private Button button6;
    }
}
