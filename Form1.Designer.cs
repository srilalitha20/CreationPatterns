namespace AbstractFactory
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.britishRadioBtn = new System.Windows.Forms.RadioButton();
            this.americanRadioBtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dinerRadioBtn = new System.Windows.Forms.RadioButton();
            this.eveningRadioBtn = new System.Windows.Forms.RadioButton();
            this.allDayRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.htmlRadioBtn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.plainTextRadioBtn = new System.Windows.Forms.RadioButton();
            this.xmlRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Menu!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Results will be displayed here.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose Cuisine:";
            // 
            // britishRadioBtn
            // 
            this.britishRadioBtn.AutoSize = true;
            this.britishRadioBtn.Location = new System.Drawing.Point(218, 48);
            this.britishRadioBtn.Name = "britishRadioBtn";
            this.britishRadioBtn.Size = new System.Drawing.Size(53, 17);
            this.britishRadioBtn.TabIndex = 3;
            this.britishRadioBtn.TabStop = true;
            this.britishRadioBtn.Text = "British";
            this.britishRadioBtn.UseVisualStyleBackColor = true;
            // 
            // americanRadioBtn
            // 
            this.americanRadioBtn.AutoSize = true;
            this.americanRadioBtn.Location = new System.Drawing.Point(298, 48);
            this.americanRadioBtn.Name = "americanRadioBtn";
            this.americanRadioBtn.Size = new System.Drawing.Size(69, 17);
            this.americanRadioBtn.TabIndex = 4;
            this.americanRadioBtn.TabStop = true;
            this.americanRadioBtn.Text = "American";
            this.americanRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choose the type of Restaurant:";
            // 
            // dinerRadioBtn
            // 
            this.dinerRadioBtn.AutoSize = true;
            this.dinerRadioBtn.Location = new System.Drawing.Point(6, 19);
            this.dinerRadioBtn.Name = "dinerRadioBtn";
            this.dinerRadioBtn.Size = new System.Drawing.Size(50, 17);
            this.dinerRadioBtn.TabIndex = 6;
            this.dinerRadioBtn.TabStop = true;
            this.dinerRadioBtn.Text = "Diner";
            this.dinerRadioBtn.UseVisualStyleBackColor = true;
            // 
            // eveningRadioBtn
            // 
            this.eveningRadioBtn.AutoSize = true;
            this.eveningRadioBtn.Location = new System.Drawing.Point(77, 19);
            this.eveningRadioBtn.Name = "eveningRadioBtn";
            this.eveningRadioBtn.Size = new System.Drawing.Size(64, 17);
            this.eveningRadioBtn.TabIndex = 7;
            this.eveningRadioBtn.TabStop = true;
            this.eveningRadioBtn.Text = "Evening";
            this.eveningRadioBtn.UseVisualStyleBackColor = true;
            // 
            // allDayRadioBtn
            // 
            this.allDayRadioBtn.AutoSize = true;
            this.allDayRadioBtn.Location = new System.Drawing.Point(167, 19);
            this.allDayRadioBtn.Name = "allDayRadioBtn";
            this.allDayRadioBtn.Size = new System.Drawing.Size(58, 17);
            this.allDayRadioBtn.TabIndex = 8;
            this.allDayRadioBtn.TabStop = true;
            this.allDayRadioBtn.Text = "All Day";
            this.allDayRadioBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dinerRadioBtn);
            this.groupBox1.Controls.Add(this.allDayRadioBtn);
            this.groupBox1.Controls.Add(this.eveningRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(330, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 64);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // htmlRadioBtn
            // 
            this.htmlRadioBtn.AutoSize = true;
            this.htmlRadioBtn.Location = new System.Drawing.Point(86, 32);
            this.htmlRadioBtn.Name = "htmlRadioBtn";
            this.htmlRadioBtn.Size = new System.Drawing.Size(55, 17);
            this.htmlRadioBtn.TabIndex = 10;
            this.htmlRadioBtn.TabStop = true;
            this.htmlRadioBtn.Text = "HTML";
            this.htmlRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Choose output format";
            // 
            // plainTextRadioBtn
            // 
            this.plainTextRadioBtn.AutoSize = true;
            this.plainTextRadioBtn.Location = new System.Drawing.Point(6, 32);
            this.plainTextRadioBtn.Name = "plainTextRadioBtn";
            this.plainTextRadioBtn.Size = new System.Drawing.Size(72, 17);
            this.plainTextRadioBtn.TabIndex = 12;
            this.plainTextRadioBtn.TabStop = true;
            this.plainTextRadioBtn.Text = "Plain Text";
            this.plainTextRadioBtn.UseVisualStyleBackColor = true;
            // 
            // xmlRadioBtn
            // 
            this.xmlRadioBtn.AutoSize = true;
            this.xmlRadioBtn.Location = new System.Drawing.Point(167, 32);
            this.xmlRadioBtn.Name = "xmlRadioBtn";
            this.xmlRadioBtn.Size = new System.Drawing.Size(47, 17);
            this.xmlRadioBtn.TabIndex = 13;
            this.xmlRadioBtn.TabStop = true;
            this.xmlRadioBtn.Text = "XML";
            this.xmlRadioBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.plainTextRadioBtn);
            this.groupBox2.Controls.Add(this.xmlRadioBtn);
            this.groupBox2.Controls.Add(this.htmlRadioBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 73);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Save File!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(681, 20);
            this.textBox1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(708, 331);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.americanRadioBtn);
            this.Controls.Add(this.britishRadioBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Restaurant Menu Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton britishRadioBtn;
        private System.Windows.Forms.RadioButton americanRadioBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton dinerRadioBtn;
        private System.Windows.Forms.RadioButton eveningRadioBtn;
        private System.Windows.Forms.RadioButton allDayRadioBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton htmlRadioBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton plainTextRadioBtn;
        private System.Windows.Forms.RadioButton xmlRadioBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

