namespace ToDoForm
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridViewTasks = new DataGridView();
            buttonAddTask = new Button();
            textBoxTaskTitle = new TextBox();
            textBoxTaskDescription = new TextBox();
            dateTimePickerDueDate = new DateTimePicker();
            comboBoxUser = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Location = new Point(250, 20);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.RowHeadersWidth = 51;
            dataGridViewTasks.Size = new Size(520, 410);
            dataGridViewTasks.TabIndex = 0;
            // 
            // buttonAddTask
            // 
            buttonAddTask.BackColor = Color.Orange;
            buttonAddTask.Location = new Point(20, 220);
            buttonAddTask.Name = "buttonAddTask";
            buttonAddTask.Size = new Size(200, 40);
            buttonAddTask.TabIndex = 5;
            buttonAddTask.Text = "Add Task";
            buttonAddTask.UseVisualStyleBackColor = false;
            buttonAddTask.Click += buttonAddTask_Click;

            // buttonDeleteTask
            buttonDeleteTask = new Button();
            buttonDeleteTask.Location = new Point(20, 280);
            buttonDeleteTask.Size = new Size(200, 40);
            buttonDeleteTask.Name = "buttonDeleteTask";
            buttonDeleteTask.TabIndex = 6;
            buttonDeleteTask.Text = "Delete Task";
            buttonDeleteTask.UseVisualStyleBackColor = true;
            buttonDeleteTask.Click += buttonDeleteTask_Click;

            
            Controls.Add(buttonDeleteTask);

            // 
            // textBoxTaskTitle
            // 
            textBoxTaskTitle.Location = new Point(20, 70);
            textBoxTaskTitle.Name = "textBoxTaskTitle";
            textBoxTaskTitle.Size = new Size(200, 27);
            textBoxTaskTitle.TabIndex = 2;
            // 
            // textBoxTaskDescription
            // 
            textBoxTaskDescription.Location = new Point(20, 120);
            textBoxTaskDescription.Name = "textBoxTaskDescription";
            textBoxTaskDescription.Size = new Size(200, 27);
            textBoxTaskDescription.TabIndex = 3;
            // 
            // dateTimePickerDueDate
            // 
            dateTimePickerDueDate.Location = new Point(20, 170);
            dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            dateTimePickerDueDate.Size = new Size(200, 27);
            dateTimePickerDueDate.TabIndex = 4;
            // 
            // comboBoxUser
            // 
            comboBoxUser.BackColor = Color.Orange;
            comboBoxUser.Location = new Point(20, 20);
            comboBoxUser.Name = "comboBoxUser";
            comboBoxUser.Size = new Size(200, 28);
            comboBoxUser.TabIndex = 1;
            comboBoxUser.SelectedIndexChanged += comboBoxUser_SelectedIndexChanged;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxUser);
            Controls.Add(textBoxTaskTitle);
            Controls.Add(textBoxTaskDescription);
            Controls.Add(dateTimePickerDueDate);
            Controls.Add(buttonAddTask);
            Controls.Add(dataGridViewTasks);
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewTasks;
        private Button buttonAddTask;
        private TextBox textBoxTaskTitle;
        private TextBox textBoxTaskDescription;
        private DateTimePicker dateTimePickerDueDate;
        private ComboBox comboBoxUser;
        private Button buttonDeleteTask;
    }
}
