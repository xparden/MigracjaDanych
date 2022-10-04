using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigracjaDanych
{

    // UWAGA: Wygenerowany kod może wymagać co najmniej programu .NET Framework 4.5 lub .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Kontrahenci
    {

        private KontrahenciKontrahent[] kontrahentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Kontrahent")]
        public KontrahenciKontrahent[] Kontrahent
        {
            get
            {
                return this.kontrahentField;
            }
            set
            {
                this.kontrahentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class KontrahenciKontrahent
    {

        private string nazwaField;

        private object peselField;

        private byte smopField;

        private string nipTrimField;

        private string regonField;

        private string indexField;

        private string ulicaField;

        private string miastoField;

        private string kodPocztowyField;

        private string telefonField;

        private object faxField;

        private string emailField;

        private string notatkaSerwisField;

        private string notatkaWindykacjaField;

        private string kontoBankoweField;

        private string sposobZaplatyField;

        private string opiekunField;

        private string pominIndeksacjeField;

        private byte zablokowanyField;

        private byte nieaktywnyField;

        private string ulicaKorespField;

        private string miastoKorespField;

        private string kodPocztowyKorespField;

        private string nazwaKorespField;

        private uint numerField;

        private byte drukujOswiadczenieField;

        private string firmaObslugujacaField;

        private KontrahenciKontrahentObiekt[] obiektField;

        /// <remarks/>
        public string Nazwa
        {
            get
            {
                return this.nazwaField;
            }
            set
            {
                this.nazwaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object Pesel
        {
            get
            {
                return this.peselField;
            }
            set
            {
                this.peselField = value;
            }
        }

        /// <remarks/>
        public byte Smop
        {
            get
            {
                return this.smopField;
            }
            set
            {
                this.smopField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string NipTrim
        {
            get
            {
                return this.nipTrimField;
            }
            set
            {
                this.nipTrimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Regon
        {
            get
            {
                return this.regonField;
            }
            set
            {
                this.regonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Index
        {
            get
            {
                return this.indexField;
            }
            set
            {
                this.indexField = value;
            }
        }

        /// <remarks/>
        public string Ulica
        {
            get
            {
                return this.ulicaField;
            }
            set
            {
                this.ulicaField = value;
            }
        }

        /// <remarks/>
        public string Miasto
        {
            get
            {
                return this.miastoField;
            }
            set
            {
                this.miastoField = value;
            }
        }

        /// <remarks/>
        public string KodPocztowy
        {
            get
            {
                return this.kodPocztowyField;
            }
            set
            {
                this.kodPocztowyField = value;
            }
        }

        /// <remarks/>
        public string Telefon
        {
            get
            {
                return this.telefonField;
            }
            set
            {
                this.telefonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object Fax
        {
            get
            {
                return this.faxField;
            }
            set
            {
                this.faxField = value;
            }
        }

        /// <remarks/>
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string NotatkaSerwis
        {
            get
            {
                return this.notatkaSerwisField;
            }
            set
            {
                this.notatkaSerwisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string NotatkaWindykacja
        {
            get
            {
                return this.notatkaWindykacjaField;
            }
            set
            {
                this.notatkaWindykacjaField = value;
            }
        }

        /// <remarks/>
        public string KontoBankowe
        {
            get
            {
                return this.kontoBankoweField;
            }
            set
            {
                this.kontoBankoweField = value;
            }
        }

        /// <remarks/>
        public string SposobZaplaty
        {
            get
            {
                return this.sposobZaplatyField;
            }
            set
            {
                this.sposobZaplatyField = value;
            }
        }

        /// <remarks/>
        public string Opiekun
        {
            get
            {
                return this.opiekunField;
            }
            set
            {
                this.opiekunField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string PominIndeksacje
        {
            get
            {
                return this.pominIndeksacjeField;
            }
            set
            {
                this.pominIndeksacjeField = value;
            }
        }

        /// <remarks/>
        public byte Zablokowany
        {
            get
            {
                return this.zablokowanyField;
            }
            set
            {
                this.zablokowanyField = value;
            }
        }

        /// <remarks/>
        public byte Nieaktywny
        {
            get
            {
                return this.nieaktywnyField;
            }
            set
            {
                this.nieaktywnyField = value;
            }
        }

        /// <remarks/>
        public string UlicaKoresp
        {
            get
            {
                return this.ulicaKorespField;
            }
            set
            {
                this.ulicaKorespField = value;
            }
        }

        /// <remarks/>
        public string MiastoKoresp
        {
            get
            {
                return this.miastoKorespField;
            }
            set
            {
                this.miastoKorespField = value;
            }
        }

        /// <remarks/>
        public string KodPocztowyKoresp
        {
            get
            {
                return this.kodPocztowyKorespField;
            }
            set
            {
                this.kodPocztowyKorespField = value;
            }
        }

        /// <remarks/>
        public string NazwaKoresp
        {
            get
            {
                return this.nazwaKorespField;
            }
            set
            {
                this.nazwaKorespField = value;
            }
        }

        /// <remarks/>
        public uint Numer
        {
            get
            {
                return this.numerField;
            }
            set
            {
                this.numerField = value;
            }
        }

        /// <remarks/>
        public byte DrukujOswiadczenie
        {
            get
            {
                return this.drukujOswiadczenieField;
            }
            set
            {
                this.drukujOswiadczenieField = value;
            }
        }

        /// <remarks/>
        public string FirmaObslugujaca
        {
            get
            {
                return this.firmaObslugujacaField;
            }
            set
            {
                this.firmaObslugujacaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Obiekt")]
        public KontrahenciKontrahentObiekt[] Obiekt
        {
            get
            {
                return this.obiektField;
            }
            set
            {
                this.obiektField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class KontrahenciKontrahentObiekt
    {

        private string kodField;

        private string nazwaField;

        private string ulicaField;

        private string kodPocztowyField;

        private string miastoField;

        private string notatkaField;

        private object sektorSerwisuField;

        private string cenaZaUslugeSerwisuField;

        private string sektorPatroluField;

        private string cenaUslugaPatroluField;

        private object wykonawcaPatroluField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Kod
        {
            get
            {
                return this.kodField;
            }
            set
            {
                this.kodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Nazwa
        {
            get
            {
                return this.nazwaField;
            }
            set
            {
                this.nazwaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Ulica
        {
            get
            {
                return this.ulicaField;
            }
            set
            {
                this.ulicaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string KodPocztowy
        {
            get
            {
                return this.kodPocztowyField;
            }
            set
            {
                this.kodPocztowyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Miasto
        {
            get
            {
                return this.miastoField;
            }
            set
            {
                this.miastoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Notatka
        {
            get
            {
                return this.notatkaField;
            }
            set
            {
                this.notatkaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object SektorSerwisu
        {
            get
            {
                return this.sektorSerwisuField;
            }
            set
            {
                this.sektorSerwisuField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CenaZaUslugeSerwisu
        {
            get
            {
                return this.cenaZaUslugeSerwisuField;
            }
            set
            {
                this.cenaZaUslugeSerwisuField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SektorPatrolu
        {
            get
            {
                return this.sektorPatroluField;
            }
            set
            {
                this.sektorPatroluField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CenaUslugaPatrolu
        {
            get
            {
                return this.cenaUslugaPatroluField;
            }
            set
            {
                this.cenaUslugaPatroluField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object WykonawcaPatrolu
        {
            get
            {
                return this.wykonawcaPatroluField;
            }
            set
            {
                this.wykonawcaPatroluField = value;
            }
        }
    }




}
