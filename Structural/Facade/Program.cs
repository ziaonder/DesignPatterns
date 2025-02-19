namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DVDPlayer dVDPlayer = new DVDPlayer();
            Projector projector = new Projector();
            SoundSystem soundSystem = new SoundSystem();
            Lights lights = new Lights();

            HomeTheaterFacade homeTheaterFacade = 
                new HomeTheaterFacade(dVDPlayer, projector, soundSystem, lights);

            homeTheaterFacade.WatchMovie("Eternal Sunshine of the Spotless Mind");
            homeTheaterFacade.EndMovie();
        }
    }
}
