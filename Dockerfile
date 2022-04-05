FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY *.csproj .
RUN dotnet restore

# copy and build app 
COPY . .
RUN dotnet publish -c release -o out

# publish
#FROM build AS publish
#WORKDIR /api
#RUN dotnet publish -c Release -o /src/publish

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# ENTRYPOINT ["dotnet", "api.dll"]
# heroku uses the following
CMD ASPNETCORE_URLS=http://*:$PORT dotnet api.dll
