namespace CSharp_BangCuuChuong
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
            label2 = new Label();
            txtSo = new TextBox();
            lblKQ = new Label();
            button1 = new Button();
            btnBox = new Button();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            groupBox1 = new GroupBox();
            rdo10 = new RadioButton();
            rdo9 = new RadioButton();
            rdo8 = new RadioButton();
            rdo7 = new RadioButton();
            rdo6 = new RadioButton();
            rdo4 = new RadioButton();
            rdo5 = new RadioButton();
            rdo3 = new RadioButton();
            rdo2 = new RadioButton();
            button2 = new Button();
            trackBar1 = new TrackBar();
            button3 = new Button();
            lblSo = new Label();
            listB1 = new ListBox();
            comB1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 42);
            label1.Name = "label1";
            label1.Size = new Size(290, 33);
            label1.TabIndex = 0;
            label1.Text = "Chọn bảng cửu chương";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 279);
            label2.Name = "label2";
            label2.Size = new Size(106, 33);
            label2.TabIndex = 0;
            label2.Text = "Kết quả";
            // 
            // txtSo
            // 
            txtSo.Location = new Point(325, 45);
            txtSo.Name = "txtSo";
            txtSo.Size = new Size(75, 40);
            txtSo.TabIndex = 1;
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.Location = new Point(29, 322);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(0, 33);
            lblKQ.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(700, 451);
            button1.Name = "button1";
            button1.Size = new Size(125, 48);
            button1.TabIndex = 3;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnBox
            // 
            btnBox.Location = new Point(641, 42);
            btnBox.Name = "btnBox";
            btnBox.Size = new Size(125, 48);
            btnBox.TabIndex = 3;
            btnBox.Text = "In ra";
            btnBox.UseVisualStyleBackColor = true;
            btnBox.Click += btnBox_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(426, 46);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(74, 40);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 9);
            label3.Name = "label3";
            label3.Size = new Size(230, 33);
            label3.TabIndex = 5;
            label3.Text = "Bảng Cửu Chương";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdo10);
            groupBox1.Controls.Add(rdo9);
            groupBox1.Controls.Add(rdo8);
            groupBox1.Controls.Add(rdo7);
            groupBox1.Controls.Add(rdo6);
            groupBox1.Controls.Add(rdo4);
            groupBox1.Controls.Add(rdo5);
            groupBox1.Controls.Add(rdo3);
            groupBox1.Controls.Add(rdo2);
            groupBox1.Location = new Point(29, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 87);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn bảng cửu chương";
            // 
            // rdo10
            // 
            rdo10.AutoSize = true;
            rdo10.Location = new Point(423, 39);
            rdo10.Name = "rdo10";
            rdo10.Size = new Size(63, 37);
            rdo10.TabIndex = 0;
            rdo10.TabStop = true;
            rdo10.Text = "10";
            rdo10.UseVisualStyleBackColor = true;
            rdo10.CheckedChanged += KiemTraRDO;
            // 
            // rdo9
            // 
            rdo9.AutoSize = true;
            rdo9.Location = new Point(369, 39);
            rdo9.Name = "rdo9";
            rdo9.Size = new Size(48, 37);
            rdo9.TabIndex = 0;
            rdo9.TabStop = true;
            rdo9.Text = "9";
            rdo9.UseVisualStyleBackColor = true;
            rdo9.CheckedChanged += KiemTraRDO;
            // 
            // rdo8
            // 
            rdo8.AutoSize = true;
            rdo8.Location = new Point(315, 39);
            rdo8.Name = "rdo8";
            rdo8.Size = new Size(48, 37);
            rdo8.TabIndex = 0;
            rdo8.TabStop = true;
            rdo8.Text = "8";
            rdo8.UseVisualStyleBackColor = true;
            rdo8.CheckedChanged += KiemTraRDO;
            // 
            // rdo7
            // 
            rdo7.AutoSize = true;
            rdo7.Location = new Point(261, 39);
            rdo7.Name = "rdo7";
            rdo7.Size = new Size(48, 37);
            rdo7.TabIndex = 0;
            rdo7.TabStop = true;
            rdo7.Text = "7";
            rdo7.UseVisualStyleBackColor = true;
            rdo7.CheckedChanged += KiemTraRDO;
            // 
            // rdo6
            // 
            rdo6.AutoSize = true;
            rdo6.Location = new Point(216, 39);
            rdo6.Name = "rdo6";
            rdo6.Size = new Size(48, 37);
            rdo6.TabIndex = 0;
            rdo6.TabStop = true;
            rdo6.Text = "6";
            rdo6.UseVisualStyleBackColor = true;
            rdo6.CheckedChanged += KiemTraRDO;
            // 
            // rdo4
            // 
            rdo4.AutoSize = true;
            rdo4.Location = new Point(108, 39);
            rdo4.Name = "rdo4";
            rdo4.Size = new Size(48, 37);
            rdo4.TabIndex = 0;
            rdo4.TabStop = true;
            rdo4.Text = "4";
            rdo4.UseVisualStyleBackColor = true;
            rdo4.CheckedChanged += KiemTraRDO;
            // 
            // rdo5
            // 
            rdo5.AutoSize = true;
            rdo5.Location = new Point(162, 39);
            rdo5.Name = "rdo5";
            rdo5.Size = new Size(48, 37);
            rdo5.TabIndex = 0;
            rdo5.TabStop = true;
            rdo5.Text = "5";
            rdo5.UseVisualStyleBackColor = true;
            rdo5.CheckedChanged += KiemTraRDO;
            // 
            // rdo3
            // 
            rdo3.AutoSize = true;
            rdo3.Location = new Point(54, 39);
            rdo3.Name = "rdo3";
            rdo3.Size = new Size(48, 37);
            rdo3.TabIndex = 0;
            rdo3.TabStop = true;
            rdo3.Text = "3";
            rdo3.UseVisualStyleBackColor = true;
            rdo3.CheckedChanged += KiemTraRDO;
            // 
            // rdo2
            // 
            rdo2.AutoSize = true;
            rdo2.Location = new Point(0, 39);
            rdo2.Name = "rdo2";
            rdo2.Size = new Size(48, 37);
            rdo2.TabIndex = 0;
            rdo2.TabStop = true;
            rdo2.Text = "2";
            rdo2.UseVisualStyleBackColor = true;
            rdo2.CheckedChanged += KiemTraRDO;
            // 
            // button2
            // 
            button2.Location = new Point(641, 141);
            button2.Name = "button2";
            button2.Size = new Size(125, 48);
            button2.TabIndex = 3;
            button2.Text = "In ra";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(29, 231);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(502, 45);
            trackBar1.TabIndex = 7;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // button3
            // 
            button3.Location = new Point(641, 228);
            button3.Name = "button3";
            button3.Size = new Size(125, 48);
            button3.TabIndex = 3;
            button3.Text = "In ra";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lblSo
            // 
            lblSo.AutoSize = true;
            lblSo.Location = new Point(29, 205);
            lblSo.Name = "lblSo";
            lblSo.Size = new Size(45, 33);
            lblSo.TabIndex = 8;
            lblSo.Text = "Số";
            // 
            // listB1
            // 
            listB1.FormattingEnabled = true;
            listB1.ItemHeight = 33;
            listB1.Location = new Point(191, 279);
            listB1.Name = "listB1";
            listB1.Size = new Size(182, 235);
            listB1.TabIndex = 9;
            // 
            // comB1
            // 
            comB1.FormattingEnabled = true;
            comB1.Location = new Point(398, 279);
            comB1.Name = "comB1";
            comB1.Size = new Size(152, 41);
            comB1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 560);
            Controls.Add(comB1);
            Controls.Add(listB1);
            Controls.Add(lblSo);
            Controls.Add(trackBar1);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnBox);
            Controls.Add(button1);
            Controls.Add(lblKQ);
            Controls.Add(txtSo);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSo;
        private Label lblKQ;
        private Button button1;
        private Button btnBox;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton rdo6;
        private RadioButton rdo4;
        private RadioButton rdo5;
        private RadioButton rdo3;
        private RadioButton rdo2;
        private RadioButton rdo10;
        private RadioButton rdo9;
        private RadioButton rdo8;
        private RadioButton rdo7;
        private Button button2;
        private TrackBar trackBar1;
        private Button button3;
        private Label lblSo;
        private ListBox listB1;
        private ComboBox comB1;
    }
}
