/*//Task 2 
Age();
static void Age()
{
        try
        {
            int age = int.Parse(Console.ReadLine());

            if (age < 18 || age > 40)
            {
                throw new ArgumentException("Age is not between 18 and 40 ");
            }
            
        }
       
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            
        }
       
    
}
*/
/*//Task 1 
static void WriteTextToAnotherFile(string filepath, string text)
{
    File.WriteAllText(filepath, text );
}

try
{
    StreamReader inputFile = new StreamReader("C:\\Sample.txt");
    string outputFile = "C:\\Output.txt";
    // Read first line
    var line = inputFile.ReadLine();
    var upperLine =line.ToUpper();
    WriteTextToAnotherFile(outputFile, upperLine);
    
    while (line != null)
    {
        line = inputFile.ReadLine();
        line.ToUpper();
        WriteTextToAnotherFile(outputFile, line);
    }
}
catch(FileNotFoundException ex ) 
{
    Console.WriteLine("File is not exist ");
}
catch(IOException ex)
{
    Console.WriteLine( ex.Message);
}*/



/*//Task 3 
//Create a subscriber class with parameters phoneNum, balance (money), isInRoraming, expirationDate, isServiceActive. 
using System.Security.Cryptography.X509Certificates;

Subscriber subscriber = new Subscriber("094552634", 200, DateTime.Today.AddDays(10), false, true);
subscriber.Service();
class Subscriber
{
    public string PhoneNum { get; set; }
    public int Balance { get; set; }
    public DateTime ExpirationDate { get; set; } // jamketi avartman amsativ  20(end)-8(today)=12
    public bool IsInRoaming { get; set; }
    public bool IsServiceActive { get; set; }
    public Subscriber(string phoneNum, int balance, DateTime expirationDate, bool isInRoaming, bool isServiceActive)
    {
        PhoneNum = phoneNum;
        Balance = balance;
        ExpirationDate = expirationDate;
        IsInRoaming = isInRoaming;
        IsServiceActive = isServiceActive;
    }

    public void Service()
    {
        try
        {
            if ((ExpirationDate - DateTime.Today).TotalDays > 10)
            {
                throw new ExpirationDateExseption("Minchev jamketi avarty ka 10-ic avel or");
            }

            if (IsServiceActive)
            {
                throw new ServiceActiveExseption("Duq cheq karox aktivacnel patety, qani vor ayn arden akti e ");
            }
            if (IsInRoaming)
            {
                throw new RoamingException("Duq cheq karox aktivacnel patety ,qani vor roamingum eq ");
            }
            if (Balance < 2000)
            {
                throw new BalanceIsNotEnoughException("Duq cheq karox aktivacnel patety qani vor dzer hashvekshrum bavarar gumar chka")
                {
                    Additionalbalance = $"Dzer pahanjvox lracucich mnacordn e {2000 - Balance}"
                };
            }

            Console.WriteLine("Dzer patety aktivacvac e ");

        }
        catch (BalanceIsNotEnoughException e)
        {
            Console.WriteLine(e.Message + e.Additionalbalance);

        }
        catch (ExpirationDateExseption e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ServiceActiveExseption e)
        {
            Console.WriteLine(e.Message);
        }
        catch(RoamingException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
class BalanceIsNotEnoughException : Exception
{
    
    public BalanceIsNotEnoughException(string Message) : base(Message)
    {

    }

    public string Additionalbalance { get; set; }
}
class RoamingException : Exception
{
    public RoamingException(string Message) : base(Message)
    {

    }
}
class ServiceActiveExseption : Exception
{
    public ServiceActiveExseption(string Message) : base(Message)
    {

    }


}
class ExpirationDateExseption : Exception
{
    public ExpirationDateExseption(string Message) : base(Message)
    {

    }

}*/



/*//Task 4
Subscriber subscriber = new Subscriber("094552634", 2400, DateTime.Today.AddDays(10), false, false);
subscriber.Deal(200000,3);
class Subscriber
{
    public string PhoneNum { get; set; }
    public int Balance { get; set; }
    public DateTime ExpirationDate { get; set; } // jamketi avartman amsativ  20(end)-8(today)=12
    public bool IsInRoaming { get; set; }
    public bool IsServiceActive { get; set; }
    public Subscriber(string phoneNum, int balance, DateTime expirationDate, bool isInRoaming, bool isServiceActive)
    {
        PhoneNum = phoneNum;
        Balance = balance;
        ExpirationDate = expirationDate;
        IsInRoaming = isInRoaming;
        IsServiceActive = isServiceActive;
    }
    public void Deal(int money, int day)
    {
            try
            {
            if (money < Balance)
            {
                Balance -= money;
                ExpirationDate.AddDays(day);
            }
            else
            {
                throw new DeductMoneyException("Dzer gumary bavarar che gorcarqy katarelu hamar ")
                {
                    Charging = $"Dzer hashvin petq e lini arnvazn {money} gumar"
                };
                
            }

            }
            catch (DeductMoneyException ex)
            {
                Console.WriteLine(ex.Message+ex.Charging );
            }
        
        
    }
 

}
public class DeductMoneyException : Exception
{
    public DeductMoneyException(string Message) : base(Message)
    {
           
    }
    public string Charging { get; set; }
}
*/


/*//Task 5
using System.Runtime.InteropServices;

List<Subscriber> list = new List<Subscriber>()
{
     new Subscriber("094557485", 8000, DateTime.Today.AddDays(20), false, true),
     new Subscriber("094362485", 2000, DateTime.Today.AddDays(5), false, false),
     new Subscriber("093658595", 1001, DateTime.Today.AddDays(15), false, false),
     new Subscriber("093563698", 2000, DateTime.Today.AddDays(1), false, false),
     new Subscriber("093487523", 10000, DateTime.Today.AddDays(3), false, false)

};
//List<Subscriber> activationCandidates = new List<Subscriber>()
//{

//};
Subscriber subscriber = new Subscriber("094552634", 200, DateTime.Today.AddDays(10), false, true);
SubscriberProcessor subscriber2 = new SubscriberProcessor(list);
List<Subscriber> list1 = subscriber2.GetActivationCandidates();
Console.WriteLine(list1.Count);
foreach (var item in list1)
{
    Console.WriteLine("25252");
    Console.WriteLine(item.PhoneNum);
}


public class Subscriber
{
    public string PhoneNum { get; set; }
    public int Balance { get; set; }
    public DateTime ExpirationDate { get; set; } // jamketi avartman amsativ  20(end)-8(today)=12
    public bool IsInRoaming { get; set; }
    public bool IsServiceActive { get; set; }
    public Subscriber(string phoneNum, int balance, DateTime expirationDate, bool isInRoaming, bool isServiceActive)
    {
        PhoneNum = phoneNum;
        Balance = balance;
        ExpirationDate = expirationDate;
        IsInRoaming = isInRoaming;
        IsServiceActive = isServiceActive;
    }


}
public class BalanceIsNotEnoughException : Exception
{
    public BalanceIsNotEnoughException(string Message) : base(Message)
    {

    }

    public string Additionalbalance { get; set; }
}
public class RoamingException : Exception
{
    public RoamingException(string Message) : base(Message)
    {

    }
}
public class ServiceActiveExseption : Exception
{
    public ServiceActiveExseption(string Message) : base(Message)
    {

    }


}
public class ExpirationDateExseption : Exception
{
    public ExpirationDateExseption(string Message) : base(Message)
    {

    }

}
public class SubscriberProcessor
{
    private List<Subscriber> _subscribers;
    private object lockobj = new object();

    public SubscriberProcessor(List<Subscriber> subscribers)
    {
        _subscribers = subscribers;
    }
    public List<Subscriber> GetActivationCandidates()    // AKTIVACRACNERY 
    {
        List<Subscriber> filteredList = new List<Subscriber>();
        List<Task> tasks = new List<Task>();

        foreach (var subs in _subscribers)
        {

            tasks.Add(Task.Factory.StartNew(() =>
            {
                try
                {
                    if (IsActivationCandidate(subs))
                    {
                        lock (lockobj)    
                        {
                            filteredList.Add(subs);
                        }
                    }
                }


                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }));

        }

        Task.WaitAll(tasks.ToArray());

        return filteredList;
    }
    public bool IsActivationCandidate(Subscriber subscriber1)
    {
        if ((subscriber1.ExpirationDate - DateTime.Today).TotalDays > 10)
        {
            throw new ExpirationDateExseption("Minchev jamketi avarty ka 10-ic avel or");
        }

        if (subscriber1.IsServiceActive)
        {
            throw new ServiceActiveExseption("Duq cheq karox aktivacnel patety, qani vor ayn arden akti e ");
        }
        if (subscriber1.IsInRoaming)
        {
            throw new RoamingException("Duq cheq karox aktivacnel patety ,qani vor roamingum eq ");
        }
        if (subscriber1.Balance < 2000)
        {
            throw new BalanceIsNotEnoughException("Duq cheq karox aktivacnel patety qani vor dzer hashvekshrum bavarar gumar chka")
            {
                Additionalbalance = $"Dzer pahanjvox lracucich mnacordn e {2000 - subscriber1.Balance}"
            };
        }
        return true;

    }
}*/
