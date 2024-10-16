namespace ArrayTest;
using ArrayAdt;
using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public class UnitTest1
{
    // private Barray cut;
    private const uint _defaultSize = 10;
    private const uint _smallerSize = 5;
    private const uint _largerSize = 15;

    private void _fillWithSequentialVals(Barray b)
    {
        for (uint idx = 0; idx < b.Length(); idx++)
        {
            int value = (int)idx;
            b.Set(idx, value);
        }
    }

    [TestMethod]
    public void CreateWithIntSize()
    {
        Barray cut = new Barray(_defaultSize);
        Assert.AreEqual(_defaultSize, cut.Length());
    }


    [TestMethod]
    public void CreateWithIntSizeHasZeroValues()
    {
        Barray cut = new Barray(_defaultSize);
        for (uint idx = 0; idx < _defaultSize; idx++)
        {
            Assert.AreEqual(0, cut.Get(idx));
        }
    }

    [TestMethod]
    public void GetAndSetDoWhatTheyShould()
    {
        Barray cut = new Barray(_defaultSize);
        for (uint idx = 0; idx < _defaultSize; idx++)
        {
            int value = (int)idx;
            cut.Set(idx, value);
            Assert.AreEqual(value, cut.Get(idx));
        }
    }

    [TestMethod]
    public void ResizeToSmallerSizeShouldUpdateLength()
    {
        Barray cut = new Barray(_defaultSize);
        cut.Resize(_smallerSize);
        Assert.AreEqual(_smallerSize, cut.Length());
    }

    [TestMethod]
    public void ResizeToSmallerSizeShouldCopyData()
    {
        Barray cut = new Barray(_defaultSize);
        _fillWithSequentialVals(cut);

        cut.Resize(_smallerSize);

        for (uint idx = 0; idx < _smallerSize; idx++)
        {
            int value = (int)idx;
            Assert.AreEqual(value, cut.Get(idx));
        }
    }

    [TestMethod]
    public void ResizeToLargerSizeShouldUpdateLength()
    {
        Barray cut = new Barray(_defaultSize);
        cut.Resize(_largerSize);
        Assert.AreEqual(_largerSize, cut.Length());
    }

    [TestMethod]
    public void ResizeToLargerSizeShouldCopyData()
    {
        Barray cut = new Barray(_defaultSize);
        _fillWithSequentialVals(cut);

        cut.Resize(_largerSize);

        for (uint idx = 0; idx < _defaultSize; idx++)
        {
            int value = (int)idx;
            Assert.AreEqual(value, cut.Get(idx));
        }
    }

    [TestMethod]
    public void ResizeToLargerSizeShouldZeroNewCells()
    {
        Barray cut = new Barray(_defaultSize);
        _fillWithSequentialVals(cut);

        cut.Resize(_largerSize);

        for (uint idx = _defaultSize; idx < _largerSize; idx++)
        {
            int value = (int)idx;
            Assert.AreEqual(0, cut.Get(idx));
        }
    }

    [TestMethod]
    public void CreateWithIntArrayHasRightLength()
    {
        int[] vals = { 13, 420, 7, 42 };
        Barray cut = new Barray(vals);
        Assert.AreEqual((uint)vals.Length, cut.Length());
    }

    [TestMethod]
    public void CreateWithIntArrayHasGivenValues()
    {
        int[] vals = { 13, 420, 7, 42, 69 };
        Barray cut = new Barray(vals);
        for (uint idx = 0; idx < vals.Length; idx++)
        {
            Assert.AreEqual(vals[idx], cut.Get(idx));
        }
    }
}
