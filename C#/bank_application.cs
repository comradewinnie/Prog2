using System;
using System.Collections.Generic;

public class Bank
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Welcome to your Bank!\n");
		
        var client1 = new LocalClient(8745631, "Andrejs", "Ivanovs", "Talsi");
		var client2 = new ForeignClient(2345242, "Oskars", "Andersons", "ASV");
		
		client1.RequestInfo();
		client2.RequestInfo();
		
		Console.WriteLine();
		
		client1.AddAccount(new Account("LV12BANK5235673", "EUR"));
		client2.AddAccount(new Account("US35BANK4209653", "USD"));
		
		client1.AccountList[0].Deposit(1200);
		client1.AccountList[0].Withdraw(60);
		client1.AccountList[0].Withdraw(45);
		client1.AccountList[0].Withdraw(270);

		var transfer = new Transfer(client1.AccountList[0], client2.AccountList[0], 87);
		
		client1.PrintAccounts();
		client2.PrintAccounts();
    }
}

public class Client
{
    protected int _id;
    protected string _name;
    protected string _surname;
	private List<Account> _accountList = new List<Account>();
	
	public List<Account> AccountList
	{
		get
		{
			return _accountList;
		}
	}
	
    public Client(int id, string name, string surname)
    {
        _id = id;
        _name = name;
        _surname = surname;
    }
    
    public virtual void RequestInfo()
    {
        Console.WriteLine($"{_id}, {_name} {_surname}");
    }
	
	public void AddAccount(Account account)
	{
		_accountList.Add(account);
	}
	
	public void PrintAccounts()
	{
		Console.WriteLine($"Client {_name} {_surname} has the following accounts:");
		foreach (var account in _accountList)
		{
			Console.WriteLine($"Number: {account.AccountNumber}. Currency: {account.AccountCurrency}.");
			account.PrintTransactions();
		}
	}
}

public class LocalClient : Client
{
    private string _city;
        
    public LocalClient(int id, string name, string surname, string city) : base(id, name, surname)
    {
        _city = city;
    }
    public override void RequestInfo()
    {
        Console.WriteLine($"{_id}, {_name} {_surname}, {_city}");  
    }
}

public class ForeignClient : Client
{
    private string _country;
    
    public ForeignClient(int id, string name, string surname, string country) : base(id, name, surname)
    {
        _country = country;
    }
    
    public override void RequestInfo()
    {
        Console.WriteLine($"{_id}, {_name} {_surname}, {_country}");
    }
}

public class Account
{
	private string _accountNumber;
	private string _accountCurrency;
	private List<Transaction> _transactionList = new List<Transaction>();
	
	public string AccountCurrency
	{
		get
		{
			return _accountCurrency;
		}
	}
	
	public string AccountNumber
	{
		get
		{
			return _accountNumber;  
		}

		set
		{
			if(string.IsNullOrEmpty(value)) 
			{
				Console.WriteLine("Error. You cannot assign empty value!\n");
			}
			else if(value.Length != 15)
			{
				Console.WriteLine("Error. IBAN must contain 15 characters!\n");
			}
			else
			{
				_accountNumber = value;
			}
		}
	}
	
	public Account(string accountNumber, string accountCurrency)
	{
		AccountNumber = accountNumber;
		_accountCurrency = accountCurrency;
	}
	
	public void Deposit(double amount)
	{
		_transactionList.Add(new Transaction(amount, "deposit"));
	}
	
	public void Withdraw(double amount)
	{
	    double balance = CalculateBalance();
	    if(amount > balance)
	    {
	        Console.WriteLine($"Error. You've tried to withdraw {amount} {AccountCurrency}, but you have only {balance} {AccountCurrency}!\n");
	    }
	    else
		    _transactionList.Add(new Transaction(amount, "withdrawal"));
	}
	
	public void PrintTransactions()
	{
		Console.WriteLine($"Transactions for the account {_accountNumber}:");
		foreach (var transaction in _transactionList)
		{
			Console.WriteLine($"{transaction.Timestamp} {transaction.Type} {transaction.Amount} {AccountCurrency}");
		}
		Console.WriteLine("--------------------");
		Console.WriteLine($"Balance: {CalculateBalance()} {AccountCurrency}\n");
	}
	
	public double CalculateBalance()
	{
		double balance = 0;
		foreach (var transaction in _transactionList)
		{
			if(transaction.Type == "deposit")
			{
				balance += transaction.Amount;
			}
			else if(transaction.Type == "withdrawal")
			{
				balance -= transaction.Amount;
			}
		}
		return balance;
	}
}

public class Transaction
{
	private DateTime _timestamp;
	private double _amount;
	private string _type;
	
	public DateTime Timestamp { get{return _timestamp;} }
	public double Amount { get{return _amount;} }
	public string Type { get{return _type;} }
	
	public Transaction(double amount, string type)
	{
		_timestamp = DateTime.Now;
		_amount = amount;
		_type = type;
	}
}

public class Transfer
{
    private Account _sourceAccount;
    private Account _targetAccount;
    private double _amount;

    public Transfer(Account sourceAccount, Account targetAccount, double amount)
    {
        _sourceAccount = sourceAccount;
        _targetAccount = targetAccount;
        _amount = amount;
        Execute();
    }

    public void Execute()
    {
        if (_sourceAccount.AccountCurrency != _targetAccount.AccountCurrency)
        {
            Console.WriteLine($"Error! Account currencies are not the same.\n");
            return; // exit from a program
        }
        if (_amount > _sourceAccount.CalculateBalance())
        {
            Console.WriteLine($"Error! You have tried to transfer {_amount} {_sourceAccount.AccountCurrency}, but you have only {_sourceAccount.CalculateBalance()} {_sourceAccount.AccountCurrency}.\n");
            return;
        }
        _sourceAccount.Withdraw(_amount);
        _targetAccount.Deposit(_amount);

        Console.WriteLine($"Successfully transferred {_amount} {_sourceAccount.AccountCurrency} from account {_sourceAccount.AccountNumber} to account {_targetAccount.AccountNumber}.\n");
    }
}
