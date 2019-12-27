# Descripcion del proyecto

El proyecto consiste en probar las librerías de inyección de dependencias del nuevo framework EF dotnetcore

# 01 Instalar mongodb. 

	El proyecto consiste en probar las librerías de inyección de dependencias del nuevo framework EF dotnetcore

###	01-01-Instalar mongodb con chocolatey(administrador)  

		choco install mongodb

###	01-02-configurar mongodb como servicio

		"C:\Program Files\MongoDB\Server\4.2\bin\mongod.exe" --config "C:\Program Files\MongoDB\Server\4.2\bin\mongod.cfg" --install

###	01-03-Iniciar servicio  mongodb 

		net start MongoDB

# 02 Inicializar proyecto .net. 

##	02-01-Desde github clonar este proyecto

		git clone https://github.com/eduardolinaresp/dotnetCoreDemo.git

		navegar hacia el proyecto cd dotnetCoreDemo\BooksApiMongo
		
##	02-02-Restaurar aplicacion   

   		dotnet restore


