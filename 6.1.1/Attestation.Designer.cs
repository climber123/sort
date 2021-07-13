namespace _6._1._1
{
    partial class Attestation
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
            this.Start_List = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.AddLast = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.AddFirst = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Random = new System.Windows.Forms.Button();
            this.Clear_Queue = new System.Windows.Forms.Button();
            this.Add_Queue = new System.Windows.Forms.Button();
            this.Create_Queue = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Clear_Stack = new System.Windows.Forms.Button();
            this.Add_Stack = new System.Windows.Forms.Button();
            this.Create_Stack = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.start_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start_List
            // 
            this.Start_List.Location = new System.Drawing.Point(6, 165);
            this.Start_List.Name = "Start_List";
            this.Start_List.Size = new System.Drawing.Size(330, 30);
            this.Start_List.TabIndex = 1;
            this.Start_List.Text = "Проверка на возрастание/убывание";
            this.Start_List.UseVisualStyleBackColor = true;
            this.Start_List.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "aa";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 31);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 600);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(418, 31);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 600);
            this.textBox3.TabIndex = 5;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(6, 21);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(330, 30);
            this.Create.TabIndex = 6;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // AddLast
            // 
            this.AddLast.Location = new System.Drawing.Point(6, 93);
            this.AddLast.Name = "AddLast";
            this.AddLast.Size = new System.Drawing.Size(330, 30);
            this.AddLast.TabIndex = 7;
            this.AddLast.Text = "Добавить в конец";
            this.AddLast.UseVisualStyleBackColor = true;
            this.AddLast.Click += new System.EventHandler(this.AddLast_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(6, 129);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(330, 30);
            this.Clear.TabIndex = 8;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // AddFirst
            // 
            this.AddFirst.Location = new System.Drawing.Point(6, 57);
            this.AddFirst.Name = "AddFirst";
            this.AddFirst.Size = new System.Drawing.Size(330, 30);
            this.AddFirst.TabIndex = 9;
            this.AddFirst.Text = "Добавить в начало";
            this.AddFirst.UseVisualStyleBackColor = true;
            this.AddFirst.Click += new System.EventHandler(this.AddFirst_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Clear);
            this.groupBox1.Controls.Add(this.AddFirst);
            this.groupBox1.Controls.Add(this.AddLast);
            this.groupBox1.Controls.Add(this.Create);
            this.groupBox1.Controls.Add(this.Start_List);
            this.groupBox1.Location = new System.Drawing.Point(68, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 206);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Списки";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.Random);
            this.groupBox2.Controls.Add(this.Clear_Queue);
            this.groupBox2.Controls.Add(this.Add_Queue);
            this.groupBox2.Controls.Add(this.Create_Queue);
            this.groupBox2.Location = new System.Drawing.Point(68, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 206);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Очередь";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(330, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Удалить все отрицательные элементы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(6, 129);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(330, 30);
            this.Random.TabIndex = 3;
            this.Random.Text = "Заполнить случайными числами";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // Clear_Queue
            // 
            this.Clear_Queue.Location = new System.Drawing.Point(6, 93);
            this.Clear_Queue.Name = "Clear_Queue";
            this.Clear_Queue.Size = new System.Drawing.Size(330, 30);
            this.Clear_Queue.TabIndex = 2;
            this.Clear_Queue.Text = "Очистить ";
            this.Clear_Queue.UseVisualStyleBackColor = true;
            this.Clear_Queue.Click += new System.EventHandler(this.Clear_Queue_Click);
            // 
            // Add_Queue
            // 
            this.Add_Queue.Location = new System.Drawing.Point(6, 57);
            this.Add_Queue.Name = "Add_Queue";
            this.Add_Queue.Size = new System.Drawing.Size(330, 30);
            this.Add_Queue.TabIndex = 1;
            this.Add_Queue.Text = "Добавить";
            this.Add_Queue.UseVisualStyleBackColor = true;
            this.Add_Queue.Click += new System.EventHandler(this.Add_Queue_Click);
            // 
            // Create_Queue
            // 
            this.Create_Queue.Location = new System.Drawing.Point(6, 21);
            this.Create_Queue.Name = "Create_Queue";
            this.Create_Queue.Size = new System.Drawing.Size(330, 30);
            this.Create_Queue.TabIndex = 0;
            this.Create_Queue.Text = "Создать";
            this.Create_Queue.UseVisualStyleBackColor = true;
            this.Create_Queue.Click += new System.EventHandler(this.Create_Queue_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.start_button);
            this.groupBox3.Controls.Add(this.Clear_Stack);
            this.groupBox3.Controls.Add(this.Add_Stack);
            this.groupBox3.Controls.Add(this.Create_Stack);
            this.groupBox3.Location = new System.Drawing.Point(68, 455);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 174);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Стек";
            // 
            // Clear_Stack
            // 
            this.Clear_Stack.Location = new System.Drawing.Point(6, 93);
            this.Clear_Stack.Name = "Clear_Stack";
            this.Clear_Stack.Size = new System.Drawing.Size(330, 30);
            this.Clear_Stack.TabIndex = 2;
            this.Clear_Stack.Text = "Очистить";
            this.Clear_Stack.UseVisualStyleBackColor = true;
            this.Clear_Stack.Click += new System.EventHandler(this.Clear_Stack_Click);
            // 
            // Add_Stack
            // 
            this.Add_Stack.Location = new System.Drawing.Point(6, 57);
            this.Add_Stack.Name = "Add_Stack";
            this.Add_Stack.Size = new System.Drawing.Size(330, 30);
            this.Add_Stack.TabIndex = 1;
            this.Add_Stack.Text = "Добавить";
            this.Add_Stack.UseVisualStyleBackColor = true;
            this.Add_Stack.Click += new System.EventHandler(this.Add_Stack_Click);
            // 
            // Create_Stack
            // 
            this.Create_Stack.Location = new System.Drawing.Point(7, 21);
            this.Create_Stack.Name = "Create_Stack";
            this.Create_Stack.Size = new System.Drawing.Size(330, 30);
            this.Create_Stack.TabIndex = 0;
            this.Create_Stack.Text = "Создать";
            this.Create_Stack.UseVisualStyleBackColor = true;
            this.Create_Stack.Click += new System.EventHandler(this.Create_Stack_Click);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(932, 28);
            this.menu.TabIndex = 13;
            this.menu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click_1);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(6, 129);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(330, 30);
            this.start_button.TabIndex = 14;
            this.start_button.Text = "Вывести цифры";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // Attestation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 687);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Attestation";
            this.Text = "Attestation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Start_List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button AddLast;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button AddFirst;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Random;
        private System.Windows.Forms.Button Clear_Queue;
        private System.Windows.Forms.Button Add_Queue;
        private System.Windows.Forms.Button Create_Queue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Clear_Stack;
        private System.Windows.Forms.Button Add_Stack;
        private System.Windows.Forms.Button Create_Stack;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Button start_button;
    }
}

