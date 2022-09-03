#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Gateways/Ocelot.Gateway/Ocelot.Gateway.csproj", "Gateways/Ocelot.Gateway/"]
RUN dotnet restore "Gateways/Ocelot.Gateway/Ocelot.Gateway.csproj"
COPY . .
WORKDIR "/src/Gateways/Ocelot.Gateway"
RUN dotnet build "Ocelot.Gateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ocelot.Gateway.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ocelot.Gateway.dll"]