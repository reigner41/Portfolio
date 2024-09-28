# Blazor Portfolio Page

This is my portfolio page that I do and update in my free time. Here, I just add my projects and some fun projects I do.

## Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) or later

## Getting Started

1. **Clone the repository**:
    ```sh
    git clone https://github.com/your-repo/blazor-portfolio.git
    cd blazor-portfolio
    ```

2. **Restore dependencies**:
    ```sh
    dotnet restore
    ```

3. **Run the application with hot reload**:
    ```sh
    dotnet watch
    ```

    This will start the application and enable hot reload, so any changes you make to the UI will be reflected immediately.

## Project Structure

- `Client/Pages/Index.razor`: Main page of the application.
- `Properties/launchSettings.json`: Configuration for launching the application with hot reload.

## Dependency Injection

The `experienceService` is injected into the `Index.razor` component using the `@inject` directive.
