namespace SomerenUI
{
    partial class AddLecturerForm
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
            lecturerAddRoomTextbox = new System.Windows.Forms.TextBox();
            lecturerAddTelephoneNumberTextbox = new System.Windows.Forms.TextBox();
            lecturerAddLastNameTextbox = new System.Windows.Forms.TextBox();
            lecturerAddFirstNameTextbox = new System.Windows.Forms.TextBox();
            lecturerAddNumberTextbox = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            addLecturerButton = new System.Windows.Forms.Button();
            lecturerAddAgeDateTime = new System.Windows.Forms.DateTimePicker();
            SuspendLayout();
            // 
            // lecturerAddRoomTextbox
            // 
            lecturerAddRoomTextbox.Location = new System.Drawing.Point(308, 255);
            lecturerAddRoomTextbox.Name = "lecturerAddRoomTextbox";
            lecturerAddRoomTextbox.Size = new System.Drawing.Size(125, 27);
            lecturerAddRoomTextbox.TabIndex = 18;
            // 
            // lecturerAddTelephoneNumberTextbox
            // 
            lecturerAddTelephoneNumberTextbox.Location = new System.Drawing.Point(308, 208);
            lecturerAddTelephoneNumberTextbox.Name = "lecturerAddTelephoneNumberTextbox";
            lecturerAddTelephoneNumberTextbox.Size = new System.Drawing.Size(125, 27);
            lecturerAddTelephoneNumberTextbox.TabIndex = 17;
            // 
            // lecturerAddLastNameTextbox
            // 
            lecturerAddLastNameTextbox.Location = new System.Drawing.Point(308, 125);
            lecturerAddLastNameTextbox.Name = "lecturerAddLastNameTextbox";
            lecturerAddLastNameTextbox.Size = new System.Drawing.Size(125, 27);
            lecturerAddLastNameTextbox.TabIndex = 15;
            // 
            // lecturerAddFirstNameTextbox
            // 
            lecturerAddFirstNameTextbox.Location = new System.Drawing.Point(308, 81);
            lecturerAddFirstNameTextbox.Name = "lecturerAddFirstNameTextbox";
            lecturerAddFirstNameTextbox.Size = new System.Drawing.Size(125, 27);
            lecturerAddFirstNameTextbox.TabIndex = 14;
            // 
            // lecturerAddNumberTextbox
            // 
            lecturerAddNumberTextbox.Location = new System.Drawing.Point(308, 36);
            lecturerAddNumberTextbox.Name = "lecturerAddNumberTextbox";
            lecturerAddNumberTextbox.Size = new System.Drawing.Size(125, 27);
            lecturerAddNumberTextbox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(28, 255);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(107, 20);
            label6.TabIndex = 24;
            label6.Text = "Room Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(28, 208);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(136, 20);
            label5.TabIndex = 23;
            label5.Text = "Telephone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(28, 166);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 20);
            label4.TabIndex = 22;
            label4.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(28, 125);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 20);
            label3.TabIndex = 21;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(28, 81);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 20);
            label2.TabIndex = 20;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(28, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 20);
            label1.TabIndex = 19;
            label1.Text = "Lecturer Number";
            // 
            // addLecturerButton
            // 
            addLecturerButton.Location = new System.Drawing.Point(156, 318);
            addLecturerButton.Name = "addLecturerButton";
            addLecturerButton.Size = new System.Drawing.Size(134, 52);
            addLecturerButton.TabIndex = 25;
            addLecturerButton.Text = "Add Lecturer";
            addLecturerButton.UseVisualStyleBackColor = true;
            addLecturerButton.Click += addLecturerButton_Click;
            // 
            // lecturerAddAgeDateTime
            // 
            lecturerAddAgeDateTime.Location = new System.Drawing.Point(308, 166);
            lecturerAddAgeDateTime.Name = "lecturerAddAgeDateTime";
            lecturerAddAgeDateTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lecturerAddAgeDateTime.Size = new System.Drawing.Size(125, 27);
            lecturerAddAgeDateTime.TabIndex = 26;
            // 
            // AddLecturerForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(462, 382);
            Controls.Add(lecturerAddAgeDateTime);
            Controls.Add(addLecturerButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lecturerAddRoomTextbox);
            Controls.Add(lecturerAddTelephoneNumberTextbox);
            Controls.Add(lecturerAddLastNameTextbox);
            Controls.Add(lecturerAddFirstNameTextbox);
            Controls.Add(lecturerAddNumberTextbox);
            Name = "AddLecturerForm";
            Text = "Add Lecturer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox lecturerAddRoomTextbox;
        private System.Windows.Forms.TextBox lecturerAddTelephoneNumberTextbox;
        private System.Windows.Forms.TextBox lecturerAddLastNameTextbox;
        private System.Windows.Forms.TextBox lecturerAddFirstNameTextbox;
        private System.Windows.Forms.TextBox lecturerAddNumberTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addLecturerButton;
        private System.Windows.Forms.DateTimePicker lecturerAddAgeDateTime;
    }
}