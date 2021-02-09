using GameProject.Abstract;
using GameProject.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class MernisServiceAdapter : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(TCKimlikNo: Convert.ToInt64(gamer.NationalityId),
                Ad: gamer.FirstName, Soyad: gamer.LastName, DogumYili: gamer.YearOfBirth))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
