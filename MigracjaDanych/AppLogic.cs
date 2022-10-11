using Soneta.Business.App;
using Soneta.Business;
using Soneta.CRM;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MigracjaDanych
{
    public static class AppLogic
    {
        public static void MigrateData()
        {
            Kontrahenci contractors = null;
            XmlSerializer serializer = new XmlSerializer(typeof(Kontrahenci));
            using (StreamReader str = new StreamReader(@"D:\migracja_test.xml"))
            {
                contractors = (Kontrahenci)serializer.Deserialize(str);
            }
            Database database = BusApplication.Instance["Asnet_test"];
            using (Login login = database.Login(false, "itdesk", "PpP9pH53pq"))
            {
                using (Session session = login.CreateSession(false, false))
                {
                    CRMModule crmModule = CRMModule.GetInstance(session);
                    using (ITransaction tran = session.Logout(true))
                    {
                        foreach (var contractor in contractors.Kontrahent)
                        {
                            Kontrahent kontrahent = new Kontrahent();
                            crmModule.Kontrahenci.AddRow(kontrahent);
                            kontrahent.Kod = contractor.Numer.ToString();
                            kontrahent.NIP = contractor.NipTrim;
                            kontrahent.Nazwa = contractor.Nazwa;
                            kontrahent.Features["INDEX"] = contractor.Index;
                            kontrahent.Adres.Ulica = contractor.Ulica;
                            kontrahent.Adres.KodPocztowyS = contractor.KodPocztowy;
                            kontrahent.Adres.Miejscowosc = contractor.Miasto;
                            kontrahent.AdresDoKorespondencji.Ulica = contractor.UlicaKoresp;
                            kontrahent.AdresDoKorespondencji.Miejscowosc = contractor.MiastoKoresp;
                            kontrahent.AdresDoKorespondencji.KodPocztowyS = contractor.KodPocztowyKoresp;
                            kontrahent.PESEL = contractor.Pesel.ToString();
                            kontrahent.REGON = contractor.Regon;
                            kontrahent.Features["Pomiń przy indeksacji"] = contractor.PominIndeksacje == "1" ? true : false;
                            kontrahent.Kontakt.EMAIL = contractor.Email;
                            kontrahent.Kontakt.TelefonKomorkowy = contractor.Telefon;
                            kontrahent.Features["Notatka dla windykacji"] = contractor.NotatkaWindykacja;
                            kontrahent.Features["Notatka dla serwisu"] = contractor.NotatkaSerwis;
                            // konto bankowe
                            // sposob zaplaty
                            // opiekun
                            // zablokowany
                            // nieaktywny
                            // nazwa korespondecji
                            // Firma obsługująca
                        }
                        tran.Commit();
                    }
                    session.Save();
                }
            }
        }
    }
}
