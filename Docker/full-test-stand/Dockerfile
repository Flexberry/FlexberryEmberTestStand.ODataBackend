FROM node:12 AS ember_app

WORKDIR /ember-app

RUN \
  set -x; \
  git clone --depth 1 https://github.com/Flexberry/ember-flexberry.git;

RUN \
  set -x; \
  cd ember-flexberry; \
  yarn global add ember-cli@3.1.4; \
  yarn global add bower;

RUN \
  set -x; \
  cd ember-flexberry; \
  yarn install ; \
  bower install  --allow-root;

RUN \
  set -x; \
  cd ember-flexberry; \
  ember build --environment=development-loc;
  
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS backend

COPY /EmberFlexberry /EmberFlexberry

WORKDIR /EmberFlexberry

RUN \
  dotnet restore EmberFlexberry.sln;\
  dotnet build EmberFlexberry.sln -c Release;\
  dotnet publish ODataBackend/EmberFlexberry.ODataBackend.csproj -c Release -o out -f net8.0

FROM mcr.microsoft.com/dotnet/aspnet:8.0

WORKDIR /app

COPY --from=backend /EmberFlexberry/out ./
COPY --from=ember_app /ember-app/ember-flexberry/dist ./wwwroot/

# Check webapi responses
HEALTHCHECK --interval=60s --timeout=15s --start-period=20s \
  CMD curl -f "http://0.0.0.0/health" || exit

ENTRYPOINT ["dotnet", "EmberFlexberry.ODataBackend.dll"]
