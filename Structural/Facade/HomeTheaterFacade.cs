using System;

public class HomeTheaterFacade
{
    private DVDPlayer dvdPlayer;
    private Projector projector;
    private SoundSystem soundSystem;
    private Lights lights;

    public HomeTheaterFacade(DVDPlayer dvdPlayer, Projector projector, SoundSystem soundSystem, Lights lights)
    {
        this.dvdPlayer = dvdPlayer;
        this.projector = projector;
        this.soundSystem = soundSystem;
        this.lights = lights;
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine("Get ready to watch a movie...");
        lights.Dim(30);
        projector.On();
        soundSystem.On();
        soundSystem.SetVolume(100);
        dvdPlayer.On();
        dvdPlayer.Play(movie);
    }

    public void EndMovie()
    {
        Console.WriteLine("Shutting down movie theater...");
        lights.Dim(100);
        projector.Off();
        soundSystem.Off();
        dvdPlayer.Off();
    }
}
