FROM microsoft/dotnet

COPY . /app
WORKDIR /app
RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]

RUN apt-get update && apt-get install -y netcat dos2unix
RUN dos2unix entrypoint.sh

CMD ["bash", "entrypoint.sh"]