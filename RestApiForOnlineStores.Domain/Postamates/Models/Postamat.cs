namespace RestApiForOnlineStores.Domain.Postamates.Models
{
    public class Postamat
    {
        public string Id { get; }
        public string Address { get; }
        //true - working, false - closed
        public bool State { get; }

        public Postamat(string id, string address, bool state)
        {
            Id = id;
            Address = address;
            State = state;
        }
    }
}