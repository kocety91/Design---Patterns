
using RestaurantComplaint.Enums;
using RestaurantComplaint.Models;

var waiter = new Waiter(Priority.Low);
var cook = new Cook(Priority.Medium);
var manager = new Manager(Priority.High);


waiter.SetSuccesor(cook);
cook.SetSuccesor(manager);

var complaint1 = new Complaint("SomeCustormer",Priority.Low);
var complaint2 = new Complaint("NoCustomer",Priority.Medium);
var complaint3 = new Complaint("RandomCustomer",Priority.High);
var complaint4 = new Complaint("ErrorCustomer",Priority.Crutial);

waiter.ProcessComplaint(complaint1);
waiter.ProcessComplaint(complaint2);
waiter.ProcessComplaint(complaint3);
waiter.ProcessComplaint(complaint4);