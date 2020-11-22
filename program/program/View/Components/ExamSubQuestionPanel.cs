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
        private int type { get; set; }
        private Label questionLabel { get; set; }

        private ScorePanel examScorePanel { get; set; }

        public int Type 
        { 
            get { return type; } 
            set { type = value; }
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

        public ExamSubQuestionPanel(CustomFonts customFonts, string question, int score) : base()
        {
            questionLabel = new Label();
            questionLabel.Text = question;
            questionLabel.AutoSize = true;
            questionLabel.Font = customFonts.TextBoxFont();
            this.Controls.Add(questionLabel);

            examScorePanel = new ScorePanel(customFonts);
            examScorePanel.ScoreTextBox.ReadOnly = true;
            this.Controls.Add(examScorePanel);
            examScorePanel.ScoreTextBox.Text = score.ToString();
        }
    }
}
