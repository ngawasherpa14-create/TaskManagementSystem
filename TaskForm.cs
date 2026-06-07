using System;
using System.Windows.Forms;

namespace TaskManagementSystem
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Check empty fields
                if (textBox1.Text == "" ||
     richTextBox1.Text == "" ||
     comboBox1.Text == "" ||
     comboBox2.Text == "")
                {
                    MessageBox.Show("Please fill all fields including Priority and Category!");
                    return;
                }

                // Create task object (OOP)
                Task task;

                if (comboBox2.Text == "Personal")
                {
                    task = new PersonalTask(
                        textBox1.Text,
                        richTextBox1.Text,
                        comboBox1.Text,
                        dateTimePicker1.Value,
                        checkBox1.Checked
                    );
                }
                else
                {
                    task = new WorkTask(
                        textBox1.Text,
                        richTextBox1.Text,
                        comboBox1.Text,
                        dateTimePicker1.Value,
                        checkBox1.Checked
                    );
                }

                // Add task to table
                dataGridView1.Rows.Add(
                    task.Title,
                    task.Description,
                    task.Priority,
                    task.DueDate.ToShortDateString(),
                    task.Completed ? "Completed" : "Pending",
                    task.GetTaskType()
                );
                

                MessageBox.Show("Task Added Successfully!");

                // Clear fields
                textBox1.Clear();
                richTextBox1.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                checkBox1.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            richTextBox1.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            checkBox1.Checked = false;

            // Clear DataGridView
            dataGridView1.Rows.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Cells[0].Value = textBox1.Text;
                dataGridView1.CurrentRow.Cells[1].Value = richTextBox1.Text;
                dataGridView1.CurrentRow.Cells[2].Value = comboBox1.Text;
                dataGridView1.CurrentRow.Cells[3].Value = dateTimePicker1.Value.ToShortDateString();
                dataGridView1.CurrentRow.Cells[4].Value =
                    checkBox1.Checked ? "Completed" : "Pending";

                MessageBox.Show("Task Updated Successfully!");
            }
            else
            {
                MessageBox.Show("Please select a task to update.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells[0].Value?.ToString();
                richTextBox1.Text = row.Cells[1].Value?.ToString();
                comboBox1.Text = row.Cells[2].Value?.ToString();

                dateTimePicker1.Value =
                    Convert.ToDateTime(row.Cells[3].Value);

                checkBox1.Checked =
                    row.Cells[4].Value?.ToString() == "Completed";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells[0].Value?.ToString();
                richTextBox1.Text = row.Cells[1].Value?.ToString();
                comboBox1.Text = row.Cells[2].Value?.ToString();

                dateTimePicker1.Value =
                    Convert.ToDateTime(row.Cells[3].Value);

                checkBox1.Checked =
                    row.Cells[4].Value?.ToString() == "Completed";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.ToLower();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string taskTitle = row.Cells[0].Value.ToString().ToLower();

                    row.Visible = taskTitle.Contains(searchText);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }
    }
}
