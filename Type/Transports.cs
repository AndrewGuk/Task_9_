namespace Type
{
    public abstract class Transport : ITransport
    {
        string _Name = "Unknow";
        int _Price = 10000;
        string _Type = "Unknow";
        public string Name
        {
            set
            {
                value = value == null ? (value = _Name) : _Name = value;
            }
            get { return _Name; }
        }
        public int Price
        {
            set
            {
                value = value == null ? (value = _Price) : _Price = value;
            }
            get { return _Price; }
        }
        public string Type
        {
            set
            {
                value = value == null ? (value = _Type) : _Type = value;
            }
            get { return _Type; }
        }

        public virtual string TransportInfo()
        {
            string x = $"Transport: {Type},\nName: {Name},\nPrice: {Price}";
            return x;
        }
    }
    public class Car : Transport 
    {
        public Car()
        {
            Type = "Car";
        }
        public override string TransportInfo()
        {
            return base.TransportInfo();
        }
    }
    public class Motorcycle : Transport
    {
        public Motorcycle()
        {
            Type = "Motorcycle";
        }
        public override string TransportInfo()
        {
            return base.TransportInfo();
        }
    }
    public class MyGarage<T> where T : Transport
    {
        List<T> list = new List<T>();
        public int Count
        {
            get { return list.Count; }
            private set { }
        }
        public void AddElement(T item)
        {
            list.Add(item);
        }
        public string PrintElement()
        {
            string x = string.Empty;
            for (int i = 0; i < list.Count; i++)
            {
                x += $"{list[i].TransportInfo()}\n";
            }
            return x;
        }
        public string InfoElement(int x)
        {
            string res = string.Empty;
            try
            {
                res = list[x].TransportInfo();
            }
            catch (ArgumentOutOfRangeException)
            {
                res = $"Sorry, MyGarage haven't the element {x}";
            }
            return res;
        }
    }
}