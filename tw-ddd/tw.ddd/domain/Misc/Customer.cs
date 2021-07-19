using System;
using System.Collections.Generic;

namespace tw_ddd.tw.ddd.domain.Misc
{
    public class Customer
    {
        public string CustomerId { get; }
        
        private List<BankAccount> _bankAccountList;
        private Address _address;

        public Customer(List<BankAccount> bankAccountList, Address address)
        {
            _bankAccountList = bankAccountList;
            CustomerId = Guid.NewGuid().ToString();
            _address = address;
        }

        public void UpdateAddress(Address newAddress)
        {
            //var bankAccountsCopy = new List<BankAccount>(_bankAccountList);
            try
            {
                foreach (var bankAccount in _bankAccountList)
                {
                    bankAccount.UpdateAddress(newAddress);
                }
                // Any processing .... 
                
                //_bankAccountList = bankAccountsCopy;
                _address = newAddress;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}