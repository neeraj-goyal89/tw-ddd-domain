namespace tw_ddd.tw.ddd.domain
{
    public class Product
    {
        private string _name;

        public Product(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Product))
                return false;
            
            return (_name == ((Product)obj)._name);
        }
        public override int GetHashCode()
        {
            return _name.GetHashCode();
        }
    }
}