FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env

WORKDIR /nhr-api-agent

# Copy csproj and restore as distinct layers
 COPY . /nhr-api-agent  #COPY nhr-api-agent.csproj ./

RUN dotnet restore

# Copy everything else and build
#COPY . ./

RUN dotnet publish -c Debug -o out
# Build runtime image

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /nhr-api-agent

COPY --from=build-env /nhr-api-agent/out .

EXPOSE 8080

ENV ASPNETCORE_URLS=http://*:8080

ENTRYPOINT ["dotnet", "CoreOnGAE.dll"]