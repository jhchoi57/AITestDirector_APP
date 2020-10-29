using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class SubQuestionPanel : Panel
    {
        private int type { get; set; }
        private TextBox questionTextBox { get; set; }

        private Label questionLabel { get; set; }

        private ScorePanel examScorePanel { get; set; }

        private QuestionDeleteButton deleteButton { get; set; }

        public int Type
        {
            get { return type; }
            set { type = value; }
        }
        public TextBox QuestionTextBox
        {
            get { return questionTextBox; }
            set { questionTextBox = value; }
        }

        public Label QuestionLabel
        {
            get { return questionLabel; }
            set { questionLabel = value; }
        }

        public ScorePanel ExamScorePanel
        {
            get { return examScorePanel; }
            set { examScorePanel = value; }
        }

        public QuestionDeleteButton DeleteButton
        {
            get { return deleteButton; }
            set { deleteButton = value; }
        }

        public SubQuestionPanel(CustomFonts customFonts) : base()
        {
            questionTextBox = new TextBox();
            questionTextBox.Multiline = true;
            questionTextBox.ScrollBars = ScrollBars.Vertical;
            questionTextBox.Font = customFonts.TextBoxFont();
            this.Controls.Add(questionTextBox);

            questionLabel = new Label();
            questionLabel.AutoSize = true;
            questionLabel.Visible = false;
            questionLabel.Font = customFonts.TextBoxFont();
            this.Controls.Add(questionLabel);

            examScorePanel = new ScorePanel(customFonts);
            this.Controls.Add(examScorePanel);

            deleteButton = new QuestionDeleteButton(customFonts);
            this.Controls.Add(deleteButton);
        }


    }
}
