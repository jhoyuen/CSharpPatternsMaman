```mermaid
classDiagram
    %% =======================
    %% CORE DOMAIN CLASSES
    %% =======================
    class Order {
        +int Id
        +string Description
        %% Tooltip: Represents a customer order with unique Id and description.
        click Order "#Order" "Order Entity"
    }
    class IOrderProcessor {
        <<interface>>
        +Task ProcessAsync(Order order, CancellationToken cancellationToken)
        %% Tooltip: Strategy interface for processing orders asynchronously.
        click IOrderProcessor "#IOrderProcessor" "IOrderProcessor Interface"
    }
    class DefaultOrderProcessor {
        +Task ProcessAsync(Order order, CancellationToken cancellationToken)
        %% Tooltip: Default implementation of IOrderProcessor using async processing.
        click DefaultOrderProcessor "#DefaultOrderProcessor" "DefaultOrderProcessor Class"
    }
    class SlowOrderProcessor {
        +void ProcessAll(List~Order~ orders)
        -void Process(Order order)
        %% Tooltip: Naive, slow processor using synchronous processing.
        click SlowOrderProcessor "#SlowOrderProcessor" "SlowOrderProcessor Class"
    }
    class BatchOrderProcessor {
        -IOrderProcessor _orderProcessor
        -int _batchSize
        +BatchOrderProcessor(IOrderProcessor orderProcessor, int batchSize=1000)
        +Task ProcessAllAsync(IAsyncEnumerable~Order~ orders, CancellationToken cancellationToken)
        -Task ProcessBatchAsync(List~Order~ batch, CancellationToken cancellationToken)
        %% Tooltip: Processes orders in batches using an IOrderProcessor strategy.
        click BatchOrderProcessor "#BatchOrderProcessor" "BatchOrderProcessor Class"
    }
    class Program {
        +static async IAsyncEnumerable~Order~ GetOrdersAsync(int total)
        +static List~Order~ LoadOrders(int total)
        %% Tooltip: Entry point, contains order generation and loading logic.
        click Program "#Program" "Program Main"
    }

    %% =======================
    %% RELATIONSHIPS
    %% =======================
    DefaultOrderProcessor ..|> IOrderProcessor : implements
    BatchOrderProcessor o-- IOrderProcessor : uses
    BatchOrderProcessor ..> Order : processes
    SlowOrderProcessor ..> Order : processes
    DefaultOrderProcessor ..> Order : processes
    IOrderProcessor ..> Order : parameter
    Program ..> BatchOrderProcessor : uses
    Program ..> DefaultOrderProcessor : uses
    Program ..> SlowOrderProcessor : uses
    Program ..> Order : uses

    %% =======================
    %% STYLING
    %% =======================
    classDef entity fill:#f9f,stroke:#333,stroke-