namespace SomerenUI
{
    partial class DeleteCheckSupervisor
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
            label1 = new System.Windows.Forms.Label();
            YesButton = new System.Windows.Forms.Button();
            NoButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(106, 159);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(539, 32);
            label1.TabIndex = 0;
            label1.Text = "Are you sure you wish to remove this supervisor?";
            // 
            // YesButton
            // 
            YesButton.Location = new System.Drawing.Point(123, 289);
            YesButton.Name = "YesButton";
            YesButton.Size = new System.Drawing.Size(150, 46);
            YesButton.TabIndex = 1;
            YesButton.Text = "Yes";
            YesButton.UseVisualStyleBackColor = true;
            YesButton.Click += YesButton_Click;
            // 
            // NoButton
            // 
            NoButton.Location = new System.Drawing.Point(459, 289);
            NoButton.Name = "NoButton";
            NoButton.Size = new System.Drawing.Size(150, 46);
            NoButton.TabIndex = 2;
            NoButton.Text = "No";
            NoButton.UseVisualStyleBackColor = true;
            NoButton.Click += NoButton_Click;
            // 
            // DeleteCheckSupervisor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(NoButton);
            Controls.Add(YesButton);
            Controls.Add(label1);
            Name = "DeleteCheckSupervisor";
            Text = "DeleteCheckSupervisor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
    }
}