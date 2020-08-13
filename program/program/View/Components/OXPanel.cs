using program.View.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace program.View
{
    class OXPanel : Panel
    {
        private Boolean answer { get; set; }
        private Button oButton { get; set; }
        private Button xButton { get; set; }
        private TextBox questionTextBox { get; set; }

        private Label questionLabel { get; set; }

        private ScorePanel examScorePanel { get; set; }

        private QuestionDeleteButton deleteButton { get; set; }

        public Boolean Answer
        {
            get { return answer; }
            set { answer = value; }
        }

        public Button OButton
        {
            get { return oButton; }
            set { oButton = value; }
        }

        public Button XButton
        {
            get { return xButton; }
            set { xButton = value; }
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

        public OXPanel() : base()
        {
            this.Size = new System.Drawing.Size(645, 45);

            answer = true;

            oButton = new Button();
            oButton.Text = "○";
            oButton.BackColor = Color.Black;
            oButton.ForeColor = Color.White;
            oButton.Location = new System.Drawing.Point(460, 8);
            oButton.Size = new System.Drawing.Size(30, 28);
            oButton.FlatAppearance.BorderSize = 0;
            oButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            oButton.Font = CustomFonts.TextBoxFont;
            this.Controls.Add(oButton);
            oButton.Click += oButton_Click_1;

            xButton = new Button();
            xButton.Text = "✕";
            xButton.Location = new System.Drawing.Point(490, 8);
            xButton.Size = new System.Drawing.Size(30, 28);
            xButton.FlatAppearance.BorderSize = 0;
            xButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            xButton.Font = CustomFonts.LabelFont;
            this.Controls.Add(xButton);
            xButton.Click += xButton_Click_1;

            questionTextBox = new TextBox();
            questionTextBox.Size = new System.Drawing.Size(450, 45);
            questionTextBox.Multiline = true;
            questionTextBox.ScrollBars = ScrollBars.Vertical;
            questionTextBox.Font = CustomFonts.TextBoxFont;
            this.Controls.Add(questionTextBox);
            questionTextBox.LostFocus += questionTextBox_LostFocus_1;

            questionLabel = new Label();
            questionLabel.AutoSize = true;
            questionLabel.MaximumSize = new System.Drawing.Size(500, 0);
            questionLabel.Visible = false;
            questionLabel.Font = CustomFonts.TextBoxFont;
            this.Controls.Add(questionLabel);
            questionLabel.Click += questionLabel_Click_1;

            examScorePanel = new ScorePanel();
            examScorePanel.Location = new Point(520, 8);
            this.Controls.Add(examScorePanel);

            deleteButton = new QuestionDeleteButton();
            deleteButton.Location = new Point(605, 8);
            this.Controls.Add(deleteButton);
            deleteButton.Click += deleteButton_Click_1;
        }

        private void questionTextBox_LostFocus_1 (object sender, EventArgs e)
        {
            string str = questionTextBox.Text.Replace(" ", "");
            str = str.Replace("\r", "");
            str = str.Replace("\n", "");
            if (str != "")
            {
                int margin = 10;
                int height;
                questionTextBox.Visible = false;
                questionLabel.Visible = true;
                questionLabel.Text = questionTextBox.Text;
                height = margin * 2 + questionLabel.Height;
                this.Height = height;
                questionLabel.Location = new Point(0, 10);
                oButton.Location = new Point(460, (height - oButton.Height) / 2);
                xButton.Location = new Point(490, (height - xButton.Height) / 2);
                examScorePanel.Location = new Point(520, (height - examScorePanel.Height) / 2);
            }
        }

        private void questionLabel_Click_1 (object sender, EventArgs e)
        {
            this.Height = questionTextBox.Height;
            oButton.Location = new Point(460, 8);
            xButton.Location = new Point(490, 8);
            examScorePanel.Location = new Point(520, 8);
            questionTextBox.Visible = true;
            questionLabel.Visible = false;
            questionTextBox.Focus();
        }

        private void oButton_Click_1 (object sender, EventArgs e)
        {
            answer = true;
            oButton.ForeColor = Color.White;
            oButton.BackColor = Color.Black;
            xButton.ForeColor = Color.Black;
            xButton.BackColor = Color.White;
        }

        private void xButton_Click_1 (object sender, EventArgs e)
        {
            answer = false;
            xButton.ForeColor = Color.White;
            xButton.BackColor = Color.Black;
            oButton.ForeColor = Color.Black;
            oButton.BackColor = Color.White;
        }

        private void deleteButton_Click_1 (object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
