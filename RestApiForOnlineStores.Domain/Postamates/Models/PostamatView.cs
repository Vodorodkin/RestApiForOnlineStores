namespace RestApiForOnlineStores.Domain.Postamates.Models
{
    public class PostamatView
    {
        public string Id { get; }
        public string Address { get; }
        public bool State { get; }
        public string StateName { get; }

        public PostamatView(string id, string address, bool state)
        {
            Id = id;
            Address = address;
            State = state;
            StateName = state ? "Рабочий" : "Закрыт";
        }
    }
}