# Use the official .NET image as a parent image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

# Use the SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Server/PortfolioWithServer.Server.csproj", "Server/"]
RUN dotnet restore "Server/PortfolioWithServer.Server.csproj"
COPY . .
WORKDIR "/src/Server"
RUN dotnet build "PortfolioWithServer.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PortfolioWithServer.Server.csproj" -c Release -o /app/publish

# Use the base image to run the app
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PortfolioWithServer.Server.dll"]