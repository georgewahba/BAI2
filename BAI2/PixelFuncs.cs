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
            return 0;
        }

        public static byte GroenWaarde(uint pixelvalue)
        {
            // *** IMPLEMENTATION HERE *** //
            return 0;
        }

        public static byte BlauwWaarde(uint pixelvalue)
        {
            // *** IMPLEMENTATION HERE *** //
            return 0;
        }

        public static uint Steganografie(uint pixelvalue)
        {
            // *** IMPLEMENTATION HERE *** //
            return 0;
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
