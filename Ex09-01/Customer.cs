public class Customer
{
    public string Name { get; set; }
    public string Address { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int CardNumber { get; set; }
    private string Pin { get; set; }

    public Customer(string name, string address, DateTime dateOfBirth, int cardNumber, string pin)
    {
        Name = name;
        Address = address;
        DateOfBirth = dateOfBirth;
        CardNumber = cardNumber;
        Pin = pin;
    }

    public bool VerifyPassword(string pin)
    {
        if (pin == null)
            throw new ArgumentNullException(nameof(pin), "O PIN fornecido é nulo.");
        
        return Pin == pin;
    }
}
