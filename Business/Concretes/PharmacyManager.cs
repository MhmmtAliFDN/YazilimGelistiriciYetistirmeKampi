using Business.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class PharmacyManager : ISupplierService
    {
        IApplicantService applicantService;

        public PharmacyManager(IApplicantService applicantService)
        {
            this.applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            //ecazeneye ait kodlar... Örn. stok bilgisi
            if (applicantService.CheckPerson(person))
            {
                if (person is Citizen)
                {
                    Console.WriteLine(((Citizen)person).NationalIdentity + " nolu " + person.FirstName + " için maske verildi.");
                }
                else
                {
                    Console.WriteLine(((Foreigner)person).ForeignerIdentity + " nolu " + person.FirstName + " için maske verildi.");
                }
            }
            else
            {
                Console.WriteLine("Kullanıcı doğrulanamadı, bilgileri eksiksiz bir şekilde tekrar giriniz.");
            }
        }
    }
}
