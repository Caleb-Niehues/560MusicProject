namespace MusicProject.Views
{
    partial class uxLogInView
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
            this.uxWelcomeLabel = new System.Windows.Forms.Label();
            this.uxLogLabel = new System.Windows.Forms.Label();
            this.uxUserlabel = new System.Windows.Forms.Label();
            this.uxPasslabel = new System.Windows.Forms.Label();
            this.uxUsernameText = new System.Windows.Forms.TextBox();
            this.uxPasswordText = new System.Windows.Forms.TextBox();
            this.uxLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxWelcomeLabel
            // 
            this.uxWelcomeLabel.AutoSize = true;
            this.uxWelcomeLabel.Location = new System.Drawing.Point(153, 58);
            this.uxWelcomeLabel.Name = "uxWelcomeLabel";
            this.uxWelcomeLabel.Size = new System.Drawing.Size(152, 13);
            this.uxWelcomeLabel.TabIndex = 0;
            this.uxWelcomeLabel.Text = "Welcome to the Music Project!";
            // 
            // uxLogLabel
            // 
            this.uxLogLabel.AutoSize = true;
            this.uxLogLabel.Location = new System.Drawing.Point(173, 71);
            this.uxLogLabel.Name = "uxLogLabel";
            this.uxLogLabel.Size = new System.Drawing.Size(100, 13);
            this.uxLogLabel.TabIndex = 1;
            this.uxLogLabel.Text = "Please Login Below";
            // 
            // uxUserlabel
            // 
            this.uxUserlabel.AutoSize = true;
            this.uxUserlabel.Location = new System.Drawing.Point(95, 130);
            this.uxUserlabel.Name = "uxUserlabel";
            this.uxUserlabel.Size = new System.Drawing.Size(58, 13);
            this.uxUserlabel.TabIndex = 2;
            this.uxUserlabel.Text = "Username:";
            // 
            // uxPasslabel
            // 
            this.uxPasslabel.AutoSize = true;
            this.uxPasslabel.Location = new System.Drawing.Point(95, 182);
            this.uxPasslabel.Name = "uxPasslabel";
            this.uxPasslabel.Size = new System.Drawing.Size(56, 13);
            this.uxPasslabel.TabIndex = 3;
            this.uxPasslabel.Text = "Password:";
            // 
            // uxUsernameText
            // 
            this.uxUsernameText.Location = new System.Drawing.Point(156, 127);
            this.uxUsernameText.Name = "uxUsernameText";
            this.uxUsernameText.Size = new System.Drawing.Size(149, 20);
            this.uxUsernameText.TabIndex = 4;
            // 
            // uxPasswordText
            // 
            this.uxPasswordText.Location = new System.Drawing.Point(156, 179);
            this.uxPasswordText.Name = "uxPasswordText";
            this.uxPasswordText.Size = new System.Drawing.Size(149, 20);
            this.uxPasswordText.TabIndex = 5;
            // 
            // uxLoginButton
            // 
            this.uxLoginButton.Location = new System.Drawing.Point(198, 221);
            this.uxLoginButton.Name = "uxLoginButton";
            this.uxLoginButton.Size = new System.Drawing.Size(75, 23);
            this.uxLoginButton.TabIndex = 6;
            this.uxLoginButton.Text = "Login";
            this.uxLoginButton.UseVisualStyleBackColor = true;
            this.uxLoginButton.Click += new System.EventHandler(this.uxLoginButton_Click);
            // 
            // uxLogInView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 290);
            this.Controls.Add(this.uxLoginButton);
            this.Controls.Add(this.uxPasswordText);
            this.Controls.Add(this.uxUsernameText);
            this.Controls.Add(this.uxPasslabel);
            this.Controls.Add(this.uxUserlabel);
            this.Controls.Add(this.uxLogLabel);
            this.Controls.Add(this.uxWelcomeLabel);
            this.Name = "uxLogInView";
            this.Text = "LogInView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxWelcomeLabel;
        private System.Windows.Forms.Label uxLogLabel;
        private System.Windows.Forms.Label uxUserlabel;
        private System.Windows.Forms.Label uxPasslabel;
        private System.Windows.Forms.TextBox uxUsernameText;
        private System.Windows.Forms.TextBox uxPasswordText;
        private System.Windows.Forms.Button uxLoginButton;
    }
}