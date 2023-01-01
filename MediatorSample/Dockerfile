FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["MediatorSample/MediatorSample.csproj", "MediatorSample/"]
RUN dotnet restore "MediatorSample/MediatorSample.csproj"
COPY . .
WORKDIR "/src/MediatorSample"
RUN dotnet build "MediatorSample.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MediatorSample.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MediatorSample.dll"]
