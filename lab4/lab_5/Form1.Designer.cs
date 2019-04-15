namespace lab_5
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAngle1 = new System.Windows.Forms.TextBox();
            this.txtAngle2 = new System.Windows.Forms.TextBox();
            this.BuildButton = new System.Windows.Forms.Button();
            this.ShiftButton = new System.Windows.Forms.Button();
            this.txtMoveX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoveY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoveZ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRotateAngle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRotateZ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRotateY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRotateX = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rotatebut = new System.Windows.Forms.Button();
            this.radioButton_z = new System.Windows.Forms.RadioButton();
            this.radioButton_y = new System.Windows.Forms.RadioButton();
            this.radioButton_x = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 569);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(652, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "α";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(720, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "β";
            // 
            // txtAngle1
            // 
            this.txtAngle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAngle1.Location = new System.Drawing.Point(670, 22);
            this.txtAngle1.Name = "txtAngle1";
            this.txtAngle1.Size = new System.Drawing.Size(30, 23);
            this.txtAngle1.TabIndex = 24;
            this.txtAngle1.Text = "35";
            this.txtAngle1.TextChanged += new System.EventHandler(this.txtAngle1_TextChanged);
            // 
            // txtAngle2
            // 
            this.txtAngle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAngle2.Location = new System.Drawing.Point(738, 21);
            this.txtAngle2.Name = "txtAngle2";
            this.txtAngle2.Size = new System.Drawing.Size(30, 23);
            this.txtAngle2.TabIndex = 25;
            this.txtAngle2.Text = "50";
            // 
            // BuildButton
            // 
            this.BuildButton.BackColor = System.Drawing.Color.PowderBlue;
            this.BuildButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildButton.Location = new System.Drawing.Point(662, 51);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(107, 31);
            this.BuildButton.TabIndex = 28;
            this.BuildButton.Text = "Построить";
            this.BuildButton.UseVisualStyleBackColor = false;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // ShiftButton
            // 
            this.ShiftButton.BackColor = System.Drawing.Color.PowderBlue;
            this.ShiftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShiftButton.Location = new System.Drawing.Point(645, 226);
            this.ShiftButton.Name = "ShiftButton";
            this.ShiftButton.Size = new System.Drawing.Size(91, 31);
            this.ShiftButton.TabIndex = 29;
            this.ShiftButton.Text = "Сдвинуть";
            this.ShiftButton.UseVisualStyleBackColor = false;
            this.ShiftButton.Click += new System.EventHandler(this.ShiftButton_Click);
            // 
            // txtMoveX
            // 
            this.txtMoveX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMoveX.Location = new System.Drawing.Point(662, 149);
            this.txtMoveX.Name = "txtMoveX";
            this.txtMoveX.Size = new System.Drawing.Size(35, 23);
            this.txtMoveX.TabIndex = 30;
            this.txtMoveX.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(643, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "X";
            // 
            // txtMoveY
            // 
            this.txtMoveY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMoveY.Location = new System.Drawing.Point(662, 175);
            this.txtMoveY.Name = "txtMoveY";
            this.txtMoveY.Size = new System.Drawing.Size(35, 23);
            this.txtMoveY.TabIndex = 32;
            this.txtMoveY.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(643, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Y";
            // 
            // txtMoveZ
            // 
            this.txtMoveZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMoveZ.Location = new System.Drawing.Point(662, 201);
            this.txtMoveZ.Name = "txtMoveZ";
            this.txtMoveZ.Size = new System.Drawing.Size(35, 23);
            this.txtMoveZ.TabIndex = 34;
            this.txtMoveZ.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(643, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Z";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(655, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "Угол";
            // 
            // txtRotateAngle
            // 
            this.txtRotateAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRotateAngle.Location = new System.Drawing.Point(701, 386);
            this.txtRotateAngle.Margin = new System.Windows.Forms.Padding(2);
            this.txtRotateAngle.Name = "txtRotateAngle";
            this.txtRotateAngle.Size = new System.Drawing.Size(35, 23);
            this.txtRotateAngle.TabIndex = 20;
            this.txtRotateAngle.Text = "45";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(679, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Z";
            // 
            // txtRotateZ
            // 
            this.txtRotateZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRotateZ.Location = new System.Drawing.Point(701, 363);
            this.txtRotateZ.Name = "txtRotateZ";
            this.txtRotateZ.Size = new System.Drawing.Size(35, 23);
            this.txtRotateZ.TabIndex = 41;
            this.txtRotateZ.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(679, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Y";
            // 
            // txtRotateY
            // 
            this.txtRotateY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRotateY.Location = new System.Drawing.Point(701, 337);
            this.txtRotateY.Name = "txtRotateY";
            this.txtRotateY.Size = new System.Drawing.Size(35, 23);
            this.txtRotateY.TabIndex = 39;
            this.txtRotateY.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(678, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "X";
            // 
            // txtRotateX
            // 
            this.txtRotateX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRotateX.Location = new System.Drawing.Point(701, 313);
            this.txtRotateX.Name = "txtRotateX";
            this.txtRotateX.Size = new System.Drawing.Size(35, 23);
            this.txtRotateX.TabIndex = 37;
            this.txtRotateX.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rotatebut);
            this.groupBox1.Controls.Add(this.radioButton_z);
            this.groupBox1.Controls.Add(this.radioButton_y);
            this.groupBox1.Controls.Add(this.radioButton_x);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(648, 413);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(189, 88);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оси";
            // 
            // rotatebut
            // 
            this.rotatebut.BackColor = System.Drawing.Color.PowderBlue;
            this.rotatebut.Location = new System.Drawing.Point(103, 34);
            this.rotatebut.Name = "rotatebut";
            this.rotatebut.Size = new System.Drawing.Size(81, 31);
            this.rotatebut.TabIndex = 48;
            this.rotatebut.Text = "Вращать";
            this.rotatebut.UseVisualStyleBackColor = false;
            this.rotatebut.Click += new System.EventHandler(this.rotatebut_Click);
            // 
            // radioButton_z
            // 
            this.radioButton_z.AutoSize = true;
            this.radioButton_z.Location = new System.Drawing.Point(8, 61);
            this.radioButton_z.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_z.Name = "radioButton_z";
            this.radioButton_z.Size = new System.Drawing.Size(64, 21);
            this.radioButton_z.TabIndex = 2;
            this.radioButton_z.TabStop = true;
            this.radioButton_z.Text = "Ось Z";
            this.radioButton_z.UseVisualStyleBackColor = true;
            // 
            // radioButton_y
            // 
            this.radioButton_y.AutoSize = true;
            this.radioButton_y.Location = new System.Drawing.Point(8, 39);
            this.radioButton_y.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_y.Name = "radioButton_y";
            this.radioButton_y.Size = new System.Drawing.Size(64, 21);
            this.radioButton_y.TabIndex = 1;
            this.radioButton_y.TabStop = true;
            this.radioButton_y.Text = "Ось Y";
            this.radioButton_y.UseVisualStyleBackColor = true;
            // 
            // radioButton_x
            // 
            this.radioButton_x.AutoSize = true;
            this.radioButton_x.Location = new System.Drawing.Point(8, 17);
            this.radioButton_x.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_x.Name = "radioButton_x";
            this.radioButton_x.Size = new System.Drawing.Size(64, 21);
            this.radioButton_x.TabIndex = 0;
            this.radioButton_x.TabStop = true;
            this.radioButton_x.Text = "Ось X";
            this.radioButton_x.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(886, 596);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRotateAngle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRotateZ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRotateY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRotateX);
            this.Controls.Add(this.ShiftButton);
            this.Controls.Add(this.txtMoveX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMoveY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMoveZ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BuildButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAngle1);
            this.Controls.Add(this.txtAngle2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №5";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAngle1;
        private System.Windows.Forms.TextBox txtAngle2;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.Button ShiftButton;
        private System.Windows.Forms.TextBox txtMoveX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMoveY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMoveZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRotateAngle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRotateZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRotateY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRotateX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_z;
        private System.Windows.Forms.RadioButton radioButton_y;
        private System.Windows.Forms.RadioButton radioButton_x;
        private System.Windows.Forms.Button rotatebut;
    }
}

