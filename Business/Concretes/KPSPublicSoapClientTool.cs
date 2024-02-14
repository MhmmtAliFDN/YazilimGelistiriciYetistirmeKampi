using Entities.Concretes;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public static class KPSPublicSoapClientTool
    {
        public static bool Check(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(((Citizen)person).NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear)
                .Result.Body.TCKimlikNoDogrulaResult;

            return result;
        }
    }
}
