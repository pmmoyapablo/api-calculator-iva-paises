#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["src/WebApiRest/WebApiRest.csproj", "src/WebApiRest/"]
RUN dotnet restore "src/WebApiRest/WebApiRest.csproj"
COPY . .
WORKDIR "/src/src/WebApiRest"
RUN dotnet build "WebApiRest.csproj" -c Release -o /app/build

FROM build as test
WORKDIR /src/test/WebApiRestTest
RUN dotnet test

FROM build AS publish
RUN dotnet publish "WebApiRest.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApiRest.dll"]