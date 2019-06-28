using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Autominy
{
   public class Autominy_NormalizedSteeringCommand : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "autominy_msgs/NormalizedSteeringCommand";
        public Standard.Header header;
        public float value;

        public Autominy_NormalizedSteeringCommand()
        {
            header = new Standard.Header();
            value = 0;
        }
    }
}