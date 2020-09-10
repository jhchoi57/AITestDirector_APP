using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class ExamSubQuestionPanel : Panel
    {
        private Label questionLabel { get; set; }

        private ScorePanel examScorePanel { get; set; }

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

        public ExamSubQuestionPanel(CustomFonts customFonts, string question, int score) : base()
        {
            questionLabel = new Label();
            questionLabel.AutoSize = true;
            questionLabel.Font = customFonts.TextBoxFont();
            this.Controls.Add(questionLabel);
            questionLabel.Text = question;

            examScorePanel = new ScorePanel(customFonts);
            examScorePanel.ScoreTextBox.ReadOnly = true;
            this.Controls.Add(examScorePanel);
            examScorePanel.ScoreTextBox.Text = score.ToString();
        }
    }
}
