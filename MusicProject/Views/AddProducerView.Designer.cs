namespace MusicProject.Views
{
    partial class AddProducerView
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
            this.uxQuestion = new System.Windows.Forms.Label();
            this.uxNameBox = new System.Windows.Forms.TextBox();
            this.uxAddProducerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxQuestion
            // 
            this.uxQuestion.AutoSize = true;
            this.uxQuestion.Location = new System.Drawing.Point(94, 82);
            this.uxQuestion.Name = "uxQuestion";
            this.uxQuestion.Size = new System.Drawing.Size(151, 13);
            this.uxQuestion.TabIndex = 0;
            this.uxQuestion.Text = "What is the Producer\'s Name?";
            // 
            // uxNameBox
            // 
            this.uxNameBox.Location = new System.Drawing.Point(65, 113);
            this.uxNameBox.Name = "uxNameBox";
            this.uxNameBox.Size = new System.Drawing.Size(209, 20);
            this.uxNameBox.TabIndex = 1;
            // 
            // uxAddProducerButton
            // 
            this.uxAddProducerButton.Location = new System.Drawing.Point(107, 151);
            this.uxAddProducerButton.Name = "uxAddProducerButton";
            this.uxAddProducerButton.Size = new System.Drawing.Size(118, 23);
            this.uxAddProducerButton.TabIndex = 2;
            this.uxAddProducerButton.Text = "Add Producer";
            this.uxAddProducerButton.UseVisualStyleBackColor = true;
            this.uxAddProducerButton.Click += new System.EventHandler(this.uxAddProducerButton_Click);
            // 
            // AddProducerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 232);
            this.Controls.Add(this.uxAddProducerButton);
            this.Controls.Add(this.uxNameBox);
            this.Controls.Add(this.uxQuestion);
            this.Name = "AddProducerView";
            this.Text = "AddProducerView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxQuestion;
        private System.Windows.Forms.TextBox uxNameBox;
        private System.Windows.Forms.Button uxAddProducerButton;
    }
}