using N32_T4.Model;

var player = new OptimizedMusicService();
player.Add("Gishtmat's song", "GishtmatOfficial");
player.Add("Qodirali's song", "QodiraliOfficial");
player.Add("Toshmat's song", "ToshmatOfficial");
player.Add("John's song", "Johnbek");

player.PlayRandomMusic();
player.DisplayCurrentSong();