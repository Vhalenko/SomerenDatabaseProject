using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;

namespace SomerenService
{
    public class OrderService
    {
        OrderDAO orderDAO;

        public OrderService()
        {
            orderDAO = new OrderDAO();
        }

        public void CreateOrder(Student student, Drink drink, int quantity, DateTime dateOfOrder)
        {
            orderDAO.CreateOrder(student, drink, quantity, dateOfOrder);
        }

        public List<Order> GetOrders()
        {
            return orderDAO.GetAll();
        }

        public List<Order> Drinks21Percent(DateTime startQuarterDate, DateTime endQuarterDate, int percentageVat)
        { 
            return orderDAO.GetAllDrinksByPercentage(startQuarterDate, endQuarterDate, percentageVat);
        }

        public List<Order> Drinks9Percent(DateTime startQuarterDate, DateTime endQuarterDate, int percentageVat)
        {
            return orderDAO.GetAllDrinksByPercentage(startQuarterDate, endQuarterDate, percentageVat);
        }

        public int CountAmountOfClients(DateTime startDate, DateTime endDate)
        {
            return orderDAO.CountAmountOfClients(startDate, endDate);
        }
    }
}
