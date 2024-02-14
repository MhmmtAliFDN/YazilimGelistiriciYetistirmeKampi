using Business.Concretes;
using Entities.Concretes;

Citizen person1 = new Citizen();
person1.NationalIdentity = 14523699700;
person1.FirstName = "Muhammet Ali";
person1.LastName = "Fidan";
person1.DateOfBirthYear = 2000;

Citizen person2 = new Citizen();
person2.NationalIdentity = 12345678900;
person2.FirstName = "Ahmet";
person2.LastName = "Erkan";
person2.DateOfBirthYear = 2002;

Foreigner person3 = new Foreigner();
person3.ForeignerIdentity = 998461201643;
person3.FirstName = "Abdulbari";
person3.LastName = "El Huseyni";
person3.DateOfBirthYear = 1996;

PttManager pttManager = new PttManager(new CitizenManager());
pttManager.GiveMask(person1);


