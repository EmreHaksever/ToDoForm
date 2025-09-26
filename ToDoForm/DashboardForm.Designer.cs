namespace ToDoForm
{
    partial class DashboardForm
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
            dataGridViewTasks.Location = new Point(3, 0);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.RowHeadersWidth = 51;
            dataGridViewTasks.Size = new Size(798, 450);
            dataGridViewTasks.TabIndex = 0;
            // 
            // buttonAddTask
            // 
            buttonAddTask.Location = new Point(3, 353);
            buttonAddTask.Name = "buttonAddTask";
            buttonAddTask.Size = new Size(94, 29);
            buttonAddTask.TabIndex = 1;
            buttonAddTask.Text = "Add Task";
            buttonAddTask.UseVisualStyleBackColor = true;
            buttonAddTask.Click += buttonAddTask_Click;
            // 
            // textBoxTaskTitle
            // 
            textBoxTaskTitle.Location = new Point(3, 209);
            textBoxTaskTitle.Name = "textBoxTaskTitle";
            textBoxTaskTitle.Size = new Size(125, 27);
            textBoxTaskTitle.TabIndex = 2;
            // 
            // textBoxTaskDescription
            // 
            textBoxTaskDescription.Location = new Point(3, 255);
            textBoxTaskDescription.Name = "textBoxTaskDescription";
            textBoxTaskDescription.Size = new Size(125, 27);
            textBoxTaskDescription.TabIndex = 3;
            // 
            // dateTimePickerDueDate
            // 
            dateTimePickerDueDate.Location = new Point(3, 305);
            dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            dateTimePickerDueDate.Size = new Size(250, 27);
            dateTimePickerDueDate.TabIndex = 4;
            // 
            // comboBoxUser
            // 
            comboBoxUser.FormattingEnabled = true;
            comboBoxUser.Location = new Point(3, 159);
            comboBoxUser.Name = "comboBoxUser";
            comboBoxUser.Size = new Size(151, 28);
            comboBoxUser.TabIndex = 5;
            comboBoxUser.SelectedIndexChanged += comboBoxUser_SelectedIndexChanged;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxUser);
            Controls.Add(dateTimePickerDueDate);
            Controls.Add(textBoxTaskDescription);
            Controls.Add(textBoxTaskTitle);
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
    }
}