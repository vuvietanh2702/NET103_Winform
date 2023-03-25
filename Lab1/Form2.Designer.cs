namespace Lab1
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.USCLN_Changed = new System.Windows.Forms.RadioButton();
            this.BSCNN = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NutThoat = new System.Windows.Forms.Button();
            this.NutBoQua = new System.Windows.Forms.Button();
            this.NutTim = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoB);
            this.groupBox1.Controls.Add(this.txtSoA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập";
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(77, 100);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(338, 27);
            this.txtSoB.TabIndex = 3;
            this.txtSoB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtSoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoB_KeyPress);
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(77, 37);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(338, 27);
            this.txtSoA.TabIndex = 2;
            this.txtSoA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoA_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "B:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "A:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.USCLN_Changed);
            this.groupBox2.Controls.Add(this.BSCNN);
            this.groupBox2.Location = new System.Drawing.Point(552, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 173);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn tìm";
            // 
            // USCLN_Changed
            // 
            this.USCLN_Changed.AutoSize = true;
            this.USCLN_Changed.Location = new System.Drawing.Point(34, 36);
            this.USCLN_Changed.Name = "USCLN_Changed";
            this.USCLN_Changed.Size = new System.Drawing.Size(75, 24);
            this.USCLN_Changed.TabIndex = 0;
            this.USCLN_Changed.TabStop = true;
            this.USCLN_Changed.Text = "USCLN";
            this.USCLN_Changed.UseVisualStyleBackColor = true;
            // 
            // BSCNN
            // 
            this.BSCNN.AutoSize = true;
            this.BSCNN.Location = new System.Drawing.Point(34, 98);
            this.BSCNN.Name = "BSCNN";
            this.BSCNN.Size = new System.Drawing.Size(78, 24);
            this.BSCNN.TabIndex = 1;
            this.BSCNN.TabStop = true;
            this.BSCNN.Text = "BSCNN";
            this.BSCNN.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NutThoat);
            this.groupBox3.Controls.Add(this.NutBoQua);
            this.groupBox3.Controls.Add(this.NutTim);
            this.groupBox3.Controls.Add(this.txtKetQua);
            this.groupBox3.Location = new System.Drawing.Point(30, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(727, 125);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // NutThoat
            // 
            this.NutThoat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NutThoat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NutThoat.Location = new System.Drawing.Point(506, 74);
            this.NutThoat.Name = "NutThoat";
            this.NutThoat.Size = new System.Drawing.Size(94, 45);
            this.NutThoat.TabIndex = 3;
            this.NutThoat.Text = "Thoát";
            this.NutThoat.UseVisualStyleBackColor = false;
            this.NutThoat.Click += new System.EventHandler(this.NutThoat_Click);
            // 
            // NutBoQua
            // 
            this.NutBoQua.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NutBoQua.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NutBoQua.Location = new System.Drawing.Point(273, 74);
            this.NutBoQua.Name = "NutBoQua";
            this.NutBoQua.Size = new System.Drawing.Size(94, 45);
            this.NutBoQua.TabIndex = 2;
            this.NutBoQua.Text = "Bỏ Qua";
            this.NutBoQua.UseVisualStyleBackColor = false;
            this.NutBoQua.Click += new System.EventHandler(this.NutBoQua_Click);
            // 
            // NutTim
            // 
            this.NutTim.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NutTim.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NutTim.Location = new System.Drawing.Point(124, 74);
            this.NutTim.Name = "NutTim";
            this.NutTim.Size = new System.Drawing.Size(76, 45);
            this.NutTim.TabIndex = 1;
            this.NutTim.Text = "Tìm";
            this.NutTim.UseVisualStyleBackColor = false;
            this.NutTim.Click += new System.EventHandler(this.NutTim_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(77, 26);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(447, 27);
            this.txtKetQua.TabIndex = 0;
            this.txtKetQua.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Tìm USCLN và BSCNN của A và B";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox txtSoA;
        private TextBox txtSoB;
        private GroupBox groupBox2;
        private RadioButton BSCNN;
        private RadioButton USCLN_Changed;
        private GroupBox groupBox3;
        private TextBox txtKetQua;
        private Button NutThoat;
        private Button NutBoQua;
        private Button NutTim;
    }
}