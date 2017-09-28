namespace DanubiusInfo.B4USApi.DTO
{
    public class ServiceDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Melyik naptárhoz tartozik
        public int Location { get; set; }

        //A szolgáltatás hossza (percben).
        public int Duration { get; set; }

        //Jelöli, hogy az ügyfél számára látható-e a szolgáltatás hossza.
        public bool IsDurationVisible { get; set; }

        //Megjegyzés
        public string Note { get; set; }

        //A felhasználó számára mutatott hossz.
        public int DurationToUser { get; set; }
    }
}
