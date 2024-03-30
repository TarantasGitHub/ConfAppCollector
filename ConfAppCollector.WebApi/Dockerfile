#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release

WORKDIR /src
COPY ["ConfAppCollector.Application/ConfAppCollector.Application.csproj", "ConfAppCollector.Application/"]
COPY ["ConfAppCollector.Domain/ConfAppCollector.Domain.csproj", "ConfAppCollector.Domain/"]
COPY ["ConfAppCollector.Infrastructure.Core/ConfAppCollector.Infrastructure.Core.csproj", "ConfAppCollector.Infrastructure.Core/"]
COPY ["ConfAppCollector.WebApi/ConfAppCollector.WebApi.csproj", "ConfAppCollector.WebApi/"]
RUN dotnet restore "ConfAppCollector.WebApi/ConfAppCollector.WebApi.csproj"

COPY . .
WORKDIR "/src/ConfAppCollector.WebApi"
RUN dotnet build "./ConfAppCollector.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ConfAppCollector.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConfAppCollector.WebApi.dll"]
