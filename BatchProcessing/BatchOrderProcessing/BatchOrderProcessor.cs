using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchOrderProcessing
{
    /// <summary>
    /// Batch Processor
    /// </summary>
    public class BatchOrderProcessor
    {
        private readonly IOrderProcessor _orderProcessor;
        private readonly int _batchSize;

        public BatchOrderProcessor(IOrderProcessor orderProcessor, int batchSize = 1000)
        {
            _orderProcessor = orderProcessor;
            _batchSize = batchSize;
        }

        public async Task ProcessAllAsync(IAsyncEnumerable<Order> orders, CancellationToken cancellationToken)
        {
            List<Order> batch = new();

            await foreach (var order in orders.WithCancellation(cancellationToken))
            {
                batch.Add(order);
                if (batch.Count >= _batchSize)
                {
                    await ProcessBatchAsync(batch, cancellationToken);
                    batch.Clear();
                }
            }

            if (batch.Count > 0)
            {
                await ProcessBatchAsync(batch, cancellationToken);
            }
        }

        private async Task ProcessBatchAsync(List<Order> batch, CancellationToken cancellationToken)
        {
            var tasks = batch.Select(order => _orderProcessor.ProcessAsync(order, cancellationToken));
            await Task.WhenAll(tasks);
        }
    }
}
