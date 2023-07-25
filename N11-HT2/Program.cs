var t1 = new Track
{
    Title = "Ona nolasi",
    Author = "Abdurahmoniy"
};
var t2 = new Track
{
    Title = "Detstvo",
    Author = "Rauf & Faik"
};

var t3 = new Track
{
    Title = "Beat it",
    Author = "Michael Jackson"
};

var musicPlayer = new MusicPlayer();
musicPlayer.Tracks.Add(t1);
musicPlayer.Tracks.Add(t2);
musicPlayer.Tracks.Add(t3);

musicPlayer.nowPlaying = musicPlayer.Tracks[0];

while (true)
{
    Console.WriteLine(" Choose a command ( next - n, previous - p, pause - pause, play - play ): ");
    var command = default(string);
    var commands = new[] { "n", "p", "pause", "play" };
    command = Console.ReadLine();

    if (commands.Contains(command))
    {
        switch (command)
        {
            case "n":
                musicPlayer.Next();
                break;
            case "p":
                musicPlayer.Previous(); break;
            case "pause":
                musicPlayer.Pause();
                break;
            case "play":
                musicPlayer.Play();
                break;
        }
    }
    else
    {
        Console.WriteLine("Command not found please try again");
    }
}


public class Track
{
    public string Title;
    public string Author;
}

public class MusicPlayer
{
    public List<Track> Tracks = new List<Track>();
    public Track nowPlaying;
    public bool isPaused = false;

    //public MusicPlayer()
    //{
    //    if (Tracks.Count > 0)
    //        nowPlaying = Tracks[0];
    //}

    public void Next()
    {
        if (Tracks[Tracks.Count - 1] == nowPlaying)
        {
            nowPlaying = Tracks[0];
        }
        else
        {
            for (var i = 0; i < Tracks.Count; i++)
            {
                if (Tracks[i] == nowPlaying)
                {
                    nowPlaying = Tracks[i + 1];
                    break;
                }
            }
        }
        Play();
    }

    public void Previous()
    {
        if (nowPlaying == Tracks[0])
            nowPlaying = Tracks[Tracks.Count - 1];
        else
        {
            for (var i = 0; i < Tracks.Count; i++)
            {
                if (nowPlaying == Tracks[i])
                {
                    nowPlaying = Tracks[i - 1];
                    break;
                }

            }
        }
        Play();

    }

    public void Pause()
    {
        Console.WriteLine($"Paused - {nowPlaying.Title}");
    }

    public void Play()
    {
        Console.WriteLine($"Play - {nowPlaying.Title}");
    }

}