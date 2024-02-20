#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CreditService.API/CreditService.API.csproj", "CreditService.API/"]
COPY ["CreditService.Domain/CreditService.Domain.csproj", "CreditService.Domain/"]
COPY ["CreditService.Infra.Data/CreditService.Infra.Data.csproj", "CreditService.Infra.Data/"]
COPY ["CreditService.Service/CreditService.Service.csproj", "CreditService.Service/"]
RUN dotnet restore "CreditService.API/CreditService.API.csproj"
COPY . .
WORKDIR "/src/CreditService.API"
RUN dotnet build "CreditService.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CreditService.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CreditService.API.dll"]