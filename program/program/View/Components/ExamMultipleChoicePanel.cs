using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class ExamMultipleChoicePanel : Panel
    {
        private RadioButton exampleRadioButton { get; set; }
        private Label exampleLabel { get; set; }
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
        public ExamMultipleChoicePanel(CustomFonts customFonts, string question) : base()
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
            this.Controls.Add(exampleLabel);
            exampleLabel.Text = question;

            this.Height = exampleLabel.Height + 10;
            exampleLabel.Location = new Point(15, (this.Height - exampleLabel.Height) / 2);
            exampleRadioButton.Location = new Point(0, (this.Height - exampleRadioButton.Height) / 2);
        }
    }
}
