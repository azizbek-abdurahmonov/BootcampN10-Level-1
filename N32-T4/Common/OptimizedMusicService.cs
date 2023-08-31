namespace N32_T4.Model;

public sealed class OptimizedMusicService : MusicService
{
    private List<Music> _musics;
    private Music _currentMusic;

    public OptimizedMusicService()
    {
        _musics = new();
    }

    public void PlayRandomMusic()
    {
        if (_musics.Count == 0)
            throw new Exception("Musiqalar yo'q");
        var random = new Random();
        _currentMusic = _musics[random.Next(0, _musics.Count)];
    }

    private void SwitchToFirst()
    {
        if (_musics.Count == 0)
            throw new Exception("Music list is empty");

        _currentMusic = _musics.First();
    }

    private void SwitchToLast()
    {
        if (_musics.Count == 0)
            throw new Exception("Music list is empty");

        _currentMusic = _musics.Last();
    }

    private bool IsCurrentTheLastOne()
    {
        return _currentMusic == _musics.Last();
    }

    private bool IsCurrentTheFirstOne()
    {
        return _currentMusic == _musics.First();
    }

    public override void SwitchNext()
    {
        if (_musics.Count == 0)
            throw new Exception("Music list is empty!");

        if (IsCurrentTheLastOne())
        {
            SwitchToFirst();
            return;
        }

        _currentMusic = _musics[_musics.IndexOf(_currentMusic) + 1];
    }

    public override void SwitchPrevious()
    {
        if (_musics.Count == 0)
            throw new Exception("Music list is empty!");

        if (IsCurrentTheFirstOne())
        {
            SwitchToLast();
            return;
        }

        _currentMusic = _musics[_musics.IndexOf(_currentMusic) - 1];
    }

    public override void DisplayCurrentSong()
    {
        if (_currentMusic == null)
            throw new Exception("Music is not playing");
        Console.WriteLine(MessageConstants.CurrentMusicMessage
            .Replace("{{MusicNameToken}}", _currentMusic.Name)
            .Replace("{{UserNameToken}}", _currentMusic.SingerName));
    }

    public override void Add(string name, string singerName)
    {
        if (!_musics.Any(x => x.Name == name && x.SingerName == singerName))
            _musics.Add(new Music(name, singerName));
    }
}