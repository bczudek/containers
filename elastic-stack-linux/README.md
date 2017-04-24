Prior to run docker-compose up see prerequisits section on https://elk-docker.readthedocs.io/ 

This set up starts four Docker containers:
- Kibana
- Elasticsearch
- Logstash
- And TestApp

TestApp uses simple http PUT to send messages to the Logstash which listens using the http input plugin and sends it to Elasticsearch