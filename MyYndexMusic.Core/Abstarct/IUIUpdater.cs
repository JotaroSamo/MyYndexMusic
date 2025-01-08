using Yandex.Music.Api.Models.Track;

namespace MyYndexMusic.Core.Abstarct;

public interface IUIUpdater
{
    void UpdateTrackInfo(YTrack track);
    void ShowMessage(string message, string title);
}