public class ORTWorld
{
    public static List<string> ListaDestinos {get;private set;} = new List<string> () {"Nueva York","Roma","Londres","Atenas","Paris","Madrid","Brujas","Munich","Tel Aviv","Lisboa"};
    public static List<string> ListaHoteles  {get;private set;} = new List<string> () {"Hilton","Four Seasons","Sheraton","InterContinental","Marriott","BTH","IHG","Accor","Choice","Ritz"};
    public static List<string> ListaAereos  {get;private set;} = new List<string> (){"Iberia","Air France","British Airways","Lufthansa","American Airways","RyanAir","ITA","Turkish Airlines","Emirates","Qatar Airways"};
    public static List<string> ListaExcursiones {get;private set;} = new List<string> (){"Empire State","Coliseo","Big Ben", "Pantenon","Torre Eiffel","Palacio Real","Paseo en Barco","Tour Museos","Mar Muerto","Tour en Tranvia" };
    public static Dictionary<string,Paquete> Paquetes {get; private set;}

    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        bool cargaDic = false;

        if(! Paquetes.ContainsKey(destinoSeleccionado))
        {
            Paquetes.Add(destinoSeleccionado, paquete);
            cargaDic = true;
        }

        return cargaDic;
    }
}