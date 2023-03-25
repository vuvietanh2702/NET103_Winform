namespace Lab1
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PTBac2 = new System.Windows.Forms.RadioButton();
            this.PTBac1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtSoC = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.giaipt = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(264, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải Phương Trình";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PTBac2);
            this.groupBox1.Controls.Add(this.PTBac1);
            this.groupBox1.Location = new System.Drawing.Point(264, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vui lòng chọn:";
            // 
            // PTBac2
            // 
            this.PTBac2.AutoSize = true;
            this.PTBac2.Location = new System.Drawing.Point(66, 85);
            this.PTBac2.Name = "PTBac2";
            this.PTBac2.Size = new System.Drawing.Size(113, 24);
            this.PTBac2.TabIndex = 1;
            this.PTBac2.TabStop = true;
            this.PTBac2.Text = "giải pt bậc 2";
            this.PTBac2.UseVisualStyleBackColor = true;
            this.PTBac2.CheckedChanged += new System.EventHandler(this.PTBac2_CheckedChanged);
            // 
            // PTBac1
            // 
            this.PTBac1.AutoSize = true;
            this.PTBac1.Location = new System.Drawing.Point(66, 37);
            this.PTBac1.Name = "PTBac1";
            this.PTBac1.Size = new System.Drawing.Size(113, 24);
            this.PTBac1.TabIndex = 0;
            this.PTBac1.TabStop = true;
            this.PTBac1.Text = "giải pt bậc 1";
            this.PTBac1.UseVisualStyleBackColor = true;
            this.PTBac1.CheckedChanged += new System.EventHandler(this.PTBac1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "nhập a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "nhập b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "nhập c:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "kết quả:";
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(216, 273);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(310, 27);
            this.txtSoA.TabIndex = 6;
            this.txtSoA.TextChanged += new System.EventHandler(this.txtSoA_TextChanged);
            this.txtSoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoA_KeyPress);
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(216, 334);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(310, 27);
            this.txtSoB.TabIndex = 7;
            this.txtSoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoB_KeyPress);
            // 
            // txtSoC
            // 
            this.txtSoC.Location = new System.Drawing.Point(216, 404);
            this.txtSoC.Name = "txtSoC";
            this.txtSoC.Size = new System.Drawing.Size(310, 27);
            this.txtSoC.TabIndex = 8;
            this.txtSoC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoC_KeyPress);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(216, 473);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(310, 27);
            this.txtKetQua.TabIndex = 9;
            // 
            // giaipt
            // 
            this.giaipt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.giaipt.Location = new System.Drawing.Point(617, 212);
            this.giaipt.Name = "giaipt";
            this.giaipt.Size = new System.Drawing.Size(131, 88);
            this.giaipt.TabIndex = 10;
            this.giaipt.Text = "giải pt";
            this.giaipt.UseVisualStyleBackColor = true;
            this.giaipt.Click += new System.EventHandler(this.GiaiPT);
            // 
            // thoat
            // 
            this.thoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thoat.Location = new System.Drawing.Point(631, 433);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(94, 43);
            this.thoat.TabIndex = 11;
            this.thoat.Text = "thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(631, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Xoá";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.giaipt);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSoC);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton PTBac2;
        private RadioButton PTBac1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSoA;
        private TextBox txtSoB;
        private TextBox txtSoC;
        private TextBox txtKetQua;
        private Button giaipt;
        private Button thoat;
        private Button button1;
    }
}