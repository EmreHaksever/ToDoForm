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
            this.dataGridViewTasks = new DataGridView();
            this.buttonAddTask = new Button();
            this.buttonDeleteTask = new Button();
            this.textBoxTaskTitle = new TextBox();
            this.textBoxTaskDescription = new TextBox();
            this.dateTimePickerDueDate = new DateTimePicker();
            this.comboBoxUser = new ComboBox();
            this.labelTitle = new Label();
            this.SuspendLayout();

            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = Color.CornflowerBlue;
            this.labelTitle.Location = new Point(20, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new Size(180, 41);
            this.labelTitle.Text = "Tasking";

            // 
            // comboBoxUser
            // 
            this.comboBoxUser.BackColor = Color.WhiteSmoke;
            this.comboBoxUser.ForeColor = Color.Black;
            this.comboBoxUser.Location = new Point(20, 70);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new Size(200, 28);
            this.comboBoxUser.TabIndex = 0;
            this.comboBoxUser.SelectedIndexChanged += comboBoxUser_SelectedIndexChanged;

            // 
            // textBoxTaskTitle
            // 
            this.textBoxTaskTitle.BackColor = Color.WhiteSmoke;
            this.textBoxTaskTitle.ForeColor = Color.Black;
            this.textBoxTaskTitle.Location = new Point(20, 120);
            this.textBoxTaskTitle.Name = "textBoxTaskTitle";
            this.textBoxTaskTitle.PlaceholderText = "Task Title";
            this.textBoxTaskTitle.Size = new Size(200, 27);
            this.textBoxTaskTitle.TabIndex = 1;

            // 
            // textBoxTaskDescription
            // 
            this.textBoxTaskDescription.BackColor = Color.WhiteSmoke;
            this.textBoxTaskDescription.ForeColor = Color.Black;
            this.textBoxTaskDescription.Location = new Point(20, 170);
            this.textBoxTaskDescription.Name = "textBoxTaskDescription";
            this.textBoxTaskDescription.PlaceholderText = "Task Description";
            this.textBoxTaskDescription.Size = new Size(200, 27);
            this.textBoxTaskDescription.TabIndex = 2;

            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.Location = new Point(20, 220);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new Size(200, 27);
            this.dateTimePickerDueDate.TabIndex = 3;

            // 
            // buttonAddTask
            // 
            this.buttonAddTask.BackColor = Color.CornflowerBlue;
            this.buttonAddTask.ForeColor = Color.White;
            this.buttonAddTask.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddTask.Location = new Point(20, 270);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new Size(200, 40);
            this.buttonAddTask.TabIndex = 4;
            this.buttonAddTask.Text = "Add Task";
            this.buttonAddTask.UseVisualStyleBackColor = false;
            this.buttonAddTask.Click += buttonAddTask_Click;

            // 
            // buttonDeleteTask
            // 
            this.buttonDeleteTask.BackColor = Color.CornflowerBlue;
            this.buttonDeleteTask.ForeColor = Color.White;
            this.buttonDeleteTask.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteTask.Location = new Point(20, 320);
            this.buttonDeleteTask.Name = "buttonDeleteTask";
            this.buttonDeleteTask.Size = new Size(200, 40);
            this.buttonDeleteTask.TabIndex = 5;
            this.buttonDeleteTask.Text = "Delete Task";
            this.buttonDeleteTask.UseVisualStyleBackColor = false;
            this.buttonDeleteTask.Click += buttonDeleteTask_Click;

            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.BackgroundColor = Color.WhiteSmoke;
            this.dataGridViewTasks.EnableHeadersVisualStyles = false;
            this.dataGridViewTasks.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
            this.dataGridViewTasks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dataGridViewTasks.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.dataGridViewTasks.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTasks.RowHeadersVisible = false;
            this.dataGridViewTasks.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridViewTasks.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            this.dataGridViewTasks.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            this.dataGridViewTasks.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridViewTasks.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            this.dataGridViewTasks.RowTemplate.Height = 30;
            this.dataGridViewTasks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewTasks.GridColor = Color.LightGray;
            this.dataGridViewTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTasks.MultiSelect = false;
            this.dataGridViewTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dataGridViewTasks.Location = new Point(250, 70);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.RowHeadersWidth = 51;
            this.dataGridViewTasks.Size = new Size(520, 410);
            this.dataGridViewTasks.TabIndex = 6;

            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 500);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.textBoxTaskTitle);
            this.Controls.Add(this.textBoxTaskDescription);
            this.Controls.Add(this.dateTimePickerDueDate);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.buttonDeleteTask);
            this.Controls.Add(this.dataGridViewTasks);
            this.Name = "DashboardForm";
            this.Text = "ToDo Dashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += DashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)this.dataGridViewTasks).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();




            this.buttonLogout = new Button();
            this.buttonLogout.BackColor = Color.Crimson;
            this.buttonLogout.ForeColor = Color.White;
            this.buttonLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.buttonLogout.Location = new Point(650, 20); // sağ üst köşe
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new Size(120, 35);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "Log Out";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += buttonLogout_Click;
            this.Controls.Add(this.buttonLogout);

        }

        // 
// buttonLogout
// 
            


        #endregion

        private DataGridView dataGridViewTasks;
        private Button buttonAddTask;
        private Button buttonDeleteTask;
        private TextBox textBoxTaskTitle;
        private TextBox textBoxTaskDescription;
        private DateTimePicker dateTimePickerDueDate;
        private ComboBox comboBoxUser;
        private Label labelTitle;
        private Button buttonLogout;

    }
}
