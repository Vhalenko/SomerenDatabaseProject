namespace SomerenUI
{
    partial class UpdateSupervisorForm
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
            label2 = new System.Windows.Forms.Label();
            NewActivitytxtBox = new System.Windows.Forms.TextBox();
            SupervisorsNumtxtBox = new System.Windows.Forms.TextBox();
            UpdateButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(69, 241);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(331, 32);
            label1.TabIndex = 0;
            label1.Text = "Update activity for supervisor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(69, 105);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(297, 32);
            label2.TabIndex = 1;
            label2.Text = "Enter supervisor's number:";
            // 
            // NewActivitytxtBox
            // 
            NewActivitytxtBox.Location = new System.Drawing.Point(419, 238);
            NewActivitytxtBox.Name = "NewActivitytxtBox";
            NewActivitytxtBox.Size = new System.Drawing.Size(200, 39);
            NewActivitytxtBox.TabIndex = 2;
            // 
            // SupervisorsNumtxtBox
            // 
            SupervisorsNumtxtBox.Location = new System.Drawing.Point(419, 102);
            SupervisorsNumtxtBox.Name = "SupervisorsNumtxtBox";
            SupervisorsNumtxtBox.Size = new System.Drawing.Size(200, 39);
            SupervisorsNumtxtBox.TabIndex = 3;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new System.Drawing.Point(301, 334);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new System.Drawing.Size(150, 46);
            UpdateButton.TabIndex = 4;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // UpdateSupervisorForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(UpdateButton);
            Controls.Add(SupervisorsNumtxtBox);
            Controls.Add(NewActivitytxtBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateSupervisorForm";
            Text = "UpdateSupervisorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewActivitytxtBox;
        private System.Windows.Forms.TextBox SupervisorsNumtxtBox;
        private System.Windows.Forms.Button UpdateButton;
    }
}