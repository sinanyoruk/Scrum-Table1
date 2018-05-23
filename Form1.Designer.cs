namespace SinanScrumTable
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStoryEkle = new System.Windows.Forms.Button();
            this.txtYeniStory = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtTaskTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTaskKategorileri = new System.Windows.Forms.ComboBox();
            this.cbStroy = new System.Windows.Forms.ComboBox();
            this.btnTaskEkle = new System.Windows.Forms.Button();
            this.txtTaskYapacakKisi = new System.Windows.Forms.TextBox();
            this.txtYeniTask = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbTasks = new System.Windows.Forms.ComboBox();
            this.panelgizli = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStoryEkle);
            this.groupBox1.Controls.Add(this.txtYeniStory);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Story Ekle";
            // 
            // btnStoryEkle
            // 
            this.btnStoryEkle.Location = new System.Drawing.Point(142, 42);
            this.btnStoryEkle.Name = "btnStoryEkle";
            this.btnStoryEkle.Size = new System.Drawing.Size(43, 32);
            this.btnStoryEkle.TabIndex = 1;
            this.btnStoryEkle.Text = "Ekle";
            this.btnStoryEkle.UseVisualStyleBackColor = true;
            this.btnStoryEkle.Click += new System.EventHandler(this.btnStoryEkle_Click);
            // 
            // txtYeniStory
            // 
            this.txtYeniStory.Location = new System.Drawing.Point(6, 19);
            this.txtYeniStory.Multiline = true;
            this.txtYeniStory.Name = "txtYeniStory";
            this.txtYeniStory.Size = new System.Drawing.Size(125, 75);
            this.txtYeniStory.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtTaskTarihi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbTaskKategorileri);
            this.groupBox2.Controls.Add(this.cbStroy);
            this.groupBox2.Controls.Add(this.btnTaskEkle);
            this.groupBox2.Controls.Add(this.txtTaskYapacakKisi);
            this.groupBox2.Controls.Add(this.txtYeniTask);
            this.groupBox2.Location = new System.Drawing.Point(227, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 198);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Task Ekle";
            // 
            // dtTaskTarihi
            // 
            this.dtTaskTarihi.Location = new System.Drawing.Point(142, 88);
            this.dtTaskTarihi.Name = "dtTaskTarihi";
            this.dtTaskTarihi.Size = new System.Drawing.Size(125, 20);
            this.dtTaskTarihi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Task Kategorisi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ait Olduğu Story:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Task\' in Yapılacağı Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Task\' i Yapacak Kişi: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Task Adı: ";
            // 
            // cbTaskKategorileri
            // 
            this.cbTaskKategorileri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTaskKategorileri.FormattingEnabled = true;
            this.cbTaskKategorileri.Location = new System.Drawing.Point(143, 126);
            this.cbTaskKategorileri.Name = "cbTaskKategorileri";
            this.cbTaskKategorileri.Size = new System.Drawing.Size(124, 21);
            this.cbTaskKategorileri.TabIndex = 2;
            // 
            // cbStroy
            // 
            this.cbStroy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStroy.FormattingEnabled = true;
            this.cbStroy.Location = new System.Drawing.Point(142, 163);
            this.cbStroy.Name = "cbStroy";
            this.cbStroy.Size = new System.Drawing.Size(124, 21);
            this.cbStroy.TabIndex = 2;
            // 
            // btnTaskEkle
            // 
            this.btnTaskEkle.Location = new System.Drawing.Point(282, 62);
            this.btnTaskEkle.Name = "btnTaskEkle";
            this.btnTaskEkle.Size = new System.Drawing.Size(37, 32);
            this.btnTaskEkle.TabIndex = 1;
            this.btnTaskEkle.Text = "Ekle";
            this.btnTaskEkle.UseVisualStyleBackColor = true;
            this.btnTaskEkle.Click += new System.EventHandler(this.btnTaskEkle_Click);
            // 
            // txtTaskYapacakKisi
            // 
            this.txtTaskYapacakKisi.Location = new System.Drawing.Point(142, 49);
            this.txtTaskYapacakKisi.Name = "txtTaskYapacakKisi";
            this.txtTaskYapacakKisi.Size = new System.Drawing.Size(125, 20);
            this.txtTaskYapacakKisi.TabIndex = 0;
            // 
            // txtYeniTask
            // 
            this.txtYeniTask.Location = new System.Drawing.Point(142, 19);
            this.txtYeniTask.Name = "txtYeniTask";
            this.txtYeniTask.Size = new System.Drawing.Size(125, 20);
            this.txtYeniTask.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(29, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Stories";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(175, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 52);
            this.label7.TabIndex = 1;
            this.label7.Text = "Not\r\nStarted";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(293, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 26);
            this.label8.TabIndex = 1;
            this.label8.Text = "In Progress";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(461, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 26);
            this.label9.TabIndex = 1;
            this.label9.Text = "Done";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(14, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 362);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.Location = new System.Drawing.Point(149, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 362);
            this.panel2.TabIndex = 2;
            this.panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel2_DragDrop);
            this.panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel2_DragEnter);
            this.panel2.DragLeave += new System.EventHandler(this.panel2_DragLeave);
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.Location = new System.Drawing.Point(286, 287);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 362);
            this.panel3.TabIndex = 2;
            this.panel3.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel3_DragDrop);
            this.panel3.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel3_DragEnter);
            this.panel3.DragLeave += new System.EventHandler(this.panel3_DragLeave);
            // 
            // panel4
            // 
            this.panel4.AllowDrop = true;
            this.panel4.Location = new System.Drawing.Point(421, 287);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(128, 362);
            this.panel4.TabIndex = 2;
            this.panel4.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel4_DragDrop);
            this.panel4.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel4_DragEnter);
            this.panel4.DragLeave += new System.EventHandler(this.panel4_DragLeave);
            // 
            // cbTasks
            // 
            this.cbTasks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTasks.FormattingEnabled = true;
            this.cbTasks.Location = new System.Drawing.Point(14, 133);
            this.cbTasks.Name = "cbTasks";
            this.cbTasks.Size = new System.Drawing.Size(124, 21);
            this.cbTasks.TabIndex = 2;
            // 
            // panelgizli
            // 
            this.panelgizli.Location = new System.Drawing.Point(100, 185);
            this.panelgizli.Name = "panelgizli";
            this.panelgizli.Size = new System.Drawing.Size(43, 25);
            this.panelgizli.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelgizli);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbTasks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Scrum Table";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStoryEkle;
        private System.Windows.Forms.TextBox txtYeniStory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbStroy;
        private System.Windows.Forms.Button btnTaskEkle;
        private System.Windows.Forms.TextBox txtYeniTask;
        private System.Windows.Forms.DateTimePicker dtTaskTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaskYapacakKisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTaskKategorileri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbTasks;
        private System.Windows.Forms.Panel panelgizli;
        private System.Windows.Forms.Button button1;
    }
}

