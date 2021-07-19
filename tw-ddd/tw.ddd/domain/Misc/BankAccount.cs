using System;

namespace tw_ddd.tw.ddd.domain.Misc
{
    public class BankAccount
    {
        private Address _address;
        private string _bankAccountNumber;
        
        public BankAccount(Address address)
        {
            _address = address;
            _bankAccountNumber = Guid.NewGuid().ToString();
        }
        protected internal bool UpdateAddress(Address newAddress)
        {
            try
            {
                _address = newAddress;
                return true;
            }
            catch (Exception _)
            {
                return false;
            }
        }
    }
}