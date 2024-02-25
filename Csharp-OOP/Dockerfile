FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Csharp-OOP/Csharp-OOP.csproj", "Csharp-OOP/"]
RUN dotnet restore "Csharp-OOP/Csharp-OOP.csproj"
COPY . .
WORKDIR "/src/Csharp-OOP"
RUN dotnet build "Csharp-OOP.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Csharp-OOP.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Csharp-OOP.dll"]
