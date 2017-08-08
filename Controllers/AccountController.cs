using Microsoft.AspNetCore.Mvc;
using tryNetMvc.Models;
using System;

namespace tryNetMvc.Controllers{
public class AccountController : Controller{
       
	public IActionResult Index(string accountName){
       	      Console.WriteLine("Enter Add Method");
	      if (accountName != null)
	      	 Account.Add(accountName);
	      return View("Index",GlobalVariables.Accounts);
	      }
	 
}
}