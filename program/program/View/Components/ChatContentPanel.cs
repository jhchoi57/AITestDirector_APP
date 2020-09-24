using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class ChatContentPanel : Panel
    {
        private int type { get; set; }
        private Label contentLabel { get; set; }
        public int Type
        {
            get { return type; }
            set { type = value; }
        }
        public Label ContentLabel
        {
            get { return contentLabel; }
            set { contentLabel = value; }
        }
        public ChatContentPanel(CustomFonts customFonts, string content, int type) : base()
        {
            this.type = type;

            contentLabel = new Label();
            contentLabel.Location = new Point(5, 5);
            contentLabel.Text = content;
            contentLabel.ForeColor = Color.White;
            contentLabel.MaximumSize = new Size(180, 0);
            contentLabel.AutoSize = true;
            contentLabel.Font = customFonts.NormalFont();
            this.Controls.Add(contentLabel);

            if (type == 0)
            {
                this.BackColor = Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(55)))), ((int)(((byte)(113)))));
                contentLabel.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                contentLabel.ForeColor = Color.Black;
            }

            this.Size = new Size(contentLabel.Width + 10, contentLabel.Height + 10);
        }
    }
}
