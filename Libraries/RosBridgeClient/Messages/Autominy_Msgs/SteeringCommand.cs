using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Autominy
{
   public class Autominy_SteeringCommand : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "autominy_msgs/SteeringCommand";
        public Standard.Header header;
        public float value;

        public Autominy_SteeringCommand()
        {
            header = new Standard.Header();
            value = 0;
        }
    }
}