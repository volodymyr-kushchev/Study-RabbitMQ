namespace RabbitMqProductApi.RabbitMq
{
    public interface IRabbitMqProducer
    {
        public void SendProductMessage<T>(T message);
    }
}
