namespace BAI
{
    public class PixelFuncs
    {
        public static uint FilterNiks(uint pixel)
        {
            return pixel;
        }

        public static uint FilterRood(uint pixel)
        {
            // *** IMPLEMENTATION HERE *** //
            //Dit is bedoeld om de rode bits (23–16) in de ARGB-kleur op 0 te zetten.
            //waarom we het reverten is om alles behalve rood te returnen
            return pixel & ~(0xFFu << 16);
        }

        public static uint FilterGroen(uint pixel)
        {
            // *** IMPLEMENTATION HERE *** //
            //Dit is bedoeld om de groene bits (15-8) in de ARGB-kleur op 0 te zetten.
            //waarom we het reverten is om alles behalve groen te returnen
            return pixel & ~(0xFFu << 8);
        }

        public static uint FilterBlauw(uint pixel)
        {
            // *** IMPLEMENTATION HERE *** //
            //Dit is bedoeld om de blauwe bits (7-0) in de ARGB-kleur op 0 te zetten.
            //waarom we het reverten is om alles behalve blauw te returnen
            return pixel & ~(0xFFu);
        }


        public static byte RoodWaarde(uint pixelvalue)
        {
            // *** IMPLEMENTATION HERE *** //
            // Haal de rode kleurcomponent (0-255) uit een 32-bit pixelwaarde (ARGB of RGB-formaat).
            // 1. (pixelvalue >> 16) schuift de bits 16 posities naar rechts,
            //    waardoor de rode component in de onderste 8 bits komt te staan.
            // 2. & 0xFFu maskeert alles behalve de onderste 8 bits,
            //    zodat alleen de rode waarde overblijft.
            // 3. (byte)(...) cast het resultaat naar een byte (0-255).
            // Dit geldt ook voor de methods GroenWaarde en BlauwWaarde.
            return (byte)((pixelvalue >> 16) & 0xFFu);
        }

        public static byte GroenWaarde(uint pixelvalue)
        {
            // *** IMPLEMENTATION HERE *** //
            return (byte)((pixelvalue >> 8) & 0xFFu);
        }   

        public static byte BlauwWaarde(uint pixelvalue)
        {
            // *** IMPLEMENTATION HERE *** //
            return (byte)((pixelvalue) & 0xFFu);
        }

        public static uint Steganografie(uint pixelvalue)
        {
            // *** IMPLEMENTATION HERE *** //

            //we mogen alleen bitwise operators gebruiken om 
            //de steganografie zichtbaar te maken 
            //in de minst-significante bit van het rode kanaal
            // >> 16 schuift de rode byte naar rechts, & 1u haalt alleen bit 0 eruit (0 of 1).
            uint bit = (pixelvalue >> 16) & 1u;

            // Als de bit = 1, geef een witte pixel terug (0xFFFFFFFF).
            // Als de bit = 0, geef een zwarte pixel terug (0xFF000000).
            // Hiermee maak je het verborgen zwart/wit beeld zichtbaar.
            return bit == 1u ? 0xFFFFFFFFu : 0xFF000000u;
        }


        // ***** Voor de liefhebbers - deze hoef je NIET te maken om een voldoende te krijgen! ***** //
        public static uint Steganografie2(uint pixelvalue)
        {
            // In het originele plaatje zit nog een tweede plaatje verstopt, maar dan op
            // een *nog* ingewikkelder manier.
            // Laat zien dat je echt een expert bent, en decodeer hier het tweede plaatje.
            // (Hint: kijk naar de eerste 4 bytes van de gedecodeerde data.)

            // *** IMPLEMENTATION HERE *** //
            return 0;
        }
    }
}
