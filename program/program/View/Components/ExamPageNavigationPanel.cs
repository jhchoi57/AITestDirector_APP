using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class ExamPageNavigationPanel : Panel
    {
        private Button pageLeftButton { get; set; }
        private Button pageRightButton { get; set; }
        private Button addPageButton { get; set; }
        private Button removePageButton { get; set; }
        private Panel nowPagePanel;
        private TextBox nowPageTextBox { get; set; }
        private Label pageSlashLabel;
        private Label wholePageLabel { get; set; }

        public Button PageLeftButton
        {
            get { return pageLeftButton; }
            set { pageLeftButton = value; }
        }
        public Button PageRightButton
        {
            get { return pageRightButton; }
            set { pageRightButton = value; }
        }
        public Button AddPageButton
        {
            get { return addPageButton; }
            set { addPageButton = value; }
        }
        public Button RemovePageButton
        {
            get { return removePageButton; }
            set { removePageButton = value; }
        }
        public TextBox NowPageTextBox
        {
            get { return nowPageTextBox; }
            set { nowPageTextBox = value; }
        }
        public Label WholePageLabel
        {
            get { return wholePageLabel; }
            set { wholePageLabel = value; }
        }

        public ExamPageNavigationPanel(CustomFonts customFonts) : base()
        {
            this.Name = "pageNavigationPanel";
            this.Size = new System.Drawing.Size(885, 42);
            this.TabIndex = 2;
            // 
            // pageLeftButton
            // 
            this.pageLeftButton = new Button();
            this.pageLeftButton.FlatAppearance.BorderSize = 0;
            this.pageLeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageLeftButton.ForeColor = System.Drawing.Color.Gray;
            this.pageLeftButton.Location = new System.Drawing.Point(362, 1);
            this.pageLeftButton.Name = "pageLeftButton";
            this.pageLeftButton.Size = new System.Drawing.Size(40, 40);
            this.pageLeftButton.Text = "<";
            // 
            // pageRightButton
            // 
            this.pageRightButton = new Button();
            this.pageRightButton.FlatAppearance.BorderSize = 0;
            this.pageRightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageRightButton.ForeColor = System.Drawing.Color.Gray;
            this.pageRightButton.Location = new System.Drawing.Point(482, 1);
            this.pageRightButton.Name = "pageRightButton";
            this.pageRightButton.Size = new System.Drawing.Size(40, 40);
            this.pageRightButton.Text = ">";
            // 
            // nowPagePanel
            // 
            this.nowPagePanel = new Panel();
            this.nowPagePanel.BackColor = System.Drawing.Color.White;
            this.nowPagePanel.Location = new System.Drawing.Point(409, 8);
            this.nowPagePanel.Name = "nowPagePanel";
            this.nowPagePanel.Size = new System.Drawing.Size(28, 26);
            // 
            // nowPageTextBox
            // 
            this.nowPageTextBox = new TextBox();
            this.nowPageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nowPageTextBox.Location = new System.Drawing.Point(5, 4);
            this.nowPageTextBox.Name = "nowPageTextBox";
            this.nowPageTextBox.Size = new System.Drawing.Size(18, 14);
            this.nowPageTextBox.Text = "1";
            this.nowPageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pageSlashLabel
            // 
            this.pageSlashLabel = new Label();
            this.pageSlashLabel.Location = new System.Drawing.Point(437, 10);
            this.pageSlashLabel.Name = "pageSlashLabel";
            this.pageSlashLabel.Size = new System.Drawing.Size(10, 21);
            this.pageSlashLabel.Text = "/";
            // 
            // wholePageLabel
            //
            this.wholePageLabel = new Label();
            this.wholePageLabel.Size = new Size(36, 21);
            this.wholePageLabel.Location = new Point(449, 12);
            this.wholePageLabel.Text = "1";
            this.Controls.Add(this.wholePageLabel);

            // 
            // addPageButtonnowPagePanel
            // 
            this.addPageButton = new Button();
            this.addPageButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.addPageButton.FlatAppearance.BorderSize = 0;
            this.addPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPageButton.Location = new System.Drawing.Point(655, 0);
            this.addPageButton.Name = "addPageButton";
            this.addPageButton.Size = new System.Drawing.Size(115, 42);
            this.addPageButton.Text = "+ 페이지 추가";
            this.addPageButton.UseVisualStyleBackColor = false;
            // 
            // removePageButton
            // 
            this.removePageButton = new Button();
            this.removePageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.removePageButton.FlatAppearance.BorderSize = 0;
            this.removePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePageButton.ForeColor = System.Drawing.Color.White;
            this.removePageButton.Location = new System.Drawing.Point(770, 0);
            this.removePageButton.Name = "removePageButton";
            this.removePageButton.Size = new System.Drawing.Size(115, 42);
            this.removePageButton.Text = "- 페이지 제거";
            this.removePageButton.UseVisualStyleBackColor = false;

            this.Controls.Add(this.pageLeftButton);
            this.Controls.Add(this.pageRightButton);
            this.Controls.Add(this.nowPagePanel);
            this.Controls.Add(this.pageSlashLabel);
            this.Controls.Add(this.wholePageLabel);
            this.Controls.Add(this.addPageButton);
            this.Controls.Add(this.removePageButton);
            this.nowPagePanel.Controls.Add(this.nowPageTextBox);

            this.pageLeftButton.Font = customFonts.LabelFont();
            this.pageRightButton.Font = customFonts.LabelFont();
            this.nowPageTextBox.Font = customFonts.TextBoxFont();
            this.pageSlashLabel.Font = customFonts.LabelFont();
            this.wholePageLabel.Font = customFonts.TextBoxFont();
            this.addPageButton.Font = customFonts.TextBoxFont();
            this.removePageButton.Font = customFonts.TextBoxFont();
        }
    }
}
