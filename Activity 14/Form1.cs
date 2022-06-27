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

        public string selected = "";    //Global variable for selected item
        
        private void ListBox_SelectedValueChanged(object sender, EventArgs e) //For the ListBox 
        {
            if (ListBox.Text == "Radio Buttons")
                RadioButtonSelected((ListBox)sender, e);
            else if (ListBox.Text == "Check Boxes")
                CheckBoxSelected((ListBox)sender, e);
            else if (ListBox.Text == "List Boxes")
                ListBoxSelected((ListBox)sender, e);
        }

        private void RadioButtonSelected(object sender, EventArgs e) //For the section of Radio Buttons
        {
            if (selected != "Radio Buttons")
            {
                RadioButtonGB.Visible = true;
                RadioButtonsRB.Checked = true;
                RadioButtonsCB.Checked = true;
                ListBox.SelectedIndex = 0;
                selected = RadioButtonsRB.Text;
                RemoveTB.Text = selected + " is currently selected.";
            }
            RadioButtonGB.Visible = RadioButtonsCB.Checked;
            CheckBoxGB.Visible = CheckBoxesCB.Checked;
            ListBoxGB.Visible = ListBoxesCB.Checked;
        }

        private void CheckBoxSelected(object sender, EventArgs e) //For the section of Check Boxes
        {
            if (selected != "Check Boxes")
            {
                CheckBoxGB.Visible = true;
                CheckBoxesRB.Checked = true;
                CheckBoxesCB.Checked = true;
                ListBox.SelectedIndex = 1;
                selected = CheckBoxesCB.Text;
                RemoveTB.Text = selected + " is currently selected.";
            }

            RadioButtonGB.Visible = RadioButtonsCB.Checked;
            CheckBoxGB.Visible = CheckBoxesCB.Checked;
            ListBoxGB.Visible = ListBoxesCB.Checked;

            if ((!RadioButtonsCB.Checked && !CheckBoxesCB.Checked && !ListBoxesCB.Checked)) // Secret for closing the program (apart from the close button)
                Close();
        }

        private void ListBoxSelected(object sender, EventArgs e) //For the section of List Box Items
        {
            if (selected != "List Boxes")
            {
                ListBoxGB.Visible = true;
                ListBoxesRB.Checked = true;
                ListBoxesCB.Checked = true;
                ListBox.SelectedIndex = 2;
                selected = ListBox.Text;
                RemoveTB.Text = selected + " is currently selected.";
            }
            RadioButtonGB.Visible = RadioButtonsCB.Checked;
            CheckBoxGB.Visible = CheckBoxesCB.Checked;
            ListBoxGB.Visible = ListBoxesCB.Checked;
        }
    }
}