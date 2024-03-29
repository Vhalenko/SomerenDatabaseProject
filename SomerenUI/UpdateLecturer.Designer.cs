namespace SomerenUI
{
    partial class UpdateLecturer
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
            lecturerRoomNumberTextbox = new System.Windows.Forms.TextBox();
            lecturerTelephoneNumberTextbox = new System.Windows.Forms.TextBox();
            lecturerAgeTextbox = new System.Windows.Forms.TextBox();
            lecturerLastNameTextbox = new System.Windows.Forms.TextBox();
            lecturerFirstNameTextbox = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            updateLecturerButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lecturerRoomNumberTextbox
            // 
            lecturerRoomNumberTextbox.Location = new System.Drawing.Point(280, 270);
            lecturerRoomNumberTextbox.Name = "lecturerRoomNumberTextbox";
            lecturerRoomNumberTextbox.Size = new System.Drawing.Size(125, 27);
            lecturerRoomNumberTextbox.TabIndex = 9;
            // 
            // lecturerTelephoneNumberTextbox
            // 
            lecturerTelephoneNumberTextbox.Location = new System.Drawing.Point(280, 207);
            lecturerTelephoneNumberTextbox.Name = "lecturerTelephoneNumberTextbox";
            lecturerTelephoneNumberTextbox.Size = new System.Drawing.Size(125, 27);
            lecturerTelephoneNumberTextbox.TabIndex = 8;
            // 
            // lecturerAgeTextbox
            // 
            lecturerAgeTextbox.Location = new System.Drawing.Point(280, 151);
            lecturerAgeTextbox.Name = "lecturerAgeTextbox";
            lecturerAgeTextbox.Size = new System.Drawing.Size(125, 27);
            lecturerAgeTextbox.TabIndex = 7;
            // 
            // lecturerLastNameTextbox
            // 
            lecturerLastNameTextbox.Location = new System.Drawing.Point(280, 100);
            lecturerLastNameTextbox.Name = "lecturerLastNameTextbox";
            lecturerLastNameTextbox.Size = new System.Drawing.Size(125, 27);
            lecturerLastNameTextbox.TabIndex = 6;
            // 
            // lecturerFirstNameTextbox
            // 
            lecturerFirstNameTextbox.Location = new System.Drawing.Point(280, 41);
            lecturerFirstNameTextbox.Name = "lecturerFirstNameTextbox";
            lecturerFirstNameTextbox.Size = new System.Drawing.Size(125, 27);
            lecturerFirstNameTextbox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(33, 273);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(107, 20);
            label5.TabIndex = 14;
            label5.Text = "Room Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(33, 210);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(136, 20);
            label4.TabIndex = 13;
            label4.Text = "Telephone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(33, 154);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(36, 20);
            label3.TabIndex = 12;
            label3.Text = "Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(33, 103);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 20);
            label2.TabIndex = 11;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(32, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 20);
            label1.TabIndex = 10;
            label1.Text = "First Name";
            // 
            // updateLecturerButton
            // 
            updateLecturerButton.Location = new System.Drawing.Point(142, 345);
            updateLecturerButton.Name = "updateLecturerButton";
            updateLecturerButton.Size = new System.Drawing.Size(134, 52);
            updateLecturerButton.TabIndex = 15;
            updateLecturerButton.Text = "Update";
            updateLecturerButton.UseVisualStyleBackColor = true;
            // 
            // UpdateLecturer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(445, 409);
            Controls.Add(updateLecturerButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lecturerRoomNumberTextbox);
            Controls.Add(lecturerTelephoneNumberTextbox);
            Controls.Add(lecturerAgeTextbox);
            Controls.Add(lecturerLastNameTextbox);
            Controls.Add(lecturerFirstNameTextbox);
            Name = "UpdateLecturer";
            Text = "Update Lecturer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox lecturerRoomNumberTextbox;
        private System.Windows.Forms.TextBox lecturerTelephoneNumberTextbox;
        private System.Windows.Forms.TextBox lecturerAgeTextbox;
        private System.Windows.Forms.TextBox lecturerLastNameTextbox;
        private System.Windows.Forms.TextBox lecturerFirstNameTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateLecturerButton;
    }
}