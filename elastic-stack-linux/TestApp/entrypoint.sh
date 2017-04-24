#!/usr/bin/env bash
echo "Stalling for logstash"
while true; do
if curl -XPUT 192.168.99.100:8080;
then break;
else 
sleep 10 
echo 'waiting for logstash'
fi
done
echo "Starting test app"
exec dotnet run
