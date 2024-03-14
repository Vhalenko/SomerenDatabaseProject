using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
            ShowDashboardPanel();
        }

        private void ShowDashboardPanel()
        {
            HideAll();
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel()
        {
            HideAll();
            pnlStudents.Show();

            try
            {
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private void ShowLecturersPanel()
        {
            HideAll();
            pnlLecturers.Show();

            try
            {
                List<Lecturer> lecturers = GetLecturers();
                DisplayLecturers(lecturers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private void ShowRoomsPanel()
        {
            pnlDashboard.Hide();
            panelRooms.Show();

            try
            {
                List<Room> rooms = GetRooms();
                DisplayRooms(rooms);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
            }
        }

        private void ShowActivitiesPanel()
        {
            HideAll();
            pnlActivities.Show();

            try
            {
                List<Activity> activities = GetActivities();
                DisplayActivities(activities);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
            }
        }

        private List<Student> GetStudents()
        {
            StudentService studentService = new();
            return studentService.GetStudents();
        }

        private List<Lecturer> GetLecturers()
        {
            LecturerService lecturerService = new();
            return lecturerService.GetLecturers();
        }

        private List<Activity> GetActivities()
        {
            ActivityService activityService = new ActivityService();
            List<Activity> activities = activityService.GetActivities();
            return activities;
        }

        private List<Room> GetRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms();
            return rooms;
        }

        private void DisplayStudents(List<Student> students)
        {
            listViewStudents.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem item = new();
                item.SubItems.Add(student.PersonNumber.ToString());
                item.SubItems.Add(student.FullName.ToString());
                item.SubItems.Add(student.ClassName.ToString());
                item.SubItems.Add(student.TelephoneNumber.ToString());
                item.SubItems.Add(student.RoomNumber.ToString());
                listViewStudents.Items.Add(item);
            }
        }

        private void DisplayLecturers(List<Lecturer> lecturers)
        {
            listViewLecturers.Items.Clear();

            foreach (var lecturer in lecturers)
            {
                ListViewItem item = new();
                item.SubItems.Add(lecturer.PersonNumber.ToString());
                item.SubItems.Add(lecturer.FullName.ToString());
                item.SubItems.Add(lecturer.Age.ToString("dd-MM-yyyy"));
                item.SubItems.Add(lecturer.TelephoneNumber.ToString());
                item.SubItems.Add(lecturer.RoomNumber.ToString());
                listViewLecturers.Items.Add(item);
            }
        }

        private void DisplayRooms(List<Room> rooms)
        {
            listViewRooms.Items.Clear();

            foreach (Room room in rooms)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(room.Number.ToString());
                item.SubItems.Add(room.Building.ToString());
                item.SubItems.Add(room.Type);
                item.SubItems.Add(room.Capacity.ToString());
                item.SubItems.Add(room.Floor.ToString());

                listViewRooms.Items.Add(item);
            }
        }

        private void DisplayActivities(List<Activity> activities)
        {
            listViewActivities.Items.Clear();

            foreach (Activity activity in activities)
            {
                ListViewItem li = new ListViewItem();
                li.SubItems.Add(activity.Id.ToString());
                li.SubItems.Add(activity.Name);
                li.SubItems.Add(activity.StartDayTime);
                li.SubItems.Add(activity.EndDayTime);

                listViewActivities.Items.Add(li);
            }
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            ShowRoomsPanel();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            ShowStudentsPanel();
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            ShowLecturersPanel();
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            ShowActivitiesPanel();
        }

        private void HideAll()
        {
            pnlDashboard.Hide();
            pnlLecturers.Hide();
            pnlStudents.Hide();
            pnlActivities.Hide();
            panelRooms.Hide();
        }
    }
}