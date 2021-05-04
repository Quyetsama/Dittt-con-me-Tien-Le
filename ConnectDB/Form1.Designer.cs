
namespace ConnectDB
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbmsv = new System.Windows.Forms.Label();
            this.lbten = new System.Windows.Forms.Label();
            this.lbgioitinh = new System.Windows.Forms.Label();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.lbngaysinh = new System.Windows.Forms.Label();
            this.textBoxmsv = new System.Windows.Forms.TextBox();
            this.textBoxten = new System.Windows.Forms.TextBox();
            this.textBoxdiachi = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rdnam = new System.Windows.Forms.RadioButton();
            this.rdnu = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbmsv
            // 
            this.lbmsv.AutoSize = true;
            this.lbmsv.Location = new System.Drawing.Point(12, 21);
            this.lbmsv.Name = "lbmsv";
            this.lbmsv.Size = new System.Drawing.Size(70, 13);
            this.lbmsv.TabIndex = 1;
            this.lbmsv.Text = "Mã sinh viên:";
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Location = new System.Drawing.Point(12, 47);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(57, 13);
            this.lbten.TabIndex = 2;
            this.lbten.Text = "Họ và tên:";
            // 
            // lbgioitinh
            // 
            this.lbgioitinh.AutoSize = true;
            this.lbgioitinh.Location = new System.Drawing.Point(12, 76);
            this.lbgioitinh.Name = "lbgioitinh";
            this.lbgioitinh.Size = new System.Drawing.Size(50, 13);
            this.lbgioitinh.TabIndex = 3;
            this.lbgioitinh.Text = "Giới tính:";
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Location = new System.Drawing.Point(269, 21);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(43, 13);
            this.lbdiachi.TabIndex = 4;
            this.lbdiachi.Text = "Địa chỉ:";
            // 
            // lbngaysinh
            // 
            this.lbngaysinh.AutoSize = true;
            this.lbngaysinh.Location = new System.Drawing.Point(269, 76);
            this.lbngaysinh.Name = "lbngaysinh";
            this.lbngaysinh.Size = new System.Drawing.Size(57, 13);
            this.lbngaysinh.TabIndex = 5;
            this.lbngaysinh.Text = "Ngày sinh:";
            // 
            // textBoxmsv
            // 
            this.textBoxmsv.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxmsv.Location = new System.Drawing.Point(88, 18);
            this.textBoxmsv.Name = "textBoxmsv";
            this.textBoxmsv.Size = new System.Drawing.Size(100, 20);
            this.textBoxmsv.TabIndex = 6;
            // 
            // textBoxten
            // 
            this.textBoxten.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxten.Location = new System.Drawing.Point(88, 47);
            this.textBoxten.Name = "textBoxten";
            this.textBoxten.Size = new System.Drawing.Size(100, 20);
            this.textBoxten.TabIndex = 7;
            // 
            // textBoxdiachi
            // 
            this.textBoxdiachi.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxdiachi.Location = new System.Drawing.Point(327, 18);
            this.textBoxdiachi.Name = "textBoxdiachi";
            this.textBoxdiachi.Size = new System.Drawing.Size(100, 20);
            this.textBoxdiachi.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(327, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2021, 4, 27, 0, 0, 0, 0);
            // 
            // rdnam
            // 
            this.rdnam.AutoSize = true;
            this.rdnam.Location = new System.Drawing.Point(64, 76);
            this.rdnam.Name = "rdnam";
            this.rdnam.Size = new System.Drawing.Size(47, 17);
            this.rdnam.TabIndex = 12;
            this.rdnam.TabStop = true;
            this.rdnam.Text = "Nam";
            this.rdnam.UseVisualStyleBackColor = true;
            // 
            // rdnu
            // 
            this.rdnu.AutoSize = true;
            this.rdnu.Location = new System.Drawing.Point(125, 76);
            this.rdnu.Name = "rdnu";
            this.rdnu.Size = new System.Drawing.Size(39, 17);
            this.rdnu.TabIndex = 13;
            this.rdnu.TabStop = true;
            this.rdnu.Text = "Nữ";
            this.rdnu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(678, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 52);
            this.button2.TabIndex = 14;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(585, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 52);
            this.button3.TabIndex = 15;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(678, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 52);
            this.button4.TabIndex = 16;
            this.button4.Text = "Ghi dữ liệu";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 323);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sinh Viên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rdnu);
            this.Controls.Add(this.rdnam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxdiachi);
            this.Controls.Add(this.textBoxten);
            this.Controls.Add(this.textBoxmsv);
            this.Controls.Add(this.lbngaysinh);
            this.Controls.Add(this.lbdiachi);
            this.Controls.Add(this.lbgioitinh);
            this.Controls.Add(this.lbten);
            this.Controls.Add(this.lbmsv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbmsv;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.Label lbgioitinh;
        private System.Windows.Forms.Label lbdiachi;
        private System.Windows.Forms.Label lbngaysinh;
        private System.Windows.Forms.TextBox textBoxmsv;
        private System.Windows.Forms.TextBox textBoxten;
        private System.Windows.Forms.TextBox textBoxdiachi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rdnam;
        private System.Windows.Forms.RadioButton rdnu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

