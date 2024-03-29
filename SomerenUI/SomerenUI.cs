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

            dateTimePickerStart.MaxDate = DateTime.Today;
            dateTimePickerEnd.MaxDate = DateTime.Today;

            dateTimePickerEnd.Value = DateTime.Today;
            dateTimePickerStart.Value = DateTime.Today;

            ShowDashboardPanel();
        }

        /*Dashboard panel*/

        private void ShowDashboardPanel()
        {
            HideAll();
            pnlDashboard.Show();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        /*Students panel*/

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

        private List<Student> GetStudents()
        {
            StudentService studentService = new();
            return studentService.GetStudents();
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
                item.Tag = student;

                listViewStudents.Items.Add(item);
            }
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        /*Lecturers panel*/

        private void ShowLecturersPanel()
        {
            HideAll();
            pnlLecturers.Show();

            try
            {
                List<Lecturer> lecturers = GetLecturers();
                DisplayLecturers(lecturers, "lecturer");
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private List<Lecturer> GetLecturers()
        {
            LecturerService lecturerService = new();
            return lecturerService.GetLecturers();
        }

        private void DisplayLecturers(List<Lecturer> lecturers, string checkpanel)
        {
            listViewLecturers.Items.Clear();
            Action<ListViewItem> addItem = checkpanel == "lecturer" ? new Action<ListViewItem>(item => listViewLecturers.Items.Add(item)) : new Action<ListViewItem>(item => listViewSupervisor.Items.Add(item));

            foreach (var lecturer in lecturers)
            {
                ListViewItem item = new();
                item.SubItems.Add(lecturer.PersonNumber.ToString());
                item.SubItems.Add(lecturer.FullName.ToString());
                item.SubItems.Add(lecturer.Age.ToString("dd-MM-yyyy"));
                item.SubItems.Add(lecturer.TelephoneNumber.ToString());
                item.SubItems.Add(lecturer.RoomNumber.ToString());
                item.Tag = lecturer;

                addItem(item);
            }
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLecturersPanel();
        }

        /*Rooms panel*/

        private void ShowRoomsPanel()
        {
            HideAll();
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

        private List<Room> GetRooms()
        {
            RoomService roomService = new();
            return roomService.GetRooms();
        }

        private void DisplayRooms(List<Room> rooms)
        {
            listViewRooms.Items.Clear();

            foreach (Room room in rooms)
            {
                ListViewItem item = new();
                item.SubItems.Add(room.Number.ToString());
                item.SubItems.Add(room.Building.ToString());
                item.SubItems.Add(room.Type);
                item.SubItems.Add(room.Capacity.ToString());
                item.SubItems.Add(room.Floor.ToString());
                item.Tag = room;

                listViewRooms.Items.Add(item);
            }
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoomsPanel();
        }

        /*Activity panel*/

        private void ShowActivitiesPanel()
        {
            HideAll();
            pnlActivities.Show();

            try
            {
                List<Activity> activities = GetActivities();
                DisplayActivities(activities, "activity");
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
            }
        }

        private List<Activity> GetActivities()
        {
            ActivityService activityService = new ActivityService();
            return activityService.GetActivities();
        }

        private void DisplayActivities(List<Activity> activities, string checkpanel)
        {
            listViewActivities.Items.Clear();

            Action<ListViewItem> addItem = checkpanel == "activity" ? new Action<ListViewItem>(li => listViewActivities.Items.Add(li)) : new Action<ListViewItem>(li => listActivitiesView.Items.Add(li));

            foreach (Activity activity in activities)
            {
                ListViewItem li = new ListViewItem(new string[]
                {
                    activity.Id.ToString(),
                    activity.Name,
                    activity.StartDayTime,
                    activity.EndDayTime
                });
                li.Tag = activity;

                addItem(li);
            }
        }
        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActivitiesPanel();
        }

        /*Drink panel*/

        private void ShowDrinksPanel()
        {
            HideAll();
            pnlDrinks.Show();

            try
            {
                List<Drink> drink = GetDrinks();
                DisplayDrinks(drink);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the drink: " + e.Message);
            }
        }

        private List<Drink> GetDrinks()
        {
            DrinkService drinkService = new();
            return drinkService.GetDrinks();
        }

        private void DisplayDrinks(List<Drink> drinks)
        {
            listViewDrinks.Items.Clear();

            foreach (Drink drink in drinks)
            {
                ListViewItem li = new();
                li.SubItems.Add(drink.Id.ToString());
                li.SubItems.Add(drink.Name);
                li.SubItems.Add(drink.Price.ToString());
                li.SubItems.Add(drink.StockToText);
                li.SubItems.Add(drink.Vat.ToString() + "%");
                li.Tag = drink;

                listViewDrinks.Items.Add(li);
            }
        }

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDrinksPanel();
        }

        private void btnDrinkDelete_Click(object sender, EventArgs e)
        {
            if (listViewDrinks.SelectedItems.Count != 0)
            {
                ListViewItem selectedDrink = listViewDrinks.SelectedItems[0];
                DrinkService drinkService = new();
                drinkService.DeleteDrink((Drink)selectedDrink.Tag);
                ShowDrinksPanel();

                MessageBox.Show("Drink deleted!");
            }
            else
            {
                MessageBox.Show("Select a drink!");
            }
        }

        private void btnDrinkAdd_Click(object sender, EventArgs e)
        {
            DrinkAddForm drinkAddForm = new();
            drinkAddForm.ShowDialog();
            ShowDrinksPanel();
        }

        private void btnUpdateDrink_Click(object sender, EventArgs e)
        {
            if (listViewDrinks.SelectedItems.Count != 0)
            {
                ListViewItem selectedDrink = listViewDrinks.SelectedItems[0];

                DrinkUpdateForm drinkUpdateForm = new((Drink)selectedDrink.Tag);

                drinkUpdateForm.ShowDialog();
                ShowDrinksPanel();
            }
            else
            {
                MessageBox.Show("Select a drink!");
            }
        }

        /*Order panel*/

        private void ShowOrderPanel()
        {
            HideAll();
            pnlOrder.Show();

            try
            {
                List<Student> students = GetStudents();
                List<Drink> drinks = GetDrinks();
                DisplayDrinksForOrder(drinks);
                DisplayStudentsForOrder(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the drink: " + e.Message);
            }
        }

        private void DisplayStudentsForOrder(List<Student> students)
        {
            listViewOrderStudent.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem item = new();
                item.SubItems.Add(student.PersonNumber.ToString());
                item.SubItems.Add(student.FullName);
                item.Tag = student;

                listViewOrderStudent.Items.Add(item);
            }
        }

        private void DisplayDrinksForOrder(List<Drink> drinks)
        {
            listViewOrderDrink.Items.Clear();

            foreach (Drink drink in drinks)
            {
                ListViewItem item = new();
                item.SubItems.Add(drink.Name);
                item.SubItems.Add(drink.Price.ToString());
                item.SubItems.Add(drink.Alcohol);
                item.SubItems.Add(drink.Stock.ToString());
                item.Tag = drink;

                listViewOrderDrink.Items.Add(item);
            }
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOrderPanel();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            try
            {
                ChooseStudentDrinkError();
                FillOrder();
                ShowOrderPanel();
                MessageBox.Show("Order is successfully placed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChooseStudentDrinkError()
        {
            if (listViewOrderStudent.SelectedItems.Count == 0)
            {
                throw new Exception("Select a student!");
            }
            else if (listViewOrderDrink.SelectedItems.Count == 0)
            {
                throw new Exception("Select a drink!");
            }
        }

        private void FillOrder()
        {
            OrderService orderService = new();
            ListViewItem selectedDrink = listViewOrderDrink.SelectedItems[0];
            ListViewItem selectedStudent = listViewOrderStudent.SelectedItems[0];

            orderService.FillOrder((Student)selectedStudent.Tag, (Drink)selectedDrink.Tag, (int)quantityOfDrinks.Value);
        }

        private void listViewOrderStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayOrderPrice();
        }

        private void listViewOrderDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayOrderPrice();
        }

        private void quantityOfDrinks_ValueChanged(object sender, EventArgs e)
        {
            DisplayOrderPrice();
        }

        private void DisplayOrderPrice()
        {
            if (listViewOrderDrink.SelectedItems.Count > 0 && listViewOrderStudent.SelectedItems.Count > 0)
            {
                OrderService orderService = new();
                ListViewItem selectedDrink = listViewOrderDrink.SelectedItems[0];
                orderService.DisplayPrice((Drink)selectedDrink.Tag, quantityOfDrinks.Value, out string totalPrice);
                PriceOutputLabel.Text = totalPrice;
            }
        }

        /*Revenue panel*/

        private void ShowRevenuePanel()
        {
            HideAll();
            pnlRevenue.Show();

            try
            {
                List<Order> orders = GetOrders();
                DisplayAllFields(orders);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the drink: " + e.Message);
            }
        }

        private List<Order> GetOrders()
        {
            OrderService orderService = new();
            return orderService.GetOrders();
        }

        private void revenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRevenuePanel();
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            ClearAllLitsts();

            OrderService orderService = new();

            try
            {
                if (orderService.RightDates(dateTimePickerStart.Value, dateTimePickerEnd.Value))
                {
                    List<Order> orders = GetOrders();
                    DisplayAllFields(orders);
                }
                else
                {
                    throw new Exception("Choose the right date!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            ClearAllLitsts();

            OrderService orderService = new();

            try
            {
                if (orderService.RightDates(dateTimePickerStart.Value, dateTimePickerEnd.Value))
                {
                    List<Order> orders = GetOrders();
                    DisplayAllFields(orders);
                }
                else
                {
                    throw new Exception("Choose the right date!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplaySeparateSales(List<Order> orders)
        {
            listViewDrinksSold.Items.Clear();

            foreach (var order in orders)
            {
                if (order.OrderDate >= dateTimePickerStart.Value && order.OrderDate <= dateTimePickerEnd.Value)
                {
                    ListViewItem item = new();
                    item.SubItems.Add(order.Drink.Name);
                    item.SubItems.Add(order.Drink.Price.ToString());
                    item.SubItems.Add(order.Quantity.ToString());
                    item.Tag = order;

                    listViewDrinksSold.Items.Add(item);
                }
            }
        }

        private void ClearAllLitsts()
        {
            listViewDrinksSold.Items.Clear();
            TotalSalesLabel.Text = string.Empty;
            Turnoverlabel.Text = string.Empty;
            NumOfCustomersLabel.Text = string.Empty;
        }

        private void DisplayAllFields(List<Order> orders)
        {
            OrderService orderService = new();

            DisplaySeparateSales(orders);
            orderService.DisplayTotalSales(orders, dateTimePickerStart.Value, dateTimePickerEnd.Value, out string totalSales);
            orderService.DisplayTurnover(orders, dateTimePickerStart.Value, dateTimePickerEnd.Value, out string turnover);
            orderService.DisplayNumberOfCustomers(dateTimePickerStart.Value, dateTimePickerEnd.Value, out string numberOfCustomers);

            NumOfCustomersLabel.Text = numberOfCustomers;
            Turnoverlabel.Text = turnover;
            TotalSalesLabel.Text = totalSales;
        }

        /*VAT panel*/

        private void ShowVATPanel()
        {
            HideAll();
            pnlVAT.Show();
        }

        private void VATInformationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShowVATPanel();
        }

        private void radioQ1B_CheckedChanged_1(object sender, EventArgs e)
        {
            ShowVatInformation(1);
        }

        private void radioQ2B_CheckedChanged(object sender, EventArgs e)
        {
            ShowVatInformation(2);
        }

        private void radioQ3B_CheckedChanged(object sender, EventArgs e)
        {
            ShowVatInformation(3);
        }

        private void radioQ4B_CheckedChanged(object sender, EventArgs e)
        {
            ShowVatInformation(4);
        }

        private void ShowVatInformation(int quarterNumber)
        {
            try
            {
                OrderService orderService = new();
                orderService.VatInformation(int.Parse(YearTextBoxVAT.Text), quarterNumber, out string startDate, out string endDate, out string vat9Percent, out string vat21Percent, out string vatTotal);
                ShowTextToElements(startDate, endDate, vat9Percent, vat21Percent, vatTotal);
            }
            catch (Exception)
            {
                MessageBox.Show("Entered year is not in the right format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowTextToElements(string startDate, string endDate, string vat9Percent, string vat21Percent, string vatTotal)
        {
            StartQuarterLabel.Text = startDate;
            EndQuarterLabel.Text = endDate;
            Vat9Label.Text = vat9Percent;
            Vat21Label.Text = vat21Percent;
            VatTotalLabel.Text = vatTotal;
        }

        /*Else*/

        private void HideAll()
        {
            foreach (Control control in Controls)
            {
                if (control is Panel)
                {
                    control.Hide();
                }
            }
        }

        private void toolStripParticipants_Click(object sender, EventArgs e)
        {

        }

        private void openStudentUpdateButton_Click(object sender, EventArgs e)
        {
            if (listViewStudents.SelectedItems.Count != 0)
            {
                ListViewItem selectedStudent = listViewStudents.SelectedItems[0];

                StudentUpdate studentUpdateForm = new((Student)selectedStudent.Tag);
                studentUpdateForm.ShowDialog();
                ShowStudentsPanel();
            }
            else
            {
                MessageBox.Show("Select a student!");
            }
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
        }

        private void OpenStudentAddForm_Click(object sender, EventArgs e)
        {

        }

        private void listViewDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripSupervisors_Click(object sender, EventArgs e)
        {
            ShowSupervisorsPanel();
        }

        private void ShowSupervisorsPanel()
        {
            HideAll();
            listActivitiesView.Items.Clear();
            pnlSupervisors.Show();

            try
            {
                List<Activity> activities = GetActivities();
                DisplayActivities(activities, "supervisor");
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
            }
        }

        private void BShowSupervisors_Click(object sender, EventArgs e)
        {
            listViewSupervisor.Items.Clear();
            if (listActivitiesView.SelectedItems.Count != 0)
            {
                ListViewItem selectedActivity = listActivitiesView.SelectedItems[0];
                LecturerService lecturerservice = new();
                List<Lecturer> lecturers = lecturerservice.ShowActivitySupervisors((Activity)selectedActivity.Tag);
                DisplayLecturers(lecturers, "supervisor");
            }
            else
            {
                MessageBox.Show("Activity wasn't chosen!");
            }
        }

        private void BDeleteSupervisors_Click(object sender, EventArgs e)
        {
            if (listViewSupervisor.SelectedItems.Count != 0)
            {
                ListViewItem selectedSupervisor = listViewSupervisor.SelectedItems[0];
                LecturerService lecturerService = new();
                lecturerService.DeleteSupervisor((Lecturer)selectedSupervisor.Tag);
                SecondCheck(selectedSupervisor);
                ShowSupervisorsPanel();
            }
            else
            {
                MessageBox.Show("Select a drink!");
            }
        }

        private void SecondCheck(ListViewItem selectedSupervisor)
        {
            DeleteCheckSupervisor deleteCheckSupervisorForm = new DeleteCheckSupervisor(selectedSupervisor);
            if (deleteCheckSupervisorForm.ShowDialog() == DialogResult.OK)
            {
                bool deleteMessage = deleteCheckSupervisorForm.DeleteMessage();
                if (deleteMessage)
                {
                    listViewSupervisor.Items.Remove(selectedSupervisor);
                    MessageBox.Show("Supervisor deleted!");
                }
                else
                {
                    MessageBox.Show("Supervisor not deleted!");
                }
            }
            else
            {
                MessageBox.Show("Action canceled!");
            }
        }

        private void BAddSupervisors_Click(object sender, EventArgs e)
        {
            AddSupervisorForm supervisorForm = new();
            supervisorForm.ShowDialog();
            ShowSupervisorsPanel();
        }

        private void BUpdateSupervisors_Click(object sender, EventArgs e)
        {
            if (listViewSupervisor.SelectedItems.Count != 0)
            {
                ListViewItem selectedSupervisor = listViewSupervisor.SelectedItems[0];

                UpdateSupervisorForm updateSupervisorForm = new((Lecturer)selectedSupervisor.Tag);

                updateSupervisorForm.ShowDialog();
                listViewSupervisor.Items.Remove(selectedSupervisor);
                ShowSupervisorsPanel();
            }
            else
            {
                MessageBox.Show("Select supervisor!");
            }
        }
    }
}