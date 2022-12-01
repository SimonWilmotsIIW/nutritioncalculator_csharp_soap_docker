# Made by Simon Wilmots
# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app
    
# Copy csproj and restore as distinct layers
COPY ./nutritioncalculator/*.csproj ./
RUN dotnet restore
    
# Copy everything else and build
COPY ./nutritioncalculator ./
RUN dotnet publish -c Release -o out
    
# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "proteincalculator.dll"]