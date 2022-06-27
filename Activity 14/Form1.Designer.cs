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
            this.RadioButtonsCB = new System.Windows.Forms.CheckBox();
            this.CheckBoxesCB = new System.Windows.Forms.CheckBox();
            this.ListBoxesCB = new System.Windows.Forms.CheckBox();
            this.RadioButtonsRB = new System.Windows.Forms.RadioButton();
            this.CheckBoxesRB = new System.Windows.Forms.RadioButton();
            this.ListBoxesRB = new System.Windows.Forms.RadioButton();
            this.ListBoxGB = new System.Windows.Forms.GroupBox();
            this.CheckBoxGB = new System.Windows.Forms.GroupBox();
            this.RadioButtonGB = new System.Windows.Forms.GroupBox();
            this.RemoveTB = new System.Windows.Forms.TextBox();
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
            // RadioButtonsCB
            // 
            this.RadioButtonsCB.AutoSize = true;
            this.RadioButtonsCB.Location = new System.Drawing.Point(6, 19);
            this.RadioButtonsCB.Name = "RadioButtonsCB";
            this.RadioButtonsCB.Size = new System.Drawing.Size(93, 17);
            this.RadioButtonsCB.TabIndex = 1;
            this.RadioButtonsCB.Text = "Radio Buttons";
            this.RadioButtonsCB.UseVisualStyleBackColor = true;
            this.RadioButtonsCB.CheckedChanged += new System.EventHandler(this.RadioButtonSelected);
            // 
            // CheckBoxesCB
            // 
            this.CheckBoxesCB.AutoSize = true;
            this.CheckBoxesCB.Checked = true;
            this.CheckBoxesCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxesCB.Location = new System.Drawing.Point(6, 43);
            this.CheckBoxesCB.Name = "CheckBoxesCB";
            this.CheckBoxesCB.Size = new System.Drawing.Size(89, 17);
            this.CheckBoxesCB.TabIndex = 2;
            this.CheckBoxesCB.Text = "Check Boxes";
            this.CheckBoxesCB.UseVisualStyleBackColor = true;
            this.CheckBoxesCB.CheckedChanged += new System.EventHandler(this.CheckBoxSelected);
            // 
            // ListBoxesCB
            // 
            this.ListBoxesCB.AutoSize = true;
            this.ListBoxesCB.Location = new System.Drawing.Point(6, 67);
            this.ListBoxesCB.Name = "ListBoxesCB";
            this.ListBoxesCB.Size = new System.Drawing.Size(74, 17);
            this.ListBoxesCB.TabIndex = 3;
            this.ListBoxesCB.Text = "List Boxes";
            this.ListBoxesCB.UseVisualStyleBackColor = true;
            this.ListBoxesCB.CheckedChanged += new System.EventHandler(this.ListBoxSelected);
            // 
            // RadioButtonsRB
            // 
            this.RadioButtonsRB.AutoSize = true;
            this.RadioButtonsRB.Location = new System.Drawing.Point(6, 19);
            this.RadioButtonsRB.Name = "RadioButtonsRB";
            this.RadioButtonsRB.Size = new System.Drawing.Size(92, 17);
            this.RadioButtonsRB.TabIndex = 4;
            this.RadioButtonsRB.Text = "Radio Buttons";
            this.RadioButtonsRB.UseVisualStyleBackColor = true;
            this.RadioButtonsRB.CheckedChanged += new System.EventHandler(this.RadioButtonSelected);
            // 
            // CheckBoxesRB
            // 
            this.CheckBoxesRB.AutoSize = true;
            this.CheckBoxesRB.Checked = true;
            this.CheckBoxesRB.Location = new System.Drawing.Point(6, 42);
            this.CheckBoxesRB.Name = "CheckBoxesRB";
            this.CheckBoxesRB.Size = new System.Drawing.Size(88, 17);
            this.CheckBoxesRB.TabIndex = 5;
            this.CheckBoxesRB.TabStop = true;
            this.CheckBoxesRB.Text = "Check Boxes";
            this.CheckBoxesRB.UseVisualStyleBackColor = true;
            this.CheckBoxesRB.CheckedChanged += new System.EventHandler(this.CheckBoxSelected);
            // 
            // ListBoxesRB
            // 
            this.ListBoxesRB.AutoSize = true;
            this.ListBoxesRB.Location = new System.Drawing.Point(6, 66);
            this.ListBoxesRB.Name = "ListBoxesRB";
            this.ListBoxesRB.Size = new System.Drawing.Size(73, 17);
            this.ListBoxesRB.TabIndex = 6;
            this.ListBoxesRB.Text = "List Boxes";
            this.ListBoxesRB.UseVisualStyleBackColor = true;
            this.ListBoxesRB.CheckedChanged += new System.EventHandler(this.ListBoxSelected);
            // 
            // ListBoxGB
            // 
            this.ListBoxGB.Controls.Add(this.ListBox);
            this.ListBoxGB.Location = new System.Drawing.Point(242, 12);
            this.ListBoxGB.Name = "ListBoxGB";
            this.ListBoxGB.Size = new System.Drawing.Size(109, 100);
            this.ListBoxGB.TabIndex = 7;
            this.ListBoxGB.TabStop = false;
            this.ListBoxGB.Visible = false;
            // 
            // CheckBoxGB
            // 
            this.CheckBoxGB.Controls.Add(this.RadioButtonsCB);
            this.CheckBoxGB.Controls.Add(this.CheckBoxesCB);
            this.CheckBoxGB.Controls.Add(this.ListBoxesCB);
            this.CheckBoxGB.Location = new System.Drawing.Point(127, 12);
            this.CheckBoxGB.Name = "CheckBoxGB";
            this.CheckBoxGB.Size = new System.Drawing.Size(109, 100);
            this.CheckBoxGB.TabIndex = 8;
            this.CheckBoxGB.TabStop = false;
            // 
            // RadioButtonGB
            // 
            this.RadioButtonGB.Controls.Add(this.RadioButtonsRB);
            this.RadioButtonGB.Controls.Add(this.CheckBoxesRB);
            this.RadioButtonGB.Controls.Add(this.ListBoxesRB);
            this.RadioButtonGB.Location = new System.Drawing.Point(12, 12);
            this.RadioButtonGB.Name = "RadioButtonGB";
            this.RadioButtonGB.Size = new System.Drawing.Size(109, 100);
            this.RadioButtonGB.TabIndex = 9;
            this.RadioButtonGB.TabStop = false;
            this.RadioButtonGB.Visible = false;
            // 
            // RemoveTB
            // 
            this.RemoveTB.Location = new System.Drawing.Point(12, 119);
            this.RemoveTB.Name = "RemoveTB";
            this.RemoveTB.ReadOnly = true;
            this.RemoveTB.Size = new System.Drawing.Size(339, 20);
            this.RemoveTB.TabIndex = 10;
            this.RemoveTB.Text = "Try to remove all 3!";
            this.RemoveTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 151);
            this.Controls.Add(this.RemoveTB);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.CheckBox RadioButtonsCB;
        private System.Windows.Forms.CheckBox CheckBoxesCB;
        private System.Windows.Forms.CheckBox ListBoxesCB;
        private System.Windows.Forms.RadioButton RadioButtonsRB;
        private System.Windows.Forms.RadioButton CheckBoxesRB;
        private System.Windows.Forms.RadioButton ListBoxesRB;
        private System.Windows.Forms.GroupBox ListBoxGB;
        private System.Windows.Forms.GroupBox CheckBoxGB;
        private System.Windows.Forms.GroupBox RadioButtonGB;
        private System.Windows.Forms.TextBox RemoveTB;
    }
}

