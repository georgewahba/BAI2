using System.Collections.Generic;

namespace BAI
{
    public class SetFuncs
    {
        public static HashSet<uint> AlleKleuren(uint[] pixeldata)
        {
            // *** IMPLEMENTATION HERE *** //
            // Hier mag je loopen over pixeldata
            // hier maak ik een hashset aan die de kleuren gaat opslaan

            var alleKleuren = new HashSet<uint>();
            if (pixeldata == null) return alleKleuren;

            foreach (var pixel in pixeldata)
            {
                alleKleuren.Add(pixel);
            }
            return alleKleuren;
        }

        public static HashSet<uint> BlauwTinten(uint[] pixeldata)
        {
            // *** IMPLEMENTATION HERE *** //
            // Hier mag je loopen over pixeldata
            // Een blauwe tint is een kleur waarbij de blauwe component (bits 7-0)
            // groter is dan zowel de rode (bits 23-16) als de groene component (bits 15-8).
            var blauweTinten = new HashSet<uint>();

            if (pixeldata == null) return blauweTinten;

            foreach (var pixel in pixeldata) 
            {
                byte rood = PixelFuncs.RoodWaarde(pixel);
                byte groen = PixelFuncs.GroenWaarde(pixel);
                byte blauw = PixelFuncs.BlauwWaarde(pixel);
                if (blauw > rood && blauw > groen)
                {
                    blauweTinten.Add(pixel);
                }
            }
            return blauweTinten;    
        }

        public static HashSet<uint> DonkereKleuren(uint[] pixeldata)
        {
            // *** IMPLEMENTATION HERE *** //
            // Hier mag je loopen over pixeldata
            // Een donkere kleur is een kleur waarbij de som van de
            // rode, groene en blauwe component (bits 23-16, 15-8, 7-0)
            // kleiner is dan 192.
            var donkereKleuren = new HashSet<uint>();

            if (pixeldata == null) return donkereKleuren;

            foreach (var pixel in pixeldata) {
                byte rood = PixelFuncs.RoodWaarde(pixel);
                byte groen = PixelFuncs.GroenWaarde(pixel);
                byte blauw = PixelFuncs.BlauwWaarde(pixel);
                if ((rood + groen + blauw) < 192)
                {
                    donkereKleuren.Add(pixel);
                }
            }
            return donkereKleuren;
        }

        public static HashSet<uint> NietBlauwTinten(uint[] pixeldata)
        {
            // *** IMPLEMENTATION HERE *** //
            // Gebruik set-operatoren op 1 of meer van de sets 'alle kleuren' /
            // 'blauwtinten' / 'donkere kleuren'
            // Gebruik dus GEEN loop

            //Pakt alle kleuren en blauwtinten en stop deze in variabelen 
            //Maakt een nieuwe hasset van alle kleuren en haalt alle blauwtinten daaruit weg.
            //bijgewerkte hasset zonder blauwtinten wordt gereturned
            var alleKleuren = AlleKleuren(pixeldata);
            var blauw = BlauwTinten(pixeldata);

            var nietBlauw = new HashSet<uint>(alleKleuren);
            nietBlauw.ExceptWith(blauw);
            return nietBlauw;
        }

        public static HashSet<uint> DonkerBlauwTinten(uint[] pixeldata)
        {
            // *** IMPLEMENTATION HERE *** //
            // Gebruik set-operatoren op 1 of meer van de sets 'alle kleuren' /
            // 'blauwtinten' / 'donkere kleuren'
            // Gebruik dus GEEN loop

            //Hetzelfde als NietBlauwTinten, maar hier kijken we naar alle waarden in DonkereKleuren die overeen komen met BlauwTinten
            //Alle overeenkomende blauwtinten uit donkere kleuren worden gereturned
            var alleDonkereKleuren = DonkereKleuren(pixeldata);
            var blauw = BlauwTinten(pixeldata);

            var nietBlauw = new HashSet<uint>(alleDonkereKleuren);
            nietBlauw.IntersectWith(blauw);
            return nietBlauw;
        }
    }
}
