using Business.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ForeignerManager : IApplicantService
    {
        public bool CheckPerson(Person person)
        {
            return true; //Yabancılara ait mernis kullanılır.
        }
    }
}
