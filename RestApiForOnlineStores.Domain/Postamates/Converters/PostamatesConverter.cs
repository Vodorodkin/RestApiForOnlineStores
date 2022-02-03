using System.Collections.Generic;
using System.Linq;
using RestApiForOnlineStores.Database.Postamates.Models;
using RestApiForOnlineStores.Domain.Postamates.Models;

namespace RestApiForOnlineStores.Domain.Postamates.Converters
{
    public static class PostamatesConverter
    {
        public static IEnumerable<PostamatView> ToPostamatViews(this IEnumerable<Postamat> postamates)
        {
            IEnumerable<PostamatView> postamatViews = postamates.Select(ToPostamatView);

            return postamatViews;
        }
        
        public static PostamatView ToPostamatView(this Postamat postamat)
        {
            PostamatView postamatView = new PostamatView(
                postamat.Id,
                postamat.Address,
                postamat.State);

            return postamatView;
        }
        
        public static IEnumerable<Postamat> ToPostamates(this IEnumerable<PostamatDb> postamatDbs)
        {
            IEnumerable<Postamat> postamates = postamatDbs.Select(ToPostamat);

            return postamates;
        }
        
        public static Postamat ToPostamat(this PostamatDb postamatDb)
        {
            Postamat postamat = new Postamat(
                postamatDb.Id,
                postamatDb.Address,
                postamatDb.State);

            return postamat;
        }
    }
}