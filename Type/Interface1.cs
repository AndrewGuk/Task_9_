
namespace Type
{
    internal interface ITransport
    {
        string Name { get; set; }
        string Type { get; set; }
        int Price { get; set; }
        string TransportInfo();
    }
}
