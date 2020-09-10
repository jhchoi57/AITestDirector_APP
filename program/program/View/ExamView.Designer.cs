using program.View.Components;
using System.Windows.Forms;

namespace program.View
{
    partial class ExamView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.examPanel = new Panel();
            this.examInfoPanel = new Panel();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.examPanel);
            this.mainPanel.Controls.Add(this.examInfoPanel);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1264, 682);
            this.mainPanel.TabIndex = 0;
            // 
            // examPanel
            // 
            this.examPanel.AutoScroll = true;
            this.examPanel.Location = new System.Drawing.Point(0, 0);
            this.examPanel.Name = "examPanel";
            this.examPanel.Size = new System.Drawing.Size(885, 640);
            this.examPanel.TabIndex = 0;
            // 
            // examInfoPanel
            // 
            this.examInfoPanel.BackColor = System.Drawing.Color.White;
            this.examInfoPanel.Location = new System.Drawing.Point(885, 0);
            this.examInfoPanel.Name = "examInfoPanel";
            this.examInfoPanel.Size = new System.Drawing.Size(379, 682);
            this.examInfoPanel.TabIndex = 1;
            // 
            // ExamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.mainPanel);
            this.Name = "ExamView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExamView";
            this.Load += new System.EventHandler(this.ExamView_Load1);
            this.ResumeLayout(false);

        }

        #endregion

        // Panels
        private System.Windows.Forms.Panel mainPanel;
        private Panel examPanel;
        private Panel examInfoPanel;

        private ExamPageNavigationPanel examPageNavigationPanel;

        //Buttons

        private ExitButton exitButton;
        private MinimizeButton minimizeButton;
    }
}