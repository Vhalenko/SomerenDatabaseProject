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
                DisplayLecturers(lecturers);
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
            RoomService roomService = new RoomService();
            return roomService.GetRooms();
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
                DisplayActivities(activities);
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
                ListViewItem li = new ListViewItem();
                li.SubItems.Add(drink.Id.ToString());
                li.SubItems.Add(drink.Name);
                li.SubItems.Add(drink.Price.ToString());
                li.SubItems.Add(drink.StockToText);
                li.SubItems.Add(drink.Vat.ToString());

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
                int drinkId = int.Parse(listViewDrinks.SelectedItems[0].SubItems[1].Text);

                DrinkService drinkService = new();
                drinkService.RemoveDrink(drinkId);

                MessageBox.Show("Drink deleted!");
            }
            else
            {
                MessageBox.Show("Select a drink!");
            }
        }

        private void btnDrinkAdd_Click(object sender, EventArgs e)
        {
            DrinkAddForm drinkAddForm = new DrinkAddForm();
            drinkAddForm.Show();
        }

        private void btnUpdateDrink_Click(object sender, EventArgs e)
        {
            if (listViewDrinks.SelectedItems.Count != 0)
            {
                int drinkId = int.Parse(listViewDrinks.SelectedItems[0].SubItems[1].Text);
                DrinkUpdateForm drinkUpdateForm = new DrinkUpdateForm(drinkId);
                drinkUpdateForm.Show();
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
            listBoxStudentsNames.Items.Clear();

            foreach (Student student in students)
            {
                listBoxStudentsNames.Items.Add(student);
            }
        }

        private void DisplayDrinksForOrder(List<Drink> drinks)
        {
            listBoxDrinks.Items.Clear();

            foreach (Drink drink in drinks)
            {
                listBoxDrinks.Items.Add(drink);
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
                OrderService orderService = new();

                orderService.FillOrder(listBoxStudentsNames.SelectedIndex, listBoxDrinks.SelectedIndex, (Student)listBoxStudentsNames.SelectedItem, (Drink)listBoxDrinks.SelectedItem, (int)quantityOfDrinks.Value);
                MessageBox.Show("Order is successfully placed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxStudentsNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderService orderService = new();

            orderService.DisplayPrice((Drink)listBoxDrinks.SelectedItem, listBoxStudentsNames.SelectedIndex, listBoxDrinks.SelectedIndex, quantityOfDrinks.Value, out string totalPrice);
            PriceOutputLabel.Text = totalPrice;
        }

        private void listBoxDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderService orderService = new();

            orderService.DisplayPrice((Drink)listBoxDrinks.SelectedItem, listBoxStudentsNames.SelectedIndex, listBoxDrinks.SelectedIndex, quantityOfDrinks.Value, out string totalPrice);
            PriceOutputLabel.Text = totalPrice;
        }

        private void quantityOfDrinks_ValueChanged(object sender, EventArgs e)
        {
            OrderService orderService = new();

            orderService.DisplayPrice((Drink)listBoxDrinks.SelectedItem, listBoxStudentsNames.SelectedIndex, listBoxDrinks.SelectedIndex, quantityOfDrinks.Value, out string totalPrice);
            PriceOutputLabel.Text = totalPrice;
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
            OrderService orderService = new();

            orderService.VatInformation(int.Parse(textBox1.Text), quarterNumber, out string startDate, out string endDate, out string vat9Percent, out string vat21Percent, out string vatTotal);

            label10.Text = startDate;
            label12.Text = endDate;
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
    }
}