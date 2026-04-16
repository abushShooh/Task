public class BankAccount
{
    private readonly int accountId;   // нельзя менять после создания
    private decimal balance;          // меняется только через методы
    private bool isFrozen;            // заморожен ли счет

    public string OwnerName { get; set; }

    public int AccountId => accountId;
    public decimal Balance => balance;
    public bool IsFrozen => isFrozen;

    // Конструктор как в примере использования: (id, ownerName, balance)
    public BankAccount(int accountId, string ownerName, decimal initialBalance)
    {
        if (accountId <= 0) throw new ArgumentException("accountId должен быть > 0.");
        if (string.IsNullOrWhiteSpace(ownerName)) throw new ArgumentException("OwnerName не может быть пустым.");
        if (initialBalance < 0) throw new ArgumentException("Начальный баланс не может быть отрицательным.");

        this.accountId = accountId;
        OwnerName = ownerName;
        balance = initialBalance;
        isFrozen = false;
    }

    // Доп. конструктор (как в диаграмме): (id, balance, ownerName)
    public BankAccount(int accountId, decimal initialBalance, string ownerName)
        : this(accountId, ownerName, initialBalance)
    {
    }

    public void Deposit(decimal amount)
    {
        if (isFrozen)
        {
            Console.WriteLine("Операция отклонена: счет заморожен.");
            return;
        }

        if (amount <= 0)
        {
            Console.WriteLine("Сумма пополнения должна быть больше 0.");
            return;
        }

        balance += amount;
        Console.WriteLine($"Пополнение: {amount:F2}. Текущий баланс: {balance:F2}");
    }

    public void Withdraw(decimal amount)
    {
        if (isFrozen)
        {
            Console.WriteLine("Операция отклонена: счет заморожен.");
            return;
        }

        if (amount <= 0)
        {
            Console.WriteLine("Сумма снятия должна быть больше 0.");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Недостаточно средств на счете.");
            return;
        }

        balance -= amount;
        Console.WriteLine($"Снятие: {amount:F2}. Текущий баланс: {balance:F2}");
    }

    public void FreezeAccount()
    {
        isFrozen = true;
        Console.WriteLine("Счет заморожен.");
    }

    public void UnfreezeAccount()
    {
        isFrozen = false;
        Console.WriteLine("Счет разморожен.");
    }
}