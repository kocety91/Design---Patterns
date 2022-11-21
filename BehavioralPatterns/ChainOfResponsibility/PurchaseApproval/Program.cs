
using PurchaseApproval.Models;

var teamLead = new TeamLead();
var vicePresident = new VicePresident();
var president = new President();

teamLead.SetSuccessor(vicePresident);
vicePresident.SetSuccessor(president);

var firstPurchase = new Purchase(343.00M, 1);
teamLead.ProccessPurchase(firstPurchase);

var secondPurchase = new Purchase(44000.00M, 2);
teamLead.ProccessPurchase(secondPurchase);

var thirdPurchase = new Purchase(70000.00M, 3);
teamLead.ProccessPurchase(thirdPurchase);   