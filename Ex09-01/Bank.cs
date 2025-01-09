using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex09_01
{
    public class Bank
{
    private List<Account> accounts = new List<Account>();

    public void AddAccount(Account account)
    {
        accounts.Add(account);
    }

    public IEnumerable<Account> ListAccounts()
    {
        return accounts;
    }

    public Account FindAccountByNumber(int number)
    {
        var account = accounts.Find(a => a.Number == number);
        if (account == null)
            throw new Exceptio.AccountNotFoundException("Conta nao encontrada.");

        return account;
        }
    }
}
