using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Activity_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string selected = "RadioButton";
        
        private void ListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ListBox.Text == "Radio Buttons")
                RadioButtonSelected((ListBox)sender, (EventArgs)e);
            else if (ListBox.Text == "Check Boxes")
                CheckBoxSelected((ListBox)sender, (EventArgs)e);
            else if (ListBox.Text == "List Boxes")
                ListBoxSelected((ListBox)sender, (EventArgs)e);
        }
        private void RadioButtonSelected(object sender, EventArgs e)
        {
            if (selected != "RadioButton")
            {
                RadioButtonGB.Visible = true;
                RadioButtonsRB.Checked = true;
                RadioButtonsCB.Checked = true;
                ListBox.SelectedIndex = 0;
                selected = "RadioButton";
                Console.WriteLine(selected);
            }
            
        }

        private void CheckBoxSelected(object sender, EventArgs e)
        {
            if (selected != "CheckBox")
            {
                CheckBoxGB.Visible = true;
                CheckBoxesRB.Checked = true;
                CheckBoxesCB.Checked = true;
                ListBox.SelectedIndex = 1;
                selected = "CheckBox";
                Console.WriteLine(selected);
            }
        }

        private void ListBoxSelected(object sender, EventArgs e)
        {
            if (selected != "ListBox")
            {
                ListBoxGB.Visible = true;
                ListBoxesRB.Checked = true;
                ListBoxesCB.Checked = true;
                ListBox.SelectedIndex = 2;
                selected = "ListBox";
                Console.WriteLine(selected);
            }
        }
    }
}
