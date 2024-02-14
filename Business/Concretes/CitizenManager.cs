using Business.Abstracts;
using Entities.Concretes;
using MernisServiceReference;

namespace Business.Concretes
{
    public class CitizenManager : IApplicantService
    {
        public bool CheckPerson(Person person)
        {
            var result = KPSPublicSoapClientTool.Check(person);
            return result;
        }
    }
}
