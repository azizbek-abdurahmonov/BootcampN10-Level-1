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
                Console.WriteLine($"Playing {musicPlayer.nowPlaying.Author} - {musicPlayer.nowPlaying.Title}");
                break;
            case "p":
                musicPlayer.Previous(); 
                Console.WriteLine($"Playing {musicPlayer.nowPlaying.Author} - {musicPlayer.nowPlaying.Title}");

                break;
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


    public void Next()
    {
        if (Tracks[Tracks.Count - 1] == nowPlaying)
        {
            Console.Write("End of music ");
            nowPlaying = Tracks[0];
            isPaused = false;
        }
        else
        {
            for (var i = 0; i < Tracks.Count; i++)
            {
                if (Tracks[i] == nowPlaying)
                {
                    nowPlaying = Tracks[i + 1];
                    isPaused = false;

                    break;
                }
            }
        }
    }

    public void Previous()
    {
        if (nowPlaying == Tracks[0])
        {
            nowPlaying = Tracks[Tracks.Count - 1];
            isPaused = false;

        }
        else
        {
            for (var i = 0; i < Tracks.Count; i++)
            {
                if (nowPlaying == Tracks[i])
                {
                    nowPlaying = Tracks[i - 1];
                    isPaused = false;

                    break;
                }

            }
        }

    }

    public void Pause()
    {
        if (isPaused)
        {
            Console.WriteLine("Already paused! " + nowPlaying.Title);
        }
        else
        {
            Console.WriteLine($"Paused - {nowPlaying.Title}");
            isPaused = true;
        }
    }

    public void Play()
    {
        if (isPaused)
        {
            Console.WriteLine($"Play - {nowPlaying.Title}");
            isPaused = false;
        }else
            Console.WriteLine("Already played " + nowPlaying.Title);
    }

}