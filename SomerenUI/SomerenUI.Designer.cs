namespace SomerenUI
{
    partial class SomerenUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlStudents = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            listViewStudents = new System.Windows.Forms.ListView();
            columnZero = new System.Windows.Forms.ColumnHeader();
            StudentNumberColumn = new System.Windows.Forms.ColumnHeader();
            NameColumn = new System.Windows.Forms.ColumnHeader();
            ClassColumn = new System.Windows.Forms.ColumnHeader();
            TelephoneNumberColumn = new System.Windows.Forms.ColumnHeader();
            RoomNumberColumn = new System.Windows.Forms.ColumnHeader();
            label1 = new System.Windows.Forms.Label();
            pnlLecturers = new System.Windows.Forms.Panel();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            listViewLecturers = new System.Windows.Forms.ListView();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnLecturerNumber = new System.Windows.Forms.ColumnHeader();
            columnName = new System.Windows.Forms.ColumnHeader();
            columnAge = new System.Windows.Forms.ColumnHeader();
            columTelephoneNumber = new System.Windows.Forms.ColumnHeader();
            columnRoomNumber = new System.Windows.Forms.ColumnHeader();
            label3 = new System.Windows.Forms.Label();
            pnlDashboard = new System.Windows.Forms.Panel();
            lblDashboard = new System.Windows.Forms.Label();
            panelRooms = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            listViewRooms = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            room_number = new System.Windows.Forms.ColumnHeader();
            building = new System.Windows.Forms.ColumnHeader();
            room_type = new System.Windows.Forms.ColumnHeader();
            beds_amount = new System.Windows.Forms.ColumnHeader();
            floor = new System.Windows.Forms.ColumnHeader();
            lblRooms = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLecturers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlDashboard.SuspendLayout();
            panelRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(11, 5, 0, 5);
            menuStrip1.Size = new System.Drawing.Size(1786, 48);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(154, 38);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(262, 44);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(262, 44);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(127, 38);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(130, 38);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(129, 38);
            activitiesToolStripMenuItem.Text = "Activities";
            activitiesToolStripMenuItem.Click += activitiesToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(106, 38);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(pictureBox1);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(label1);
            pnlStudents.Location = new System.Drawing.Point(23, 58);
            pnlStudents.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(1742, 994);
            pnlStudents.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(1495, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(242, 262);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnZero, StudentNumberColumn, NameColumn, ClassColumn, TelephoneNumberColumn, RoomNumberColumn });
            listViewStudents.Location = new System.Drawing.Point(29, 90);
            listViewStudents.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(1419, 650);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // columnZero
            // 
            columnZero.Text = "";
            columnZero.Width = 0;
            // 
            // StudentNumberColumn
            // 
            StudentNumberColumn.Text = "Student Number";
            StudentNumberColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            StudentNumberColumn.Width = 180;
            // 
            // NameColumn
            // 
            NameColumn.Text = "Student Name";
            NameColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            NameColumn.Width = 220;
            // 
            // ClassColumn
            // 
            ClassColumn.Text = "Class";
            ClassColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ClassColumn.Width = 120;
            // 
            // TelephoneNumberColumn
            // 
            TelephoneNumberColumn.Text = "Telephone Number";
            TelephoneNumberColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            TelephoneNumberColumn.Width = 220;
            // 
            // RoomNumberColumn
            // 
            RoomNumberColumn.Text = "Room Number";
            RoomNumberColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            RoomNumberColumn.Width = 130;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(24, 14);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(211, 65);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // pnlLecturers
            // 
            pnlLecturers.Controls.Add(pictureBox3);
            pnlLecturers.Controls.Add(listViewLecturers);
            pnlLecturers.Controls.Add(label3);
            pnlLecturers.Location = new System.Drawing.Point(23, 58);
            pnlLecturers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pnlLecturers.Name = "pnlLecturers";
            pnlLecturers.Size = new System.Drawing.Size(1742, 994);
            pnlLecturers.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(1495, 0);
            pictureBox3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(242, 262);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // listViewLecturers
            // 
            listViewLecturers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader2, columnLecturerNumber, columnName, columnAge, columTelephoneNumber, columnRoomNumber });
            listViewLecturers.Location = new System.Drawing.Point(29, 90);
            listViewLecturers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            listViewLecturers.Name = "listViewLecturers";
            listViewLecturers.Size = new System.Drawing.Size(1419, 650);
            listViewLecturers.TabIndex = 1;
            listViewLecturers.UseCompatibleStateImageBehavior = false;
            listViewLecturers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "";
            columnHeader2.Width = 0;
            // 
            // columnLecturerNumber
            // 
            columnLecturerNumber.Text = "Lecturer Number";
            columnLecturerNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnLecturerNumber.Width = 180;
            // 
            // columnName
            // 
            columnName.Text = "Name";
            columnName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnName.Width = 220;
            // 
            // columnAge
            // 
            columnAge.Text = "Age";
            columnAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnAge.Width = 100;
            // 
            // columTelephoneNumber
            // 
            columTelephoneNumber.Text = "Telephone Number";
            columTelephoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columTelephoneNumber.Width = 220;
            // 
            // columnRoomNumber
            // 
            columnRoomNumber.Text = "Room Number";
            columnRoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnRoomNumber.Width = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(24, 14);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(220, 65);
            label3.TabIndex = 0;
            label3.Text = "Lecturers";
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(18, 58);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1742, 994);
            pnlDashboard.TabIndex = 5;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(24, 27);
            lblDashboard.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(421, 32);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // panelRooms
            // 
            panelRooms.Controls.Add(pictureBox2);
            panelRooms.Controls.Add(listViewRooms);
            panelRooms.Controls.Add(lblRooms);
            panelRooms.Location = new System.Drawing.Point(21, 42);
            panelRooms.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            panelRooms.Name = "panelRooms";
            panelRooms.Size = new System.Drawing.Size(1742, 994);
            panelRooms.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(1495, 0);
            pictureBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(242, 262);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // listViewRooms
            // 
            listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, room_number, building, room_type, beds_amount, floor });
            listViewRooms.Location = new System.Drawing.Point(29, 90);
            listViewRooms.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(1419, 650);
            listViewRooms.TabIndex = 1;
            listViewRooms.UseCompatibleStateImageBehavior = false;
            listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "";
            columnHeader1.Width = 0;
            // 
            // room_number
            // 
            room_number.Text = "Room Number";
            room_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            room_number.Width = 120;
            // 
            // building
            // 
            building.Text = "Building";
            building.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            building.Width = 70;
            // 
            // room_type
            // 
            room_type.Text = "Room Type";
            room_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            room_type.Width = 120;
            // 
            // beds_amount
            // 
            beds_amount.Text = "Beds Amount";
            beds_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            beds_amount.Width = 120;
            // 
            // floor
            // 
            floor.Text = "Floor";
            floor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            floor.Width = 50;
            // 
            // lblRooms
            // 
            lblRooms.AutoSize = true;
            lblRooms.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRooms.Location = new System.Drawing.Point(24, 14);
            lblRooms.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblRooms.Name = "lblRooms";
            lblRooms.Size = new System.Drawing.Size(173, 65);
            lblRooms.TabIndex = 0;
            lblRooms.Text = "Rooms";
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1786, 1077);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlStudents);
            Controls.Add(panelRooms);
            Controls.Add(pnlLecturers);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlLecturers.ResumeLayout(false);
            pnlLecturers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            panelRooms.ResumeLayout(false);
            panelRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnZero;
        private System.Windows.Forms.ColumnHeader StudentNumberColumn;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader ClassColumn;
        private System.Windows.Forms.ColumnHeader TelephoneNumberColumn;
        private System.Windows.Forms.ColumnHeader RoomNumberColumn;
        private System.Windows.Forms.Panel pnlLecturers;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel listVieLecturers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewLecturers;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnLecturerNumber;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnAge;
        private System.Windows.Forms.ColumnHeader columTelephoneNumber;
        private System.Windows.Forms.ColumnHeader columnRoomNumber;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel panelRooms;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader room_number;
        private System.Windows.Forms.ColumnHeader building;
        private System.Windows.Forms.ColumnHeader room_type;
        private System.Windows.Forms.ColumnHeader beds_amount;
        private System.Windows.Forms.ColumnHeader floor;
        private System.Windows.Forms.Label lblRooms;
    }
}