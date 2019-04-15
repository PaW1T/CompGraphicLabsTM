namespace Laba3
{
    partial class Lab3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.drawbutton = new System.Windows.Forms.Button();
            this.animatebutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.ShowDotsCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(239, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 585);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 205);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // drawbutton
            // 
            this.drawbutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.drawbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drawbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawbutton.Location = new System.Drawing.Point(15, 223);
            this.drawbutton.Name = "drawbutton";
            this.drawbutton.Size = new System.Drawing.Size(99, 33);
            this.drawbutton.TabIndex = 2;
            this.drawbutton.Text = "Нарисовать";
            this.drawbutton.UseVisualStyleBackColor = false;
            this.drawbutton.Click += new System.EventHandler(this.drawbutton_Click);
            // 
            // animatebutton
            // 
            this.animatebutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.animatebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.animatebutton.Location = new System.Drawing.Point(134, 223);
            this.animatebutton.Name = "animatebutton";
            this.animatebutton.Size = new System.Drawing.Size(83, 33);
            this.animatebutton.TabIndex = 3;
            this.animatebutton.Text = "Изменить";
            this.animatebutton.UseVisualStyleBackColor = false;
            this.animatebutton.Click += new System.EventHandler(this.animatebutton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Time_Plus);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Y = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "X = ";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(44, 283);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(13, 13);
            this.labelY.TabIndex = 19;
            this.labelY.Text = "0";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(44, 270);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(13, 13);
            this.labelX.TabIndex = 18;
            this.labelX.Text = "0";
            // 
            // ShowDotsCheck
            // 
            this.ShowDotsCheck.AutoSize = true;
            this.ShowDotsCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowDotsCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowDotsCheck.Location = new System.Drawing.Point(15, 319);
            this.ShowDotsCheck.Name = "ShowDotsCheck";
            this.ShowDotsCheck.Size = new System.Drawing.Size(131, 20);
            this.ShowDotsCheck.TabIndex = 22;
            this.ShowDotsCheck.Text = "Показать точки";
            this.ShowDotsCheck.UseVisualStyleBackColor = true;
            this.ShowDotsCheck.CheckedChanged += new System.EventHandler(this.ShowDotsCheck_Changed);
            // 
            // Lab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(849, 627);
            this.Controls.Add(this.ShowDotsCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.animatebutton);
            this.Controls.Add(this.drawbutton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Lab3";
            this.Text = "Лабораторная работа №3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button drawbutton;
        private System.Windows.Forms.Button animatebutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.CheckBox ShowDotsCheck;
    }
}

