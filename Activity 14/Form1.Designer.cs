namespace Activity_14
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
            this.ListBox = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.ListBoxGB = new System.Windows.Forms.GroupBox();
            this.CheckBoxGB = new System.Windows.Forms.GroupBox();
            this.RadioButtonGB = new System.Windows.Forms.GroupBox();
            this.ListBoxGB.SuspendLayout();
            this.CheckBoxGB.SuspendLayout();
            this.RadioButtonGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Items.AddRange(new object[] {
            "Radio Buttons",
            "Check Boxes",
            "List Boxes"});
            this.ListBox.Location = new System.Drawing.Point(6, 19);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(93, 69);
            this.ListBox.TabIndex = 0;
            this.ListBox.SelectedValueChanged += new System.EventHandler(this.ListBox_SelectedValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Radio Buttons";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 43);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(89, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Check Boxes";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 67);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(74, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "List Boxes";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Radio Buttons";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Check Boxes";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 66);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "List Boxes";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // ListBoxGB
            // 
            this.ListBoxGB.Controls.Add(this.ListBox);
            this.ListBoxGB.Location = new System.Drawing.Point(12, 224);
            this.ListBoxGB.Name = "ListBoxGB";
            this.ListBoxGB.Size = new System.Drawing.Size(109, 100);
            this.ListBoxGB.TabIndex = 7;
            this.ListBoxGB.TabStop = false;
            // 
            // CheckBoxGB
            // 
            this.CheckBoxGB.Controls.Add(this.checkBox1);
            this.CheckBoxGB.Controls.Add(this.checkBox2);
            this.CheckBoxGB.Controls.Add(this.checkBox3);
            this.CheckBoxGB.Location = new System.Drawing.Point(12, 118);
            this.CheckBoxGB.Name = "CheckBoxGB";
            this.CheckBoxGB.Size = new System.Drawing.Size(109, 100);
            this.CheckBoxGB.TabIndex = 8;
            this.CheckBoxGB.TabStop = false;
            // 
            // RadioButtonGB
            // 
            this.RadioButtonGB.Controls.Add(this.radioButton1);
            this.RadioButtonGB.Controls.Add(this.radioButton2);
            this.RadioButtonGB.Controls.Add(this.radioButton3);
            this.RadioButtonGB.Location = new System.Drawing.Point(12, 12);
            this.RadioButtonGB.Name = "RadioButtonGB";
            this.RadioButtonGB.Size = new System.Drawing.Size(109, 100);
            this.RadioButtonGB.TabIndex = 9;
            this.RadioButtonGB.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 474);
            this.Controls.Add(this.RadioButtonGB);
            this.Controls.Add(this.CheckBoxGB);
            this.Controls.Add(this.ListBoxGB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ListBoxGB.ResumeLayout(false);
            this.CheckBoxGB.ResumeLayout(false);
            this.CheckBoxGB.PerformLayout();
            this.RadioButtonGB.ResumeLayout(false);
            this.RadioButtonGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox ListBoxGB;
        private System.Windows.Forms.GroupBox CheckBoxGB;
        private System.Windows.Forms.GroupBox RadioButtonGB;
    }
}

