using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class MultipleChoicePanel : Panel
    {
        private RadioButton exampleRadioButton { get; set; }
        private Label exampleLabel { get; set; }
        private TextBox exampleTextBox { get; set; }
        private QuestionDeleteButton deleteButton { get; set; }
        public RadioButton ExampleRadioButton
        {
            get { return exampleRadioButton; }
            set { exampleRadioButton = value; }
        }
        public Label ExampleLabel
        {
            get { return exampleLabel; }
            set { exampleLabel = value; }
        }
        public TextBox ExampleTextBox
        {
            get { return exampleTextBox; }
            set { exampleTextBox = value; }
        }
        public QuestionDeleteButton DeleteButton
        {
            get { return deleteButton; }
            set { deleteButton = value; }
        }
        public MultipleChoicePanel(CustomFonts customFonts) : base()
        {
            this.Size = new Size(450, 50);

            exampleRadioButton = new RadioButton();
            exampleRadioButton.Font = customFonts.TextBoxFont();
            exampleRadioButton.Size = new Size(15, 28);
            exampleRadioButton.Location = new Point(0, 11);
            this.Controls.Add(exampleRadioButton);

            exampleLabel = new Label();
            exampleLabel.MaximumSize = new Size(390, 0);
            exampleLabel.Location = new Point(15, 0);
            exampleLabel.AutoSize = true;
            exampleLabel.Font = customFonts.TextBoxFont();
            exampleLabel.Visible = false;
            this.Controls.Add(exampleLabel);
            exampleLabel.Click += exampleLabel_Click_1;

            exampleTextBox = new TextBox();
            exampleTextBox.Font = customFonts.TextBoxFont();
            exampleTextBox.Size = new Size(390, 50);
            exampleTextBox.Location = new Point(15, 0);
            exampleTextBox.Multiline = true;
            exampleTextBox.ScrollBars = ScrollBars.Vertical;
            this.Controls.Add(exampleTextBox);
            exampleTextBox.BringToFront();
            exampleTextBox.LostFocus += exampleTextBox_LostFocus_1;

            deleteButton = new QuestionDeleteButton(customFonts);
            deleteButton.Location = new Point(410, 11);
            this.Controls.Add(DeleteButton);
        }

        private void exampleTextBox_LostFocus_1(object sender, EventArgs e)
        {
            string str = exampleTextBox.Text.Replace(" ", "");
            str = str.Replace("\r", "");
            str = str.Replace("\n", "");
            if (str != "")
            {
                exampleLabel.Text = exampleTextBox.Text;
                this.Height = exampleLabel.Height + 10;
                exampleLabel.Location = new Point(15, (this.Height - exampleLabel.Height) / 2);
                deleteButton.Location = new Point(410, (this.Height - deleteButton.Height) / 2);
                exampleRadioButton.Location = new Point(0, (this.Height - exampleRadioButton.Height) / 2);
                exampleTextBox.Visible = false;
                exampleLabel.Visible = true;
            }
        }
        private void exampleLabel_Click_1(object sender, EventArgs e)
        {
            this.Height = 50;
            deleteButton.Location = new Point(410, (this.Height - deleteButton.Height) / 2);
            exampleRadioButton.Location = new Point(0, (this.Height - exampleRadioButton.Height) / 2);
            exampleTextBox.Visible = true;
            exampleLabel.Visible = false;
            exampleTextBox.Focus();
        }
    }
}
