using MyYndexMusic.Model;
using Yandex.Music.Api.Models.Playlist;

namespace MyYndexMusic.Cashe;

public static class CasheClass
{
    public static List<PlayListModel> _playlists;
    public static List<YPlaylist> _yPlaylists = new List<YPlaylist>();
}