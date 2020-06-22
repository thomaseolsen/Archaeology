FROM mcr.microsoft.com/dotnet/core/runtime:2.2

WORKDIR /home/app

COPY ./*.sln ./
COPY ./*/*.csproj ./
RUN for file in $(ls *.csproj); do mkdir -p ./${file%.*}/ && mv $file ./${file%.*}/; done

RUN dotnet restore

COPY . .

RUN dotnet test

RUN dotnet publish ./WebNotebbook/WebNotebook.csproj -o /publish/

WORKDIR /publish

ENTRYPOINT ["dotnet", "WebNotebook.dll"]
