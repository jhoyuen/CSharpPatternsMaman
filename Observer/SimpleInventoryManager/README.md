# SimpleInventoryManager

A simple C# project demonstrating the Observer design pattern for inventory management.

## Project Intent

This project illustrates how to decouple inventory logic from components that need to react to inventory changes, such as user interfaces or logging systems. By using the Observer pattern, you can easily extend or modify how inventory updates are handled without changing the core inventory logic.

## Features

- Observer pattern implementation for inventory management
- Multiple observers can subscribe to inventory changes
- Automatic notification to observers when items are added or removed
- Example observers included (e.g., UI, logger)
- Easily extensible for real-world scenarios

## Project Structure

- **Inventory**: The singleton Inventory class that contains Products as observable subject. Manages item quantities and notifies observers of changes in product current stock level and manages product status.
- **IProductObserver**: Interface for observers to implement update logic.
- **Concrete Observers**: Example observers that react to inventory changes (e.g., UI, logger).

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Build and Run

1. Clone the repository:
    ```sh
    git clone <repository-url>
    cd SimpleInventoryManager
    ```
2. Build the project:
    ```sh
    dotnet build
    ```
3. Run the example:
    ```sh
    dotnet run --project SimpleInventoryManager
    ```

### Example Usage

To add a new observer, implement the `IProductObserver` interface and register it with the `Inventory` instance.

## License

This project is for demonstration purposes.