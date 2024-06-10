public class ORTWorld
{
    public static List<string> ListaDestinos {get;private set;} = new List<string> () {"Nueva York.jpg","Roma.jpg","Londres.jpg","Atenas.jpg","Paris.jpeg","Madrid.jpg","Brujas.jpg","Munich.jpg","Tel Aviv.jpg","Lisboa.jpg"};
    public static List<string> ListaHoteles  {get;private set;} = new List<string> () {"Hilton.jpg","Four Seasons.jpg","Sheraton.jpg","InterContinental.jfif","Marriott.jpg","BTH.jpg","IHG.jpg","Accor.jpg","Choice.jpg","Ritz.jpg"};
    public static List<string> ListaAereos  {get;private set;} = new List<string> (){"Iberia.jpg","Air France.jpg","British Airways.png","Lufthansa.jpg","American Airlines.jpg","RyanAir.jpg","Alitalia.jpg","Turkish Airlines.jpg","Emirates.png","Qatar Airways.png"};
    public static List<string> ListaExcursiones {get;private set;} = new List<string> (){"Empire State.jpg","Coliseo.jpg","Big Ben.jpg", "Pantenon.jpg","Torre Eiffel.png","Palacio Real.jpg","Paseo en Barco.jpg","Tour Museos.jpg","Mar Muerto.jpg","Tour en Tranvia.jpg" };
    public static Dictionary<string,Paquete> Paquetes {get; private set;} = new Dictionary<string, Paquete>();

    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        bool cargaDic = false;

        if(!Paquetes.ContainsKey(destinoSeleccionado))
        {
            Paquetes.Add(destinoSeleccionado, paquete);
            cargaDic = true;
        }

        return cargaDic;
    }
}