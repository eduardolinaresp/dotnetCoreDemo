# Iniciar Proyecto

#Crear imagen

	docker build -t appx-img .
	
# Crear contenedor

	docker run --rm -d -v ${PWD}/src:/home/ -p 5000:5000  --hostname appx --name appx_container -i appx-img

	docker run --rm  -p 5000:5000  --hostname appx --name appx_container -i appx-img

	docker run --rm  -p 5001:5001  --hostname appx --name appx_container -i appx-img

# Ingresar contenedor 

    docker exec -i -t appx_container bash	

# Habilitar Kestrel remote conections

	dotnet run --urls http://0.0.0.0:5001

# Documentacion

	https://stefanprodan.com/2016/nginx-reverse-proxy-aspnetcore-docker-swarm/

	https://weblog.west-wind.com/posts/2016/sep/28/external-network-access-to-kestrel-and-iis-express-in-aspnet-core
	
	
	docker rm -vf $(docker ps -a -q)