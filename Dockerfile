# Use the official .NET image as a parent image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

# Use the SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Copy the server project file and restore dependencies
COPY ["Server/PortfolioWithServer.Server.csproj", "Server/"]
COPY ["Shared/PortfolioWithServer.Shared.csproj", "Shared/"]
COPY ["Client/PortfolioWithServer.Client.csproj", "Client/"]
RUN dotnet restore "Server/PortfolioWithServer.Server.csproj"

# Copy the entire solution and build the server project
COPY . .
WORKDIR "/src/Server"
RUN dotnet build "PortfolioWithServer.Server.csproj" -c Release -o /app/build

# Publish the server project
FROM build AS publish
RUN dotnet publish "PortfolioWithServer.Server.csproj" -c Release -o /app/publish

# Use the base image to run the app
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PortfolioWithServer.Server.dll"]