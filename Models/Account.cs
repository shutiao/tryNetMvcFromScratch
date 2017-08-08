using System.Collections.Generic;
using System;

namespace tryNetMvc.Models{
public class Account{
       public string Name;
       public static void Add(string AccountName){
       	      var account = new Account();
	      account.Name = AccountName;
	      GlobalVariables.Accounts.Add(account);
	      Console.WriteLine(account.Name + " is added");
	      }
	 public static List<Account> GetAll(){
	 	return GlobalVariables.Accounts;
		}
}
}