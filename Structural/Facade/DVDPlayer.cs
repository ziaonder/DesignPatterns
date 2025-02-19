using System;

public class DVDPlayer
{
    public void On() => Console.WriteLine("DVD player is on");
    public void Off() => Console.WriteLine("DVD player is off");
    public void Play(string movie) => Console.WriteLine($"DVD player is playing {movie}");
}
