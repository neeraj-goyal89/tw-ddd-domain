namespace tw_ddd.tw.ddd.domain.Misc
{
    public class Address
    {
        public int HouseNumber { get; }
        public string State { get; }
        public int PinCode { get; }

        public Address(int houseNumber, string state, int pinCode)
        {
            HouseNumber = houseNumber;
            State = state;
            PinCode = pinCode;
        }
    }
}