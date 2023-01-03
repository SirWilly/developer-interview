namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var selfDecodeOrderLines = File.ReadAllLines("C:\\temp\\SelfDecode300Order\\SelfDecode300.txt");
        var samplesInMarvel = File.ReadAllLines("C:\\temp\\SelfDecode300Order\\SamplesAlreadyInMarvel.txt");
        var difference = new List<string>();

        foreach (var selfDecodeOrderItem in selfDecodeOrderLines)
        {
            var trimmedItem = selfDecodeOrderItem.Trim();
            if (samplesInMarvel.Any(line => line.Trim() == trimmedItem))
            {
                continue;
            }
            difference.Add(selfDecodeOrderItem);
        }
        
        File.WriteAllLines("C:\\temp\\SelfDecode300Order\\result.txt", difference);

        Assert.That(difference, Has.Count.EqualTo(258));
    }
}