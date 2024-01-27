FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Identification.Service/Identification.Service.csproj", "Identification.Service/"]
RUN dotnet restore "Identification.Service/Identification.Service.csproj"
COPY . .
WORKDIR "/src/Identification.Service"
RUN dotnet build "Identification.Service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Identification.Service.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Identification.Service.dll"]
