public class Track
{
    public int LapsNumber { get; set; }
    public double TrackLength { get; set; }

    public Track(int lapsNumber, double trackLength)
    {
        this.LapsNumber = lapsNumber;
        this.TrackLength = trackLength;
    }
}