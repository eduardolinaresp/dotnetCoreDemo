# Iniciar Proyecto

* Configuration
    
    docker-compose build

* Database creation
    
    docker-compose run --rm appx dotnet ef database update
   
* Database initialization

    docker-compose run --rm appx dotnet ef database update

#Ejecutar proyecto

	docker-compose up -d
	
	docker rm -vf $(docker ps -a -q)