namespace SomerenUI
{
    partial class AddSupervisorForm
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
            AddLecNumtxtBox = new System.Windows.Forms.TextBox();
            AddIdtxtBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            AddSupervisorB = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(89, 84);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(272, 32);
            label1.TabIndex = 0;
            label1.Text = "Enter a lecturer number:";
            // 
            // AddLecNumtxtBox
            // 
            AddLecNumtxtBox.Location = new System.Drawing.Point(430, 84);
            AddLecNumtxtBox.Name = "AddLecNumtxtBox";
            AddLecNumtxtBox.Size = new System.Drawing.Size(200, 39);
            AddLecNumtxtBox.TabIndex = 1;
            // 
            // AddIdtxtBox
            // 
            AddIdtxtBox.Location = new System.Drawing.Point(430, 177);
            AddIdtxtBox.Name = "AddIdtxtBox";
            AddIdtxtBox.Size = new System.Drawing.Size(200, 39);
            AddIdtxtBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(89, 184);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(183, 32);
            label2.TabIndex = 3;
            label2.Text = "Enter activity id:";
            // 
            // AddSupervisorB
            // 
            AddSupervisorB.Location = new System.Drawing.Point(226, 294);
            AddSupervisorB.Name = "AddSupervisorB";
            AddSupervisorB.Size = new System.Drawing.Size(250, 46);
            AddSupervisorB.TabIndex = 4;
            AddSupervisorB.Text = "Add Supervisor";
            AddSupervisorB.UseVisualStyleBackColor = true;
            AddSupervisorB.Click += button1_Click;
            // 
            // AddSupervisorForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(AddSupervisorB);
            Controls.Add(label2);
            Controls.Add(AddIdtxtBox);
            Controls.Add(AddLecNumtxtBox);
            Controls.Add(label1);
            Name = "AddSupervisorForm";
            Text = "AddSupervisorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddLecNumtxtBox;
        private System.Windows.Forms.TextBox AddIdtxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddSupervisorB;
    }
}