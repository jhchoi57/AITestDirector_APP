using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace program.View
{
    partial class StudentHomeView
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
            this.signupExitButton = new System.Windows.Forms.Button();
            this.signupMinimizeButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.myPagePanel = new System.Windows.Forms.Panel();
            this.testPanel = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // signupExitButton
            //
            this.signupExitButton.FlatAppearance.BorderSize = 0;
            this.signupExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupExitButton.Location = new System.Drawing.Point(349, 0);
            this.signupExitButton.Name = "signupExitButton";
            this.signupExitButton.Size = new System.Drawing.Size(30, 28);
            this.signupExitButton.TabStop = false;
            this.signupExitButton.Text = "✕";
            this.signupExitButton.Click += new System.EventHandler(this.signupExitButton_Click);
            // 
            // signupMinimizeButton
            // 
            this.signupMinimizeButton.FlatAppearance.BorderSize = 0;
            this.signupMinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupMinimizeButton.Location = new System.Drawing.Point(319, 0);
            this.signupMinimizeButton.Name = "signupMinimizeButton";
            this.signupMinimizeButton.Size = new System.Drawing.Size(30, 28);
            this.signupMinimizeButton.TabStop = false;
            this.signupMinimizeButton.Text = "_";
            this.signupMinimizeButton.Click += new System.EventHandler(this.signupMinimizeButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.testPanel);
            this.mainPanel.Controls.Add(this.myPagePanel);
            this.mainPanel.Size = new System.Drawing.Size(1264, 682);
            this.mainPanel.BackColor = Color.White;
            this.mainPanel.Name = "mainPanel";
            // 
            // myPagePanel
            // 
            this.myPagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.myPagePanel.Location = new System.Drawing.Point(885, 0);
            this.myPagePanel.Name = "myPagePanel";
            this.myPagePanel.Size = new System.Drawing.Size(379, 682);
            this.myPagePanel.Controls.Add(this.signupExitButton);
            this.myPagePanel.Controls.Add(this.signupMinimizeButton);
            // 
            // testPanel
            // 
            this.testPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.testPanel.Location = new System.Drawing.Point(0, 0);
            this.testPanel.Name = "testPanel";
            this.testPanel.Size = new System.Drawing.Size(885, 682);
            // 
            // StudentHomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.mainPanel);
            this.Name = "StudentHomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentHomeView";
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signupExitButton;
        private System.Windows.Forms.Button signupMinimizeButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel testPanel;
        private System.Windows.Forms.Panel myPagePanel;
    }
}