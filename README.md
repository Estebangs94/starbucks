# Starbucks

Small system that allows a user to place an order. It will validate if the order can be processed or not.
At the end, it will apply taxes to the order based on the location of the store.

## System design
![image](https://github.com/Estebangs94/starbucks/assets/18756969/e86cc2e6-bcd8-4011-afb5-4b91b0419e6e)

## Running the application

### Running from vs code
There is a .vscode folder with a profile already built, simply hit F5 and it will run the application. This requires to have a postgres running for the database. The `appsettings.Development` uses localhost as the expected configuration.

You can refer to [Docker-Compose](#docker-compose) section to run a postgres container

### Docker-Compose
You can also run this application with `docker-compose up` from the root directory. This will set the environment variable `ASPNETCORE_ENVIRONMENT` to production.
To do this, you will need to [install docker](https://docs.docker.com/get-docker/).
