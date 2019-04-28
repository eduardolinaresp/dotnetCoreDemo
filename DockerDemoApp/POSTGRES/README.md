# Iniciar Proyecto

#Crear imagen

	docker build -t pg-img .
	
# Crear contenedor

	docker run --rm -d -v ${PWD}:/home/ -p 5432:5432  --hostname pg --name pg_container -i pg-img

	docker run --rm  -p 5432:5432  --hostname pg --name pg_container -i pg-img

	

# Ingresar contenedor 

    docker exec -i -t pg_container bash	
	