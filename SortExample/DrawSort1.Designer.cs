namespace SortExample
{
    partial class DrawSort1
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
            this.buttonRandom = new System.Windows.Forms.Button();
            this.Bubble = new System.Windows.Forms.Button();
            this.HoaraWithRec = new System.Windows.Forms.Button();
            this.HoaraWithStack = new System.Windows.Forms.Button();
            this.Show123 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(368, 24);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(75, 23);
            this.buttonRandom.TabIndex = 0;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // Bubble
            // 
            this.Bubble.Location = new System.Drawing.Point(490, 24);
            this.Bubble.Name = "Bubble";
            this.Bubble.Size = new System.Drawing.Size(117, 29);
            this.Bubble.TabIndex = 1;
            this.Bubble.Text = "Пузырьковая";
            this.Bubble.UseVisualStyleBackColor = true;
            this.Bubble.Click += new System.EventHandler(this.Bubble_Click);
            // 
            // HoaraWithRec
            // 
            this.HoaraWithRec.Location = new System.Drawing.Point(641, 19);
            this.HoaraWithRec.Name = "HoaraWithRec";
            this.HoaraWithRec.Size = new System.Drawing.Size(124, 32);
            this.HoaraWithRec.TabIndex = 2;
            this.HoaraWithRec.Text = "Быстрая Рек";
            this.HoaraWithRec.UseVisualStyleBackColor = true;
            this.HoaraWithRec.Click += new System.EventHandler(this.HoaraWithRec_Click);
            // 
            // HoaraWithStack
            // 
            this.HoaraWithStack.Location = new System.Drawing.Point(811, 30);
            this.HoaraWithStack.Name = "HoaraWithStack";
            this.HoaraWithStack.Size = new System.Drawing.Size(137, 23);
            this.HoaraWithStack.TabIndex = 3;
            this.HoaraWithStack.Text = "Быстрая стек";
            this.HoaraWithStack.UseVisualStyleBackColor = true;
            this.HoaraWithStack.Click += new System.EventHandler(this.HoaraWithStack_Click);
            // 
            // Show123
            // 
            this.Show123.Location = new System.Drawing.Point(212, 24);
            this.Show123.Name = "Show123";
            this.Show123.Size = new System.Drawing.Size(75, 29);
            this.Show123.TabIndex = 4;
            this.Show123.Text = "Графики";
            this.Show123.UseVisualStyleBackColor = true;
            this.Show123.Click += new System.EventHandler(this.Show123_Click);
            // 
            // DrawSort1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 373);
            this.Controls.Add(this.Show123);
            this.Controls.Add(this.HoaraWithStack);
            this.Controls.Add(this.HoaraWithRec);
            this.Controls.Add(this.Bubble);
            this.Controls.Add(this.buttonRandom);
            this.Name = "DrawSort1";
            this.Text = "DrawSort1";
            this.Load += new System.EventHandler(this.DrawSort1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawSort1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button Bubble;
        private System.Windows.Forms.Button HoaraWithRec;
        private System.Windows.Forms.Button HoaraWithStack;
        private System.Windows.Forms.Button Show123;
    }
}