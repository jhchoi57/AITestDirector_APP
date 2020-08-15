using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class QuestionKindPanel : Panel
    {
        private Label questionKindLabel { get; set; }
        private ComboBox questionKindComboBox { get; set; }

        public Label QuestionKindLabel
        {
            get { return questionKindLabel; }
            set { questionKindLabel = value; }
        }

        public ComboBox QuestionKindComboBox
        {
            get { return questionKindComboBox; }
            set { questionKindComboBox = value; }
        }

        public QuestionKindPanel(CustomFonts customFonts) : base()
        {
            string[] questionItems = { "○/✕", "단답형", "서술형", "선다형", "빈 칸" };

            this.Size = new Size(157, 27);

            questionKindLabel = new Label();
            questionKindLabel.Location = new Point(0, 4);
            questionKindLabel.Size = new Size(82, 21);
            questionKindLabel.Text = "출제 유형:";
            questionKindLabel.Font = customFonts.LabelFont();
            Controls.Add(this.questionKindLabel);

            questionKindComboBox = new ComboBox();
            questionKindComboBox.Location = new System.Drawing.Point(82, 0);
            questionKindComboBox.Name = "questionKindComboBox";
            questionKindComboBox.Size = new System.Drawing.Size(75, 20);
            questionKindComboBox.Font = customFonts.LabelFont();
            questionKindComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Controls.Add(this.questionKindComboBox);

            questionKindComboBox.Items.AddRange(questionItems);
            questionKindComboBox.SelectedIndex = 0;
        }
    }
}
