using System.Diagnostics;
using BatchOrderProcessing;

int totalOrderCount = 1000;
long batchOrderProcessingTimeMS = 0;
long slowOrderProcessingTimeMS = 0;

// Fast order processing using Batch Processing

var cts = new CancellationTokenSource();
Console.CancelKeyPress += (s, e) => {
    e.Cancel = true;
    cts.Cancel();
};

var processor = new DefaultOrderProcessor();
var batchProcessor = new BatchOrderProcessor(processor, 100);

var stopWatch = new Stopwatch();
stopWatch.Start();
await batchProcessor.ProcessAllAsync(GetOrdersAsync(totalOrderCount), cts.Token);
stopWatch.Stop();
batchOrderProcessingTimeMS = stopWatch.ElapsedMilliseconds;

static async IAsyncEnumerable<Order> GetOrdersAsync(int total)
{
    for (int i = 1; i <= total; i++)
    {
        yield return new Order { Id = i, Description = $"Order {i}" };
        if (i % 1000 == 0)
            await Task.Delay(10); // simulate streaming from DB
    }
}

// Slow order processing using foreach loop

var orders = LoadOrders(totalOrderCount); // All loaded into memory at once

var slowProcessor = new SlowOrderProcessor();
stopWatch.Restart();
slowProcessor.ProcessAll(orders);
stopWatch.Stop();
slowOrderProcessingTimeMS = stopWatch.ElapsedMilliseconds;

static List<Order> LoadOrders(int total)
{
    var list = new List<Order>(total);
    for (int i = 1; i <= total; i++)
    {
        list.Add(new Order { Id = i, Description = $"Order {i}" });
    }
    return list;
}

Console.WriteLine($"Batch processing orders took {batchOrderProcessingTimeMS}ms to complete!");
Console.WriteLine($"Slow standard foreach loop processing orders took {slowOrderProcessingTimeMS}ms to complete!");