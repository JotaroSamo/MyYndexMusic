namespace MyYndexMusic.Core.Abstarct;

public interface IProgressBar
{
    void UpdateProgress(double value);
    void Reset();
    void SetMaximum(double max);
}