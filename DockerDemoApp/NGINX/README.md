# Iniciar Proyecto

#Crear imagen

	docker build -t nginx-img .
	
# Crear contenedor

	docker run --rm -d -v ${PWD}/nginx.conf:/etc/nginx/nginx.conf -p 80:5000  --hostname nginx --name appx_container -i appx-img
	docker run --rm  -p 80:80  --hostname nginx --name nginx_container -i nginx-img

# Ingresar contenedor 

    docker exec -i -t nginx_container bash	
	
# Documentacion

	https://stefanprodan.com/2016/nginx-reverse-proxy-aspnetcore-docker-swarm/
	
	
	docker rm -vf $(docker ps -a -q)
	
	docker service scale appx=0
	
	docker service remove appx
	
	 docker exec -i -t nginx_container bash
	 
		apt-get update --fix-missing
		apt-get update && apt-get install -y --no-install-recommends apt-utils
		apt-get install -y iputils-ping
		apt-get install -y nano 
		apt-get install -y unzip
		apt-get install -y curl
		apt-get install -y net-tools
	
	