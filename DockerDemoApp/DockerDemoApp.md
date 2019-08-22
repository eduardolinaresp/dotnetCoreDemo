# 01 Descripción

   Esta es una aplicación web que consulta una base de datos postgres

# Iniciar Proyecto

* Configuration
    
    docker-compose build

* Database creation
    
    docker-compose run --rm appx dotnet ef database update
   
* Database initialization

    docker-compose run --rm appx dotnet ef database update

# Ejecutar proyecto

	docker-compose up -d

# Verificar la aplicación

   ir al navegador y digitar localhost

# Terminar Ejecución del proyecto
 
   docker-compose down

# Observaciones
 
   si el computador donde se ejecutan estos comandos es lento, 
   se recomienda dejar pasar 3 minutos antes de verificar en navegador,
   en caso contrario sólo se verá la página de incio de nginx

# Si hay conflictos remover contenedores

	docker rm -vf $(docker ps -a -q)
	
# Documentacion por cada proyecto la encuentras acá

- [appx](APPX/APPX.md)
- [nginx](NGINX/NGINX.md)
- [postgres](POSTGRES/POSTGRES.md)