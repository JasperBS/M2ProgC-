
namespace Classes
{

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
            program.Run();
    }

        private void Run()
        {
            Auto auto1 = new Auto()
            {
                automaat = true,
                kenteken = "AA824H",
                kilometerstand = 20567,
                merk = "volkswagen"
            };

            Auto auto2 = new Auto()
            {
                automaat = false,
                kenteken = "KU786G",
                kilometerstand = 65739,
                merk = "volvo"
            };


        Rijleraar RijLeraar;

        }
}
}