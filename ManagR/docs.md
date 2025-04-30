# Y

## Non-functional requirements

- The application must be built in .NET using C#.
- Use only Postgre **OR** MongoDB as the database.
  - Do not use PL/pgSQL or any other database language.
- A queueing system must be used to handle the processing of the data.
  - Use any queueing system. RabbitMQ, SQS/SNS, Kafka, Google Pub/Sub, etc.

### Use cases

#### Admin (role within SwaggerUI)

- As Admin:
  - Register a new **motorcycle**:
    - Fields:
      - Id [Guid, unique];
      - Year [int];
      - Model [string];
      - License plate [string];
  - When a new motorcycle is registered, the system must send a "MotorcycleCreatedEvent".
  - The event must be sent to the queueing system.
  - The event must be saved in the database for further query.
    - There must be an consumer registered to the queueing system that will listen for motorcycles **created** at year **2024**.
  - **Endpoints**:
    - There must be an endpoint to query all motorcycles and by an specific license plate.
    - There must be an endpoint to update a motorcycle, changing **only** its license plate (and nothing else).
    - There
  
## Guides

- [Swagger usage and configuration](https://dev.to/bigboybamo/how-to-use-swagger-ui-on-a-net-9-web-api-project-2659);
- [How to make Swagger open browser automatically](https://stackoverflow.com/questions/74212852/net-6-0-stop-swagger-from-opening-automatically-on-startup) (reverse)
