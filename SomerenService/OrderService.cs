using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace SomerenService
{
    public class OrderService
    {
        OrderDAO orderDAO;
        const decimal VAT_9percentCalculation = 0.09m;
        const decimal VAT_21percentCalculation = 0.21m;
        

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

        public decimal Count9DrinkPrice(DateTime startDateTime, DateTime endDateTime)
        {
            List<Order> orders9VAT = Drinks9Percent(startDateTime, endDateTime, 9);
            decimal totalPrice9Percent = 0m;

            foreach (var order in orders9VAT)
            {
                totalPrice9Percent += order.Quantity * order.Drink.Price * VAT_9percentCalculation;
            }

            return totalPrice9Percent;
        }

        public decimal Count21DrinkPrice(DateTime startDateTime, DateTime endDateTime)
        {
            List<Order> orders21VAT = Drinks9Percent(startDateTime, endDateTime, 21);
            decimal totalPrice21Percent = 0m;

            foreach (var order in orders21VAT)
            {
                totalPrice21Percent += order.Quantity * order.Drink.Price * VAT_21percentCalculation;
            }

            return totalPrice21Percent;
        }

        public decimal CountTotalPrice(DateTime startDateTime, DateTime endDateTime)
        {
            return Count21DrinkPrice(startDateTime, endDateTime) + Count9DrinkPrice(startDateTime, endDateTime);
        }

        public DateTime CreateDateTime(int year, int quarterNr, bool isStart)
        {
            DateTime startDateTime = new DateTime(year, ((quarterNr - 1) * 3) + 1, 1);
            DateTime endDateTime = startDateTime.AddMonths(3).AddDays(-1);

            return isStart ? startDateTime : endDateTime;
        }

        public void VatInformation(int year, int quarterNumber, out string startDate, out string endDate, out string vat9Percent, out string vat21Percent, out string vatTotal)
        {
            DateTime startDateTime = CreateDateTime(year, quarterNumber, isStart: true);
            DateTime endDateTime = CreateDateTime(year, quarterNumber, isStart: false);
            startDate = startDateTime.ToString("yyyy-MM-dd");
            endDate = endDateTime.ToString("yyyy-MM-dd");
            ShowVAT(startDateTime, endDateTime, out vat9Percent, out vat21Percent, out vatTotal);
        }

        public void ShowVAT(DateTime startDateTime, DateTime endDateTime, out string vat9Percent, out string vat21Percent, out string vatTotal)
        {
            OrderService orderService = new();

            vat9Percent = orderService.Count9DrinkPrice(startDateTime, endDateTime).ToString("0.00");
            vat21Percent = orderService.Count21DrinkPrice(startDateTime, endDateTime).ToString("0.00");

            decimal totalVAT = orderService.CountTotalPrice(startDateTime, endDateTime);
            vatTotal = totalVAT.ToString("0.00");
        }
    }
}
