namespace MusicProject.Views
{
    partial class LogInView
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
            this.uxDeleteUser = new System.Windows.Forms.Button();
            this.uxCreateUser = new System.Windows.Forms.Button();
            this.uxUserWeight = new System.Windows.Forms.TextBox();
            this.uxWeightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxWelcomeLabel
            // 
            this.uxWelcomeLabel.AutoSize = true;
            this.uxWelcomeLabel.Location = new System.Drawing.Point(204, 71);
            this.uxWelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxWelcomeLabel.Name = "uxWelcomeLabel";
            this.uxWelcomeLabel.Size = new System.Drawing.Size(197, 17);
            this.uxWelcomeLabel.TabIndex = 0;
            this.uxWelcomeLabel.Text = "Welcome to the Music Project!";
            // 
            // uxLogLabel
            // 
            this.uxLogLabel.AutoSize = true;
            this.uxLogLabel.Location = new System.Drawing.Point(231, 87);
            this.uxLogLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLogLabel.Name = "uxLogLabel";
            this.uxLogLabel.Size = new System.Drawing.Size(144, 17);
            this.uxLogLabel.TabIndex = 1;
            this.uxLogLabel.Text = "Enter User Info Below";
            // 
            // uxUserlabel
            // 
            this.uxUserlabel.AutoSize = true;
            this.uxUserlabel.Location = new System.Drawing.Point(126, 128);
            this.uxUserlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxUserlabel.Name = "uxUserlabel";
            this.uxUserlabel.Size = new System.Drawing.Size(77, 17);
            this.uxUserlabel.TabIndex = 2;
            this.uxUserlabel.Text = "Username:";
            // 
            // uxPasslabel
            // 
            this.uxPasslabel.AutoSize = true;
            this.uxPasslabel.Location = new System.Drawing.Point(126, 192);
            this.uxPasslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxPasslabel.Name = "uxPasslabel";
            this.uxPasslabel.Size = new System.Drawing.Size(73, 17);
            this.uxPasslabel.TabIndex = 3;
            this.uxPasslabel.Text = "Password:";
            // 
            // uxUsernameText
            // 
            this.uxUsernameText.Location = new System.Drawing.Point(207, 124);
            this.uxUsernameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxUsernameText.Name = "uxUsernameText";
            this.uxUsernameText.Size = new System.Drawing.Size(197, 22);
            this.uxUsernameText.TabIndex = 4;
            // 
            // uxPasswordText
            // 
            this.uxPasswordText.Location = new System.Drawing.Point(207, 188);
            this.uxPasswordText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxPasswordText.Name = "uxPasswordText";
            this.uxPasswordText.PasswordChar = '*';
            this.uxPasswordText.Size = new System.Drawing.Size(197, 22);
            this.uxPasswordText.TabIndex = 5;
            // 
            // uxLoginButton
            // 
            this.uxLoginButton.Location = new System.Drawing.Point(135, 240);
            this.uxLoginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxLoginButton.Name = "uxLoginButton";
            this.uxLoginButton.Size = new System.Drawing.Size(100, 28);
            this.uxLoginButton.TabIndex = 6;
            this.uxLoginButton.Text = "Login";
            this.uxLoginButton.UseVisualStyleBackColor = true;
            this.uxLoginButton.Click += new System.EventHandler(this.uxLoginButton_Click);
            // 
            // uxDeleteUser
            // 
            this.uxDeleteUser.Location = new System.Drawing.Point(351, 240);
            this.uxDeleteUser.Margin = new System.Windows.Forms.Padding(4);
            this.uxDeleteUser.Name = "uxDeleteUser";
            this.uxDeleteUser.Size = new System.Drawing.Size(100, 28);
            this.uxDeleteUser.TabIndex = 7;
            this.uxDeleteUser.Text = "Delete User";
            this.uxDeleteUser.UseVisualStyleBackColor = true;
            this.uxDeleteUser.Click += new System.EventHandler(this.uxDeleteUser_Click);
            // 
            // uxCreateUser
            // 
            this.uxCreateUser.Location = new System.Drawing.Point(243, 240);
            this.uxCreateUser.Margin = new System.Windows.Forms.Padding(4);
            this.uxCreateUser.Name = "uxCreateUser";
            this.uxCreateUser.Size = new System.Drawing.Size(100, 28);
            this.uxCreateUser.TabIndex = 8;
            this.uxCreateUser.Text = "Create User";
            this.uxCreateUser.UseVisualStyleBackColor = true;
            this.uxCreateUser.Click += new System.EventHandler(this.uxCreateUser_Click);
            // 
            // uxUserWeight
            // 
            this.uxUserWeight.Location = new System.Drawing.Point(243, 302);
            this.uxUserWeight.Margin = new System.Windows.Forms.Padding(4);
            this.uxUserWeight.Name = "uxUserWeight";
            this.uxUserWeight.Size = new System.Drawing.Size(100, 22);
            this.uxUserWeight.TabIndex = 9;
            // 
            // uxWeightLabel
            // 
            this.uxWeightLabel.AutoSize = true;
            this.uxWeightLabel.Location = new System.Drawing.Point(243, 281);
            this.uxWeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxWeightLabel.Name = "uxWeightLabel";
            this.uxWeightLabel.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.uxWeightLabel.Size = new System.Drawing.Size(100, 17);
            this.uxWeightLabel.TabIndex = 10;
            this.uxWeightLabel.Text = "User Weight";
            // 
            // LogInView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 357);
            this.Controls.Add(this.uxWeightLabel);
            this.Controls.Add(this.uxUserWeight);
            this.Controls.Add(this.uxCreateUser);
            this.Controls.Add(this.uxDeleteUser);
            this.Controls.Add(this.uxLoginButton);
            this.Controls.Add(this.uxPasswordText);
            this.Controls.Add(this.uxUsernameText);
            this.Controls.Add(this.uxPasslabel);
            this.Controls.Add(this.uxUserlabel);
            this.Controls.Add(this.uxLogLabel);
            this.Controls.Add(this.uxWelcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LogInView";
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
        private System.Windows.Forms.Button uxDeleteUser;
        private System.Windows.Forms.Button uxCreateUser;
        private System.Windows.Forms.TextBox uxUserWeight;
        private System.Windows.Forms.Label uxWeightLabel;
    }
}