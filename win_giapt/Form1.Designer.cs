namespace win_giapt
{
    partial class hung
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
            this.hsA = new System.Windows.Forms.Label();
            this.hsB = new System.Windows.Forms.Label();
            this.kqpt = new System.Windows.Forms.Label();
            this.hsC = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ketqua = new System.Windows.Forms.Button();
            this.tb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hsA
            // 
            this.hsA.AutoSize = true;
            this.hsA.Location = new System.Drawing.Point(35, 50);
            this.hsA.Name = "hsA";
            this.hsA.Size = new System.Drawing.Size(52, 16);
            this.hsA.TabIndex = 1;
            this.hsA.Text = "he so A";
            // 
            // hsB
            // 
            this.hsB.AutoSize = true;
            this.hsB.Location = new System.Drawing.Point(35, 106);
            this.hsB.Name = "hsB";
            this.hsB.Size = new System.Drawing.Size(52, 16);
            this.hsB.TabIndex = 2;
            this.hsB.Text = "he so B";
            // 
            // kqpt
            // 
            this.kqpt.AutoSize = true;
            this.kqpt.Location = new System.Drawing.Point(35, 265);
            this.kqpt.Name = "kqpt";
            this.kqpt.Size = new System.Drawing.Size(65, 16);
            this.kqpt.TabIndex = 3;
            this.kqpt.Text = "ket qua pt";
            // 
            // hsC
            // 
            this.hsC.AutoSize = true;
            this.hsC.Location = new System.Drawing.Point(35, 156);
            this.hsC.Name = "hsC";
            this.hsC.Size = new System.Drawing.Size(52, 16);
            this.hsC.TabIndex = 4;
            this.hsC.Text = "he so C";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(145, 156);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(145, 259);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(367, 22);
            this.textBox4.TabIndex = 8;
            // 
            // ketqua
            // 
            this.ketqua.Location = new System.Drawing.Point(145, 341);
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(75, 23);
            this.ketqua.TabIndex = 9;
            this.ketqua.Text = "ket qua";
            this.ketqua.UseVisualStyleBackColor = true;
            this.ketqua.Click += new System.EventHandler(this.ketqua_Click);
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(368, 47);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(151, 43);
            this.tb.TabIndex = 10;
            this.tb.Text = "thong bao";
            this.tb.UseVisualStyleBackColor = true;
            this.tb.Click += new System.EventHandler(this.tb_Click);
            // 
            // hung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hsC);
            this.Controls.Add(this.kqpt);
            this.Controls.Add(this.hsB);
            this.Controls.Add(this.hsA);
            this.Name = "hung";
            this.Text = "hung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hsA;
        private System.Windows.Forms.Label hsB;
        private System.Windows.Forms.Label kqpt;
        private System.Windows.Forms.Label hsC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button ketqua;
        private System.Windows.Forms.Button tb;
    }
}

