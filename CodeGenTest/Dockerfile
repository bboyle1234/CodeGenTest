FROM mcr.microsoft.com/dotnet/core/runtime:3.0-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["CodeGenTest/CodeGenTest.csproj", "CodeGenTest/"]
RUN dotnet restore "CodeGenTest/CodeGenTest.csproj"
COPY . .
WORKDIR "/src/CodeGenTest"
RUN dotnet build "CodeGenTest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CodeGenTest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CodeGenTest.dll"]