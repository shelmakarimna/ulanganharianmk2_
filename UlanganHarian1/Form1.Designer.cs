namespace UlanganHarian1
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
            lb_kota = new Label();
            rb_surabaya = new RadioButton();
            rb_jakarta = new RadioButton();
            rb_purwokerto = new RadioButton();
            lb_total = new Label();
            rb_8 = new RadioButton();
            rb_4 = new RadioButton();
            rb_12 = new RadioButton();
            btn_submit2 = new Button();
            gb_soal1 = new GroupBox();
            groupBox2 = new GroupBox();
            gb_soal2 = new GroupBox();
            btn_submit1 = new Button();
            gb_soal1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(318, 26);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 0;
            label1.Text = "Kuis Pilihan Ganda";
            // 
            // lb_kota
            // 
            lb_kota.AutoSize = true;
            lb_kota.Font = new Font("Segoe UI", 10F);
            lb_kota.Location = new Point(12, 106);
            lb_kota.Name = "lb_kota";
            lb_kota.Size = new Size(238, 23);
            lb_kota.TabIndex = 1;
            lb_kota.Text = "1. Ibu kota Indonesia adalah...";
            // 
            // rb_surabaya
            // 
            rb_surabaya.AutoSize = true;
            rb_surabaya.Font = new Font("Segoe UI", 10F);
            rb_surabaya.Location = new Point(34, 132);
            rb_surabaya.Name = "rb_surabaya";
            rb_surabaya.Size = new Size(101, 27);
            rb_surabaya.TabIndex = 2;
            rb_surabaya.TabStop = true;
            rb_surabaya.Text = "Surabaya";
            rb_surabaya.UseVisualStyleBackColor = true;
            // 
            // rb_jakarta
            // 
            rb_jakarta.AutoSize = true;
            rb_jakarta.Font = new Font("Segoe UI", 10F);
            rb_jakarta.Location = new Point(34, 165);
            rb_jakarta.Name = "rb_jakarta";
            rb_jakarta.Size = new Size(84, 27);
            rb_jakarta.TabIndex = 3;
            rb_jakarta.TabStop = true;
            rb_jakarta.Text = "Jakarta";
            rb_jakarta.UseVisualStyleBackColor = true;
            // 
            // rb_purwokerto
            // 
            rb_purwokerto.AutoSize = true;
            rb_purwokerto.Font = new Font("Segoe UI", 10F);
            rb_purwokerto.Location = new Point(34, 198);
            rb_purwokerto.Name = "rb_purwokerto";
            rb_purwokerto.Size = new Size(118, 27);
            rb_purwokerto.TabIndex = 4;
            rb_purwokerto.TabStop = true;
            rb_purwokerto.Text = "Purwokerto";
            rb_purwokerto.UseVisualStyleBackColor = true;
            // 
            // lb_total
            // 
            lb_total.AutoSize = true;
            lb_total.Font = new Font("Segoe UI", 10F);
            lb_total.Location = new Point(12, 271);
            lb_total.Name = "lb_total";
            lb_total.Size = new Size(185, 23);
            lb_total.TabIndex = 5;
            lb_total.Text = "2. Berapa total 2+6 =...";
            // 
            // rb_8
            // 
            rb_8.AutoSize = true;
            rb_8.Font = new Font("Segoe UI", 10F);
            rb_8.Location = new Point(34, 297);
            rb_8.Name = "rb_8";
            rb_8.Size = new Size(40, 27);
            rb_8.TabIndex = 6;
            rb_8.TabStop = true;
            rb_8.Text = "8";
            rb_8.UseVisualStyleBackColor = true;
            // 
            // rb_4
            // 
            rb_4.AutoSize = true;
            rb_4.Location = new Point(34, 330);
            rb_4.Name = "rb_4";
            rb_4.Size = new Size(38, 24);
            rb_4.TabIndex = 7;
            rb_4.TabStop = true;
            rb_4.Text = "4";
            rb_4.UseVisualStyleBackColor = true;
            // 
            // rb_12
            // 
            rb_12.AutoSize = true;
            rb_12.Font = new Font("Segoe UI", 10F);
            rb_12.Location = new Point(34, 360);
            rb_12.Name = "rb_12";
            rb_12.Size = new Size(49, 27);
            rb_12.TabIndex = 8;
            rb_12.TabStop = true;
            rb_12.Text = "12";
            rb_12.UseVisualStyleBackColor = true;
            // 
            // btn_submit2
            // 
            btn_submit2.Font = new Font("Segoe UI", 8F);
            btn_submit2.Location = new Point(118, 379);
            btn_submit2.Name = "btn_submit2";
            btn_submit2.Size = new Size(79, 27);
            btn_submit2.TabIndex = 9;
            btn_submit2.Text = "Submit";
            btn_submit2.UseVisualStyleBackColor = true;
            btn_submit2.Click += btn_check2_Click;
            // 
            // gb_soal1
            // 
            gb_soal1.Controls.Add(groupBox2);
            gb_soal1.Font = new Font("Segoe UI", 10F);
            gb_soal1.Location = new Point(219, 231);
            gb_soal1.Name = "gb_soal1";
            gb_soal1.Size = new Size(243, 40);
            gb_soal1.TabIndex = 10;
            gb_soal1.TabStop = false;
            gb_soal1.Text = "Jawaban anda: ";
            gb_soal1.Enter += gb_soal1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(232, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // gb_soal2
            // 
            gb_soal2.Font = new Font("Segoe UI", 10F);
            gb_soal2.Location = new Point(219, 366);
            gb_soal2.Name = "gb_soal2";
            gb_soal2.Size = new Size(243, 40);
            gb_soal2.TabIndex = 11;
            gb_soal2.TabStop = false;
            gb_soal2.Text = "Jawaban anda:";
            // 
            // btn_submit1
            // 
            btn_submit1.Font = new Font("Segoe UI", 8F);
            btn_submit1.Location = new Point(118, 231);
            btn_submit1.Name = "btn_submit1";
            btn_submit1.Size = new Size(79, 26);
            btn_submit1.TabIndex = 12;
            btn_submit1.Text = "Submit";
            btn_submit1.UseVisualStyleBackColor = true;
            btn_submit1.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_submit1);
            Controls.Add(gb_soal2);
            Controls.Add(gb_soal1);
            Controls.Add(btn_submit2);
            Controls.Add(rb_12);
            Controls.Add(rb_4);
            Controls.Add(rb_8);
            Controls.Add(lb_total);
            Controls.Add(rb_purwokerto);
            Controls.Add(rb_jakarta);
            Controls.Add(rb_surabaya);
            Controls.Add(lb_kota);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gb_soal1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lb_kota;
        private RadioButton rb_surabaya;
        private RadioButton rb_jakarta;
        private RadioButton rb_purwokerto;
        private Label lb_total;
        private RadioButton rb_8;
        private RadioButton rb_4;
        private RadioButton rb_12;
        private Button btn_submit2;
        private GroupBox gb_soal1;
        private GroupBox groupBox2;
        private GroupBox gb_soal2;
        private Button btn_submit1;
    }
}
