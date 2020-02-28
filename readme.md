# JAVS RecorderAPI

This is used to simulate HTTP interaction with a JAVS recorder. I use this in development to avoid adding unnecessary data to a live recorder and to avoid conflicts when the recorders are in use. This is by no means a complete JAVS recorder API, but does allow you to add schedules and sessions. The recorder uses MongoDB for storage.

This repo includes a Dockerfile to build the fake recorder.

This repo also includes a Docker compose file to bring up a network, the recorder(s), and a MongoDB container. Add additional recorder services and databases as needed.

The build:args:HTTPS_PROXY is available in case you are a corporate proxy like me and need to get to Nuget during build. Remove if not behind a proxy. 

The MongDB connection string and database name are set in the compose file as environment variables.

Modify mongo-init.js to create the databases and users needed for your recorder(s). This is only executed if the mongo volume does not already exist.
