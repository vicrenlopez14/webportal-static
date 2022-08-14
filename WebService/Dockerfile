#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ProFind_WebService/ProFind_WebService.csproj", "ProFind_WebService/"]
RUN dotnet restore "ProFind_WebService/ProFind_WebService.csproj"
COPY . .
WORKDIR "/src/ProFind_WebService"
RUN dotnet build "ProFind_WebService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProFind_WebService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProFind_WebService.dll"]