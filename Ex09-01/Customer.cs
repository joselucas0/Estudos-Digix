using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex09_01
{
    class Customer
{
    public string Name { get; }
    public string Address { get; }
    public DateTime DateOfBirth { get; }
    public int CardNumber { get; }
    private string PIN;

    public Customer(string name, string address, DateTime dob, int cardNumber, string pin)
    {
        Name = name;
        Address = address;
        DateOfBirth = dob;
        CardNumber = cardNumber;
        PIN = pin;
    }

    public void VerifyPassword(string pin)
    {
        if (PIN != pin)
            throw new Exceptio.AuthenticationException("PIN inválido.");
    }
 }
}