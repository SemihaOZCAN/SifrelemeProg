namespace Sifreli_Veriler
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAD = new System.Windows.Forms.TextBox();
            this.textBoxSOYAD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMAIL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSIFRE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHESAPNO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSIFRECOZ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "AD:";
            // 
            // textBoxAD
            // 
            this.textBoxAD.Location = new System.Drawing.Point(112, 40);
            this.textBoxAD.Name = "textBoxAD";
            this.textBoxAD.Size = new System.Drawing.Size(214, 30);
            this.textBoxAD.TabIndex = 2;
            // 
            // textBoxSOYAD
            // 
            this.textBoxSOYAD.Location = new System.Drawing.Point(112, 79);
            this.textBoxSOYAD.Name = "textBoxSOYAD";
            this.textBoxSOYAD.Size = new System.Drawing.Size(214, 30);
            this.textBoxSOYAD.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "SOYAD:";
            // 
            // textBoxMAIL
            // 
            this.textBoxMAIL.Location = new System.Drawing.Point(112, 119);
            this.textBoxMAIL.Name = "textBoxMAIL";
            this.textBoxMAIL.Size = new System.Drawing.Size(214, 30);
            this.textBoxMAIL.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "MAIL:";
            // 
            // textBoxSIFRE
            // 
            this.textBoxSIFRE.Location = new System.Drawing.Point(480, 40);
            this.textBoxSIFRE.Name = "textBoxSIFRE";
            this.textBoxSIFRE.Size = new System.Drawing.Size(214, 30);
            this.textBoxSIFRE.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "ŞİFRE:";
            // 
            // textBoxHESAPNO
            // 
            this.textBoxHESAPNO.Location = new System.Drawing.Point(480, 94);
            this.textBoxHESAPNO.Name = "textBoxHESAPNO";
            this.textBoxHESAPNO.Size = new System.Drawing.Size(214, 30);
            this.textBoxHESAPNO.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "HESAP NO:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(522, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 51);
            this.button1.TabIndex = 11;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonKAYDET_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(769, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            // 
            // buttonSIFRECOZ
            // 
            this.buttonSIFRECOZ.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSIFRECOZ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSIFRECOZ.Location = new System.Drawing.Point(859, 119);
            this.buttonSIFRECOZ.Name = "buttonSIFRECOZ";
            this.buttonSIFRECOZ.Size = new System.Drawing.Size(145, 51);
            this.buttonSIFRECOZ.TabIndex = 13;
            this.buttonSIFRECOZ.Text = "ŞİFRE ÇÖZ";
            this.buttonSIFRECOZ.UseVisualStyleBackColor = false;
            this.buttonSIFRECOZ.Click += new System.EventHandler(this.buttonSIFRECOZ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 537);
            this.Controls.Add(this.buttonSIFRECOZ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxHESAPNO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSIFRE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMAIL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSOYAD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAD;
        private System.Windows.Forms.TextBox textBoxSOYAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMAIL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSIFRE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHESAPNO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSIFRECOZ;
    }
}

