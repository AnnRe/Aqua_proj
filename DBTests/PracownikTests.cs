using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aquadrom.Utilities;
using NUnit.Framework;
using Objects;

namespace DBTests
{
    public class PracownikTests
    {
        [Test]
        public void ShouldCreatePracownik()
        {
            //given
            string imie = "Ala";
            string nazwisko = "Makota";
            eStanowisko stanowisko = eStanowisko.KZ;
            //when
            Pracownik pracownik = new Pracownik(imie, nazwisko, stanowisko);
            //then
            Assert.IsInstanceOf<Pracownik>(pracownik);
        }

    }
}
