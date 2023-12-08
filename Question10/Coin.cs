using System.Collections.Generic;

class Coin
{
    public bool IsActive { get; set; }
    public int FrameCounter { get; set; }

    // Reset the coin to its initial state
    public void Reset()
    {
        IsActive = true;
        FrameCounter = 0;
    }

    // Update the coin state per frame
    public void Update()
    {
        if (!IsActive) return;

        FrameCounter++;
        if (FrameCounter >= 300)
        {
            IsActive = false;
        }

    }

    // Method to "collect" the coin
    public void Collect()
    {
        IsActive = false;
    }
}
