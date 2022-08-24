using System;

/// <summary> LESSON3 / ÖDEV2
/// 
/// ClassMetotDemo isimli bir proje oluşturunuz.
/// Bunu Github'a aktarınız.
/// Projeniz şunu yapacak.
/// Bir bankada müşteri takibi yapmak istiyorsunuz.
/// Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
/// MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme, silme gibi metotları simule ediniz.
///
/// </summary>

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
              //  --1--
            Customer customer1 = new Customer();
            customer1.ID = 1;
            customer1.NameSurname = "Fatima Ali";
            customer1.Adress = "İstanbul";
            customer1.Email = "fatima@gmail.com";

              // --2--
            Customer customer2 = new Customer();
            customer2.ID = 2;
            customer2.NameSurname = "Ahmaet Ahmet";
            customer2.Adress = "İstanbul";
            customer2.Email = "ahmet@gmail.com";
            
            CustomerManager CManager = new CustomerManager();
            //  add
            CManager.addCustomer(customer1);
            CManager.addCustomer(customer2);

            // list
            CManager.listCustomer();

            // remove
            CManager.removCustomer(customer2);

        }
    }
}
