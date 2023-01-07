using Government;
using Bank;
CentralGov govt = new CentralGov();
BankManager bankMgr = new BankManager();

TaxOperation itoperation = new TaxOperation(govt.DeductIncomeTax);
TaxOperation stoperation = new TaxOperation(govt.DeductServiceTax);
TaxOperation ptoperation = new TaxOperation(govt.DeductProfessionalTax);

ManagerOpr smsalert = new ManagerOpr(bankMgr.SMSAlert);
ManagerOpr emailalert = new ManagerOpr(bankMgr.EmailAlert);
ManagerOpr blockact = new ManagerOpr(bankMgr.BlockAccount);

// itoperation();
// stoperation();
// ptoperation();

Account act1 =new Account(30000);



act1.overbalance+=itoperation;
act1.overbalance+=stoperation;

act1.underbalance+=smsalert;
act1.underbalance+=emailalert;
act1.underbalance+=blockact;

act1.deposit(500000);
act1.processTax();
Console.WriteLine(act1);

act1.withdraw(526000);
Console.WriteLine(act1);
