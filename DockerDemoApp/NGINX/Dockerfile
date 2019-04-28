FROM nginx

ENV DEBIAN_FRONTEND="noninteractive"

COPY ./nginx.conf /etc/nginx/nginx.conf
#COPY ./default.conf /etc/nginx/nginx.conf

RUN apt-get update && apt-get install -y 

RUN     apt-get install -y iputils-ping
RUN     apt-get install -y nano 
RUN		apt-get install -y curl
RUN		apt-get install -y net-tools