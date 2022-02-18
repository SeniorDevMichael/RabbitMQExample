Run rabbitMQ image command:
docker run -it --rm --name c_rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3.9-management

İnstallation from nuget:
-RabbitMQ.Client
-Newtonsoft.Json

Process:
-Connection
-Declare Queue
-Declare Exchange
-Bind Queue with Exchange
-Publish messages
-Consume messages